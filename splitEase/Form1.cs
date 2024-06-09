using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using UCajouterDepense;
using System.Drawing.Printing;

namespace splitEase
{
    public partial class frmSplitEase : Form
    {
        private SQLiteConnection cx;
        private DataTable eventsTable = new DataTable();
        private int currentIndex;


        public frmSplitEase()
        {
            InitializeComponent();

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
            
            this.cx.Close();
            cacherTout();
            btnAjouterDepense.Visible = true;
        }

        private void loadData()
        {
            string qry = @"SELECT e.codeEvent, e.titreEvent, e.description, e.dateDebut, e.dateFin, e.soldeON, p.nomPart, p.prenomPart FROM Evenements e JOIN Participants p ON e.codeCreateur = p.codeParticipant;";
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx))
            {
                da.Fill(eventsTable);
            }

            if(eventsTable.Rows.Count > 0) 
            {
                DisplayRecord(currentIndex);
            }
        }

        private void DisplayRecord(int index)
        {
            if (index >= 0 && index < eventsTable.Rows.Count)
            {
                DataRow row = eventsTable.Rows[index];
                lblEventNum.Text = row["codeEvent"].ToString();
                lblCreePar.Text = $"{row["prenomPart"].ToString()} {row["nomPart"].ToString()}";
                lblTitre.Text = row["titreEvent"].ToString();
                lblDescription.Text = row["description"].ToString();
                lblDateDebut.Text = Convert.ToDateTime(row["dateDebut"]).ToString("dd/MM/yyyy");
                lblDateFin.Text = Convert.ToDateTime(row["dateFin"]).ToString("dd/MM/yyyy");
                chkSoldeON.Checked = Convert.ToBoolean(row["soldeON"]);
                lblEventSur.Text = $"Enregistrement: {index + 1} sur {eventsTable.Rows.Count}";
            }
        }

        private void frmSplitEase_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAjouterDepense_Click(object sender, EventArgs e)
        {
            btnAjouterDepense.Enabled = false;
            UC_Ajouter_Depense add = new UC_Ajouter_Depense(cx);
            panelAjouterDepense.Controls.Clear();
            panelAjouterDepense.Controls.Add(add);

            add.Dock = DockStyle.Fill;
            panelAjouterDepense.Visible = true;

            add.DepenseValider += Add_DepenseValider;
            
        }

        private void Add_DepenseValider(object sender, EventArgs e)
        {
            panelAjouterDepense.Controls.Clear();
            panelAjouterDepense.Visible = false;
            btnAjouterDepense.Enabled = true;
        }

        private void BarDeNav_ParticipantsClicked(object sender, EventArgs e)
        {
            this.Text = "Split Ease : Participants";
            lblCategorie.Text = "Participants";
            cacherTout();
        }

        private void BarDeNav_EvenementsClicked(object sender, EventArgs e)
        {
            this.Text = "Split Ease : Evénements";
            lblCategorie.Text = "Evénement";
            cacherTout();
            btnAjouterEvenement.Visible = true;
            pnl1a1.Visible = true;
            pnlBtn1a1.Visible = true;
        }

        private void BarDeNav_DepensesClicked(object sender, EventArgs e)
        {
            this.Text = "Split Ease : Dépenses";
            lblCategorie.Text = "Dépenses";
            cacherTout();
        }

        private void BarDeNav_AcceuilClicked(object sender, EventArgs e)
        {
            this.Text = "Split Ease : Acceuil";
            lblCategorie.Text = "Acceuil";
            cacherTout();
            btnAjouterDepense.Visible = true;
        }

        private void cacherTout()
        {
            foreach(Control c in this.Controls)
            {
                if(!(c == BarDeNav || c == lblCategorie))
                {
                    c.Visible = false;
                }
            }
        }

        private void lblEventNum_Click(object sender, EventArgs e)
        {

        }

        private void pnl1a1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEvenementNum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            DisplayRecord(currentIndex);
        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            if(currentIndex > 0)
            {
                currentIndex--;
                DisplayRecord(currentIndex);
            }
        }

        private void btnApres_Click(object sender, EventArgs e)
        {
            if(currentIndex < eventsTable.Rows.Count - 1) 
            {
                currentIndex++;
                DisplayRecord(currentIndex);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = eventsTable.Rows.Count - 1;
            DisplayRecord(currentIndex);
        }
    }
}
