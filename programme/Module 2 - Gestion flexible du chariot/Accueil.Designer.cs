﻿namespace Module_2___Gestion_flexible_du_chariot
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
            this.AllerTracabiliteLots.Location = new System.Drawing.Point(527, 470);
            this.AllerTracabiliteLots.Name = "AllerTracabiliteLots";
            this.AllerTracabiliteLots.Size = new System.Drawing.Size(420, 65);
            this.AllerTracabiliteLots.TabIndex = 0;
            this.AllerTracabiliteLots.Text = "Traçabilité des lots";
            this.AllerTracabiliteLots.UseVisualStyleBackColor = true;
            this.AllerTracabiliteLots.UseWaitCursor = true;
            this.AllerTracabiliteLots.Click += new System.EventHandler(this.AllerTracabiliteLots_Click);
            // 
            // AllerEditionLots
            // 
            this.AllerEditionLots.Location = new System.Drawing.Point(527, 353);
            this.AllerEditionLots.Name = "AllerEditionLots";
            this.AllerEditionLots.Size = new System.Drawing.Size(420, 65);
            this.AllerEditionLots.TabIndex = 1;
            this.AllerEditionLots.Text = "Edition de lots";
            this.AllerEditionLots.UseVisualStyleBackColor = true;
            this.AllerEditionLots.UseWaitCursor = true;
            this.AllerEditionLots.Click += new System.EventHandler(this.AllerEditionLots_Click);
            // 
            // AllerEditionRecettes
            // 
            this.AllerEditionRecettes.Location = new System.Drawing.Point(527, 237);
            this.AllerEditionRecettes.Name = "AllerEditionRecettes";
            this.AllerEditionRecettes.Size = new System.Drawing.Size(420, 65);
            this.AllerEditionRecettes.TabIndex = 2;
            this.AllerEditionRecettes.Text = "Edition de recettes";
            this.AllerEditionRecettes.UseVisualStyleBackColor = true;
            this.AllerEditionRecettes.UseWaitCursor = true;
            this.AllerEditionRecettes.Click += new System.EventHandler(this.AllerEditionRecettes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(991, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Module 2 - Gestion flexible du chariot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // AllerEvenements
            // 
            this.AllerEvenements.Location = new System.Drawing.Point(527, 590);
            this.AllerEvenements.Name = "AllerEvenements";
            this.AllerEvenements.Size = new System.Drawing.Size(420, 65);
            this.AllerEvenements.TabIndex = 4;
            this.AllerEvenements.Text = "Evénements";
            this.AllerEvenements.UseVisualStyleBackColor = true;
            this.AllerEvenements.UseWaitCursor = true;
            this.AllerEvenements.Click += new System.EventHandler(this.AllerEvenements_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 761);
            this.Controls.Add(this.AllerEvenements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllerEditionRecettes);
            this.Controls.Add(this.AllerEditionLots);
            this.Controls.Add(this.AllerTracabiliteLots);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.UseWaitCursor = true;
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

