﻿namespace Module_2___Gestion_flexible_du_chariot
{
    partial class EditionRecette
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Charger = new System.Windows.Forms.Button();
            this.Sauvegarder = new System.Windows.Forms.Button();
            this.NewRecette = new System.Windows.Forms.Button();
            this.DeleteRecette = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 396);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleName = "EditRecetteGridView";
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(275, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(492, 396);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // Charger
            // 
            this.Charger.Location = new System.Drawing.Point(12, 414);
            this.Charger.Name = "Charger";
            this.Charger.Size = new System.Drawing.Size(80, 25);
            this.Charger.TabIndex = 2;
            this.Charger.Text = "Charger";
            this.Charger.UseVisualStyleBackColor = true;
            this.Charger.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sauvegarder
            // 
            this.Sauvegarder.Location = new System.Drawing.Point(98, 414);
            this.Sauvegarder.Name = "Sauvegarder";
            this.Sauvegarder.Size = new System.Drawing.Size(80, 25);
            this.Sauvegarder.TabIndex = 3;
            this.Sauvegarder.Text = "Sauvegarder";
            this.Sauvegarder.UseVisualStyleBackColor = true;
            this.Sauvegarder.Click += new System.EventHandler(this.Sauvegarder_Click);
            // 
            // NewRecette
            // 
            this.NewRecette.Location = new System.Drawing.Point(192, 414);
            this.NewRecette.Name = "NewRecette";
            this.NewRecette.Size = new System.Drawing.Size(99, 24);
            this.NewRecette.TabIndex = 4;
            this.NewRecette.Text = "Nouvelle Recette";
            this.NewRecette.UseVisualStyleBackColor = true;
            this.NewRecette.Click += new System.EventHandler(this.NewRecette_Click);
            // 
            // DeleteRecette
            // 
            this.DeleteRecette.Location = new System.Drawing.Point(297, 414);
            this.DeleteRecette.Name = "DeleteRecette";
            this.DeleteRecette.Size = new System.Drawing.Size(104, 24);
            this.DeleteRecette.TabIndex = 5;
            this.DeleteRecette.Text = "Supprimer Recette";
            this.DeleteRecette.UseVisualStyleBackColor = true;
            this.DeleteRecette.Click += new System.EventHandler(this.DeleteRecette_Click);
            // 
            // EditionRecette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteRecette);
            this.Controls.Add(this.NewRecette);
            this.Controls.Add(this.Sauvegarder);
            this.Controls.Add(this.Charger);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditionRecette";
            this.Text = "EditionRecette";
            this.Load += new System.EventHandler(this.EditionRecette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Charger;
        private System.Windows.Forms.Button Sauvegarder;
        private System.Windows.Forms.Button NewRecette;
        private System.Windows.Forms.Button DeleteRecette;
    }
}