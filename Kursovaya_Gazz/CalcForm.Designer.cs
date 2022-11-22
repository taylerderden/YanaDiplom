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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDlg = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnBezDolga = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxSDolgom = new System.Windows.Forms.TextBox();
            this.textBoxBezDolga = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxDlg);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.btnBezDolga);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxDate);
            this.panel1.Controls.Add(this.textBoxSDolgom);
            this.panel1.Controls.Add(this.textBoxBezDolga);
            this.panel1.Controls.Add(this.textBoxFIO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(324, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 27);
            this.label5.TabIndex = 62;
            this.label5.Text = "Сумма долга";
            // 
            // textBoxDlg
            // 
            this.textBoxDlg.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDlg.Location = new System.Drawing.Point(329, 166);
            this.textBoxDlg.Multiline = true;
            this.textBoxDlg.Name = "textBoxDlg";
            this.textBoxDlg.Size = new System.Drawing.Size(131, 34);
            this.textBoxDlg.TabIndex = 61;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(342, 263);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 37);
            this.btnCalc.TabIndex = 56;
            this.btnCalc.Text = "Расчет";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnBezDolga
            // 
            this.btnBezDolga.Location = new System.Drawing.Point(684, 197);
            this.btnBezDolga.Name = "btnBezDolga";
            this.btnBezDolga.Size = new System.Drawing.Size(75, 23);
            this.btnBezDolga.TabIndex = 55;
            this.btnBezDolga.Text = "OK";
            this.btnBezDolga.UseVisualStyleBackColor = true;
            this.btnBezDolga.Click += new System.EventHandler(this.btnBezDolga_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(144, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 27);
            this.label4.TabIndex = 54;
            this.label4.Text = "Без учёта долга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(479, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 53;
            this.label3.Text = "К оплате";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(479, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 52;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 51;
            this.label1.Text = "ФИО";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDate.Location = new System.Drawing.Point(484, 106);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 34);
            this.textBoxDate.TabIndex = 50;
            // 
            // textBoxSDolgom
            // 
            this.textBoxSDolgom.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSDolgom.Location = new System.Drawing.Point(484, 209);
            this.textBoxSDolgom.Name = "textBoxSDolgom";
            this.textBoxSDolgom.Size = new System.Drawing.Size(100, 34);
            this.textBoxSDolgom.TabIndex = 49;
            // 
            // textBoxBezDolga
            // 
            this.textBoxBezDolga.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBezDolga.Location = new System.Drawing.Point(149, 209);
            this.textBoxBezDolga.Multiline = true;
            this.textBoxBezDolga.Name = "textBoxBezDolga";
            this.textBoxBezDolga.Size = new System.Drawing.Size(164, 34);
            this.textBoxBezDolga.TabIndex = 48;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFIO.Location = new System.Drawing.Point(149, 106);
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
            this.Name = "CalcForm";
            this.Text = "CalcForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnBezDolga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxSDolgom;
        private System.Windows.Forms.TextBox textBoxBezDolga;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxDlg;
        private System.Windows.Forms.Label label5;
    }
}