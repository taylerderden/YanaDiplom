namespace Kursovaya_Gazz
{
    partial class UserForm
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
            this.tBDate = new System.Windows.Forms.TextBox();
            this.tBSchetchik = new System.Windows.Forms.TextBox();
            this.tBCurrent = new System.Windows.Forms.TextBox();
            this.tBPrevious = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tBid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBDate
            // 
            this.tBDate.Location = new System.Drawing.Point(103, 279);
            this.tBDate.Multiline = true;
            this.tBDate.Name = "tBDate";
            this.tBDate.Size = new System.Drawing.Size(234, 44);
            this.tBDate.TabIndex = 0;
            // 
            // tBSchetchik
            // 
            this.tBSchetchik.Location = new System.Drawing.Point(446, 279);
            this.tBSchetchik.Multiline = true;
            this.tBSchetchik.Name = "tBSchetchik";
            this.tBSchetchik.Size = new System.Drawing.Size(233, 44);
            this.tBSchetchik.TabIndex = 1;
            // 
            // tBCurrent
            // 
            this.tBCurrent.Location = new System.Drawing.Point(445, 172);
            this.tBCurrent.Multiline = true;
            this.tBCurrent.Name = "tBCurrent";
            this.tBCurrent.Size = new System.Drawing.Size(234, 44);
            this.tBCurrent.TabIndex = 2;
            // 
            // tBPrevious
            // 
            this.tBPrevious.Location = new System.Drawing.Point(103, 171);
            this.tBPrevious.Multiline = true;
            this.tBPrevious.Name = "tBPrevious";
            this.tBPrevious.Size = new System.Drawing.Size(234, 45);
            this.tBPrevious.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(315, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F);
            this.label1.Location = new System.Drawing.Point(100, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Предыдущие показания ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F);
            this.label2.Location = new System.Drawing.Point(100, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F);
            this.label3.Location = new System.Drawing.Point(445, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Последние показания ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F);
            this.label4.Location = new System.Drawing.Point(445, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер счётчика";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(800, 109);
            this.label5.TabIndex = 9;
            this.label5.Text = "Добро пожаловать в личный кабинет";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tBid
            // 
            this.tBid.Location = new System.Drawing.Point(12, 416);
            this.tBid.Name = "tBid";
            this.tBid.Size = new System.Drawing.Size(39, 22);
            this.tBid.TabIndex = 11;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBPrevious);
            this.Controls.Add(this.tBCurrent);
            this.Controls.Add(this.tBSchetchik);
            this.Controls.Add(this.tBDate);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBDate;
        private System.Windows.Forms.TextBox tBSchetchik;
        private System.Windows.Forms.TextBox tBCurrent;
        private System.Windows.Forms.TextBox tBPrevious;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tBid;
    }
}