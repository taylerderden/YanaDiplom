
namespace Kursovaya_Gazz
{
    partial class RegistrationForm
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
            this.tbSchet = new System.Windows.Forms.TextBox();
            this.labelSchet = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.labelSq = new System.Windows.Forms.Label();
            this.tbSquare = new System.Windows.Forms.TextBox();
            this.labelPeople = new System.Windows.Forms.Label();
            this.tbPeople = new System.Windows.Forms.TextBox();
            this.btnCreateAbonent = new System.Windows.Forms.Button();
            this.cbTarif = new System.Windows.Forms.ComboBox();
            this.cbLgota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelColla = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSchet
            // 
            this.tbSchet.Location = new System.Drawing.Point(361, 200);
            this.tbSchet.Margin = new System.Windows.Forms.Padding(4);
            this.tbSchet.MaxLength = 12;
            this.tbSchet.Name = "tbSchet";
            this.tbSchet.Size = new System.Drawing.Size(256, 30);
            this.tbSchet.TabIndex = 0;
            this.tbSchet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSchet_KeyPress);
            // 
            // labelSchet
            // 
            this.labelSchet.AutoSize = true;
            this.labelSchet.Location = new System.Drawing.Point(357, 166);
            this.labelSchet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSchet.Name = "labelSchet";
            this.labelSchet.Size = new System.Drawing.Size(188, 23);
            this.labelSchet.TabIndex = 1;
            this.labelSchet.Text = "Номер лицевого счета";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(16, 139);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(123, 23);
            this.labelFIO.TabIndex = 3;
            this.labelFIO.Text = "Фамилия И.О.";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(21, 173);
            this.tbFIO.Margin = new System.Windows.Forms.Padding(4);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(256, 30);
            this.tbFIO.TabIndex = 2;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(16, 209);
            this.labelAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(58, 23);
            this.labelAdress.TabIndex = 5;
            this.labelAdress.Text = "Адрес";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(21, 237);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(256, 30);
            this.tbAdress.TabIndex = 4;
            // 
            // labelSq
            // 
            this.labelSq.AutoSize = true;
            this.labelSq.Location = new System.Drawing.Point(16, 280);
            this.labelSq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSq.Name = "labelSq";
            this.labelSq.Size = new System.Drawing.Size(251, 23);
            this.labelSq.TabIndex = 7;
            this.labelSq.Text = "Отапливаемая площадь (кв.м)";
            // 
            // tbSquare
            // 
            this.tbSquare.Location = new System.Drawing.Point(21, 309);
            this.tbSquare.Margin = new System.Windows.Forms.Padding(4);
            this.tbSquare.Name = "tbSquare";
            this.tbSquare.Size = new System.Drawing.Size(256, 30);
            this.tbSquare.TabIndex = 6;
            this.tbSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSquare_KeyPress);
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Location = new System.Drawing.Point(16, 352);
            this.labelPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(226, 23);
            this.labelPeople.TabIndex = 9;
            this.labelPeople.Text = "Количество проживающих";
            // 
            // tbPeople
            // 
            this.tbPeople.Location = new System.Drawing.Point(21, 379);
            this.tbPeople.Margin = new System.Windows.Forms.Padding(4);
            this.tbPeople.MaxLength = 2;
            this.tbPeople.Name = "tbPeople";
            this.tbPeople.Size = new System.Drawing.Size(256, 30);
            this.tbPeople.TabIndex = 8;
            this.tbPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPeople_KeyPress);
            // 
            // btnCreateAbonent
            // 
            this.btnCreateAbonent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnCreateAbonent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAbonent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCreateAbonent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCreateAbonent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAbonent.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateAbonent.ForeColor = System.Drawing.Color.White;
            this.btnCreateAbonent.Location = new System.Drawing.Point(183, 444);
            this.btnCreateAbonent.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAbonent.Name = "btnCreateAbonent";
            this.btnCreateAbonent.Size = new System.Drawing.Size(258, 49);
            this.btnCreateAbonent.TabIndex = 10;
            this.btnCreateAbonent.Text = "Создать аккаунт";
            this.btnCreateAbonent.UseVisualStyleBackColor = false;
            this.btnCreateAbonent.Click += new System.EventHandler(this.btnCreateAbonent_Click);
            // 
            // cbTarif
            // 
            this.cbTarif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarif.FormattingEnabled = true;
            this.cbTarif.Items.AddRange(new object[] {
            "Экономичный",
            "Стандартный",
            "Неограниченный"});
            this.cbTarif.Location = new System.Drawing.Point(361, 264);
            this.cbTarif.Margin = new System.Windows.Forms.Padding(4);
            this.cbTarif.Name = "cbTarif";
            this.cbTarif.Size = new System.Drawing.Size(256, 31);
            this.cbTarif.TabIndex = 11;
            // 
            // cbLgota
            // 
            this.cbLgota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLgota.FormattingEnabled = true;
            this.cbLgota.Items.AddRange(new object[] {
            "Ветераны войны",
            "Беженцы",
            "Пенсионеры",
            "Безработные",
            "Без льгот"});
            this.cbLgota.Location = new System.Drawing.Point(361, 336);
            this.cbLgota.Margin = new System.Windows.Forms.Padding(4);
            this.cbLgota.Name = "cbLgota";
            this.cbLgota.Size = new System.Drawing.Size(256, 31);
            this.cbLgota.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Тариф";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Льгота";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 67);
            this.label3.TabIndex = 15;
            this.label3.Text = "Регистрация";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelColla);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 29);
            this.panel2.TabIndex = 51;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // labelColla
            // 
            this.labelColla.AutoSize = true;
            this.labelColla.BackColor = System.Drawing.Color.White;
            this.labelColla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelColla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColla.ForeColor = System.Drawing.Color.Black;
            this.labelColla.Location = new System.Drawing.Point(583, 2);
            this.labelColla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColla.Name = "labelColla";
            this.labelColla.Size = new System.Drawing.Size(25, 20);
            this.labelColla.TabIndex = 51;
            this.labelColla.Text = "➖";
            this.labelColla.Click += new System.EventHandler(this.labelColla_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.White;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.Color.Black;
            this.labelClose.Location = new System.Drawing.Point(616, 0);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 24);
            this.labelClose.TabIndex = 49;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(13, 444);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 49);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(639, 505);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLgota);
            this.Controls.Add(this.cbTarif);
            this.Controls.Add(this.btnCreateAbonent);
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.tbPeople);
            this.Controls.Add(this.labelSq);
            this.Controls.Add(this.tbSquare);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.labelSchet);
            this.Controls.Add(this.tbSchet);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSchet;
        private System.Windows.Forms.Label labelSchet;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label labelSq;
        private System.Windows.Forms.TextBox tbSquare;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.TextBox tbPeople;
        private System.Windows.Forms.Button btnCreateAbonent;
        private System.Windows.Forms.ComboBox cbTarif;
        private System.Windows.Forms.ComboBox cbLgota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelColla;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Button btnBack;
    }
}