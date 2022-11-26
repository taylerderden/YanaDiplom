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
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelCur = new System.Windows.Forms.Label();
            this.labelPrev = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.tBID = new System.Windows.Forms.TextBox();
            this.tBPrev = new System.Windows.Forms.TextBox();
            this.tBCur = new System.Windows.Forms.TextBox();
            this.labelSch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.tBSch = new System.Windows.Forms.TextBox();
            this.tBDate = new System.Windows.Forms.TextBox();
            this.tBidAb = new System.Windows.Forms.TextBox();
            this.tBCalc = new System.Windows.Forms.TextBox();
            this.labelidAb = new System.Windows.Forms.Label();
            this.labelCalc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelColla = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPokazanie)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVPokazanie
            // 
            this.dGVPokazanie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVPokazanie.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGVPokazanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPokazanie.Location = new System.Drawing.Point(13, 204);
            this.dGVPokazanie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dGVPokazanie.Name = "dGVPokazanie";
            this.dGVPokazanie.RowHeadersWidth = 51;
            this.dGVPokazanie.RowTemplate.Height = 24;
            this.dGVPokazanie.Size = new System.Drawing.Size(820, 453);
            this.dGVPokazanie.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(841, 204);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 47);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelCur
            // 
            this.labelCur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCur.AutoSize = true;
            this.labelCur.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCur.Location = new System.Drawing.Point(316, 89);
            this.labelCur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCur.Name = "labelCur";
            this.labelCur.Size = new System.Drawing.Size(178, 23);
            this.labelCur.TabIndex = 37;
            this.labelCur.Text = "Текущие показания";
            // 
            // labelPrev
            // 
            this.labelPrev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrev.AutoSize = true;
            this.labelPrev.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrev.Location = new System.Drawing.Point(91, 89);
            this.labelPrev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrev.Name = "labelPrev";
            this.labelPrev.Size = new System.Drawing.Size(216, 23);
            this.labelPrev.TabIndex = 36;
            this.labelPrev.Text = "Предыдущие показания";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(16, 89);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(30, 23);
            this.labelId.TabIndex = 35;
            this.labelId.Text = "ID";
            // 
            // tBID
            // 
            this.tBID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBID.Location = new System.Drawing.Point(16, 116);
            this.tBID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBID.Multiline = true;
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(48, 42);
            this.tBID.TabIndex = 34;
            // 
            // tBPrev
            // 
            this.tBPrev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBPrev.Location = new System.Drawing.Point(96, 116);
            this.tBPrev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBPrev.Multiline = true;
            this.tBPrev.Name = "tBPrev";
            this.tBPrev.Size = new System.Drawing.Size(174, 42);
            this.tBPrev.TabIndex = 33;
            // 
            // tBCur
            // 
            this.tBCur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBCur.Location = new System.Drawing.Point(320, 116);
            this.tBCur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBCur.Multiline = true;
            this.tBCur.Name = "tBCur";
            this.tBCur.Size = new System.Drawing.Size(174, 42);
            this.tBCur.TabIndex = 32;
            // 
            // labelSch
            // 
            this.labelSch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSch.AutoSize = true;
            this.labelSch.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSch.Location = new System.Drawing.Point(739, 89);
            this.labelSch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSch.Name = "labelSch";
            this.labelSch.Size = new System.Drawing.Size(150, 23);
            this.labelSch.TabIndex = 43;
            this.labelSch.Text = "Номер счётчика";
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
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(529, 89);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(144, 23);
            this.labelDate.TabIndex = 41;
            this.labelDate.Text = "Дата показаний";
            // 
            // tBSch
            // 
            this.tBSch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSch.Location = new System.Drawing.Point(742, 116);
            this.tBSch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBSch.Multiline = true;
            this.tBSch.Name = "tBSch";
            this.tBSch.Size = new System.Drawing.Size(174, 42);
            this.tBSch.TabIndex = 40;
            // 
            // tBDate
            // 
            this.tBDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBDate.Location = new System.Drawing.Point(532, 116);
            this.tBDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBDate.Multiline = true;
            this.tBDate.Name = "tBDate";
            this.tBDate.Size = new System.Drawing.Size(174, 42);
            this.tBDate.TabIndex = 39;
            // 
            // tBidAb
            // 
            this.tBidAb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBidAb.Location = new System.Drawing.Point(956, 116);
            this.tBidAb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBidAb.Multiline = true;
            this.tBidAb.Name = "tBidAb";
            this.tBidAb.Size = new System.Drawing.Size(66, 42);
            this.tBidAb.TabIndex = 38;
            // 
            // tBCalc
            // 
            this.tBCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBCalc.Location = new System.Drawing.Point(1076, 116);
            this.tBCalc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBCalc.Multiline = true;
            this.tBCalc.Name = "tBCalc";
            this.tBCalc.Size = new System.Drawing.Size(174, 42);
            this.tBCalc.TabIndex = 44;
            // 
            // labelidAb
            // 
            this.labelidAb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelidAb.AutoSize = true;
            this.labelidAb.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelidAb.Location = new System.Drawing.Point(950, 89);
            this.labelidAb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelidAb.Name = "labelidAb";
            this.labelidAb.Size = new System.Drawing.Size(117, 23);
            this.labelidAb.TabIndex = 45;
            this.labelidAb.Text = "ID Абонента";
            // 
            // labelCalc
            // 
            this.labelCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCalc.AutoSize = true;
            this.labelCalc.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalc.Location = new System.Drawing.Point(1075, 90);
            this.labelCalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalc.Name = "labelCalc";
            this.labelCalc.Size = new System.Drawing.Size(66, 23);
            this.labelCalc.TabIndex = 46;
            this.labelCalc.Text = "Расчёт";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelColla);
            this.panel1.Controls.Add(this.labelOpen);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Location = new System.Drawing.Point(-7, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 39);
            this.panel1.TabIndex = 47;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.labelOpen.Click += new System.EventHandler(this.labelOpen_Click);
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
            // PokazanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1317, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCalc);
            this.Controls.Add(this.labelidAb);
            this.Controls.Add(this.tBCalc);
            this.Controls.Add(this.labelSch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.tBSch);
            this.Controls.Add(this.tBDate);
            this.Controls.Add(this.tBidAb);
            this.Controls.Add(this.labelCur);
            this.Controls.Add(this.labelPrev);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.tBPrev);
            this.Controls.Add(this.tBCur);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dGVPokazanie);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelCur;
        private System.Windows.Forms.Label labelPrev;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.TextBox tBPrev;
        private System.Windows.Forms.TextBox tBCur;
        private System.Windows.Forms.Label labelSch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox tBSch;
        private System.Windows.Forms.TextBox tBDate;
        private System.Windows.Forms.TextBox tBidAb;
        private System.Windows.Forms.TextBox tBCalc;
        private System.Windows.Forms.Label labelidAb;
        private System.Windows.Forms.Label labelCalc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelColla;
        private System.Windows.Forms.Label label1;
    }
}