namespace Kursovaya_Gazz
{
    partial class PokazanieForm
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
            this.dGVPokazanie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPokazanie)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVPokazanie
            // 
            this.dGVPokazanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPokazanie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVPokazanie.Location = new System.Drawing.Point(0, 0);
            this.dGVPokazanie.Name = "dGVPokazanie";
            this.dGVPokazanie.RowHeadersWidth = 51;
            this.dGVPokazanie.RowTemplate.Height = 24;
            this.dGVPokazanie.Size = new System.Drawing.Size(800, 450);
            this.dGVPokazanie.TabIndex = 0;
            // 
            // PokazanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVPokazanie);
            this.Name = "PokazanieForm";
            this.Text = "PokazanieForm";
            this.Load += new System.EventHandler(this.PokazanieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPokazanie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVPokazanie;
    }
}