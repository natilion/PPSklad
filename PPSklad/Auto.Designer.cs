
namespace PPSklad
{
    partial class Auto
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
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Ac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(624, 324);
            this.password.MaxLength = 30;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(350, 55);
            this.password.TabIndex = 20;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(624, 237);
            this.login.MaxLength = 30;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(350, 55);
            this.login.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(454, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 51);
            this.label4.TabIndex = 18;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(477, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 51);
            this.label3.TabIndex = 17;
            this.label3.Text = "Логин";
            // 
            // bLog
            // 
            this.bLog.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLog.Location = new System.Drawing.Point(463, 397);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(511, 67);
            this.bLog.TabIndex = 16;
            this.bLog.Text = "Войти";
            this.bLog.UseVisualStyleBackColor = true;
            this.bLog.Click += new System.EventHandler(this.bLog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(564, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 51);
            this.label2.TabIndex = 13;
            this.label2.Text = "Авторизация";
            // 
            // Ac
            // 
            this.Ac.AutoSize = true;
            this.Ac.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.Ac.ForeColor = System.Drawing.Color.Black;
            this.Ac.Location = new System.Drawing.Point(980, 9);
            this.Ac.Name = "Ac";
            this.Ac.Size = new System.Drawing.Size(0, 51);
            this.Ac.TabIndex = 12;
            // 
            // Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ac);
            this.MaximumSize = new System.Drawing.Size(1350, 720);
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Name = "Auto";
            this.Text = "Auto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ac;
    }
}