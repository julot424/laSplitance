namespace UCajouterDepense
{
    partial class UC_Ajouter_Depense
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Ajouter_Depense));
            this.lblTitre = new System.Windows.Forms.Label();
            this.cboEvenement = new System.Windows.Forms.ComboBox();
            this.cboPayePar = new System.Windows.Forms.ComboBox();
            this.txtQuoi = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.dateDepense = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCommentaire = new System.Windows.Forms.TextBox();
            this.lblBeneficiaire = new System.Windows.Forms.Label();
            this.chkTous = new System.Windows.Forms.CheckBox();
            this.chkListBenef = new System.Windows.Forms.CheckedListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.picBoxDelimitation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(17, 17);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(266, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Nouvelle dépense :";
            // 
            // cboEvenement
            // 
            this.cboEvenement.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEvenement.FormattingEnabled = true;
            this.cboEvenement.Location = new System.Drawing.Point(23, 75);
            this.cboEvenement.Name = "cboEvenement";
            this.cboEvenement.Size = new System.Drawing.Size(260, 32);
            this.cboEvenement.TabIndex = 1;
            this.cboEvenement.Text = "Evénement";
            this.cboEvenement.SelectedIndexChanged += new System.EventHandler(this.cboEvenement_SelectedIndexChanged);
            // 
            // cboPayePar
            // 
            this.cboPayePar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayePar.FormattingEnabled = true;
            this.cboPayePar.Location = new System.Drawing.Point(317, 75);
            this.cboPayePar.Name = "cboPayePar";
            this.cboPayePar.Size = new System.Drawing.Size(260, 32);
            this.cboPayePar.TabIndex = 2;
            this.cboPayePar.Text = "Payé par";
            this.cboPayePar.SelectedIndexChanged += new System.EventHandler(this.cboPayePar_SelectedIndexChanged);
            // 
            // txtQuoi
            // 
            this.txtQuoi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtQuoi.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtQuoi.Location = new System.Drawing.Point(23, 133);
            this.txtQuoi.Multiline = true;
            this.txtQuoi.Name = "txtQuoi";
            this.txtQuoi.Size = new System.Drawing.Size(260, 32);
            this.txtQuoi.TabIndex = 3;
            this.txtQuoi.Text = "Quoi";
            this.txtQuoi.Enter += new System.EventHandler(this.txtQuoi_Enter);
            // 
            // txtMontant
            // 
            this.txtMontant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontant.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtMontant.Location = new System.Drawing.Point(317, 130);
            this.txtMontant.Multiline = true;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(260, 35);
            this.txtMontant.TabIndex = 4;
            this.txtMontant.Text = "Montant";
            this.txtMontant.Click += new System.EventHandler(this.txtMontant_Click);
            this.txtMontant.Enter += new System.EventHandler(this.txtMontant_Enter);
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // dateDepense
            // 
            this.dateDepense.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.dateDepense.Location = new System.Drawing.Point(317, 191);
            this.dateDepense.Name = "dateDepense";
            this.dateDepense.Size = new System.Drawing.Size(260, 35);
            this.dateDepense.TabIndex = 5;
            // 
            // txtBoxCommentaire
            // 
            this.txtBoxCommentaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCommentaire.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtBoxCommentaire.Location = new System.Drawing.Point(317, 240);
            this.txtBoxCommentaire.Multiline = true;
            this.txtBoxCommentaire.Name = "txtBoxCommentaire";
            this.txtBoxCommentaire.Size = new System.Drawing.Size(260, 103);
            this.txtBoxCommentaire.TabIndex = 6;
            this.txtBoxCommentaire.Text = "Commentaire";
            this.txtBoxCommentaire.Enter += new System.EventHandler(this.txtBoxCommentaire_Enter);
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.BackColor = System.Drawing.Color.White;
            this.lblBeneficiaire.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiaire.Location = new System.Drawing.Point(23, 195);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(260, 35);
            this.lblBeneficiaire.TabIndex = 7;
            this.lblBeneficiaire.Text = "Bénéficiaires";
            this.lblBeneficiaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTous
            // 
            this.chkTous.AutoSize = true;
            this.chkTous.BackColor = System.Drawing.Color.White;
            this.chkTous.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTous.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkTous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkTous.Location = new System.Drawing.Point(198, 200);
            this.chkTous.Name = "chkTous";
            this.chkTous.Size = new System.Drawing.Size(76, 26);
            this.chkTous.TabIndex = 8;
            this.chkTous.Text = "Tous";
            this.chkTous.UseVisualStyleBackColor = false;
            this.chkTous.CheckedChanged += new System.EventHandler(this.chkTous_CheckedChanged);
            // 
            // chkListBenef
            // 
            this.chkListBenef.CheckOnClick = true;
            this.chkListBenef.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListBenef.FormattingEnabled = true;
            this.chkListBenef.Location = new System.Drawing.Point(23, 230);
            this.chkListBenef.Name = "chkListBenef";
            this.chkListBenef.Size = new System.Drawing.Size(260, 172);
            this.chkListBenef.TabIndex = 9;
            this.chkListBenef.SelectedIndexChanged += new System.EventHandler(this.chkListBenef_SelectedIndexChanged);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnValider.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(317, 355);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(260, 47);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // picBoxDelimitation
            // 
            this.picBoxDelimitation.Image = global::UCajouterDepense.Properties.Resources.delimitationBar;
            this.picBoxDelimitation.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxDelimitation.InitialImage")));
            this.picBoxDelimitation.Location = new System.Drawing.Point(3, 26);
            this.picBoxDelimitation.Name = "picBoxDelimitation";
            this.picBoxDelimitation.Size = new System.Drawing.Size(592, 63);
            this.picBoxDelimitation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDelimitation.TabIndex = 11;
            this.picBoxDelimitation.TabStop = false;
            this.picBoxDelimitation.Click += new System.EventHandler(this.picBoxDelimitation_Click);
            // 
            // UC_Ajouter_Depense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.chkListBenef);
            this.Controls.Add(this.chkTous);
            this.Controls.Add(this.lblBeneficiaire);
            this.Controls.Add(this.txtBoxCommentaire);
            this.Controls.Add(this.dateDepense);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtQuoi);
            this.Controls.Add(this.cboPayePar);
            this.Controls.Add(this.cboEvenement);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.picBoxDelimitation);
            this.Name = "UC_Ajouter_Depense";
            this.Size = new System.Drawing.Size(598, 422);
            this.Load += new System.EventHandler(this.UC_Ajouter_Depense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cboEvenement;
        private System.Windows.Forms.ComboBox cboPayePar;
        private System.Windows.Forms.TextBox txtQuoi;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.DateTimePicker dateDepense;
        private System.Windows.Forms.TextBox txtBoxCommentaire;
        private System.Windows.Forms.Label lblBeneficiaire;
        private System.Windows.Forms.CheckBox chkTous;
        private System.Windows.Forms.CheckedListBox chkListBenef;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.PictureBox picBoxDelimitation;
    }
}
