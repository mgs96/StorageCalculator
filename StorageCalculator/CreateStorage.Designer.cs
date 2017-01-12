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
            this.TXTidentificador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDancho = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDlargo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDlinealCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDancho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDlargo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNcrear
            // 
            this.BTNcrear.Location = new System.Drawing.Point(69, 207);
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
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metros lineales disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificador";
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(15, 64);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(187, 20);
            this.TXTname.TabIndex = 3;
            // 
            // NUDlinealCapacity
            // 
            this.NUDlinealCapacity.Location = new System.Drawing.Point(15, 103);
            this.NUDlinealCapacity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDlinealCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDlinealCapacity.Name = "NUDlinealCapacity";
            this.NUDlinealCapacity.Size = new System.Drawing.Size(187, 20);
            this.NUDlinealCapacity.TabIndex = 4;
            this.NUDlinealCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TXTidentificador
            // 
            this.TXTidentificador.Location = new System.Drawing.Point(15, 25);
            this.TXTidentificador.Name = "TXTidentificador";
            this.TXTidentificador.Size = new System.Drawing.Size(187, 20);
            this.TXTidentificador.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // NUDancho
            // 
            this.NUDancho.Location = new System.Drawing.Point(15, 142);
            this.NUDancho.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDancho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDancho.Name = "NUDancho";
            this.NUDancho.Size = new System.Drawing.Size(187, 20);
            this.NUDancho.TabIndex = 8;
            this.NUDancho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ancho";
            // 
            // NUDlargo
            // 
            this.NUDlargo.Location = new System.Drawing.Point(15, 181);
            this.NUDlargo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDlargo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDlargo.Name = "NUDlargo";
            this.NUDlargo.Size = new System.Drawing.Size(187, 20);
            this.NUDlargo.TabIndex = 10;
            this.NUDlargo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Largo";
            // 
            // CreateStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 246);
            this.Controls.Add(this.NUDlargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NUDancho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTidentificador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NUDlinealCapacity);
            this.Controls.Add(this.TXTname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNcrear);
            this.Name = "CreateStorage";
            this.Text = "Nueva Bodega";
            ((System.ComponentModel.ISupportInitialize)(this.NUDlinealCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDancho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDlargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.NumericUpDown NUDlinealCapacity;
        private System.Windows.Forms.TextBox TXTidentificador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDancho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDlargo;
        private System.Windows.Forms.Label label5;
    }
}