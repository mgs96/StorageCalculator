namespace StorageCalculator
{
    partial class EditStorage
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
            this.NUDlinealCapacity = new System.Windows.Forms.NumericUpDown();
            this.TXTname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDlinealCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDlinealCapacity
            // 
            this.NUDlinealCapacity.Location = new System.Drawing.Point(166, 47);
            this.NUDlinealCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDlinealCapacity.Name = "NUDlinealCapacity";
            this.NUDlinealCapacity.Size = new System.Drawing.Size(38, 20);
            this.NUDlinealCapacity.TabIndex = 9;
            this.NUDlinealCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(65, 12);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(139, 20);
            this.TXTname.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Capacidad en metros lineales:";
            // 
            // BTNguardar
            // 
            this.BTNguardar.Location = new System.Drawing.Point(65, 81);
            this.BTNguardar.Name = "BTNguardar";
            this.BTNguardar.Size = new System.Drawing.Size(75, 23);
            this.BTNguardar.TabIndex = 5;
            this.BTNguardar.Text = "Guardar";
            this.BTNguardar.UseVisualStyleBackColor = true;
            // 
            // EditStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 116);
            this.Controls.Add(this.NUDlinealCapacity);
            this.Controls.Add(this.TXTname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNguardar);
            this.Name = "EditStorage";
            this.Text = "EditStorage";
            ((System.ComponentModel.ISupportInitialize)(this.NUDlinealCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDlinealCapacity;
        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNguardar;
    }
}