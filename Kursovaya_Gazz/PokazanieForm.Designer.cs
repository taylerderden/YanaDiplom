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
            this.tBID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelColla = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.tBIDp = new System.Windows.Forms.TextBox();
            this.tBPrev = new System.Windows.Forms.TextBox();
            this.tBCur = new System.Windows.Forms.TextBox();
            this.tBData = new System.Windows.Forms.TextBox();
            this.tBSchN = new System.Windows.Forms.TextBox();
            this.tBidAb = new System.Windows.Forms.TextBox();
            this.tBCalc = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.labelUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPokazanie)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVPokazanie
            // 
            this.dGVPokazanie.BackgroundColor = System.Drawing.Color.White;
            this.dGVPokazanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPokazanie.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dGVPokazanie.Location = new System.Drawing.Point(77, 112);
            this.dGVPokazanie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dGVPokazanie.Name = "dGVPokazanie";
            this.dGVPokazanie.RowHeadersWidth = 51;
            this.dGVPokazanie.RowTemplate.Height = 24;
            this.dGVPokazanie.Size = new System.Drawing.Size(856, 461);
            this.dGVPokazanie.TabIndex = 0;
            // 
            // tBID
            // 
            this.tBID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBID.Location = new System.Drawing.Point(220, 12);
            this.tBID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBID.Multiline = true;
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(266, 27);
            this.tBID.TabIndex = 34;
            this.tBID.TextChanged += new System.EventHandler(this.tBID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelUpdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelColla);
            this.panel1.Controls.Add(this.labelOpen);
            this.panel1.Controls.Add(this.tBID);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Location = new System.Drawing.Point(-7, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 45);
            this.panel1.TabIndex = 47;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(493, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "🔍";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "Показания";
            // 
            // labelColla
            // 
            this.labelColla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelColla.AutoSize = true;
            this.labelColla.BackColor = System.Drawing.Color.White;
            this.labelColla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelColla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColla.Location = new System.Drawing.Point(1211, 18);
            this.labelColla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColla.Name = "labelColla";
            this.labelColla.Size = new System.Drawing.Size(25, 20);
            this.labelColla.TabIndex = 48;
            this.labelColla.Text = "➖";
            this.labelColla.Click += new System.EventHandler(this.labelColla_Click);
            // 
            // labelOpen
            // 
            this.labelOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOpen.AutoSize = true;
            this.labelOpen.BackColor = System.Drawing.Color.White;
            this.labelOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOpen.Location = new System.Drawing.Point(1251, 9);
            this.labelOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(28, 25);
            this.labelOpen.TabIndex = 1;
            this.labelOpen.Text = "⧉";
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.White;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelClose.Location = new System.Drawing.Point(1293, 14);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(23, 22);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // tBIDp
            // 
            this.tBIDp.Location = new System.Drawing.Point(1001, 186);
            this.tBIDp.Multiline = true;
            this.tBIDp.Name = "tBIDp";
            this.tBIDp.Size = new System.Drawing.Size(253, 34);
            this.tBIDp.TabIndex = 50;
            this.tBIDp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBIDp.Enter += new System.EventHandler(this.tBIDp_Enter);
            this.tBIDp.Leave += new System.EventHandler(this.tBIDp_Leave);
            // 
            // tBPrev
            // 
            this.tBPrev.Location = new System.Drawing.Point(1001, 226);
            this.tBPrev.Multiline = true;
            this.tBPrev.Name = "tBPrev";
            this.tBPrev.Size = new System.Drawing.Size(253, 34);
            this.tBPrev.TabIndex = 49;
            this.tBPrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBPrev.Enter += new System.EventHandler(this.tBPrev_Enter);
            this.tBPrev.Leave += new System.EventHandler(this.tBPrev_Leave);
            // 
            // tBCur
            // 
            this.tBCur.Location = new System.Drawing.Point(1001, 266);
            this.tBCur.Multiline = true;
            this.tBCur.Name = "tBCur";
            this.tBCur.Size = new System.Drawing.Size(253, 36);
            this.tBCur.TabIndex = 48;
            this.tBCur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBCur.Enter += new System.EventHandler(this.tBCur_Enter);
            this.tBCur.Leave += new System.EventHandler(this.tBCur_Leave);
            // 
            // tBData
            // 
            this.tBData.Location = new System.Drawing.Point(1001, 308);
            this.tBData.Multiline = true;
            this.tBData.Name = "tBData";
            this.tBData.Size = new System.Drawing.Size(253, 34);
            this.tBData.TabIndex = 53;
            this.tBData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBData.Enter += new System.EventHandler(this.tBData_Enter);
            this.tBData.Leave += new System.EventHandler(this.tBData_Leave);
            // 
            // tBSchN
            // 
            this.tBSchN.Location = new System.Drawing.Point(1001, 348);
            this.tBSchN.Multiline = true;
            this.tBSchN.Name = "tBSchN";
            this.tBSchN.Size = new System.Drawing.Size(253, 34);
            this.tBSchN.TabIndex = 52;
            this.tBSchN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBSchN.Enter += new System.EventHandler(this.tBSchN_Enter);
            this.tBSchN.Leave += new System.EventHandler(this.tBSchN_Leave);
            // 
            // tBidAb
            // 
            this.tBidAb.Location = new System.Drawing.Point(1001, 388);
            this.tBidAb.Multiline = true;
            this.tBidAb.Name = "tBidAb";
            this.tBidAb.Size = new System.Drawing.Size(253, 36);
            this.tBidAb.TabIndex = 51;
            this.tBidAb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBidAb.Enter += new System.EventHandler(this.tBidAb_Enter);
            this.tBidAb.Leave += new System.EventHandler(this.tBidAb_Leave);
            // 
            // tBCalc
            // 
            this.tBCalc.Location = new System.Drawing.Point(1001, 430);
            this.tBCalc.Multiline = true;
            this.tBCalc.Name = "tBCalc";
            this.tBCalc.Size = new System.Drawing.Size(253, 36);
            this.tBCalc.TabIndex = 54;
            this.tBCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBCalc.Enter += new System.EventHandler(this.tBCalc_Enter);
            this.tBCalc.Leave += new System.EventHandler(this.tBCalc_Leave);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(1045, 530);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(162, 34);
            this.btnDel.TabIndex = 56;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpd.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpd.ForeColor = System.Drawing.Color.White;
            this.btnUpd.Location = new System.Drawing.Point(1045, 487);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(162, 35);
            this.btnUpd.TabIndex = 55;
            this.btnUpd.Text = "Обновить";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUpdate.ForeColor = System.Drawing.Color.Black;
            this.labelUpdate.Location = new System.Drawing.Point(177, 9);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(36, 32);
            this.labelUpdate.TabIndex = 62;
            this.labelUpdate.Text = "🗘";
            // 
            // PokazanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1317, 670);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.tBCalc);
            this.Controls.Add(this.tBData);
            this.Controls.Add(this.tBSchN);
            this.Controls.Add(this.tBidAb);
            this.Controls.Add(this.tBIDp);
            this.Controls.Add(this.tBPrev);
            this.Controls.Add(this.tBCur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVPokazanie);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PokazanieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokazanieForm";
            this.Load += new System.EventHandler(this.PokazanieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPokazanie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVPokazanie;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelColla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBIDp;
        private System.Windows.Forms.TextBox tBPrev;
        private System.Windows.Forms.TextBox tBCur;
        private System.Windows.Forms.TextBox tBData;
        private System.Windows.Forms.TextBox tBSchN;
        private System.Windows.Forms.TextBox tBidAb;
        private System.Windows.Forms.TextBox tBCalc;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Label labelUpdate;
    }
}