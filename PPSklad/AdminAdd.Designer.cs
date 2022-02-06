
namespace PPSklad
{
    partial class AdminAdd
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
            this.WhoEdit = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WhoEdit
            // 
            this.WhoEdit.AutoSize = true;
            this.WhoEdit.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhoEdit.ForeColor = System.Drawing.Color.Black;
            this.WhoEdit.Location = new System.Drawing.Point(673, 166);
            this.WhoEdit.Name = "WhoEdit";
            this.WhoEdit.Size = new System.Drawing.Size(94, 34);
            this.WhoEdit.TabIndex = 90;
            this.WhoEdit.Text = "Логин";
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(12, 610);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(182, 51);
            this.bBack.TabIndex = 89;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bAdd.Location = new System.Drawing.Point(1138, 610);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(182, 51);
            this.bAdd.TabIndex = 88;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(673, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 34);
            this.label5.TabIndex = 86;
            this.label5.Text = "Пароль";
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastname.Location = new System.Drawing.Point(179, 233);
            this.lastname.MaxLength = 99999999;
            this.lastname.Name = "lastname";
            this.lastname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lastname.Size = new System.Drawing.Size(471, 38);
            this.lastname.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 34);
            this.label4.TabIndex = 84;
            this.label4.Text = "Фамилия";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(179, 166);
            this.name.MaxLength = 30;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(471, 38);
            this.name.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 34);
            this.label3.TabIndex = 82;
            this.label3.Text = "Имя";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(837, 166);
            this.login.MaxLength = 99999999;
            this.login.Name = "login";
            this.login.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.login.Size = new System.Drawing.Size(480, 38);
            this.login.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(673, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 34);
            this.label1.TabIndex = 92;
            this.label1.Text = "Должность";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 31;
            this.comboBox1.Items.AddRange(new object[] {
            "Администратор",
            "Кладовщик"});
            this.comboBox1.Location = new System.Drawing.Point(837, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(483, 39);
            this.comboBox1.TabIndex = 93;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(837, 233);
            this.pass.MaxLength = 99999999;
            this.pass.Name = "pass";
            this.pass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pass.Size = new System.Drawing.Size(480, 38);
            this.pass.TabIndex = 94;
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.WhoEdit);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(1350, 720);
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Name = "AdminAdd";
            this.Text = "AdminAdd";
            this.Load += new System.EventHandler(this.AdminAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhoEdit;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox pass;
    }
}