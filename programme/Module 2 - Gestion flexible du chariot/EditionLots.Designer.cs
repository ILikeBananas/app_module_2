namespace Module_2___Gestion_flexible_du_chariot
{
    partial class EditionLots
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LotName = new System.Windows.Forms.TextBox();
            this.LabelLotName = new System.Windows.Forms.Label();
            this.LabelNbrePieces = new System.Windows.Forms.Label();
            this.NbrePieces = new System.Windows.Forms.TextBox();
            this.DateButoir = new System.Windows.Forms.DateTimePicker();
            this.LabelDateButoir = new System.Windows.Forms.Label();
            this.RecetteBox = new System.Windows.Forms.ComboBox();
            this.LabelRecetteBox = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crétation des lots";
            // 
            // LotName
            // 
            this.LotName.Location = new System.Drawing.Point(110, 51);
            this.LotName.Name = "LotName";
            this.LotName.Size = new System.Drawing.Size(98, 20);
            this.LotName.TabIndex = 1;
            // 
            // LabelLotName
            // 
            this.LabelLotName.AutoSize = true;
            this.LabelLotName.Location = new System.Drawing.Point(2, 54);
            this.LabelLotName.Name = "LabelLotName";
            this.LabelLotName.Size = new System.Drawing.Size(67, 13);
            this.LabelLotName.TabIndex = 2;
            this.LabelLotName.Text = "Nom du lot : ";
            // 
            // LabelNbrePieces
            // 
            this.LabelNbrePieces.AutoSize = true;
            this.LabelNbrePieces.Location = new System.Drawing.Point(2, 81);
            this.LabelNbrePieces.Name = "LabelNbrePieces";
            this.LabelNbrePieces.Size = new System.Drawing.Size(102, 13);
            this.LabelNbrePieces.TabIndex = 6;
            this.LabelNbrePieces.Text = "Nombre de pièces : ";
            // 
            // NbrePieces
            // 
            this.NbrePieces.Location = new System.Drawing.Point(110, 78);
            this.NbrePieces.Name = "NbrePieces";
            this.NbrePieces.Size = new System.Drawing.Size(98, 20);
            this.NbrePieces.TabIndex = 5;
            // 
            // DateButoir
            // 
            this.DateButoir.Location = new System.Drawing.Point(110, 104);
            this.DateButoir.Name = "DateButoir";
            this.DateButoir.Size = new System.Drawing.Size(182, 20);
            this.DateButoir.TabIndex = 7;
            // 
            // LabelDateButoir
            // 
            this.LabelDateButoir.AutoSize = true;
            this.LabelDateButoir.Location = new System.Drawing.Point(2, 110);
            this.LabelDateButoir.Name = "LabelDateButoir";
            this.LabelDateButoir.Size = new System.Drawing.Size(65, 13);
            this.LabelDateButoir.TabIndex = 8;
            this.LabelDateButoir.Text = "Date butoir :";
            // 
            // RecetteBox
            // 
            this.RecetteBox.FormattingEnabled = true;
            this.RecetteBox.Location = new System.Drawing.Point(110, 135);
            this.RecetteBox.Name = "RecetteBox";
            this.RecetteBox.Size = new System.Drawing.Size(97, 21);
            this.RecetteBox.TabIndex = 9;
            // 
            // LabelRecetteBox
            // 
            this.LabelRecetteBox.AutoSize = true;
            this.LabelRecetteBox.Location = new System.Drawing.Point(2, 143);
            this.LabelRecetteBox.Name = "LabelRecetteBox";
            this.LabelRecetteBox.Size = new System.Drawing.Size(89, 13);
            this.LabelRecetteBox.TabIndex = 10;
            this.LabelRecetteBox.Text = "Recette utilisée  :";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(5, 168);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(97, 25);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "Créer lot";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Location = new System.Drawing.Point(108, 168);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(10, 13);
            this.ErrorMessage.TabIndex = 12;
            this.ErrorMessage.Text = " ";
            // 
            // EditionLots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 324);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.LabelRecetteBox);
            this.Controls.Add(this.RecetteBox);
            this.Controls.Add(this.LabelDateButoir);
            this.Controls.Add(this.DateButoir);
            this.Controls.Add(this.LabelNbrePieces);
            this.Controls.Add(this.NbrePieces);
            this.Controls.Add(this.LabelLotName);
            this.Controls.Add(this.LotName);
            this.Controls.Add(this.label1);
            this.Name = "EditionLots";
            this.Text = "EditionLots";
            this.Load += new System.EventHandler(this.EditionLots_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LotName;
        private System.Windows.Forms.Label LabelLotName;
        private System.Windows.Forms.Label LabelNbrePieces;
        private System.Windows.Forms.TextBox NbrePieces;
        private System.Windows.Forms.DateTimePicker DateButoir;
        private System.Windows.Forms.Label LabelDateButoir;
        private System.Windows.Forms.ComboBox RecetteBox;
        private System.Windows.Forms.Label LabelRecetteBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label ErrorMessage;
    }
}