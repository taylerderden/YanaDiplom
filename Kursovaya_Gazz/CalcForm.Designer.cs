namespace Kursovaya_Gazz
{
    partial class CalcForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWord = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelColla = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDlg = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSDolgom = new System.Windows.Forms.TextBox();
            this.textBoxBezDolga = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.btnWord);
            this.panel1.Controls.Add(this.textBoxDate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxDlg);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSDolgom);
            this.panel1.Controls.Add(this.textBoxBezDolga);
            this.panel1.Controls.Add(this.textBoxFIO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 30;
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWord.ForeColor = System.Drawing.Color.White;
            this.btnWord.Location = new System.Drawing.Point(300, 401);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(191, 37);
            this.btnWord.TabIndex = 66;
            this.btnWord.Text = "Создать квитанцию";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDate.Location = new System.Drawing.Point(514, 182);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(200, 34);
            this.textBoxDate.TabIndex = 65;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(514, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker1.TabIndex = 64;
            this.dateTimePicker1.Value = new System.DateTime(2023, 2, 25, 16, 47, 20, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelColla);
            this.panel2.Controls.Add(this.labelOpen);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 35);
            this.panel2.TabIndex = 63;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 27);
            this.labelName.TabIndex = 52;
            this.labelName.Text = "Расчёт";
            // 
            // labelColla
            // 
            this.labelColla.AutoSize = true;
            this.labelColla.BackColor = System.Drawing.Color.White;
            this.labelColla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelColla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColla.Location = new System.Drawing.Point(703, 13);
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
            this.labelOpen.Location = new System.Drawing.Point(736, 9);
            this.labelOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(28, 25);
            this.labelOpen.TabIndex = 50;
            this.labelOpen.Text = "⧉";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelClose.Location = new System.Drawing.Point(772, 12);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 24);
            this.labelClose.TabIndex = 49;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(322, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 27);
            this.label5.TabIndex = 62;
            this.label5.Text = "Сумма долга";
            // 
            // textBoxDlg
            // 
            this.textBoxDlg.Enabled = false;
            this.textBoxDlg.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDlg.Location = new System.Drawing.Point(309, 286);
            this.textBoxDlg.Multiline = true;
            this.textBoxDlg.Name = "textBoxDlg";
            this.textBoxDlg.Size = new System.Drawing.Size(168, 34);
            this.textBoxDlg.TabIndex = 61;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(309, 336);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(168, 37);
            this.btnCalc.TabIndex = 56;
            this.btnCalc.Text = "Расчет";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(111, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 27);
            this.label4.TabIndex = 54;
            this.label4.Text = "Без учёта долга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(539, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 53;
            this.label3.Text = "К оплате";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(509, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "ФИО";
            // 
            // textBoxSDolgom
            // 
            this.textBoxSDolgom.Enabled = false;
            this.textBoxSDolgom.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSDolgom.Location = new System.Drawing.Point(514, 286);
            this.textBoxSDolgom.Name = "textBoxSDolgom";
            this.textBoxSDolgom.Size = new System.Drawing.Size(168, 34);
            this.textBoxSDolgom.TabIndex = 49;
            // 
            // textBoxBezDolga
            // 
            this.textBoxBezDolga.Enabled = false;
            this.textBoxBezDolga.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBezDolga.Location = new System.Drawing.Point(116, 286);
            this.textBoxBezDolga.Multiline = true;
            this.textBoxBezDolga.Name = "textBoxBezDolga";
            this.textBoxBezDolga.Size = new System.Drawing.Size(164, 34);
            this.textBoxBezDolga.TabIndex = 48;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFIO.Location = new System.Drawing.Point(116, 133);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(164, 34);
            this.textBoxFIO.TabIndex = 47;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalcForm";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSDolgom;
        private System.Windows.Forms.TextBox textBoxBezDolga;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxDlg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelColla;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button btnWord;
    }
}