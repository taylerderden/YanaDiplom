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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelColla = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnAbonent,
            this.tSBtnTarif,
            this.tSBtnLgota,
            this.tSBtnPokazanie,
            this.tSBtnDolg,
            this.toolStripBtnCalc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1091, 55);
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
            this.tSBtnAbonent.Size = new System.Drawing.Size(85, 52);
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
            this.tSBtnTarif.Size = new System.Drawing.Size(70, 53);
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
            this.tSBtnLgota.Size = new System.Drawing.Size(69, 52);
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
            this.tSBtnPokazanie.Size = new System.Drawing.Size(111, 52);
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
            this.tSBtnDolg.Size = new System.Drawing.Size(54, 52);
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
            this.toolStripBtnCalc.Size = new System.Drawing.Size(95, 52);
            this.toolStripBtnCalc.Text = "Расчёт";
            this.toolStripBtnCalc.Click += new System.EventHandler(this.toolStripBtnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(995, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelColla);
            this.panel2.Controls.Add(this.labelOpen);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Location = new System.Drawing.Point(0, -4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 36);
            this.panel2.TabIndex = 50;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // labelColla
            // 
            this.labelColla.AutoSize = true;
            this.labelColla.BackColor = System.Drawing.Color.White;
            this.labelColla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelColla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColla.Location = new System.Drawing.Point(994, 13);
            this.labelColla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColla.Name = "labelColla";
            this.labelColla.Size = new System.Drawing.Size(25, 20);
            this.labelColla.TabIndex = 51;
            this.labelColla.Text = "➖";
            this.labelColla.Click += new System.EventHandler(this.labelColla_Click);
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOpen.Location = new System.Drawing.Point(1027, 8);
            this.labelOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(28, 25);
            this.labelOpen.TabIndex = 50;
            this.labelOpen.Text = "⧉";
            this.labelOpen.Click += new System.EventHandler(this.labelOpen_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelClose.Location = new System.Drawing.Point(1063, 11);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(23, 22);
            this.labelClose.TabIndex = 49;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelColla;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelClose;
    }
}