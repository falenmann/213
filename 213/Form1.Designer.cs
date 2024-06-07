namespace _213
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DdConnector = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.choosePhoto = new System.Windows.Forms.Button();
            this.MainPhoto = new System.Windows.Forms.PictureBox();
            this.AiProcessing = new System.Windows.Forms.Button();
            this.Calssification = new System.Windows.Forms.Label();
            this.WriteIndb = new System.Windows.Forms.Button();
            this.Saving = new System.Windows.Forms.Button();
            this.PhotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // DdConnector
            // 
            this.DdConnector.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DdConnector.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DdConnector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DdConnector.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DdConnector.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DdConnector.Location = new System.Drawing.Point(12, 687);
            this.DdConnector.Name = "DdConnector";
            this.DdConnector.Size = new System.Drawing.Size(136, 64);
            this.DdConnector.TabIndex = 0;
            this.DdConnector.Text = "Подключение базы данных";
            this.DdConnector.UseVisualStyleBackColor = false;
            this.DdConnector.Click += new System.EventHandler(this.DdConnector_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Close.Location = new System.Drawing.Point(968, 687);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(136, 64);
            this.Close.TabIndex = 1;
            this.Close.Text = "Выйти";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // choosePhoto
            // 
            this.choosePhoto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.choosePhoto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.choosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choosePhoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePhoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.choosePhoto.Location = new System.Drawing.Point(154, 687);
            this.choosePhoto.Name = "choosePhoto";
            this.choosePhoto.Size = new System.Drawing.Size(136, 64);
            this.choosePhoto.TabIndex = 2;
            this.choosePhoto.Text = "Выбрать фото";
            this.choosePhoto.UseVisualStyleBackColor = false;
            this.choosePhoto.Click += new System.EventHandler(this.choosePhoto_Click);
            // 
            // MainPhoto
            // 
            this.MainPhoto.Location = new System.Drawing.Point(12, 12);
            this.MainPhoto.Name = "MainPhoto";
            this.MainPhoto.Size = new System.Drawing.Size(640, 480);
            this.MainPhoto.TabIndex = 3;
            this.MainPhoto.TabStop = false;
            // 
            // AiProcessing
            // 
            this.AiProcessing.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AiProcessing.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AiProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AiProcessing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AiProcessing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AiProcessing.Location = new System.Drawing.Point(296, 687);
            this.AiProcessing.Name = "AiProcessing";
            this.AiProcessing.Size = new System.Drawing.Size(136, 64);
            this.AiProcessing.TabIndex = 4;
            this.AiProcessing.Text = "Определить модель";
            this.AiProcessing.UseVisualStyleBackColor = false;
            this.AiProcessing.Click += new System.EventHandler(this.AiProcessing_Click);
            // 
            // Calssification
            // 
            this.Calssification.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calssification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calssification.Location = new System.Drawing.Point(708, 59);
            this.Calssification.Name = "Calssification";
            this.Calssification.Size = new System.Drawing.Size(381, 232);
            this.Calssification.TabIndex = 5;
            this.Calssification.Text = "Здесь будет ответ нейронной сети";
            // 
            // WriteIndb
            // 
            this.WriteIndb.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.WriteIndb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WriteIndb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WriteIndb.Enabled = false;
            this.WriteIndb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WriteIndb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteIndb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WriteIndb.Location = new System.Drawing.Point(438, 687);
            this.WriteIndb.Name = "WriteIndb";
            this.WriteIndb.Size = new System.Drawing.Size(136, 64);
            this.WriteIndb.TabIndex = 6;
            this.WriteIndb.Text = "Записать в базу данных";
            this.WriteIndb.UseVisualStyleBackColor = false;
            this.WriteIndb.Click += new System.EventHandler(this.button1_Click);
            // 
            // Saving
            // 
            this.Saving.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Saving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Saving.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Saving.Enabled = false;
            this.Saving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Saving.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saving.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Saving.Location = new System.Drawing.Point(580, 687);
            this.Saving.Name = "Saving";
            this.Saving.Size = new System.Drawing.Size(136, 64);
            this.Saving.TabIndex = 7;
            this.Saving.Text = "Сохранить модели в файл";
            this.Saving.UseVisualStyleBackColor = false;
            this.Saving.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PhotoLabel
            // 
            this.PhotoLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhotoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhotoLabel.Location = new System.Drawing.Point(51, 59);
            this.PhotoLabel.Name = "PhotoLabel";
            this.PhotoLabel.Size = new System.Drawing.Size(381, 232);
            this.PhotoLabel.TabIndex = 8;
            this.PhotoLabel.Text = "Здесь будет выбранная вами фотография";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1169, 761);
            this.Controls.Add(this.PhotoLabel);
            this.Controls.Add(this.Saving);
            this.Controls.Add(this.WriteIndb);
            this.Controls.Add(this.Calssification);
            this.Controls.Add(this.AiProcessing);
            this.Controls.Add(this.MainPhoto);
            this.Controls.Add(this.choosePhoto);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.DdConnector);
            this.Name = "Form1";
            this.Text = "Ai recignition cars";
            ((System.ComponentModel.ISupportInitialize)(this.MainPhoto)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label PhotoLabel;

        private System.Windows.Forms.Button Saving;

        private System.Windows.Forms.Button WriteIndb;

        private System.Windows.Forms.Label Calssification;

        private System.Windows.Forms.Button AiProcessing;

        private System.Windows.Forms.PictureBox MainPhoto;

        private System.Windows.Forms.Button choosePhoto;

        private System.Windows.Forms.Button Close;

        #endregion

        private System.Windows.Forms.Button DdConnector;
    }
}

