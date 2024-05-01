
namespace Kursovaya_Gazz
{
    partial class MissPassForm
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelNewPass2 = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbNewPass2 = new System.Windows.Forms.TextBox();
            this.btnSendKod = new System.Windows.Forms.Button();
            this.labelKod = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.labelYes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(8, 13);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 20);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Почта";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 56);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(276, 28);
            this.textBoxEmail.TabIndex = 12;
            // 
            // labelNewPass2
            // 
            this.labelNewPass2.AutoSize = true;
            this.labelNewPass2.Location = new System.Drawing.Point(8, 277);
            this.labelNewPass2.Name = "labelNewPass2";
            this.labelNewPass2.Size = new System.Drawing.Size(187, 20);
            this.labelNewPass2.TabIndex = 11;
            this.labelNewPass2.Text = "Повторите новый пароль";
            this.labelNewPass2.Visible = false;
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Location = new System.Drawing.Point(8, 198);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(110, 20);
            this.labelNewPass.TabIndex = 10;
            this.labelNewPass.Text = "Новый пароль";
            this.labelNewPass.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(12, 367);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(276, 55);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Обновить данные";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(12, 229);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(276, 28);
            this.tbNewPass.TabIndex = 8;
            this.tbNewPass.Visible = false;
            // 
            // tbNewPass2
            // 
            this.tbNewPass2.Location = new System.Drawing.Point(12, 311);
            this.tbNewPass2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewPass2.Name = "tbNewPass2";
            this.tbNewPass2.Size = new System.Drawing.Size(276, 28);
            this.tbNewPass2.TabIndex = 7;
            this.tbNewPass2.Visible = false;
            // 
            // btnSendKod
            // 
            this.btnSendKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnSendKod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendKod.ForeColor = System.Drawing.Color.White;
            this.btnSendKod.Location = new System.Drawing.Point(12, 92);
            this.btnSendKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendKod.Name = "btnSendKod";
            this.btnSendKod.Size = new System.Drawing.Size(276, 29);
            this.btnSendKod.TabIndex = 14;
            this.btnSendKod.Text = "Отправить код";
            this.btnSendKod.UseVisualStyleBackColor = false;
            this.btnSendKod.Click += new System.EventHandler(this.btnSendKod_Click);
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Location = new System.Drawing.Point(8, 126);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(35, 20);
            this.labelKod.TabIndex = 16;
            this.labelKod.Text = "Код";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(12, 157);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(276, 28);
            this.textBoxKod.TabIndex = 15;
            this.textBoxKod.TextChanged += new System.EventHandler(this.textBoxKod_TextChanged);
            // 
            // labelYes
            // 
            this.labelYes.AutoSize = true;
            this.labelYes.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold);
            this.labelYes.Location = new System.Drawing.Point(294, 152);
            this.labelYes.Name = "labelYes";
            this.labelYes.Size = new System.Drawing.Size(23, 32);
            this.labelYes.TabIndex = 17;
            this.labelYes.Text = "-";
            // 
            // MissPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(320, 435);
            this.Controls.Add(this.labelYes);
            this.Controls.Add(this.labelKod);
            this.Controls.Add(this.textBoxKod);
            this.Controls.Add(this.btnSendKod);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelNewPass2);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbNewPass2);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MissPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MissPassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelNewPass2;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbNewPass2;
        private System.Windows.Forms.Button btnSendKod;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.Label labelYes;
    }
}