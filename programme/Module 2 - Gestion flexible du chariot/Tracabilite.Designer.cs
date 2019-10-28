namespace Module_2___Gestion_flexible_du_chariot {
    partial class Tracabilite {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lotDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radioAttente = new System.Windows.Forms.RadioButton();
            this.radioTous = new System.Windows.Forms.RadioButton();
            this.radioTermine = new System.Windows.Forms.RadioButton();
            this.radioProduction = new System.Windows.Forms.RadioButton();
            this.timePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.timePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.useDateFilters = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioDateCreation = new System.Windows.Forms.RadioButton();
            this.radioDateButoir = new System.Windows.Forms.RadioButton();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lotDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lotDataGrid
            // 
            this.lotDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lotDataGrid.Location = new System.Drawing.Point(326, 68);
            this.lotDataGrid.Name = "lotDataGrid";
            this.lotDataGrid.Size = new System.Drawing.Size(700, 370);
            this.lotDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tracabilité des lots";
            // 
            // radioAttente
            // 
            this.radioAttente.AutoSize = true;
            this.radioAttente.Location = new System.Drawing.Point(16, 65);
            this.radioAttente.Name = "radioAttente";
            this.radioAttente.Size = new System.Drawing.Size(74, 17);
            this.radioAttente.TabIndex = 2;
            this.radioAttente.Text = "En attente";
            this.radioAttente.UseVisualStyleBackColor = true;
            // 
            // radioTous
            // 
            this.radioTous.AutoSize = true;
            this.radioTous.Checked = true;
            this.radioTous.Location = new System.Drawing.Point(16, 19);
            this.radioTous.Name = "radioTous";
            this.radioTous.Size = new System.Drawing.Size(49, 17);
            this.radioTous.TabIndex = 3;
            this.radioTous.TabStop = true;
            this.radioTous.Text = "Tous";
            this.radioTous.UseVisualStyleBackColor = true;
            // 
            // radioTermine
            // 
            this.radioTermine.AutoSize = true;
            this.radioTermine.Location = new System.Drawing.Point(16, 42);
            this.radioTermine.Name = "radioTermine";
            this.radioTermine.Size = new System.Drawing.Size(63, 17);
            this.radioTermine.TabIndex = 4;
            this.radioTermine.Text = "Terminé";
            this.radioTermine.UseVisualStyleBackColor = true;
            // 
            // radioProduction
            // 
            this.radioProduction.AutoSize = true;
            this.radioProduction.Location = new System.Drawing.Point(16, 88);
            this.radioProduction.Name = "radioProduction";
            this.radioProduction.Size = new System.Drawing.Size(91, 17);
            this.radioProduction.TabIndex = 5;
            this.radioProduction.Text = "En production";
            this.radioProduction.UseVisualStyleBackColor = true;
            // 
            // timePickerDebut
            // 
            this.timePickerDebut.Location = new System.Drawing.Point(119, 69);
            this.timePickerDebut.Name = "timePickerDebut";
            this.timePickerDebut.Size = new System.Drawing.Size(171, 20);
            this.timePickerDebut.TabIndex = 6;
            // 
            // timePickerFin
            // 
            this.timePickerFin.Location = new System.Drawing.Point(119, 95);
            this.timePickerFin.Name = "timePickerFin";
            this.timePickerFin.Size = new System.Drawing.Size(171, 20);
            this.timePickerFin.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date de début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date de fin";
            // 
            // useDateFilters
            // 
            this.useDateFilters.AutoSize = true;
            this.useDateFilters.Location = new System.Drawing.Point(6, 19);
            this.useDateFilters.Name = "useDateFilters";
            this.useDateFilters.Size = new System.Drawing.Size(134, 17);
            this.useDateFilters.TabIndex = 10;
            this.useDateFilters.Text = "Utiliser le filtre de dates";
            this.useDateFilters.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDateButoir);
            this.groupBox1.Controls.Add(this.radioDateCreation);
            this.groupBox1.Controls.Add(this.useDateFilters);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.timePickerFin);
            this.groupBox1.Controls.Add(this.timePickerDebut);
            this.groupBox1.Location = new System.Drawing.Point(10, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre sur les dates";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioProduction);
            this.groupBox2.Controls.Add(this.radioTermine);
            this.groupBox2.Controls.Add(this.radioTous);
            this.groupBox2.Controls.Add(this.radioAttente);
            this.groupBox2.Location = new System.Drawing.Point(10, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 113);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtre sur l\'état";
            // 
            // radioDateCreation
            // 
            this.radioDateCreation.AutoSize = true;
            this.radioDateCreation.Location = new System.Drawing.Point(6, 42);
            this.radioDateCreation.Name = "radioDateCreation";
            this.radioDateCreation.Size = new System.Drawing.Size(89, 17);
            this.radioDateCreation.TabIndex = 11;
            this.radioDateCreation.TabStop = true;
            this.radioDateCreation.Text = "Date création";
            this.radioDateCreation.UseVisualStyleBackColor = true;
            // 
            // radioDateButoir
            // 
            this.radioDateButoir.AutoSize = true;
            this.radioDateButoir.Checked = true;
            this.radioDateButoir.Location = new System.Drawing.Point(119, 42);
            this.radioDateButoir.Name = "radioDateButoir";
            this.radioDateButoir.Size = new System.Drawing.Size(77, 17);
            this.radioDateButoir.TabIndex = 12;
            this.radioDateButoir.TabStop = true;
            this.radioDateButoir.Text = "Date butoir";
            this.radioDateButoir.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(10, 314);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(89, 20);
            this.update.TabIndex = 13;
            this.update.Text = "Actualiser";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Tracabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 458);
            this.Controls.Add(this.update);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lotDataGrid);
            this.Name = "Tracabilite";
            this.Text = "Tracabilite";
            this.Load += new System.EventHandler(this.Tracabilite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lotDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lotDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAttente;
        private System.Windows.Forms.RadioButton radioTous;
        private System.Windows.Forms.RadioButton radioTermine;
        private System.Windows.Forms.RadioButton radioProduction;
        private System.Windows.Forms.DateTimePicker timePickerDebut;
        private System.Windows.Forms.DateTimePicker timePickerFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox useDateFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioDateButoir;
        private System.Windows.Forms.RadioButton radioDateCreation;
        private System.Windows.Forms.Button update;
    }
}