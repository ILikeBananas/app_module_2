namespace Module_2___Gestion_flexible_du_chariot
{
    partial class Accueil
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
            this.AllerTracabiliteLots = new System.Windows.Forms.Button();
            this.AllerEditionLots = new System.Windows.Forms.Button();
            this.AllerEditionRecettes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllerEvenements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllerTracabiliteLots
            // 
            this.AllerTracabiliteLots.CausesValidation = false;
            this.AllerTracabiliteLots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllerTracabiliteLots.Location = new System.Drawing.Point(123, 243);
            this.AllerTracabiliteLots.Margin = new System.Windows.Forms.Padding(2);
            this.AllerTracabiliteLots.Name = "AllerTracabiliteLots";
            this.AllerTracabiliteLots.Size = new System.Drawing.Size(280, 42);
            this.AllerTracabiliteLots.TabIndex = 0;
            this.AllerTracabiliteLots.Text = "Traçabilité des lots";
            this.AllerTracabiliteLots.UseVisualStyleBackColor = true;
            this.AllerTracabiliteLots.Click += new System.EventHandler(this.AllerTracabiliteLots_Click);
            // 
            // AllerEditionLots
            // 
            this.AllerEditionLots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllerEditionLots.Location = new System.Drawing.Point(123, 167);
            this.AllerEditionLots.Margin = new System.Windows.Forms.Padding(2);
            this.AllerEditionLots.Name = "AllerEditionLots";
            this.AllerEditionLots.Size = new System.Drawing.Size(280, 42);
            this.AllerEditionLots.TabIndex = 1;
            this.AllerEditionLots.Text = "Edition de lots";
            this.AllerEditionLots.UseVisualStyleBackColor = true;
            this.AllerEditionLots.Click += new System.EventHandler(this.AllerEditionLots_Click);
            // 
            // AllerEditionRecettes
            // 
            this.AllerEditionRecettes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllerEditionRecettes.Location = new System.Drawing.Point(123, 92);
            this.AllerEditionRecettes.Margin = new System.Windows.Forms.Padding(2);
            this.AllerEditionRecettes.Name = "AllerEditionRecettes";
            this.AllerEditionRecettes.Size = new System.Drawing.Size(280, 42);
            this.AllerEditionRecettes.TabIndex = 2;
            this.AllerEditionRecettes.Text = "Edition de recettes";
            this.AllerEditionRecettes.UseVisualStyleBackColor = true;
            this.AllerEditionRecettes.Click += new System.EventHandler(this.AllerEditionRecettes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Module 2 - Gestion flexible du chariot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllerEvenements
            // 
            this.AllerEvenements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllerEvenements.Location = new System.Drawing.Point(123, 321);
            this.AllerEvenements.Margin = new System.Windows.Forms.Padding(2);
            this.AllerEvenements.Name = "AllerEvenements";
            this.AllerEvenements.Size = new System.Drawing.Size(280, 42);
            this.AllerEvenements.TabIndex = 4;
            this.AllerEvenements.Text = "Evénements";
            this.AllerEvenements.UseVisualStyleBackColor = true;
            this.AllerEvenements.Click += new System.EventHandler(this.AllerEvenements_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 420);
            this.Controls.Add(this.AllerEvenements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllerEditionRecettes);
            this.Controls.Add(this.AllerEditionLots);
            this.Controls.Add(this.AllerTracabiliteLots);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AllerTracabiliteLots;
        private System.Windows.Forms.Button AllerEditionLots;
        private System.Windows.Forms.Button AllerEditionRecettes;
        private System.Windows.Forms.Button AllerEvenements;
        private System.Windows.Forms.Label label1;


    }
}

