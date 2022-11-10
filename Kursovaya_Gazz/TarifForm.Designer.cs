namespace Kursovaya_Gazz
{
    partial class TarifForm
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
            this.dGVTarif = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTarif)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVTarif
            // 
            this.dGVTarif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTarif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVTarif.Location = new System.Drawing.Point(0, 0);
            this.dGVTarif.Name = "dGVTarif";
            this.dGVTarif.RowHeadersWidth = 51;
            this.dGVTarif.RowTemplate.Height = 24;
            this.dGVTarif.Size = new System.Drawing.Size(800, 450);
            this.dGVTarif.TabIndex = 0;
            // 
            // TarifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVTarif);
            this.Name = "TarifForm";
            this.Text = "TarifForm";
            this.Load += new System.EventHandler(this.TarifForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTarif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVTarif;
    }
}