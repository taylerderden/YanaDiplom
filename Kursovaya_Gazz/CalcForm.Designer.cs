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
            this.labelAb = new System.Windows.Forms.Label();
            this.labelLg = new System.Windows.Forms.Label();
            this.labelTar = new System.Windows.Forms.Label();
            this.btnSDolgom = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.labelAb);
            this.panel1.Controls.Add(this.labelLg);
            this.panel1.Controls.Add(this.labelTar);
            this.panel1.Controls.Add(this.btnSDolgom);
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
            // labelAb
            // 
            this.labelAb.AutoSize = true;
            this.labelAb.Location = new System.Drawing.Point(419, 217);
            this.labelAb.Name = "labelAb";
            this.labelAb.Size = new System.Drawing.Size(24, 16);
            this.labelAb.TabIndex = 59;
            this.labelAb.Text = "Ab";
            // 
            // labelLg
            // 
            this.labelLg.AutoSize = true;
            this.labelLg.Location = new System.Drawing.Point(391, 217);
            this.labelLg.Name = "labelLg";
            this.labelLg.Size = new System.Drawing.Size(22, 16);
            this.labelLg.TabIndex = 58;
            this.labelLg.Text = "Lg";
            // 
            // labelTar
            // 
            this.labelTar.AutoSize = true;
            this.labelTar.Location = new System.Drawing.Point(357, 217);
            this.labelTar.Name = "labelTar";
            this.labelTar.Size = new System.Drawing.Size(28, 16);
            this.labelTar.TabIndex = 57;
            this.labelTar.Text = "Tar";
            // 
            // btnSDolgom
            // 
            this.btnSDolgom.Location = new System.Drawing.Point(490, 292);
            this.btnSDolgom.Name = "btnSDolgom";
            this.btnSDolgom.Size = new System.Drawing.Size(75, 23);
            this.btnSDolgom.TabIndex = 56;
            this.btnSDolgom.Text = "OK";
            this.btnSDolgom.UseVisualStyleBackColor = true;
            this.btnSDolgom.Click += new System.EventHandler(this.btnSDolgom_Click);
            // 
            // btnBezDolga
            // 
            this.btnBezDolga.Location = new System.Drawing.Point(236, 292);
            this.btnBezDolga.Name = "btnBezDolga";
            this.btnBezDolga.Size = new System.Drawing.Size(75, 23);
            this.btnBezDolga.TabIndex = 55;
            this.btnBezDolga.Text = "OK";
            this.btnBezDolga.UseVisualStyleBackColor = true;
            this.btnBezDolga.Click += new System.EventHandler(this.btnBezDolga_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Без учёта долга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "К оплате";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "ФИО";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(480, 165);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxDate.TabIndex = 50;
            // 
            // textBoxSDolgom
            // 
            this.textBoxSDolgom.Location = new System.Drawing.Point(480, 246);
            this.textBoxSDolgom.Name = "textBoxSDolgom";
            this.textBoxSDolgom.Size = new System.Drawing.Size(100, 22);
            this.textBoxSDolgom.TabIndex = 49;
            // 
            // textBoxBezDolga
            // 
            this.textBoxBezDolga.Location = new System.Drawing.Point(224, 246);
            this.textBoxBezDolga.Name = "textBoxBezDolga";
            this.textBoxBezDolga.Size = new System.Drawing.Size(100, 22);
            this.textBoxBezDolga.TabIndex = 48;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(224, 165);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(100, 22);
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
        private System.Windows.Forms.Button btnSDolgom;
        private System.Windows.Forms.Button btnBezDolga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxSDolgom;
        private System.Windows.Forms.TextBox textBoxBezDolga;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelAb;
        private System.Windows.Forms.Label labelLg;
        private System.Windows.Forms.Label labelTar;
    }
}