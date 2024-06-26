﻿namespace UCajouterEvenement
{
    partial class UC_Ajouter_Evenement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Ajouter_Evenement));
            this.lblNouvelEvenement = new System.Windows.Forms.Label();
            this.txtTitreEvent = new System.Windows.Forms.TextBox();
            this.picBoxDelimitation = new System.Windows.Forms.PictureBox();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.lblCreePar = new System.Windows.Forms.Label();
            this.cboCreePar = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.pnlInvitation = new System.Windows.Forms.Panel();
            this.btnEnvoyerInvite = new System.Windows.Forms.Button();
            this.chkListParticipants = new System.Windows.Forms.CheckedListBox();
            this.lblPartAInvite = new System.Windows.Forms.Label();
            this.chkSolde = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation)).BeginInit();
            this.pnlInvitation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNouvelEvenement
            // 
            this.lblNouvelEvenement.AutoSize = true;
            this.lblNouvelEvenement.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblNouvelEvenement.Location = new System.Drawing.Point(12, 13);
            this.lblNouvelEvenement.Name = "lblNouvelEvenement";
            this.lblNouvelEvenement.Size = new System.Drawing.Size(276, 32);
            this.lblNouvelEvenement.TabIndex = 0;
            this.lblNouvelEvenement.Text = "Nouvel événement :";
            // 
            // txtTitreEvent
            // 
            this.txtTitreEvent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTitreEvent.ForeColor = System.Drawing.Color.Black;
            this.txtTitreEvent.Location = new System.Drawing.Point(155, 96);
            this.txtTitreEvent.Multiline = true;
            this.txtTitreEvent.Name = "txtTitreEvent";
            this.txtTitreEvent.Size = new System.Drawing.Size(260, 32);
            this.txtTitreEvent.TabIndex = 4;
            this.txtTitreEvent.Text = "Titre";
            this.txtTitreEvent.Enter += new System.EventHandler(this.txtTitreEvent_Enter);
            // 
            // picBoxDelimitation
            // 
            this.picBoxDelimitation.Image = global::UCajouterEvenement.Properties.Resources.delimitationBar;
            this.picBoxDelimitation.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxDelimitation.InitialImage")));
            this.picBoxDelimitation.Location = new System.Drawing.Point(6, 27);
            this.picBoxDelimitation.Name = "picBoxDelimitation";
            this.picBoxDelimitation.Size = new System.Drawing.Size(586, 63);
            this.picBoxDelimitation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDelimitation.TabIndex = 5;
            this.picBoxDelimitation.TabStop = false;
            // 
            // DateStart
            // 
            this.DateStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStart.Location = new System.Drawing.Point(18, 183);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(258, 26);
            this.DateStart.TabIndex = 6;
            this.DateStart.Value = new System.DateTime(2024, 6, 9, 0, 0, 0, 0);
            // 
            // DateEnd
            // 
            this.DateEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.DateEnd.Location = new System.Drawing.Point(318, 183);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(258, 26);
            this.DateEnd.TabIndex = 7;
            this.DateEnd.Value = new System.DateTime(2024, 6, 9, 9, 50, 59, 0);
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(14, 158);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(122, 22);
            this.lblDateDebut.TabIndex = 8;
            this.lblDateDebut.Text = "Date début :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(314, 158);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(92, 22);
            this.lblDateFin.TabIndex = 9;
            this.lblDateFin.Text = "Date fin :";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.Location = new System.Drawing.Point(14, 234);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(146, 22);
            this.lblCommentaire.TabIndex = 10;
            this.lblCommentaire.Text = "Commentaire :";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentaire.Location = new System.Drawing.Point(18, 259);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(558, 77);
            this.txtCommentaire.TabIndex = 11;
            // 
            // lblCreePar
            // 
            this.lblCreePar.AutoSize = true;
            this.lblCreePar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreePar.Location = new System.Drawing.Point(23, 405);
            this.lblCreePar.Name = "lblCreePar";
            this.lblCreePar.Size = new System.Drawing.Size(102, 22);
            this.lblCreePar.TabIndex = 12;
            this.lblCreePar.Text = "Créé par :";
            // 
            // cboCreePar
            // 
            this.cboCreePar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboCreePar.FormattingEnabled = true;
            this.cboCreePar.Location = new System.Drawing.Point(131, 402);
            this.cboCreePar.Name = "cboCreePar";
            this.cboCreePar.Size = new System.Drawing.Size(284, 30);
            this.cboCreePar.TabIndex = 13;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnValider.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(18, 449);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(574, 47);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider et envoyer les invitations";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // pnlInvitation
            // 
            this.pnlInvitation.Controls.Add(this.btnEnvoyerInvite);
            this.pnlInvitation.Controls.Add(this.chkListParticipants);
            this.pnlInvitation.Controls.Add(this.lblPartAInvite);
            this.pnlInvitation.Location = new System.Drawing.Point(18, 134);
            this.pnlInvitation.Name = "pnlInvitation";
            this.pnlInvitation.Size = new System.Drawing.Size(571, 362);
            this.pnlInvitation.TabIndex = 16;
            this.pnlInvitation.Visible = false;
            // 
            // btnEnvoyerInvite
            // 
            this.btnEnvoyerInvite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnEnvoyerInvite.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEnvoyerInvite.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyerInvite.Location = new System.Drawing.Point(22, 309);
            this.btnEnvoyerInvite.Name = "btnEnvoyerInvite";
            this.btnEnvoyerInvite.Size = new System.Drawing.Size(527, 40);
            this.btnEnvoyerInvite.TabIndex = 12;
            this.btnEnvoyerInvite.Text = "Envoyer les invitations";
            this.btnEnvoyerInvite.UseVisualStyleBackColor = false;
            this.btnEnvoyerInvite.Click += new System.EventHandler(this.btnEnvoyerInvite_Click);
            // 
            // chkListParticipants
            // 
            this.chkListParticipants.CheckOnClick = true;
            this.chkListParticipants.ColumnWidth = 250;
            this.chkListParticipants.Font = new System.Drawing.Font("Arial", 12F);
            this.chkListParticipants.FormattingEnabled = true;
            this.chkListParticipants.Location = new System.Drawing.Point(22, 47);
            this.chkListParticipants.MultiColumn = true;
            this.chkListParticipants.Name = "chkListParticipants";
            this.chkListParticipants.Size = new System.Drawing.Size(527, 256);
            this.chkListParticipants.TabIndex = 11;
            this.chkListParticipants.SelectedIndexChanged += new System.EventHandler(this.chkListParticipants_SelectedIndexChanged);
            // 
            // lblPartAInvite
            // 
            this.lblPartAInvite.AutoSize = true;
            this.lblPartAInvite.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartAInvite.Location = new System.Drawing.Point(160, 10);
            this.lblPartAInvite.Name = "lblPartAInvite";
            this.lblPartAInvite.Size = new System.Drawing.Size(257, 22);
            this.lblPartAInvite.TabIndex = 9;
            this.lblPartAInvite.Text = "Les participants à ajouter :";
            // 
            // chkSolde
            // 
            this.chkSolde.AutoSize = true;
            this.chkSolde.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSolde.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkSolde.Location = new System.Drawing.Point(27, 359);
            this.chkSolde.Name = "chkSolde";
            this.chkSolde.Size = new System.Drawing.Size(120, 26);
            this.chkSolde.TabIndex = 17;
            this.chkSolde.Text = "Soldé O/N";
            this.chkSolde.UseVisualStyleBackColor = true;
            // 
            // UC_Ajouter_Evenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pnlInvitation);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cboCreePar);
            this.Controls.Add(this.lblCreePar);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.txtTitreEvent);
            this.Controls.Add(this.lblNouvelEvenement);
            this.Controls.Add(this.picBoxDelimitation);
            this.Controls.Add(this.chkSolde);
            this.Name = "UC_Ajouter_Evenement";
            this.Size = new System.Drawing.Size(609, 520);
            this.Load += new System.EventHandler(this.UC_Ajouter_Evenement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelimitation)).EndInit();
            this.pnlInvitation.ResumeLayout(false);
            this.pnlInvitation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNouvelEvenement;
        private System.Windows.Forms.TextBox txtTitreEvent;
        private System.Windows.Forms.PictureBox picBoxDelimitation;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label lblCreePar;
        private System.Windows.Forms.ComboBox cboCreePar;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Panel pnlInvitation;
        private System.Windows.Forms.Label lblPartAInvite;
        private System.Windows.Forms.CheckedListBox chkListParticipants;
        private System.Windows.Forms.Button btnEnvoyerInvite;
        private System.Windows.Forms.CheckBox chkSolde;
    }
}
