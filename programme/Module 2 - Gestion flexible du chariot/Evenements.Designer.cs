namespace Module_2___Gestion_flexible_du_chariot {
    partial class Evenements {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.useDateFilters = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timePickerFin = new System.Windows.Forms.DateTimePicker();
            this.timePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.lotDataGrid = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.useLotFilters = new System.Windows.Forms.CheckBox();
            this.comboLots = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.useDateFilters);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.timePickerFin);
            this.groupBox1.Controls.Add(this.timePickerDebut);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 121);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre sur les dates";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date de début";
            // 
            // timePickerFin
            // 
            this.timePickerFin.Location = new System.Drawing.Point(119, 65);
            this.timePickerFin.Name = "timePickerFin";
            this.timePickerFin.Size = new System.Drawing.Size(171, 20);
            this.timePickerFin.TabIndex = 7;
            // 
            // timePickerDebut
            // 
            this.timePickerDebut.Location = new System.Drawing.Point(119, 39);
            this.timePickerDebut.Name = "timePickerDebut";
            this.timePickerDebut.Size = new System.Drawing.Size(171, 20);
            this.timePickerDebut.TabIndex = 6;
            // 
            // lotDataGrid
            // 
            this.lotDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lotDataGrid.Location = new System.Drawing.Point(331, 54);
            this.lotDataGrid.Name = "lotDataGrid";
            this.lotDataGrid.Size = new System.Drawing.Size(527, 356);
            this.lotDataGrid.TabIndex = 12;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(15, 284);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(89, 20);
            this.update.TabIndex = 14;
            this.update.Text = "Actualiser";
            this.update.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Evenements";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboLots);
            this.groupBox2.Controls.Add(this.useLotFilters);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 84);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtre sur les lots";
            // 
            // useLotFilters
            // 
            this.useLotFilters.AutoSize = true;
            this.useLotFilters.Location = new System.Drawing.Point(14, 19);
            this.useLotFilters.Name = "useLotFilters";
            this.useLotFilters.Size = new System.Drawing.Size(142, 17);
            this.useLotFilters.TabIndex = 0;
            this.useLotFilters.Text = "Utiliser le filtre sur les lots";
            this.useLotFilters.UseVisualStyleBackColor = true;
            // 
            // comboLots
            // 
            this.comboLots.FormattingEnabled = true;
            this.comboLots.Location = new System.Drawing.Point(75, 44);
            this.comboLots.Name = "comboLots";
            this.comboLots.Size = new System.Drawing.Size(139, 21);
            this.comboLots.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nom du lot";
            // 
            // Evenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lotDataGrid);
            this.Name = "Evenement";
            this.Text = "Evenement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox useDateFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timePickerFin;
        private System.Windows.Forms.DateTimePicker timePickerDebut;
        private System.Windows.Forms.DataGridView lotDataGrid;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboLots;
        private System.Windows.Forms.CheckBox useLotFilters;
    }
}