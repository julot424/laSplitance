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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarDeNav = new navigationBar.navigationBar();
            this.btnAjouterDepense = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.panelAjouterDepense = new System.Windows.Forms.Panel();
            this.pnlBtn1a1 = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAvant = new System.Windows.Forms.Button();
            this.btnApres = new System.Windows.Forms.Button();
            this.btnAjouterEvenement = new System.Windows.Forms.Button();
            this.pnl1a1 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblCreateur = new System.Windows.Forms.Label();
            this.lblEventSur = new System.Windows.Forms.Label();
            this.chkSoldeON = new System.Windows.Forms.CheckBox();
            this.lblSoldeON = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblAu = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDu = new System.Windows.Forms.Label();
            this.lblestDescription = new System.Windows.Forms.Label();
            this.lblestTitre = new System.Windows.Forms.Label();
            this.lblCree = new System.Windows.Forms.Label();
            this.picBoxDelimitation = new System.Windows.Forms.PictureBox();
            this.lblEventNum = new System.Windows.Forms.Label();
            this.lblEvenementNum = new System.Windows.Forms.Label();
            this.pnlAjouterEvenement = new System.Windows.Forms.Panel();
            this.btnAjouterPart = new System.Windows.Forms.Button();
            this.pnlGestionDesPart = new System.Windows.Forms.Panel();
            this.dataGridViewListPart = new System.Windows.Forms.DataGridView();
            this.cboListEvenement = new System.Windows.Forms.ComboBox();
            this.lblCurentEvent = new System.Windows.Forms.Label();
            this.lblParticipantA = new System.Windows.Forms.Label();
            this.lblGestionDelEvent = new System.Windows.Forms.Label();
            this.picBoxDelimitation1 = new System.Windows.Forms.PictureBox();
            this.pnlBtn1a1.SuspendLayout();
            this.pnl1a1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation)).BeginInit();
            this.pnlGestionDesPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation1)).BeginInit();
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
            this.lblCategorie.Location = new System.Drawing.Point(12, 196);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(116, 34);
            this.lblCategorie.TabIndex = 2;
            this.lblCategorie.Text = "Acceuil";
            // 
            // panelAjouterDepense
            // 
            this.panelAjouterDepense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAjouterDepense.Location = new System.Drawing.Point(202, 42);
            this.panelAjouterDepense.Name = "panelAjouterDepense";
            this.panelAjouterDepense.Size = new System.Drawing.Size(609, 443);
            this.panelAjouterDepense.TabIndex = 3;
            this.panelAjouterDepense.Visible = false;
            // 
            // pnlBtn1a1
            // 
            this.pnlBtn1a1.Controls.Add(this.btnFirst);
            this.pnlBtn1a1.Controls.Add(this.btnLast);
            this.pnlBtn1a1.Controls.Add(this.btnAvant);
            this.pnlBtn1a1.Controls.Add(this.btnApres);
            this.pnlBtn1a1.Location = new System.Drawing.Point(651, 472);
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
            this.btnAjouterEvenement.Click += new System.EventHandler(this.btnAjouterEvenement_Click);
            // 
            // pnl1a1
            // 
            this.pnl1a1.Controls.Add(this.lblDescription);
            this.pnl1a1.Controls.Add(this.lblTitre);
            this.pnl1a1.Controls.Add(this.lblCreateur);
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
            this.pnl1a1.Location = new System.Drawing.Point(18, 233);
            this.pnl1a1.Name = "pnl1a1";
            this.pnl1a1.Size = new System.Drawing.Size(627, 339);
            this.pnl1a1.TabIndex = 5;
            this.pnl1a1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1a1_Paint);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(151, 174);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(473, 45);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "sans desciption";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(97, 137);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(84, 19);
            this.lblTitre.TabIndex = 14;
            this.lblTitre.Text = "sans Titre";
            // 
            // lblCreateur
            // 
            this.lblCreateur.AutoSize = true;
            this.lblCreateur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCreateur.Location = new System.Drawing.Point(128, 99);
            this.lblCreateur.Name = "lblCreateur";
            this.lblCreateur.Size = new System.Drawing.Size(113, 19);
            this.lblCreateur.TabIndex = 13;
            this.lblCreateur.Text = "sans créateur";
            this.lblCreateur.Click += new System.EventHandler(this.label1_Click);
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
            // pnlAjouterEvenement
            // 
            this.pnlAjouterEvenement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAjouterEvenement.Location = new System.Drawing.Point(205, 17);
            this.pnlAjouterEvenement.Name = "pnlAjouterEvenement";
            this.pnlAjouterEvenement.Size = new System.Drawing.Size(609, 555);
            this.pnlAjouterEvenement.TabIndex = 4;
            this.pnlAjouterEvenement.Visible = false;
            // 
            // btnAjouterPart
            // 
            this.btnAjouterPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnAjouterPart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPart.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPart.Location = new System.Drawing.Point(651, 182);
            this.btnAjouterPart.Name = "btnAjouterPart";
            this.btnAjouterPart.Size = new System.Drawing.Size(349, 68);
            this.btnAjouterPart.TabIndex = 11;
            this.btnAjouterPart.Text = "Ajouter un participant";
            this.btnAjouterPart.UseVisualStyleBackColor = false;
            this.btnAjouterPart.Click += new System.EventHandler(this.btnAjouterPart_Click);
            // 
            // pnlGestionDesPart
            // 
            this.pnlGestionDesPart.Controls.Add(this.dataGridViewListPart);
            this.pnlGestionDesPart.Controls.Add(this.cboListEvenement);
            this.pnlGestionDesPart.Controls.Add(this.lblCurentEvent);
            this.pnlGestionDesPart.Controls.Add(this.lblParticipantA);
            this.pnlGestionDesPart.Controls.Add(this.lblGestionDelEvent);
            this.pnlGestionDesPart.Controls.Add(this.picBoxDelimitation1);
            this.pnlGestionDesPart.Location = new System.Drawing.Point(18, 233);
            this.pnlGestionDesPart.Name = "pnlGestionDesPart";
            this.pnlGestionDesPart.Size = new System.Drawing.Size(627, 339);
            this.pnlGestionDesPart.TabIndex = 12;
            // 
            // dataGridViewListPart
            // 
            this.dataGridViewListPart.AllowUserToAddRows = false;
            this.dataGridViewListPart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridViewListPart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListPart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewListPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewListPart.Location = new System.Drawing.Point(45, 119);
            this.dataGridViewListPart.Name = "dataGridViewListPart";
            this.dataGridViewListPart.RowHeadersVisible = false;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridViewListPart.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewListPart.Size = new System.Drawing.Size(539, 201);
            this.dataGridViewListPart.TabIndex = 17;
            this.dataGridViewListPart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cboListEvenement
            // 
            this.cboListEvenement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cboListEvenement.FormattingEnabled = true;
            this.cboListEvenement.Location = new System.Drawing.Point(278, 0);
            this.cboListEvenement.Name = "cboListEvenement";
            this.cboListEvenement.Size = new System.Drawing.Size(268, 27);
            this.cboListEvenement.TabIndex = 16;
            this.cboListEvenement.SelectedIndexChanged += new System.EventHandler(this.cboListEvenement_SelectedIndexChanged);
            // 
            // lblCurentEvent
            // 
            this.lblCurentEvent.AutoSize = true;
            this.lblCurentEvent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurentEvent.Location = new System.Drawing.Point(276, 82);
            this.lblCurentEvent.Name = "lblCurentEvent";
            this.lblCurentEvent.Size = new System.Drawing.Size(97, 19);
            this.lblCurentEvent.TabIndex = 13;
            this.lblCurentEvent.Text = "EventName";
            // 
            // lblParticipantA
            // 
            this.lblParticipantA.AutoSize = true;
            this.lblParticipantA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblParticipantA.Location = new System.Drawing.Point(41, 82);
            this.lblParticipantA.Name = "lblParticipantA";
            this.lblParticipantA.Size = new System.Drawing.Size(229, 19);
            this.lblParticipantA.TabIndex = 3;
            this.lblParticipantA.Text = "Participants de l\'événement :";
            // 
            // lblGestionDelEvent
            // 
            this.lblGestionDelEvent.AutoSize = true;
            this.lblGestionDelEvent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionDelEvent.Location = new System.Drawing.Point(75, 3);
            this.lblGestionDelEvent.Name = "lblGestionDelEvent";
            this.lblGestionDelEvent.Size = new System.Drawing.Size(197, 19);
            this.lblGestionDelEvent.TabIndex = 0;
            this.lblGestionDelEvent.Text = "Gestion de l\'événement :";
            // 
            // picBoxDelimitation1
            // 
            this.picBoxDelimitation1.Image = global::splitEase.Properties.Resources.delimitationBar;
            this.picBoxDelimitation1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxDelimitation1.InitialImage")));
            this.picBoxDelimitation1.Location = new System.Drawing.Point(3, 16);
            this.picBoxDelimitation1.Name = "picBoxDelimitation1";
            this.picBoxDelimitation1.Size = new System.Drawing.Size(621, 63);
            this.picBoxDelimitation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDelimitation1.TabIndex = 2;
            this.picBoxDelimitation1.TabStop = false;
            // 
            // frmSplitEase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 600);
            this.Controls.Add(this.panelAjouterDepense);
            this.Controls.Add(this.pnlAjouterEvenement);
            this.Controls.Add(this.pnlBtn1a1);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.BarDeNav);
            this.Controls.Add(this.pnl1a1);
            this.Controls.Add(this.btnAjouterPart);
            this.Controls.Add(this.btnAjouterEvenement);
            this.Controls.Add(this.btnAjouterDepense);
            this.Controls.Add(this.pnlGestionDesPart);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSplitEase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split Ease : Acceuil";
            this.Load += new System.EventHandler(this.frmSplitEase_Load);
            this.pnlBtn1a1.ResumeLayout(false);
            this.pnl1a1.ResumeLayout(false);
            this.pnl1a1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation)).EndInit();
            this.pnlGestionDesPart.ResumeLayout(false);
            this.pnlGestionDesPart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation1)).EndInit();
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
        private System.Windows.Forms.Label lblCreateur;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnAvant;
        private System.Windows.Forms.Button btnApres;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel pnlBtn1a1;
        private System.Windows.Forms.Panel pnlAjouterEvenement;
        private System.Windows.Forms.Button btnAjouterPart;
        private System.Windows.Forms.Panel pnlGestionDesPart;
        private System.Windows.Forms.ComboBox cboListEvenement;
        private System.Windows.Forms.Label lblCurentEvent;
        private System.Windows.Forms.Label lblParticipantA;
        private System.Windows.Forms.PictureBox picBoxDelimitation1;
        private System.Windows.Forms.Label lblGestionDelEvent;
        private System.Windows.Forms.DataGridView dataGridViewListPart;
    }
}

