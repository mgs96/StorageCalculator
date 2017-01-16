namespace StorageCalculator
{
    partial class CreateBox
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
            this.BTNcrear = new System.Windows.Forms.Button();
            this.DGVsu = new System.Windows.Forms.DataGridView();
            this.RTXTlog = new System.Windows.Forms.RichTextBox();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDfolios = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDfolios)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNcrear
            // 
            this.BTNcrear.Location = new System.Drawing.Point(231, 350);
            this.BTNcrear.Name = "BTNcrear";
            this.BTNcrear.Size = new System.Drawing.Size(75, 23);
            this.BTNcrear.TabIndex = 0;
            this.BTNcrear.Text = "Crear";
            this.BTNcrear.UseVisualStyleBackColor = true;
            this.BTNcrear.Click += new System.EventHandler(this.BTNcrear_Click);
            // 
            // DGVsu
            // 
            this.DGVsu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGVsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVsu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGVsu.Location = new System.Drawing.Point(12, 132);
            this.DGVsu.Name = "DGVsu";
            this.DGVsu.Size = new System.Drawing.Size(495, 212);
            this.DGVsu.TabIndex = 3;
            // 
            // RTXTlog
            // 
            this.RTXTlog.Location = new System.Drawing.Point(15, 379);
            this.RTXTlog.Name = "RTXTlog";
            this.RTXTlog.Size = new System.Drawing.Size(492, 53);
            this.RTXTlog.TabIndex = 4;
            this.RTXTlog.Text = "";
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(12, 37);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(233, 20);
            this.TXTnombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de la empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NIT";
            // 
            // TXTnit
            // 
            this.TXTnit.Location = new System.Drawing.Point(275, 37);
            this.TXTnit.Name = "TXTnit";
            this.TXTnit.Size = new System.Drawing.Size(232, 20);
            this.TXTnit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "1 metro lineal =";
            // 
            // NUDfolios
            // 
            this.NUDfolios.Location = new System.Drawing.Point(93, 70);
            this.NUDfolios.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUDfolios.Name = "NUDfolios";
            this.NUDfolios.Size = new System.Drawing.Size(70, 20);
            this.NUDfolios.TabIndex = 10;
            this.NUDfolios.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "folios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unidades de almacenamiento";
            // 
            // CreateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUDfolios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.RTXTlog);
            this.Controls.Add(this.DGVsu);
            this.Controls.Add(this.BTNcrear);
            this.Name = "CreateBox";
            this.Text = "Ajustes de aplicación";
            this.Load += new System.EventHandler(this.CreateBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDfolios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcrear;
        private System.Windows.Forms.DataGridView DGVsu;
        private System.Windows.Forms.RichTextBox RTXTlog;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDfolios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}