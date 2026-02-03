
namespace шегрикян
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label наименование_специальностиLabel;
            System.Windows.Forms.Label описание_специальностиLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.шегрикян_КDataSet1 = new шегрикян.Шегрикян_КDataSet1();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиTableAdapter = new шегрикян.Шегрикян_КDataSet1TableAdapters.СпециальностиTableAdapter();
            this.tableAdapterManager = new шегрикян.Шегрикян_КDataSet1TableAdapters.TableAdapterManager();
            this.специальностиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.специальностиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.шегрикян_КDataSet = new шегрикян.Шегрикян_КDataSet();
            this.специальностиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиTableAdapter1 = new шегрикян.Шегрикян_КDataSetTableAdapters.СпециальностиTableAdapter();
            this.tableAdapterManager1 = new шегрикян.Шегрикян_КDataSetTableAdapters.TableAdapterManager();
            this.шегрикян_КDataSet3 = new шегрикян.Шегрикян_КDataSet3();
            this.предметыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметыTableAdapter = new шегрикян.Шегрикян_КDataSet3TableAdapters.ПредметыTableAdapter();
            this.tableAdapterManager2 = new шегрикян.Шегрикян_КDataSet3TableAdapters.TableAdapterManager();
            this.шегрикян_КDataSet4 = new шегрикян.Шегрикян_КDataSet4();
            this.специальностиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиTableAdapter2 = new шегрикян.Шегрикян_КDataSet4TableAdapters.СпециальностиTableAdapter();
            this.tableAdapterManager3 = new шегрикян.Шегрикян_КDataSet4TableAdapters.TableAdapterManager();
            this.наименование_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.описание_специальностиTextBox = new System.Windows.Forms.TextBox();
            наименование_специальностиLabel = new System.Windows.Forms.Label();
            описание_специальностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.шегрикян_КDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingNavigator)).BeginInit();
            this.специальностиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.шегрикян_КDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.шегрикян_КDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.шегрикян_КDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица\"Специальности\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // шегрикян_КDataSet1
            // 
            this.шегрикян_КDataSet1.DataSetName = "Шегрикян_КDataSet1";
            this.шегрикян_КDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.шегрикян_КDataSet1;
            // 
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = шегрикян.Шегрикян_КDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СпециальностиTableAdapter = this.специальностиTableAdapter;
            // 
            // специальностиBindingNavigator
            // 
            this.специальностиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.специальностиBindingNavigator.BindingSource = this.специальностиBindingSource;
            this.специальностиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.специальностиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.специальностиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.специальностиBindingNavigatorSaveItem});
            this.специальностиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.специальностиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.специальностиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.специальностиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.специальностиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.специальностиBindingNavigator.Name = "специальностиBindingNavigator";
            this.специальностиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.специальностиBindingNavigator.Size = new System.Drawing.Size(1467, 25);
            this.специальностиBindingNavigator.TabIndex = 1;
            this.специальностиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // специальностиBindingNavigatorSaveItem
            // 
            this.специальностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.специальностиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("специальностиBindingNavigatorSaveItem.Image")));
            this.специальностиBindingNavigatorSaveItem.Name = "специальностиBindingNavigatorSaveItem";
            this.специальностиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.специальностиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.специальностиBindingNavigatorSaveItem.Click += new System.EventHandler(this.специальностиBindingNavigatorSaveItem_Click);
            // 
            // шегрикян_КDataSet
            // 
            this.шегрикян_КDataSet.DataSetName = "Шегрикян_КDataSet";
            this.шегрикян_КDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностиBindingSource1
            // 
            this.специальностиBindingSource1.DataMember = "Специальности";
            this.специальностиBindingSource1.DataSource = this.шегрикян_КDataSet;
            // 
            // специальностиTableAdapter1
            // 
            this.специальностиTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = шегрикян.Шегрикян_КDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ОценкиTableAdapter = null;
            this.tableAdapterManager1.ПредметыTableAdapter = null;
            this.tableAdapterManager1.СпециальностиTableAdapter = this.специальностиTableAdapter1;
            this.tableAdapterManager1.СтудентыTableAdapter = null;
            // 
            // шегрикян_КDataSet3
            // 
            this.шегрикян_КDataSet3.DataSetName = "Шегрикян_КDataSet3";
            this.шегрикян_КDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // предметыBindingSource
            // 
            this.предметыBindingSource.DataMember = "Предметы";
            this.предметыBindingSource.DataSource = this.шегрикян_КDataSet3;
            // 
            // предметыTableAdapter
            // 
            this.предметыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.UpdateOrder = шегрикян.Шегрикян_КDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.ПредметыTableAdapter = this.предметыTableAdapter;
            // 
            // шегрикян_КDataSet4
            // 
            this.шегрикян_КDataSet4.DataSetName = "Шегрикян_КDataSet4";
            this.шегрикян_КDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностиBindingSource2
            // 
            this.специальностиBindingSource2.DataMember = "Специальности";
            this.специальностиBindingSource2.DataSource = this.шегрикян_КDataSet4;
            // 
            // специальностиTableAdapter2
            // 
            this.специальностиTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.UpdateOrder = шегрикян.Шегрикян_КDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager3.СпециальностиTableAdapter = this.специальностиTableAdapter2;
            // 
            // наименование_специальностиLabel
            // 
            наименование_специальностиLabel.AutoSize = true;
            наименование_специальностиLabel.Location = new System.Drawing.Point(137, 245);
            наименование_специальностиLabel.Name = "наименование_специальностиLabel";
            наименование_специальностиLabel.Size = new System.Drawing.Size(292, 24);
            наименование_специальностиLabel.TabIndex = 2;
            наименование_специальностиLabel.Text = "Наименование специальности:";
            // 
            // наименование_специальностиTextBox
            // 
            this.наименование_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.специальностиBindingSource2, "Наименование специальности", true));
            this.наименование_специальностиTextBox.Location = new System.Drawing.Point(435, 242);
            this.наименование_специальностиTextBox.Name = "наименование_специальностиTextBox";
            this.наименование_специальностиTextBox.Size = new System.Drawing.Size(209, 29);
            this.наименование_специальностиTextBox.TabIndex = 3;
            // 
            // описание_специальностиLabel
            // 
            описание_специальностиLabel.AutoSize = true;
            описание_специальностиLabel.Location = new System.Drawing.Point(181, 355);
            описание_специальностиLabel.Name = "описание_специальностиLabel";
            описание_специальностиLabel.Size = new System.Drawing.Size(248, 24);
            описание_специальностиLabel.TabIndex = 4;
            описание_специальностиLabel.Text = "Описание специальности:";
            // 
            // описание_специальностиTextBox
            // 
            this.описание_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.специальностиBindingSource2, "Описание специальности", true));
            this.описание_специальностиTextBox.Location = new System.Drawing.Point(435, 352);
            this.описание_специальностиTextBox.Name = "описание_специальностиTextBox";
            this.описание_специальностиTextBox.Size = new System.Drawing.Size(209, 29);
            this.описание_специальностиTextBox.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(описание_специальностиLabel);
            this.Controls.Add(this.описание_специальностиTextBox);
            this.Controls.Add(наименование_специальностиLabel);
            this.Controls.Add(this.наименование_специальностиTextBox);
            this.Controls.Add(this.специальностиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Таблица \"Специальности\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.шегрикян_КDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingNavigator)).EndInit();
            this.специальностиBindingNavigator.ResumeLayout(false);
            this.специальностиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.шегрикян_КDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.шегрикян_КDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.шегрикян_КDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Шегрикян_КDataSet1 шегрикян_КDataSet1;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private Шегрикян_КDataSet1TableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private Шегрикян_КDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator специальностиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton специальностиBindingNavigatorSaveItem;
        private Шегрикян_КDataSet шегрикян_КDataSet;
        private System.Windows.Forms.BindingSource специальностиBindingSource1;
        private Шегрикян_КDataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter1;
        private Шегрикян_КDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Шегрикян_КDataSet3 шегрикян_КDataSet3;
        private System.Windows.Forms.BindingSource предметыBindingSource;
        private Шегрикян_КDataSet3TableAdapters.ПредметыTableAdapter предметыTableAdapter;
        private Шегрикян_КDataSet3TableAdapters.TableAdapterManager tableAdapterManager2;
        private Шегрикян_КDataSet4 шегрикян_КDataSet4;
        private System.Windows.Forms.BindingSource специальностиBindingSource2;
        private Шегрикян_КDataSet4TableAdapters.СпециальностиTableAdapter специальностиTableAdapter2;
        private Шегрикян_КDataSet4TableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.TextBox наименование_специальностиTextBox;
        private System.Windows.Forms.TextBox описание_специальностиTextBox;
    }
}