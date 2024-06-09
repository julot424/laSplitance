namespace splitEase
{
    partial class frmSplitEase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplitEase));
            this.BarDeNav = new navigationBar.navigationBar();
            this.btnAjouterDepense = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.panelAjouterDepense = new System.Windows.Forms.Panel();
            this.btnAjouterEvenement = new System.Windows.Forms.Button();
            this.pnl1a1 = new System.Windows.Forms.Panel();
            this.lblEvenementNum = new System.Windows.Forms.Label();
            this.lblEventNum = new System.Windows.Forms.Label();
            this.lblCree = new System.Windows.Forms.Label();
            this.lblestTitre = new System.Windows.Forms.Label();
            this.lblestDescription = new System.Windows.Forms.Label();
            this.lblDu = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblAu = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblSoldeON = new System.Windows.Forms.Label();
            this.chkSoldeON = new System.Windows.Forms.CheckBox();
            this.lblEventSur = new System.Windows.Forms.Label();
            this.lblCreePar = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAvant = new System.Windows.Forms.Button();
            this.btnApres = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.pnlBtn1a1 = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.picBoxDelimitation = new System.Windows.Forms.PictureBox();
            this.pnl1a1.SuspendLayout();
            this.pnlBtn1a1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation)).BeginInit();
            this.SuspendLayout();
            // 
            // BarDeNav
            // 
            this.BarDeNav.AutoSize = true;
            this.BarDeNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.BarDeNav.Location = new System.Drawing.Point(-3, 0);
            this.BarDeNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BarDeNav.Name = "BarDeNav";
            this.BarDeNav.Size = new System.Drawing.Size(1171, 175);
            this.BarDeNav.TabIndex = 0;
            this.BarDeNav.AcceuilClicked += new System.EventHandler(this.BarDeNav_AcceuilClicked);
            this.BarDeNav.ParticipantsClicked += new System.EventHandler(this.BarDeNav_ParticipantsClicked);
            this.BarDeNav.EvenementsClicked += new System.EventHandler(this.BarDeNav_EvenementsClicked);
            this.BarDeNav.DepensesClicked += new System.EventHandler(this.BarDeNav_DepensesClicked);
            // 
            // btnAjouterDepense
            // 
            this.btnAjouterDepense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnAjouterDepense.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDepense.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDepense.Location = new System.Drawing.Point(651, 182);
            this.btnAjouterDepense.Name = "btnAjouterDepense";
            this.btnAjouterDepense.Size = new System.Drawing.Size(349, 68);
            this.btnAjouterDepense.TabIndex = 1;
            this.btnAjouterDepense.Text = "Ajouter une dépense";
            this.btnAjouterDepense.UseVisualStyleBackColor = false;
            this.btnAjouterDepense.Click += new System.EventHandler(this.btnAjouterDepense_Click);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.lblCategorie.Location = new System.Drawing.Point(12, 182);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(116, 34);
            this.lblCategorie.TabIndex = 2;
            this.lblCategorie.Text = "Acceuil";
            // 
            // panelAjouterDepense
            // 
            this.panelAjouterDepense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAjouterDepense.Location = new System.Drawing.Point(211, 87);
            this.panelAjouterDepense.Name = "panelAjouterDepense";
            this.panelAjouterDepense.Size = new System.Drawing.Size(602, 443);
            this.panelAjouterDepense.TabIndex = 3;
            this.panelAjouterDepense.Visible = false;
            // 
            // btnAjouterEvenement
            // 
            this.btnAjouterEvenement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnAjouterEvenement.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterEvenement.ForeColor = System.Drawing.Color.White;
            this.btnAjouterEvenement.Location = new System.Drawing.Point(651, 182);
            this.btnAjouterEvenement.Name = "btnAjouterEvenement";
            this.btnAjouterEvenement.Size = new System.Drawing.Size(349, 68);
            this.btnAjouterEvenement.TabIndex = 4;
            this.btnAjouterEvenement.Text = "Ajouter un événement";
            this.btnAjouterEvenement.UseVisualStyleBackColor = false;
            // 
            // pnl1a1
            // 
            this.pnl1a1.Controls.Add(this.lblDescription);
            this.pnl1a1.Controls.Add(this.lblTitre);
            this.pnl1a1.Controls.Add(this.lblCreePar);
            this.pnl1a1.Controls.Add(this.lblEventSur);
            this.pnl1a1.Controls.Add(this.chkSoldeON);
            this.pnl1a1.Controls.Add(this.lblSoldeON);
            this.pnl1a1.Controls.Add(this.lblDateFin);
            this.pnl1a1.Controls.Add(this.lblAu);
            this.pnl1a1.Controls.Add(this.lblDateDebut);
            this.pnl1a1.Controls.Add(this.lblDu);
            this.pnl1a1.Controls.Add(this.lblestDescription);
            this.pnl1a1.Controls.Add(this.lblestTitre);
            this.pnl1a1.Controls.Add(this.lblCree);
            this.pnl1a1.Controls.Add(this.picBoxDelimitation);
            this.pnl1a1.Controls.Add(this.lblEventNum);
            this.pnl1a1.Controls.Add(this.lblEvenementNum);
            this.pnl1a1.Location = new System.Drawing.Point(18, 236);
            this.pnl1a1.Name = "pnl1a1";
            this.pnl1a1.Size = new System.Drawing.Size(627, 339);
            this.pnl1a1.TabIndex = 5;
            this.pnl1a1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1a1_Paint);
            // 
            // lblEvenementNum
            // 
            this.lblEvenementNum.AutoSize = true;
            this.lblEvenementNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenementNum.Location = new System.Drawing.Point(243, 0);
            this.lblEvenementNum.Name = "lblEvenementNum";
            this.lblEvenementNum.Size = new System.Drawing.Size(115, 19);
            this.lblEvenementNum.TabIndex = 0;
            this.lblEvenementNum.Text = "Evénement n°";
            this.lblEvenementNum.Click += new System.EventHandler(this.lblEvenementNum_Click);
            // 
            // lblEventNum
            // 
            this.lblEventNum.AutoSize = true;
            this.lblEventNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEventNum.Location = new System.Drawing.Point(352, 0);
            this.lblEventNum.Name = "lblEventNum";
            this.lblEventNum.Size = new System.Drawing.Size(18, 19);
            this.lblEventNum.TabIndex = 1;
            this.lblEventNum.Text = "1";
            this.lblEventNum.Click += new System.EventHandler(this.lblEventNum_Click);
            // 
            // lblCree
            // 
            this.lblCree.AutoSize = true;
            this.lblCree.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCree.Location = new System.Drawing.Point(38, 99);
            this.lblCree.Name = "lblCree";
            this.lblCree.Size = new System.Drawing.Size(84, 19);
            this.lblCree.TabIndex = 3;
            this.lblCree.Text = "Créé par :";
            // 
            // lblestTitre
            // 
            this.lblestTitre.AutoSize = true;
            this.lblestTitre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblestTitre.Location = new System.Drawing.Point(38, 137);
            this.lblestTitre.Name = "lblestTitre";
            this.lblestTitre.Size = new System.Drawing.Size(53, 19);
            this.lblestTitre.TabIndex = 4;
            this.lblestTitre.Text = "Titre :";
            // 
            // lblestDescription
            // 
            this.lblestDescription.AutoSize = true;
            this.lblestDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblestDescription.Location = new System.Drawing.Point(38, 174);
            this.lblestDescription.Name = "lblestDescription";
            this.lblestDescription.Size = new System.Drawing.Size(107, 19);
            this.lblestDescription.TabIndex = 5;
            this.lblestDescription.Text = "Description :";
            // 
            // lblDu
            // 
            this.lblDu.AutoSize = true;
            this.lblDu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDu.Location = new System.Drawing.Point(38, 255);
            this.lblDu.Name = "lblDu";
            this.lblDu.Size = new System.Drawing.Size(41, 19);
            this.lblDu.TabIndex = 6;
            this.lblDu.Text = "Du :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateDebut.Location = new System.Drawing.Point(85, 255);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(89, 19);
            this.lblDateDebut.TabIndex = 7;
            this.lblDateDebut.Text = "01/01/2024";
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAu.Location = new System.Drawing.Point(180, 255);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(28, 19);
            this.lblAu.TabIndex = 8;
            this.lblAu.Text = "au";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateFin.Location = new System.Drawing.Point(214, 255);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(89, 19);
            this.lblDateFin.TabIndex = 9;
            this.lblDateFin.Text = "01/01/2024";
            // 
            // lblSoldeON
            // 
            this.lblSoldeON.AutoSize = true;
            this.lblSoldeON.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoldeON.Location = new System.Drawing.Point(38, 294);
            this.lblSoldeON.Name = "lblSoldeON";
            this.lblSoldeON.Size = new System.Drawing.Size(104, 19);
            this.lblSoldeON.TabIndex = 10;
            this.lblSoldeON.Text = "Soldé (P/N) :";
            // 
            // chkSoldeON
            // 
            this.chkSoldeON.AutoSize = true;
            this.chkSoldeON.Enabled = false;
            this.chkSoldeON.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkSoldeON.Location = new System.Drawing.Point(148, 299);
            this.chkSoldeON.Name = "chkSoldeON";
            this.chkSoldeON.Size = new System.Drawing.Size(15, 14);
            this.chkSoldeON.TabIndex = 11;
            this.chkSoldeON.UseVisualStyleBackColor = true;
            // 
            // lblEventSur
            // 
            this.lblEventSur.AutoSize = true;
            this.lblEventSur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEventSur.Location = new System.Drawing.Point(243, 306);
            this.lblEventSur.Name = "lblEventSur";
            this.lblEventSur.Size = new System.Drawing.Size(0, 19);
            this.lblEventSur.TabIndex = 12;
            // 
            // lblCreePar
            // 
            this.lblCreePar.AutoSize = true;
            this.lblCreePar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCreePar.Location = new System.Drawing.Point(128, 99);
            this.lblCreePar.Name = "lblCreePar";
            this.lblCreePar.Size = new System.Drawing.Size(59, 19);
            this.lblCreePar.TabIndex = 13;
            this.lblCreePar.Text = "neuille";
            this.lblCreePar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(97, 137);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(105, 19);
            this.lblTitre.TabIndex = 14;
            this.lblTitre.Text = "rdvdeNeuille";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(151, 174);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(473, 45);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "big rdv de neuille sa mere";
            // 
            // btnAvant
            // 
            this.btnAvant.BackgroundImage = global::splitEase.Properties.Resources.btnPrevious;
            this.btnAvant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvant.Location = new System.Drawing.Point(95, 31);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(55, 36);
            this.btnAvant.TabIndex = 7;
            this.btnAvant.UseVisualStyleBackColor = true;
            this.btnAvant.Click += new System.EventHandler(this.btnAvant_Click);
            // 
            // btnApres
            // 
            this.btnApres.BackgroundImage = global::splitEase.Properties.Resources.btnNext;
            this.btnApres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApres.Location = new System.Drawing.Point(191, 31);
            this.btnApres.Name = "btnApres";
            this.btnApres.Size = new System.Drawing.Size(55, 36);
            this.btnApres.TabIndex = 8;
            this.btnApres.UseVisualStyleBackColor = true;
            this.btnApres.Click += new System.EventHandler(this.btnApres_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackgroundImage = global::splitEase.Properties.Resources.btnLast;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.Location = new System.Drawing.Point(281, 31);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(55, 36);
            this.btnLast.TabIndex = 9;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // pnlBtn1a1
            // 
            this.pnlBtn1a1.Controls.Add(this.btnFirst);
            this.pnlBtn1a1.Controls.Add(this.btnLast);
            this.pnlBtn1a1.Controls.Add(this.btnAvant);
            this.pnlBtn1a1.Controls.Add(this.btnApres);
            this.pnlBtn1a1.Location = new System.Drawing.Point(651, 475);
            this.pnlBtn1a1.Name = "pnlBtn1a1";
            this.pnlBtn1a1.Size = new System.Drawing.Size(357, 100);
            this.pnlBtn1a1.TabIndex = 10;
            // 
            // btnFirst
            // 
            this.btnFirst.BackgroundImage = global::splitEase.Properties.Resources.btnFirst;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirst.Location = new System.Drawing.Point(0, 31);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(55, 36);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // picBoxDelimitation
            // 
            this.picBoxDelimitation.Image = global::splitEase.Properties.Resources.delimitationBar;
            this.picBoxDelimitation.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxDelimitation.InitialImage")));
            this.picBoxDelimitation.Location = new System.Drawing.Point(3, 22);
            this.picBoxDelimitation.Name = "picBoxDelimitation";
            this.picBoxDelimitation.Size = new System.Drawing.Size(621, 63);
            this.picBoxDelimitation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDelimitation.TabIndex = 2;
            this.picBoxDelimitation.TabStop = false;
            // 
            // frmSplitEase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 600);
            this.Controls.Add(this.pnlBtn1a1);
            this.Controls.Add(this.pnl1a1);
            this.Controls.Add(this.btnAjouterEvenement);
            this.Controls.Add(this.panelAjouterDepense);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.btnAjouterDepense);
            this.Controls.Add(this.BarDeNav);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSplitEase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split Ease : Acceuil";
            this.Load += new System.EventHandler(this.frmSplitEase_Load);
            this.pnl1a1.ResumeLayout(false);
            this.pnl1a1.PerformLayout();
            this.pnlBtn1a1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private navigationBar.navigationBar BarDeNav;
        private System.Windows.Forms.Button btnAjouterDepense;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Panel panelAjouterDepense;
        private System.Windows.Forms.Button btnAjouterEvenement;
        private System.Windows.Forms.Panel pnl1a1;
        private System.Windows.Forms.Label lblEvenementNum;
        private System.Windows.Forms.Label lblEventNum;
        private System.Windows.Forms.PictureBox picBoxDelimitation;
        private System.Windows.Forms.Label lblCree;
        private System.Windows.Forms.Label lblestTitre;
        private System.Windows.Forms.Label lblestDescription;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDu;
        private System.Windows.Forms.Label lblSoldeON;
        private System.Windows.Forms.CheckBox chkSoldeON;
        private System.Windows.Forms.Label lblEventSur;
        private System.Windows.Forms.Label lblCreePar;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnAvant;
        private System.Windows.Forms.Button btnApres;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel pnlBtn1a1;
    }
}

