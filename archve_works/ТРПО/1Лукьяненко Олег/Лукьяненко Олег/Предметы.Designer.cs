
namespace Лукьяненко_Олег
{
    partial class Предметы
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
            System.Windows.Forms.Label описание_специальностиLabel;
            System.Windows.Forms.Label наименование_специальностиLabel;
            this.описание_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.наименование_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            описание_специальностиLabel = new System.Windows.Forms.Label();
            наименование_специальностиLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // описание_специальностиLabel
            // 
            описание_специальностиLabel.AutoSize = true;
            описание_специальностиLabel.Location = new System.Drawing.Point(263, 267);
            описание_специальностиLabel.Name = "описание_специальностиLabel";
            описание_специальностиLabel.Size = new System.Drawing.Size(112, 13);
            описание_специальностиLabel.TabIndex = 9;
            описание_специальностиLabel.Text = "Описание предмета:";
            описание_специальностиLabel.Click += new System.EventHandler(this.описание_специальностиLabel_Click);
            // 
            // описание_специальностиTextBox
            // 
            this.описание_специальностиTextBox.Location = new System.Drawing.Point(401, 264);
            this.описание_специальностиTextBox.Name = "описание_специальностиTextBox";
            this.описание_специальностиTextBox.Size = new System.Drawing.Size(164, 20);
            this.описание_специальностиTextBox.TabIndex = 10;
            this.описание_специальностиTextBox.TextChanged += new System.EventHandler(this.описание_специальностиTextBox_TextChanged);
            // 
            // наименование_специальностиLabel
            // 
            наименование_специальностиLabel.AutoSize = true;
            наименование_специальностиLabel.Location = new System.Drawing.Point(237, 221);
            наименование_специальностиLabel.Name = "наименование_специальностиLabel";
            наименование_специальностиLabel.Size = new System.Drawing.Size(138, 13);
            наименование_специальностиLabel.TabIndex = 7;
            наименование_специальностиLabel.Text = "Наименование предмета:";
            наименование_специальностиLabel.Click += new System.EventHandler(this.наименование_специальностиLabel_Click);
            // 
            // наименование_специальностиTextBox
            // 
            this.наименование_специальностиTextBox.Location = new System.Drawing.Point(401, 218);
            this.наименование_специальностиTextBox.Name = "наименование_специальностиTextBox";
            this.наименование_специальностиTextBox.Size = new System.Drawing.Size(164, 20);
            this.наименование_специальностиTextBox.TabIndex = 8;
            this.наименование_специальностиTextBox.TextChanged += new System.EventHandler(this.наименование_специальностиTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(301, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Таблица \"Предметы\"";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Предметы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(описание_специальностиLabel);
            this.Controls.Add(this.описание_специальностиTextBox);
            this.Controls.Add(наименование_специальностиLabel);
            this.Controls.Add(this.наименование_специальностиTextBox);
            this.Controls.Add(this.label4);
            this.Name = "Предметы";
            this.Text = "Предметы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox описание_специальностиTextBox;
        private System.Windows.Forms.TextBox наименование_специальностиTextBox;
        private System.Windows.Forms.Label label4;
    }
}