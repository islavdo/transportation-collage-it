
namespace Проект_sql
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label наименование_специальностиLabel;
            System.Windows.Forms.Label описание_специальностиLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.бешкеев_Артём3834DataSet = new Проект_sql.Бешкеев_Артём3834DataSet();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиTableAdapter = new Проект_sql.Бешкеев_Артём3834DataSetTableAdapters.СпециальностиTableAdapter();
            this.tableAdapterManager = new Проект_sql.Бешкеев_Артём3834DataSetTableAdapters.TableAdapterManager();
            this.наименование_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.описание_специальностиTextBox = new System.Windows.Forms.TextBox();
            наименование_специальностиLabel = new System.Windows.Forms.Label();
            описание_специальностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бешкеев_Артём3834DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // наименование_специальностиLabel
            // 
            наименование_специальностиLabel.AutoSize = true;
            наименование_специальностиLabel.Location = new System.Drawing.Point(229, 146);
            наименование_специальностиLabel.Name = "наименование_специальностиLabel";
            наименование_специальностиLabel.Size = new System.Drawing.Size(166, 13);
            наименование_специальностиLabel.TabIndex = 2;
            наименование_специальностиLabel.Text = "Наименование специальности:";
            // 
            // описание_специальностиLabel
            // 
            описание_специальностиLabel.AutoSize = true;
            описание_специальностиLabel.Location = new System.Drawing.Point(229, 226);
            описание_специальностиLabel.Name = "описание_специальностиLabel";
            описание_специальностиLabel.Size = new System.Drawing.Size(140, 13);
            описание_специальностиLabel.TabIndex = 4;
            описание_специальностиLabel.Text = "Описание специальности:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(258, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Специальности\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // бешкеев_Артём3834DataSet
            // 
            this.бешкеев_Артём3834DataSet.DataSetName = "Бешкеев_Артём3834DataSet";
            this.бешкеев_Артём3834DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.бешкеев_Артём3834DataSet;
            // 
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Проект_sql.Бешкеев_Артём3834DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = this.специальностиTableAdapter;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            // 
            // наименование_специальностиTextBox
            // 
            this.наименование_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.специальностиBindingSource, "Наименование специальности", true));
            this.наименование_специальностиTextBox.Location = new System.Drawing.Point(439, 139);
            this.наименование_специальностиTextBox.Name = "наименование_специальностиTextBox";
            this.наименование_специальностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименование_специальностиTextBox.TabIndex = 3;
            // 
            // описание_специальностиTextBox
            // 
            this.описание_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.специальностиBindingSource, "Описание специальности", true));
            this.описание_специальностиTextBox.Location = new System.Drawing.Point(439, 223);
            this.описание_специальностиTextBox.Name = "описание_специальностиTextBox";
            this.описание_специальностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.описание_специальностиTextBox.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Проект_sql.Properties.Resources.AUMSUmain_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(885, 572);
            this.Controls.Add(описание_специальностиLabel);
            this.Controls.Add(this.описание_специальностиTextBox);
            this.Controls.Add(наименование_специальностиLabel);
            this.Controls.Add(this.наименование_специальностиTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Специальности";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бешкеев_Артём3834DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Бешкеев_Артём3834DataSet бешкеев_Артём3834DataSet;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private Бешкеев_Артём3834DataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private Бешкеев_Артём3834DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox наименование_специальностиTextBox;
        private System.Windows.Forms.TextBox описание_специальностиTextBox;
    }
}