namespace Kursovaya_Gazz
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBtnAbonent = new System.Windows.Forms.ToolStripButton();
            this.tSBtnTarif = new System.Windows.Forms.ToolStripButton();
            this.tSBtnLgota = new System.Windows.Forms.ToolStripButton();
            this.tSBtnPokazanie = new System.Windows.Forms.ToolStripButton();
            this.tSBtnDolg = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCalc = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnAbonent,
            this.tSBtnTarif,
            this.tSBtnLgota,
            this.tSBtnPokazanie,
            this.tSBtnDolg,
            this.toolStripBtnCalc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1062, 57);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnAbonent
            // 
            this.tSBtnAbonent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnAbonent.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSBtnAbonent.ForeColor = System.Drawing.Color.White;
            this.tSBtnAbonent.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnAbonent.Image")));
            this.tSBtnAbonent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnAbonent.Margin = new System.Windows.Forms.Padding(45, 1, 75, 2);
            this.tSBtnAbonent.Name = "tSBtnAbonent";
            this.tSBtnAbonent.Size = new System.Drawing.Size(85, 54);
            this.tSBtnAbonent.Text = "Абонент";
            this.tSBtnAbonent.Click += new System.EventHandler(this.tSBtnAbonent_Click);
            // 
            // tSBtnTarif
            // 
            this.tSBtnTarif.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnTarif.Font = new System.Drawing.Font("Palatino Linotype", 10.8F);
            this.tSBtnTarif.ForeColor = System.Drawing.Color.White;
            this.tSBtnTarif.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnTarif.Image")));
            this.tSBtnTarif.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnTarif.Margin = new System.Windows.Forms.Padding(5, 1, 50, 1);
            this.tSBtnTarif.Name = "tSBtnTarif";
            this.tSBtnTarif.Size = new System.Drawing.Size(70, 55);
            this.tSBtnTarif.Text = "Тариф";
            this.tSBtnTarif.Click += new System.EventHandler(this.tSBtnTarif_Click);
            // 
            // tSBtnLgota
            // 
            this.tSBtnLgota.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnLgota.Font = new System.Drawing.Font("Palatino Linotype", 10.8F);
            this.tSBtnLgota.ForeColor = System.Drawing.Color.White;
            this.tSBtnLgota.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnLgota.Image")));
            this.tSBtnLgota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnLgota.Margin = new System.Windows.Forms.Padding(20, 1, 54, 2);
            this.tSBtnLgota.Name = "tSBtnLgota";
            this.tSBtnLgota.Size = new System.Drawing.Size(69, 54);
            this.tSBtnLgota.Text = "Льгота";
            this.tSBtnLgota.Click += new System.EventHandler(this.tSBtnLgota_Click);
            // 
            // tSBtnPokazanie
            // 
            this.tSBtnPokazanie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnPokazanie.Font = new System.Drawing.Font("Palatino Linotype", 10.8F);
            this.tSBtnPokazanie.ForeColor = System.Drawing.Color.White;
            this.tSBtnPokazanie.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnPokazanie.Image")));
            this.tSBtnPokazanie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnPokazanie.Margin = new System.Windows.Forms.Padding(10, 1, 45, 2);
            this.tSBtnPokazanie.Name = "tSBtnPokazanie";
            this.tSBtnPokazanie.Size = new System.Drawing.Size(111, 54);
            this.tSBtnPokazanie.Text = "Показания ";
            this.tSBtnPokazanie.Click += new System.EventHandler(this.tSBtnPokazanie_Click);
            // 
            // tSBtnDolg
            // 
            this.tSBtnDolg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnDolg.Font = new System.Drawing.Font("Palatino Linotype", 10.8F);
            this.tSBtnDolg.ForeColor = System.Drawing.Color.White;
            this.tSBtnDolg.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnDolg.Image")));
            this.tSBtnDolg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnDolg.Margin = new System.Windows.Forms.Padding(15, 1, 10, 2);
            this.tSBtnDolg.Name = "tSBtnDolg";
            this.tSBtnDolg.Size = new System.Drawing.Size(54, 54);
            this.tSBtnDolg.Text = "Долг";
            this.tSBtnDolg.Click += new System.EventHandler(this.tSBtnDolg_Click);
            // 
            // toolStripBtnCalc
            // 
            this.toolStripBtnCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnCalc.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripBtnCalc.ForeColor = System.Drawing.Color.White;
            this.toolStripBtnCalc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCalc.Image")));
            this.toolStripBtnCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCalc.Margin = new System.Windows.Forms.Padding(40, 1, 10, 2);
            this.toolStripBtnCalc.Name = "toolStripBtnCalc";
            this.toolStripBtnCalc.Size = new System.Drawing.Size(95, 54);
            this.toolStripBtnCalc.Text = "Расчёт";
            this.toolStripBtnCalc.Click += new System.EventHandler(this.toolStripBtnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(966, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnAbonent;
        private System.Windows.Forms.ToolStripButton tSBtnTarif;
        private System.Windows.Forms.ToolStripButton tSBtnLgota;
        private System.Windows.Forms.ToolStripButton tSBtnPokazanie;
        private System.Windows.Forms.ToolStripButton tSBtnDolg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripButton toolStripBtnCalc;
    }
}