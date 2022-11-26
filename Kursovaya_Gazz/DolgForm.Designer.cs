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
            this.labelidAb = new System.Windows.Forms.Label();
            this.labelSumma = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.tBID = new System.Windows.Forms.TextBox();
            this.tBSumma = new System.Windows.Forms.TextBox();
            this.tBidAb = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelColla = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDolg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVDolg
            // 
            this.dGVDolg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDolg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVDolg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGVDolg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDolg.Location = new System.Drawing.Point(12, 188);
            this.dGVDolg.Name = "dGVDolg";
            this.dGVDolg.RowHeadersWidth = 51;
            this.dGVDolg.RowTemplate.Height = 24;
            this.dGVDolg.Size = new System.Drawing.Size(677, 371);
            this.dGVDolg.TabIndex = 0;
            // 
            // labelidAb
            // 
            this.labelidAb.AutoSize = true;
            this.labelidAb.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelidAb.Location = new System.Drawing.Point(582, 64);
            this.labelidAb.Name = "labelidAb";
            this.labelidAb.Size = new System.Drawing.Size(127, 24);
            this.labelidAb.TabIndex = 23;
            this.labelidAb.Text = "ID Абонента";
            // 
            // labelSumma
            // 
            this.labelSumma.AutoSize = true;
            this.labelSumma.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelSumma.Location = new System.Drawing.Point(310, 64);
            this.labelSumma.Name = "labelSumma";
            this.labelSumma.Size = new System.Drawing.Size(126, 24);
            this.labelSumma.TabIndex = 22;
            this.labelSumma.Text = "Сумма долга";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(46, 65);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(32, 24);
            this.labelId.TabIndex = 21;
            this.labelId.Text = "ID";
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(46, 110);
            this.tBID.Multiline = true;
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(162, 34);
            this.tBID.TabIndex = 20;
            // 
            // tBSumma
            // 
            this.tBSumma.Location = new System.Drawing.Point(310, 110);
            this.tBSumma.Multiline = true;
            this.tBSumma.Name = "tBSumma";
            this.tBSumma.Size = new System.Drawing.Size(162, 34);
            this.tBSumma.TabIndex = 19;
            // 
            // tBidAb
            // 
            this.tBidAb.Location = new System.Drawing.Point(582, 110);
            this.tBidAb.Multiline = true;
            this.tBidAb.Name = "tBidAb";
            this.tBidAb.Size = new System.Drawing.Size(162, 36);
            this.tBidAb.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(772, 525);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 33);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnDel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(772, 472);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(162, 34);
            this.btnDel.TabIndex = 26;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnUpd.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpd.ForeColor = System.Drawing.Color.White;
            this.btnUpd.Location = new System.Drawing.Point(772, 419);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(162, 36);
            this.btnUpd.TabIndex = 25;
            this.btnUpd.Text = "Обновить";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnIns.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnIns.ForeColor = System.Drawing.Color.White;
            this.btnIns.Location = new System.Drawing.Point(772, 362);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(162, 36);
            this.btnIns.TabIndex = 24;
            this.btnIns.Text = "Добавить ";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelColla);
            this.panel2.Controls.Add(this.labelOpen);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 35);
            this.panel2.TabIndex = 57;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(15, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 27);
            this.labelName.TabIndex = 56;
            this.labelName.Text = "Долг";
            // 
            // labelColla
            // 
            this.labelColla.AutoSize = true;
            this.labelColla.BackColor = System.Drawing.Color.White;
            this.labelColla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelColla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColla.Location = new System.Drawing.Point(906, 13);
            this.labelColla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColla.Name = "labelColla";
            this.labelColla.Size = new System.Drawing.Size(25, 20);
            this.labelColla.TabIndex = 51;
            this.labelColla.Text = "➖";
            this.labelColla.Click += new System.EventHandler(this.labelColla_Click);
            this.labelColla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelColla_MouseDown);
            this.labelColla.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelColla_MouseMove);
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOpen.Location = new System.Drawing.Point(939, 8);
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
            this.labelClose.Location = new System.Drawing.Point(975, 10);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(23, 22);
            this.labelClose.TabIndex = 49;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // DolgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.labelidAb);
            this.Controls.Add(this.labelSumma);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.tBSumma);
            this.Controls.Add(this.tBidAb);
            this.Controls.Add(this.dGVDolg);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DolgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DolgForm";
            this.Load += new System.EventHandler(this.DolgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDolg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDolg;
        private System.Windows.Forms.Label labelidAb;
        private System.Windows.Forms.Label labelSumma;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.TextBox tBSumma;
        private System.Windows.Forms.TextBox tBidAb;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelColla;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelName;
    }
}