
namespace PPSklad
{
    partial class SkladAdd
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
            this.about = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.specs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.WhoEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about.Location = new System.Drawing.Point(685, 160);
            this.about.MaxLength = 99999999;
            this.about.Multiline = true;
            this.about.Name = "about";
            this.about.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.about.Size = new System.Drawing.Size(638, 376);
            this.about.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(679, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 34);
            this.label5.TabIndex = 77;
            this.label5.Text = "Об устройстве";
            // 
            // specs
            // 
            this.specs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specs.Location = new System.Drawing.Point(12, 160);
            this.specs.MaxLength = 99999999;
            this.specs.Multiline = true;
            this.specs.Name = "specs";
            this.specs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.specs.Size = new System.Drawing.Size(644, 376);
            this.specs.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 34);
            this.label4.TabIndex = 75;
            this.label4.Text = "Характеристики";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(157, 56);
            this.name.MaxLength = 30;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(499, 38);
            this.name.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 34);
            this.label3.TabIndex = 73;
            this.label3.Text = "Название";
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(12, 610);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(182, 51);
            this.bBack.TabIndex = 80;
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
            this.bAdd.TabIndex = 79;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // WhoEdit
            // 
            this.WhoEdit.AutoSize = true;
            this.WhoEdit.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhoEdit.ForeColor = System.Drawing.Color.Black;
            this.WhoEdit.Location = new System.Drawing.Point(679, 56);
            this.WhoEdit.Name = "WhoEdit";
            this.WhoEdit.Size = new System.Drawing.Size(354, 34);
            this.WhoEdit.TabIndex = 81;
            this.WhoEdit.Text = "Последнее изменение от: ";
            // 
            // SkladAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.WhoEdit);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.about);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.specs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(1350, 720);
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Name = "SkladAdd";
            this.Text = "SkladAdd";
            this.Load += new System.EventHandler(this.SkladAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox about;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox specs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label WhoEdit;
    }
}