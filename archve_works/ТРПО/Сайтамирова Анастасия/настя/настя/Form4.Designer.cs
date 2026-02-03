
namespace настя
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label родителиLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label номер_зачеткиLabel;
            System.Windows.Forms.Label дата_поступленияLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label курсLabel;
            System.Windows.Forms.Label код_специальностиLabel;
            System.Windows.Forms.Label очная_форма_обученияLabel;
            this.сайтамирова_3834DataSet = new настя.сайтамирова_3834DataSet();
            this.table_студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_студентыTableAdapter = new настя.сайтамирова_3834DataSetTableAdapters.Table_студентыTableAdapter();
            this.tableAdapterManager = new настя.сайтамирова_3834DataSetTableAdapters.TableAdapterManager();
            this.table_студентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.table_студентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.родителиTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.номер_зачеткиTextBox = new System.Windows.Forms.TextBox();
            this.дата_поступленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.курсTextBox = new System.Windows.Forms.TextBox();
            this.код_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.очная_форма_обученияCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            родителиLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            номер_зачеткиLabel = new System.Windows.Forms.Label();
            дата_поступленияLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            курсLabel = new System.Windows.Forms.Label();
            код_специальностиLabel = new System.Windows.Forms.Label();
            очная_форма_обученияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сайтамирова_3834DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_студентыBindingNavigator)).BeginInit();
            this.table_студентыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // сайтамирова_3834DataSet
            // 
            this.сайтамирова_3834DataSet.DataSetName = "сайтамирова_3834DataSet";
            this.сайтамирова_3834DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_студентыBindingSource
            // 
            this.table_студентыBindingSource.DataMember = "Table_студенты";
            this.table_студентыBindingSource.DataSource = this.сайтамирова_3834DataSet;
            // 
            // table_студентыTableAdapter
            // 
            this.table_студентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_оценкиTableAdapter = null;
            this.tableAdapterManager.Table_предметыTableAdapter = null;
            this.tableAdapterManager.Table_специальностиTableAdapter = null;
            this.tableAdapterManager.Table_студентыTableAdapter = this.table_студентыTableAdapter;
            this.tableAdapterManager.UpdateOrder = настя.сайтамирова_3834DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_студентыBindingNavigator
            // 
            this.table_студентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_студентыBindingNavigator.BindingSource = this.table_студентыBindingSource;
            this.table_студентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_студентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_студентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table_студентыBindingNavigatorSaveItem});
            this.table_студентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_студентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_студентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_студентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_студентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_студентыBindingNavigator.Name = "table_студентыBindingNavigator";
            this.table_студентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_студентыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.table_студентыBindingNavigator.TabIndex = 0;
            this.table_студентыBindingNavigator.Text = "bindingNavigator1";
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
            // table_студентыBindingNavigatorSaveItem
            // 
            this.table_студентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_студентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_студентыBindingNavigatorSaveItem.Image")));
            this.table_студентыBindingNavigatorSaveItem.Name = "table_студентыBindingNavigatorSaveItem";
            this.table_студентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.table_студентыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.table_студентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.table_студентыBindingNavigatorSaveItem_Click);
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(12, 63);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 1;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_студентыBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(118, 71);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 2;
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(12, 199);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(86, 13);
            дата_рожденияLabel.TabIndex = 3;
            дата_рожденияLabel.Text = "дата рождения:";
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_студентыBindingSource, "дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(118, 193);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 4;
            // 
            // родителиLabel
            // 
            родителиLabel.AutoSize = true;
            родителиLabel.Location = new System.Drawing.Point(12, 312);
            родителиLabel.Name = "родителиLabel";
            родителиLabel.Size = new System.Drawing.Size(57, 13);
            родителиLabel.TabIndex = 5;
            родителиLabel.Text = "родители:";
            // 
            // родителиTextBox
            // 
            this.родителиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_студентыBindingSource, "родители", true));
            this.родителиTextBox.Location = new System.Drawing.Point(118, 251);
            this.родителиTextBox.Name = "родителиTextBox";
            this.родителиTextBox.Size = new System.Drawing.Size(100, 20);
            this.родителиTextBox.TabIndex = 6;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(12, 225);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(40, 13);
            адресLabel.TabIndex = 7;
            адресLabel.Text = "адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_студентыBindingSource, "адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(118, 225);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.адресTextBox.TabIndex = 8;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(12, 258);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(53, 13);
            телефонLabel.TabIndex = 9;
            телефонLabel.Text = "телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_студентыBindingSource, "телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(118, 323);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 20);
            this.телефонTextBox.TabIndex = 10;
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(12, 283);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(112, 13);
            паспортные_данныеLabel.TabIndex = 11;
            паспортные_данныеLabel.Text = "паспортные данные:";
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_студентыBindingSource, "паспортные данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(118, 280);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(100, 20);
            this.паспортные_данныеTextBox.TabIndex = 12;
            // 
            // номер_зачеткиLabel
            // 
            номер_зачеткиLabel.AutoSize = true;
            номер_зачеткиLabel.Location = new System.Drawing.Point(13, 349);
            номер_зачеткиLabel.Name = "номер_зачеткиLabel";
            номер_зачеткиLabel.Size = new System.Drawing.Size(85, 13);
            номер_зачеткиLabel.TabIndex = 13;
            номер_зачеткиLabel.Text = "номер зачетки:";
            // 
            // номер_зачеткиTextBox
            // 
            this.номер_зачеткиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_студентыBindingSource, "номер зачетки", true));
            this.номер_зачеткиTextBox.Location = new System.Drawing.Point(118, 349);
            this.номер_зачеткиTextBox.Name = "номер_зачеткиTextBox";
            this.номер_зачеткиTextBox.Size = new System.Drawing.Size(100, 20);
            this.номер_зачеткиTextBox.TabIndex = 14;
            // 
            // дата_поступленияLabel
            // 
            дата_поступленияLabel.AutoSize = true;
            дата_поступленияLabel.Location = new System.Drawing.Point(12, 379);
            дата_поступленияLabel.Name = "дата_поступленияLabel";
            дата_поступленияLabel.Size = new System.Drawing.Size(100, 13);
            дата_поступленияLabel.TabIndex = 15;
            дата_поступленияLabel.Text = "дата поступления:";
            // 
            // дата_поступленияDateTimePicker
            // 
            this.дата_поступленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_студентыBindingSource, "дата поступления", true));
            this.дата_поступленияDateTimePicker.Location = new System.Drawing.Point(118, 379);
            this.дата_поступленияDateTimePicker.Name = "дата_поступленияDateTimePicker";
            this.дата_поступленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_поступленияDateTimePicker.TabIndex = 16;
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Location = new System.Drawing.Point(12, 163);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(44, 13);
            группаLabel.TabIndex = 17;
            группаLabel.Text = "группа:";
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_студентыBindingSource, "группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(118, 167);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(100, 20);
            this.группаTextBox.TabIndex = 18;
            // 
            // курсLabel
            // 
            курсLabel.AutoSize = true;
            курсLabel.Location = new System.Drawing.Point(12, 97);
            курсLabel.Name = "курсLabel";
            курсLabel.Size = new System.Drawing.Size(33, 13);
            курсLabel.TabIndex = 19;
            курсLabel.Text = "курс:";
            // 
            // курсTextBox
            // 
            this.курсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_студентыBindingSource, "курс", true));
            this.курсTextBox.Location = new System.Drawing.Point(118, 97);
            this.курсTextBox.Name = "курсTextBox";
            this.курсTextBox.Size = new System.Drawing.Size(100, 20);
            this.курсTextBox.TabIndex = 20;
            // 
            // код_специальностиLabel
            // 
            код_специальностиLabel.AutoSize = true;
            код_специальностиLabel.Location = new System.Drawing.Point(12, 131);
            код_специальностиLabel.Name = "код_специальностиLabel";
            код_специальностиLabel.Size = new System.Drawing.Size(108, 13);
            код_специальностиLabel.TabIndex = 21;
            код_специальностиLabel.Text = "код специальности:";
            // 
            // код_специальностиTextBox
            // 
            this.код_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_студентыBindingSource, "код специальности", true));
            this.код_специальностиTextBox.Location = new System.Drawing.Point(118, 128);
            this.код_специальностиTextBox.Name = "код_специальностиTextBox";
            this.код_специальностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_специальностиTextBox.TabIndex = 22;
            // 
            // очная_форма_обученияLabel
            // 
            очная_форма_обученияLabel.AutoSize = true;
            очная_форма_обученияLabel.Location = new System.Drawing.Point(13, 413);
            очная_форма_обученияLabel.Name = "очная_форма_обученияLabel";
            очная_форма_обученияLabel.Size = new System.Drawing.Size(125, 13);
            очная_форма_обученияLabel.TabIndex = 23;
            очная_форма_обученияLabel.Text = "очная форма обучения:";
            // 
            // очная_форма_обученияCheckBox
            // 
            this.очная_форма_обученияCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.table_студентыBindingSource, "очная форма обучения", true));
            this.очная_форма_обученияCheckBox.Location = new System.Drawing.Point(172, 413);
            this.очная_форма_обученияCheckBox.Name = "очная_форма_обученияCheckBox";
            this.очная_форма_обученияCheckBox.Size = new System.Drawing.Size(104, 24);
            this.очная_форма_обученияCheckBox.TabIndex = 24;
            this.очная_форма_обученияCheckBox.Text = "checkBox1";
            this.очная_форма_обученияCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Таблица \"Студенты\"";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(очная_форма_обученияLabel);
            this.Controls.Add(this.очная_форма_обученияCheckBox);
            this.Controls.Add(код_специальностиLabel);
            this.Controls.Add(this.код_специальностиTextBox);
            this.Controls.Add(курсLabel);
            this.Controls.Add(this.курсTextBox);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(дата_поступленияLabel);
            this.Controls.Add(this.дата_поступленияDateTimePicker);
            this.Controls.Add(номер_зачеткиLabel);
            this.Controls.Add(this.номер_зачеткиTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(родителиLabel);
            this.Controls.Add(this.родителиTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.table_студентыBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сайтамирова_3834DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_студентыBindingNavigator)).EndInit();
            this.table_студентыBindingNavigator.ResumeLayout(false);
            this.table_студентыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private сайтамирова_3834DataSet сайтамирова_3834DataSet;
        private System.Windows.Forms.BindingSource table_студентыBindingSource;
        private сайтамирова_3834DataSetTableAdapters.Table_студентыTableAdapter table_студентыTableAdapter;
        private сайтамирова_3834DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_студентыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table_студентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox родителиTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox номер_зачеткиTextBox;
        private System.Windows.Forms.DateTimePicker дата_поступленияDateTimePicker;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.TextBox курсTextBox;
        private System.Windows.Forms.TextBox код_специальностиTextBox;
        private System.Windows.Forms.CheckBox очная_форма_обученияCheckBox;
        private System.Windows.Forms.Label label1;
    }
}