namespace StorageCalculator
{
    partial class CreateStorage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTname = new System.Windows.Forms.TextBox();
            this.NUDlinealCapacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDlinealCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNcrear
            // 
            this.BTNcrear.Location = new System.Drawing.Point(65, 81);
            this.BTNcrear.Name = "BTNcrear";
            this.BTNcrear.Size = new System.Drawing.Size(75, 23);
            this.BTNcrear.TabIndex = 0;
            this.BTNcrear.Text = "Crear";
            this.BTNcrear.UseVisualStyleBackColor = true;
            this.BTNcrear.Click += new System.EventHandler(this.BTNcrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capacidad en metros lineales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(65, 12);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(139, 20);
            this.TXTname.TabIndex = 3;
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
            this.NUDlinealCapacity.TabIndex = 4;
            this.NUDlinealCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 116);
            this.Controls.Add(this.NUDlinealCapacity);
            this.Controls.Add(this.TXTname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNcrear);
            this.Name = "CreateStorage";
            this.Text = "Nueva Bodega";
            ((System.ComponentModel.ISupportInitialize)(this.NUDlinealCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.NumericUpDown NUDlinealCapacity;
    }
}