using System.ComponentModel;

namespace _213
{
    partial class SaveToFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtSave = new System.Windows.Forms.Button();
            this.JsonSave = new System.Windows.Forms.Button();
            this.csvSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSave
            // 
            this.txtSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSave.Location = new System.Drawing.Point(12, 249);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(136, 64);
            this.txtSave.TabIndex = 3;
            this.txtSave.Text = "сохранить в txt";
            this.txtSave.UseVisualStyleBackColor = false;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // JsonSave
            // 
            this.JsonSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.JsonSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.JsonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JsonSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JsonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JsonSave.Location = new System.Drawing.Point(154, 249);
            this.JsonSave.Name = "JsonSave";
            this.JsonSave.Size = new System.Drawing.Size(136, 64);
            this.JsonSave.TabIndex = 4;
            this.JsonSave.Text = "сохранить в Json";
            this.JsonSave.UseVisualStyleBackColor = false;
            this.JsonSave.Click += new System.EventHandler(this.JsonSave_Click);
            // 
            // csvSave
            // 
            this.csvSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.csvSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.csvSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csvSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.csvSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.csvSave.Location = new System.Drawing.Point(296, 249);
            this.csvSave.Name = "csvSave";
            this.csvSave.Size = new System.Drawing.Size(136, 64);
            this.csvSave.TabIndex = 5;
            this.csvSave.Text = "сохранить в CSV";
            this.csvSave.UseVisualStyleBackColor = false;
            this.csvSave.Click += new System.EventHandler(this.csvSave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выбирете формат файла";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputText.Location = new System.Drawing.Point(12, 85);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(643, 58);
            this.outputText.TabIndex = 8;
            this.outputText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(519, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 64);
            this.button3.TabIndex = 9;
            this.button3.Text = "Выйти";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveToFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(667, 340);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.csvSave);
            this.Controls.Add(this.JsonSave);
            this.Controls.Add(this.txtSave);
            this.Name = "SaveToFile";
            this.Text = "SaveToFile";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label outputText;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.Button JsonSave;
        private System.Windows.Forms.Button csvSave;

        #endregion
    }
}