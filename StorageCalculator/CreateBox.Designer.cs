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
            this.TXTrotulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTtipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDmetrosLineales = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDmetrosLineales)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNcrear
            // 
            this.BTNcrear.Location = new System.Drawing.Point(70, 119);
            this.BTNcrear.Name = "BTNcrear";
            this.BTNcrear.Size = new System.Drawing.Size(75, 23);
            this.BTNcrear.TabIndex = 0;
            this.BTNcrear.Text = "Crear";
            this.BTNcrear.UseVisualStyleBackColor = true;
            this.BTNcrear.Click += new System.EventHandler(this.BTNcrear_Click);
            // 
            // TXTrotulo
            // 
            this.TXTrotulo.Location = new System.Drawing.Point(59, 12);
            this.TXTrotulo.Name = "TXTrotulo";
            this.TXTrotulo.Size = new System.Drawing.Size(143, 20);
            this.TXTrotulo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rótulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo:";
            // 
            // TXTtipo
            // 
            this.TXTtipo.Location = new System.Drawing.Point(49, 47);
            this.TXTtipo.Name = "TXTtipo";
            this.TXTtipo.Size = new System.Drawing.Size(153, 20);
            this.TXTtipo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tamaño en metros lineales";
            // 
            // NUDmetrosLineales
            // 
            this.NUDmetrosLineales.Location = new System.Drawing.Point(155, 82);
            this.NUDmetrosLineales.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDmetrosLineales.Name = "NUDmetrosLineales";
            this.NUDmetrosLineales.Size = new System.Drawing.Size(47, 20);
            this.NUDmetrosLineales.TabIndex = 11;
            this.NUDmetrosLineales.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 160);
            this.Controls.Add(this.NUDmetrosLineales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTtipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTrotulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNcrear);
            this.Name = "CreateBox";
            this.Text = "CreateBox";
            ((System.ComponentModel.ISupportInitialize)(this.NUDmetrosLineales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcrear;
        private System.Windows.Forms.TextBox TXTrotulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTtipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDmetrosLineales;
    }
}