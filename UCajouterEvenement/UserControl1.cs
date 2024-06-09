using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UCajouterEvenement
{
    public partial class UC_Ajouter_Evenement: UserControl
    {
        private SQLiteConnection cx = new SQLiteConnection();
        public UC_Ajouter_Evenement(/*SQLiteConnection conn*/)
        {
            InitializeComponent();

            //cx = conn;
            string chaine = "Data Source=Events.sqlite";

            try
            {
                this.cx = new SQLiteConnection(chaine);
                this.cx.Open();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            cx.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            pnlInvitation.Visible = true;
        }

        private void UC_Ajouter_Evenement_Load(object sender, EventArgs e)
        {
            List<int> selectedParticipants = new List<int>();

            cx.Open();
            string qry = "Select codeParticipant, (prenomPart ||' '|| nomPart) as fullname from Participants";
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                chkListParticipants.Items.Clear();

                chkListParticipants.DataSource = dt;
                chkListParticipants.DisplayMember = "fullname";
                chkListParticipants.ValueMember = "codeParticipant";

                foreach(DataRow r in dt.Rows)
                {
                    int codePart = Convert.ToInt32(r["codeParticipant"]);
                    selectedParticipants.Add(codePart);
                }

                foreach(int codePart in selectedParticipants)
                {
                    string insertInvite = "INSERT INTO Invites (codeEvent, codePart) VALUES (@codeEvent, @codePart)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertInvite, cx))
                    {
                        cmd.Parameters.AddWithValue("@codeEvent", 1);
                        cmd.Parameters.AddWithValue("@codeParticipant", codePart);
                        //cmd.ExecuteNonQuery();
                    }
                }

                pnlInvitation.Visible = false;
            }
            cx.Close();
        }

        private void btnInviter_Click(object sender, EventArgs e)
        {
            
        }

        private void chkListParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkListParticipants.ClearSelected();
        }
    }
}
