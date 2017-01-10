namespace StorageCalculator
{
    partial class Lista
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
            this.DGVlista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVlista)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVlista
            // 
            this.DGVlista.AllowUserToAddRows = false;
            this.DGVlista.AllowUserToDeleteRows = false;
            this.DGVlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVlista.Location = new System.Drawing.Point(0, 0);
            this.DGVlista.Name = "DGVlista";
            this.DGVlista.ReadOnly = true;
            this.DGVlista.Size = new System.Drawing.Size(288, 479);
            this.DGVlista.TabIndex = 0;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 479);
            this.Controls.Add(this.DGVlista);
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVlista;

    }
}