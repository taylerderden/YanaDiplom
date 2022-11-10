namespace Kursovaya_Gazz
{
    partial class LgotaForm
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
            this.dGVLgota = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLgota)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVLgota
            // 
            this.dGVLgota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLgota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVLgota.Location = new System.Drawing.Point(0, 0);
            this.dGVLgota.Name = "dGVLgota";
            this.dGVLgota.RowHeadersWidth = 51;
            this.dGVLgota.RowTemplate.Height = 24;
            this.dGVLgota.Size = new System.Drawing.Size(800, 450);
            this.dGVLgota.TabIndex = 0;
            // 
            // LgotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVLgota);
            this.Name = "LgotaForm";
            this.Text = "LgotaForm";
            this.Load += new System.EventHandler(this.LgotaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLgota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVLgota;
    }
}