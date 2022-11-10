namespace Kursovaya_Gazz
{
    partial class AbonentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbonentForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBtnDobavit = new System.Windows.Forms.ToolStripButton();
            this.tStBtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.tSBtnDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(991, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnDobavit,
            this.tStBtnUpdate,
            this.tSBtnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(991, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnDobavit
            // 
            this.tSBtnDobavit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnDobavit.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnDobavit.Image")));
            this.tSBtnDobavit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnDobavit.Name = "tSBtnDobavit";
            this.tSBtnDobavit.Size = new System.Drawing.Size(80, 28);
            this.tSBtnDobavit.Text = "Добавить";
            // 
            // tStBtnUpdate
            // 
            this.tStBtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStBtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tStBtnUpdate.Image")));
            this.tStBtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStBtnUpdate.Name = "tStBtnUpdate";
            this.tStBtnUpdate.Size = new System.Drawing.Size(86, 28);
            this.tStBtnUpdate.Text = "Обновить ";
            // 
            // tSBtnDelete
            // 
            this.tSBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnDelete.Image")));
            this.tSBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnDelete.Name = "tSBtnDelete";
            this.tSBtnDelete.Size = new System.Drawing.Size(73, 28);
            this.tSBtnDelete.Text = "Удалить ";
            // 
            // AbonentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AbonentForm";
            this.Text = "AbonentForm";
            this.Load += new System.EventHandler(this.AbonentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnDobavit;
        private System.Windows.Forms.ToolStripButton tStBtnUpdate;
        private System.Windows.Forms.ToolStripButton tSBtnDelete;
    }
}