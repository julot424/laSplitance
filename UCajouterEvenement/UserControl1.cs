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
            string qry = "INSERT INTO Evenements (titreEvent, dateDebut, dateFin, description, codeCreateur, soldeON) VALUES(@titre, @dateDebut, @dateFin, @commentaire, @codeCreateur, @soldeON); SELECT last_insert_rowid();";
            int codeCrea = Convert.ToInt32(cboCreePar.SelectedValue);
            int soldeON = chkSolde.Checked ? 1 : 0;
            string dateDebutFormatted = DateStart.Value.ToString("yyyy-MM-dd");
            string dateFinFormatted = DateEnd.Value.ToString("yyyy-MM-dd");

            using (SQLiteCommand cmd = new SQLiteCommand(qry, cx))
            {
                cmd.Parameters.AddWithValue("@titre", txtTitreEvent.Text);
                cmd.Parameters.AddWithValue("@dateDebut", dateDebutFormatted);
                cmd.Parameters.AddWithValue("@dateFin", dateFinFormatted);
                cmd.Parameters.AddWithValue("@commentaire", txtCommentaire.Text);
                cmd.Parameters.AddWithValue("@codeCreateur", codeCrea);
                cmd.Parameters.AddWithValue("@soldeON", soldeON);
                
                cx.Open();
                //cmd.ExecuteNonQuery();
                long eventID = (long)cmd.ExecuteScalar();
                cx.Close();
                
            }

            


            pnlInvitation.Visible = true;
        }

        private void UC_Ajouter_Evenement_Load(object sender, EventArgs e)
        {
            pnlInvitation.Visible = false;
            List<int> selectedParticipants = new List<int>();

            cx.Open();
            string qry = "Select codeParticipant, (prenomPart ||' '|| nomPart) as fullname from Participants";
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboCreePar.Items.Clear();

                cboCreePar.DataSource = dt;
                cboCreePar.DisplayMember = "fullname";
                cboCreePar.ValueMember = "codeParticipant";
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
