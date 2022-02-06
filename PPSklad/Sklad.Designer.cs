
namespace PPSklad
{
    partial class Sklad
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDel = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bLogOut = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 518);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bDel
            // 
            this.bDel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bDel.Location = new System.Drawing.Point(391, 84);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(182, 51);
            this.bDel.TabIndex = 64;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bUp
            // 
            this.bUp.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bUp.Location = new System.Drawing.Point(203, 84);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(182, 51);
            this.bUp.TabIndex = 63;
            this.bUp.Text = "Обновить";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bAdd.Location = new System.Drawing.Point(15, 84);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(182, 51);
            this.bAdd.TabIndex = 62;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 51);
            this.label2.TabIndex = 54;
            this.label2.Text = "Склад";
            // 
            // bLogOut
            // 
            this.bLogOut.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.bLogOut.Location = new System.Drawing.Point(1135, 14);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(182, 51);
            this.bLogOut.TabIndex = 52;
            this.bLogOut.Text = "Выйти";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(897, 97);
            this.name.MaxLength = 30;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(410, 38);
            this.name.TabIndex = 75;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bUp);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bLogOut);
            this.MaximumSize = new System.Drawing.Size(1350, 720);
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Name = "Sklad";
            this.Text = "Sklad";
            this.Load += new System.EventHandler(this.Sklad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.TextBox name;
    }
}