namespace Kursovaya_Gazz
{
    partial class DolgForm
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
            this.dGVDolg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDolg)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDolg
            // 
            this.dGVDolg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDolg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVDolg.Location = new System.Drawing.Point(0, 0);
            this.dGVDolg.Name = "dGVDolg";
            this.dGVDolg.RowHeadersWidth = 51;
            this.dGVDolg.RowTemplate.Height = 24;
            this.dGVDolg.Size = new System.Drawing.Size(800, 450);
            this.dGVDolg.TabIndex = 0;
            // 
            // DolgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVDolg);
            this.Name = "DolgForm";
            this.Text = "DolgForm";
            this.Load += new System.EventHandler(this.DolgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDolg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDolg;
    }
}