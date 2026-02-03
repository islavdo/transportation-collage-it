
namespace настя
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label код_студента_Label;
            System.Windows.Forms.Label дата_экзамена1Label;
            System.Windows.Forms.Label код_предмета1Label;
            System.Windows.Forms.Label оценка1Label;
            System.Windows.Forms.Label дата_экзамена_2Label;
            System.Windows.Forms.Label код_предмета2Label;
            System.Windows.Forms.Label оценка2Label;
            System.Windows.Forms.Label дата_экзамена_3Label;
            System.Windows.Forms.Label код_предмета_3Label;
            System.Windows.Forms.Label оценка3Label;
            System.Windows.Forms.Label средний_баллLabel;
            this.сайтамирова_3834DataSet = new настя.сайтамирова_3834DataSet();
            this.table_оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_оценкиTableAdapter = new настя.сайтамирова_3834DataSetTableAdapters.Table_оценкиTableAdapter();
            this.tableAdapterManager = new настя.сайтамирова_3834DataSetTableAdapters.TableAdapterManager();
            this.table_оценкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.table_оценкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_студента_TextBox = new System.Windows.Forms.TextBox();
            this.дата_экзамена1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета1TextBox = new System.Windows.Forms.TextBox();
            this.оценка1TextBox = new System.Windows.Forms.TextBox();
            this.дата_экзамена_2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета2TextBox = new System.Windows.Forms.TextBox();
            this.оценка2TextBox = new System.Windows.Forms.TextBox();
            this.дата_экзамена_3DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_3TextBox = new System.Windows.Forms.TextBox();
            this.оценка3TextBox = new System.Windows.Forms.TextBox();
            this.средний_баллTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            код_студента_Label = new System.Windows.Forms.Label();
            дата_экзамена1Label = new System.Windows.Forms.Label();
            код_предмета1Label = new System.Windows.Forms.Label();
            оценка1Label = new System.Windows.Forms.Label();
            дата_экзамена_2Label = new System.Windows.Forms.Label();
            код_предмета2Label = new System.Windows.Forms.Label();
            оценка2Label = new System.Windows.Forms.Label();
            дата_экзамена_3Label = new System.Windows.Forms.Label();
            код_предмета_3Label = new System.Windows.Forms.Label();
            оценка3Label = new System.Windows.Forms.Label();
            средний_баллLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сайтамирова_3834DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_оценкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_оценкиBindingNavigator)).BeginInit();
            this.table_оценкиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // сайтамирова_3834DataSet
            // 
            this.сайтамирова_3834DataSet.DataSetName = "сайтамирова_3834DataSet";
            this.сайтамирова_3834DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_оценкиBindingSource
            // 
            this.table_оценкиBindingSource.DataMember = "Table_оценки";
            this.table_оценкиBindingSource.DataSource = this.сайтамирова_3834DataSet;
            // 
            // table_оценкиTableAdapter
            // 
            this.table_оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_оценкиTableAdapter = this.table_оценкиTableAdapter;
            this.tableAdapterManager.Table_предметыTableAdapter = null;
            this.tableAdapterManager.Table_специальностиTableAdapter = null;
            this.tableAdapterManager.Table_студентыTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = настя.сайтамирова_3834DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_оценкиBindingNavigator
            // 
            this.table_оценкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_оценкиBindingNavigator.BindingSource = this.table_оценкиBindingSource;
            this.table_оценкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_оценкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_оценкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table_оценкиBindingNavigatorSaveItem});
            this.table_оценкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_оценкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_оценкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_оценкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_оценкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_оценкиBindingNavigator.Name = "table_оценкиBindingNavigator";
            this.table_оценкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_оценкиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.table_оценкиBindingNavigator.TabIndex = 0;
            this.table_оценкиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // table_оценкиBindingNavigatorSaveItem
            // 
            this.table_оценкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_оценкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_оценкиBindingNavigatorSaveItem.Image")));
            this.table_оценкиBindingNavigatorSaveItem.Name = "table_оценкиBindingNavigatorSaveItem";
            this.table_оценкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.table_оценкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.table_оценкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.table_оценкиBindingNavigatorSaveItem_Click);
            // 
            // код_студента_Label
            // 
            код_студента_Label.AutoSize = true;
            код_студента_Label.Location = new System.Drawing.Point(12, 41);
            код_студента_Label.Name = "код_студента_Label";
            код_студента_Label.Size = new System.Drawing.Size(79, 13);
            код_студента_Label.TabIndex = 1;
            код_студента_Label.Text = "код студента :";
            // 
            // код_студента_TextBox
            // 
            this.код_студента_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_оценкиBindingSource, "код студента ", true));
            this.код_студента_TextBox.Location = new System.Drawing.Point(110, 41);
            this.код_студента_TextBox.Name = "код_студента_TextBox";
            this.код_студента_TextBox.Size = new System.Drawing.Size(100, 20);
            this.код_студента_TextBox.TabIndex = 2;
            // 
            // дата_экзамена1Label
            // 
            дата_экзамена1Label.AutoSize = true;
            дата_экзамена1Label.Location = new System.Drawing.Point(12, 64);
            дата_экзамена1Label.Name = "дата_экзамена1Label";
            дата_экзамена1Label.Size = new System.Drawing.Size(92, 13);
            дата_экзамена1Label.TabIndex = 3;
            дата_экзамена1Label.Text = "дата экзамена1:";
            // 
            // дата_экзамена1DateTimePicker
            // 
            this.дата_экзамена1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_оценкиBindingSource, "дата экзамена1", true));
            this.дата_экзамена1DateTimePicker.Location = new System.Drawing.Point(110, 64);
            this.дата_экзамена1DateTimePicker.Name = "дата_экзамена1DateTimePicker";
            this.дата_экзамена1DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_экзамена1DateTimePicker.TabIndex = 4;
            // 
            // код_предмета1Label
            // 
            код_предмета1Label.AutoSize = true;
            код_предмета1Label.Location = new System.Drawing.Point(12, 93);
            код_предмета1Label.Name = "код_предмета1Label";
            код_предмета1Label.Size = new System.Drawing.Size(86, 13);
            код_предмета1Label.TabIndex = 5;
            код_предмета1Label.Text = "код предмета1:";
            // 
            // код_предмета1TextBox
            // 
            this.код_предмета1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_оценкиBindingSource, "код предмета1", true));
            this.код_предмета1TextBox.Location = new System.Drawing.Point(110, 173);
            this.код_предмета1TextBox.Name = "код_предмета1TextBox";
            this.код_предмета1TextBox.Size = new System.Drawing.Size(100, 20);
            this.код_предмета1TextBox.TabIndex = 6;
            // 
            // оценка1Label
            // 
            оценка1Label.AutoSize = true;
            оценка1Label.Location = new System.Drawing.Point(12, 116);
            оценка1Label.Name = "оценка1Label";
            оценка1Label.Size = new System.Drawing.Size(52, 13);
            оценка1Label.TabIndex = 7;
            оценка1Label.Text = "оценка1:";
            // 
            // оценка1TextBox
            // 
            this.оценка1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_оценкиBindingSource, "оценка1", true));
            this.оценка1TextBox.Location = new System.Drawing.Point(110, 304);
            this.оценка1TextBox.Name = "оценка1TextBox";
            this.оценка1TextBox.Size = new System.Drawing.Size(100, 20);
            this.оценка1TextBox.TabIndex = 8;
            // 
            // дата_экзамена_2Label
            // 
            дата_экзамена_2Label.AutoSize = true;
            дата_экзамена_2Label.Location = new System.Drawing.Point(12, 150);
            дата_экзамена_2Label.Name = "дата_экзамена_2Label";
            дата_экзамена_2Label.Size = new System.Drawing.Size(95, 13);
            дата_экзамена_2Label.TabIndex = 9;
            дата_экзамена_2Label.Text = "дата экзамена 2:";
            // 
            // дата_экзамена_2DateTimePicker
            // 
            this.дата_экзамена_2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_оценкиBindingSource, "дата экзамена 2", true));
            this.дата_экзамена_2DateTimePicker.Location = new System.Drawing.Point(110, 144);
            this.дата_экзамена_2DateTimePicker.Name = "дата_экзамена_2DateTimePicker";
            this.дата_экзамена_2DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_экзамена_2DateTimePicker.TabIndex = 10;
            // 
            // код_предмета2Label
            // 
            код_предмета2Label.AutoSize = true;
            код_предмета2Label.Location = new System.Drawing.Point(12, 176);
            код_предмета2Label.Name = "код_предмета2Label";
            код_предмета2Label.Size = new System.Drawing.Size(86, 13);
            код_предмета2Label.TabIndex = 11;
            код_предмета2Label.Text = "код предмета2:";
            // 
            // код_предмета2TextBox
            // 
            this.код_предмета2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_оценкиBindingSource, "код предмета2", true));
            this.код_предмета2TextBox.Location = new System.Drawing.Point(110, 113);
            this.код_предмета2TextBox.Name = "код_предмета2TextBox";
            this.код_предмета2TextBox.Size = new System.Drawing.Size(100, 20);
            this.код_предмета2TextBox.TabIndex = 12;
            // 
            // оценка2Label
            // 
            оценка2Label.AutoSize = true;
            оценка2Label.Location = new System.Drawing.Point(12, 208);
            оценка2Label.Name = "оценка2Label";
            оценка2Label.Size = new System.Drawing.Size(52, 13);
            оценка2Label.TabIndex = 13;
            оценка2Label.Text = "оценка2:";
            // 
            // оценка2TextBox
            // 
            this.оценка2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_оценкиBindingSource, "оценка2", true));
            this.оценка2TextBox.Location = new System.Drawing.Point(110, 90);
            this.оценка2TextBox.Name = "оценка2TextBox";
            this.оценка2TextBox.Size = new System.Drawing.Size(100, 20);
            this.оценка2TextBox.TabIndex = 14;
            // 
            // дата_экзамена_3Label
            // 
            дата_экзамена_3Label.AutoSize = true;
            дата_экзамена_3Label.Location = new System.Drawing.Point(12, 246);
            дата_экзамена_3Label.Name = "дата_экзамена_3Label";
            дата_экзамена_3Label.Size = new System.Drawing.Size(95, 13);
            дата_экзамена_3Label.TabIndex = 15;
            дата_экзамена_3Label.Text = "дата экзамена 3:";
            // 
            // дата_экзамена_3DateTimePicker
            // 
            this.дата_экзамена_3DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_оценкиBindingSource, "дата экзамена 3", true));
            this.дата_экзамена_3DateTimePicker.Location = new System.Drawing.Point(110, 239);
            this.дата_экзамена_3DateTimePicker.Name = "дата_экзамена_3DateTimePicker";
            this.дата_экзамена_3DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_экзамена_3DateTimePicker.TabIndex = 16;
            // 
            // код_предмета_3Label
            // 
            код_предмета_3Label.AutoSize = true;
            код_предмета_3Label.Location = new System.Drawing.Point(12, 275);
            код_предмета_3Label.Name = "код_предмета_3Label";
            код_предмета_3Label.Size = new System.Drawing.Size(89, 13);
            код_предмета_3Label.TabIndex = 17;
            код_предмета_3Label.Text = "код предмета 3:";
            // 
            // код_предмета_3TextBox
            // 
            this.код_предмета_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_оценкиBindingSource, "код предмета 3", true));
            this.код_предмета_3TextBox.Location = new System.Drawing.Point(110, 272);
            this.код_предмета_3TextBox.Name = "код_предмета_3TextBox";
            this.код_предмета_3TextBox.Size = new System.Drawing.Size(100, 20);
            this.код_предмета_3TextBox.TabIndex = 18;
            // 
            // оценка3Label
            // 
            оценка3Label.AutoSize = true;
            оценка3Label.Location = new System.Drawing.Point(12, 311);
            оценка3Label.Name = "оценка3Label";
            оценка3Label.Size = new System.Drawing.Size(52, 13);
            оценка3Label.TabIndex = 19;
            оценка3Label.Text = "оценка3:";
            // 
            // оценка3TextBox
            // 
            this.оценка3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_оценкиBindingSource, "оценка3", true));
            this.оценка3TextBox.Location = new System.Drawing.Point(110, 201);
            this.оценка3TextBox.Name = "оценка3TextBox";
            this.оценка3TextBox.Size = new System.Drawing.Size(100, 20);
            this.оценка3TextBox.TabIndex = 20;
            // 
            // средний_баллLabel
            // 
            средний_баллLabel.AutoSize = true;
            средний_баллLabel.Location = new System.Drawing.Point(19, 367);
            средний_баллLabel.Name = "средний_баллLabel";
            средний_баллLabel.Size = new System.Drawing.Size(79, 13);
            средний_баллLabel.TabIndex = 21;
            средний_баллLabel.Text = "средний балл:";
            // 
            // средний_баллTextBox
            // 
            this.средний_баллTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_оценкиBindingSource, "средний балл", true));
            this.средний_баллTextBox.Location = new System.Drawing.Point(110, 367);
            this.средний_баллTextBox.Name = "средний_баллTextBox";
            this.средний_баллTextBox.Size = new System.Drawing.Size(100, 20);
            this.средний_баллTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Таблица \"Оценки\"";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(средний_баллLabel);
            this.Controls.Add(this.средний_баллTextBox);
            this.Controls.Add(оценка3Label);
            this.Controls.Add(this.оценка3TextBox);
            this.Controls.Add(код_предмета_3Label);
            this.Controls.Add(this.код_предмета_3TextBox);
            this.Controls.Add(дата_экзамена_3Label);
            this.Controls.Add(this.дата_экзамена_3DateTimePicker);
            this.Controls.Add(оценка2Label);
            this.Controls.Add(this.оценка2TextBox);
            this.Controls.Add(код_предмета2Label);
            this.Controls.Add(this.код_предмета2TextBox);
            this.Controls.Add(дата_экзамена_2Label);
            this.Controls.Add(this.дата_экзамена_2DateTimePicker);
            this.Controls.Add(оценка1Label);
            this.Controls.Add(this.оценка1TextBox);
            this.Controls.Add(код_предмета1Label);
            this.Controls.Add(this.код_предмета1TextBox);
            this.Controls.Add(дата_экзамена1Label);
            this.Controls.Add(this.дата_экзамена1DateTimePicker);
            this.Controls.Add(код_студента_Label);
            this.Controls.Add(this.код_студента_TextBox);
            this.Controls.Add(this.table_оценкиBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сайтамирова_3834DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_оценкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_оценкиBindingNavigator)).EndInit();
            this.table_оценкиBindingNavigator.ResumeLayout(false);
            this.table_оценкиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private сайтамирова_3834DataSet сайтамирова_3834DataSet;
        private System.Windows.Forms.BindingSource table_оценкиBindingSource;
        private сайтамирова_3834DataSetTableAdapters.Table_оценкиTableAdapter table_оценкиTableAdapter;
        private сайтамирова_3834DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_оценкиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table_оценкиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_студента_TextBox;
        private System.Windows.Forms.DateTimePicker дата_экзамена1DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета1TextBox;
        private System.Windows.Forms.TextBox оценка1TextBox;
        private System.Windows.Forms.DateTimePicker дата_экзамена_2DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета2TextBox;
        private System.Windows.Forms.TextBox оценка2TextBox;
        private System.Windows.Forms.DateTimePicker дата_экзамена_3DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_3TextBox;
        private System.Windows.Forms.TextBox оценка3TextBox;
        private System.Windows.Forms.TextBox средний_баллTextBox;
        private System.Windows.Forms.Label label1;
    }
}