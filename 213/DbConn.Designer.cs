namespace _213
{
    partial class DbConn
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
            this.ServerIp = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.PasswordDb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DbName = new System.Windows.Forms.TextBox();
            this.OkerNot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServerIp
            // 
            this.ServerIp.Location = new System.Drawing.Point(190, 80);
            this.ServerIp.Name = "ServerIp";
            this.ServerIp.Size = new System.Drawing.Size(100, 20);
            this.ServerIp.TabIndex = 9;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(190, 132);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(100, 20);
            this.User.TabIndex = 1;
            // 
            // PasswordDb
            // 
            this.PasswordDb.Location = new System.Drawing.Point(190, 228);
            this.PasswordDb.Name = "PasswordDb";
            this.PasswordDb.Size = new System.Drawing.Size(100, 20);
            this.PasswordDb.TabIndex = 2;
            this.PasswordDb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите IP для подключения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(77, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите пороль:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(122, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Подключиться к базе данных";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(578, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "        Введите название базы:\r\n (если нет, оставте поле пустым)";
            // 
            // DbName
            // 
            this.DbName.Location = new System.Drawing.Point(190, 178);
            this.DbName.Name = "DbName";
            this.DbName.Size = new System.Drawing.Size(100, 20);
            this.DbName.TabIndex = 11;
            // 
            // OkerNot
            // 
            this.OkerNot.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OkerNot.Location = new System.Drawing.Point(542, 80);
            this.OkerNot.Name = "OkerNot";
            this.OkerNot.Size = new System.Drawing.Size(217, 164);
            this.OkerNot.TabIndex = 12;
            // 
            // DbConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OkerNot);
            this.Controls.Add(this.DbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordDb);
            this.Controls.Add(this.User);
            this.Controls.Add(this.ServerIp);
            this.Name = "DbConn";
            this.Text = "DbConn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label OkerNot;

        #endregion

        private System.Windows.Forms.TextBox ServerIp;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox PasswordDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DbName;
    }
}