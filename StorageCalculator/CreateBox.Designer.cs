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
            ((System.ComponentModel.ISupportInitialize)(this.DGVsu)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNcrear
            // 
            this.BTNcrear.Location = new System.Drawing.Point(232, 152);
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
            this.DGVsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVsu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGVsu.Location = new System.Drawing.Point(0, 0);
            this.DGVsu.Name = "DGVsu";
            this.DGVsu.Size = new System.Drawing.Size(544, 146);
            this.DGVsu.TabIndex = 3;
            // 
            // RTXTlog
            // 
            this.RTXTlog.Location = new System.Drawing.Point(0, 181);
            this.RTXTlog.Name = "RTXTlog";
            this.RTXTlog.Size = new System.Drawing.Size(544, 53);
            this.RTXTlog.TabIndex = 4;
            this.RTXTlog.Text = "";
            // 
            // CreateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 234);
            this.Controls.Add(this.RTXTlog);
            this.Controls.Add(this.DGVsu);
            this.Controls.Add(this.BTNcrear);
            this.Name = "CreateBox";
            this.Text = "Nueva unidad de Almacenamieto";
            this.Load += new System.EventHandler(this.CreateBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNcrear;
        private System.Windows.Forms.DataGridView DGVsu;
        private System.Windows.Forms.RichTextBox RTXTlog;
    }
}