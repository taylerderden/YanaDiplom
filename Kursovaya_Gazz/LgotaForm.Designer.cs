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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.labelKoeff = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.tBID = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBKoeff = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelColla = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLgota)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVLgota
            // 
            this.dGVLgota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVLgota.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVLgota.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGVLgota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLgota.Location = new System.Drawing.Point(12, 153);
            this.dGVLgota.Name = "dGVLgota";
            this.dGVLgota.RowHeadersWidth = 51;
            this.dGVLgota.RowTemplate.Height = 24;
            this.dGVLgota.Size = new System.Drawing.Size(745, 377);
            this.dGVLgota.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(840, 497);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 33);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnDel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(840, 444);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(162, 34);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnUpd.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpd.ForeColor = System.Drawing.Color.White;
            this.btnUpd.Location = new System.Drawing.Point(840, 391);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(162, 36);
            this.btnUpd.TabIndex = 9;
            this.btnUpd.Text = "Обновить";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnIns.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnIns.ForeColor = System.Drawing.Color.White;
            this.btnIns.Location = new System.Drawing.Point(840, 334);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(162, 36);
            this.btnIns.TabIndex = 8;
            this.btnIns.Text = "Добавить ";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // labelKoeff
            // 
            this.labelKoeff.AutoSize = true;
            this.labelKoeff.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelKoeff.Location = new System.Drawing.Point(576, 47);
            this.labelKoeff.Name = "labelKoeff";
            this.labelKoeff.Size = new System.Drawing.Size(131, 23);
            this.labelKoeff.TabIndex = 17;
            this.labelKoeff.Text = "Коэффициент";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(304, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 23);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Название";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(40, 48);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(30, 23);
            this.labelId.TabIndex = 15;
            this.labelId.Text = "ID";
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(40, 93);
            this.tBID.Multiline = true;
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(162, 34);
            this.tBID.TabIndex = 14;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(304, 93);
            this.tBName.Multiline = true;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(162, 34);
            this.tBName.TabIndex = 13;
            // 
            // tBKoeff
            // 
            this.tBKoeff.Location = new System.Drawing.Point(576, 93);
            this.tBKoeff.Multiline = true;
            this.tBKoeff.Name = "tBKoeff";
            this.tBKoeff.Size = new System.Drawing.Size(162, 36);
            this.tBKoeff.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelColla);
            this.panel2.Controls.Add(this.labelOpen);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 33);
            this.panel2.TabIndex = 55;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "Льготы";
            // 
            // labelColla
            // 
            this.labelColla.AutoSize = true;
            this.labelColla.BackColor = System.Drawing.Color.White;
            this.labelColla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelColla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColla.Location = new System.Drawing.Point(950, 9);
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
            this.labelOpen.Location = new System.Drawing.Point(983, 5);
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
            this.labelClose.Location = new System.Drawing.Point(1019, 8);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(23, 22);
            this.labelClose.TabIndex = 49;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // LgotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1051, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelKoeff);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.tBKoeff);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.dGVLgota);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LgotaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LgotaForm";
            this.Load += new System.EventHandler(this.LgotaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLgota)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVLgota;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Label labelKoeff;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBKoeff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelColla;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
    }
}