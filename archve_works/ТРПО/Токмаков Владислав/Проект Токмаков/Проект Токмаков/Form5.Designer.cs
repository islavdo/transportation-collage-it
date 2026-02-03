
namespace Проект_Токмаков
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
            System.Windows.Forms.Label код_студентаLabel;
            System.Windows.Forms.Label дата_экзамена_1Label;
            System.Windows.Forms.Label код_предмета_1Label;
            System.Windows.Forms.Label оценка_1Label;
            System.Windows.Forms.Label дата_экзамена_2Label;
            System.Windows.Forms.Label код_предмета_2Label;
            System.Windows.Forms.Label оценка_2Label;
            System.Windows.Forms.Label дата_экзамена_3Label;
            System.Windows.Forms.Label код_предмета_3Label;
            System.Windows.Forms.Label оценка_3Label;
            System.Windows.Forms.Label средний_баллLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.токмаков_Владислав_3834DataSet = new Проект_Токмаков.Токмаков_Владислав_3834DataSet();
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оценкиTableAdapter = new Проект_Токмаков.Токмаков_Владислав_3834DataSetTableAdapters.ОценкиTableAdapter();
            this.tableAdapterManager = new Проект_Токмаков.Токмаков_Владислав_3834DataSetTableAdapters.TableAdapterManager();
            this.оценкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.оценкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_студентаTextBox = new System.Windows.Forms.TextBox();
            this.дата_экзамена_1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_1TextBox = new System.Windows.Forms.TextBox();
            this.оценка_1TextBox = new System.Windows.Forms.TextBox();
            this.дата_экзамена_2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_2TextBox = new System.Windows.Forms.TextBox();
            this.оценка_2TextBox = new System.Windows.Forms.TextBox();
            this.дата_экзамена_3DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_предмета_3TextBox = new System.Windows.Forms.TextBox();
            this.оценка_3TextBox = new System.Windows.Forms.TextBox();
            this.средний_баллTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            код_студентаLabel = new System.Windows.Forms.Label();
            дата_экзамена_1Label = new System.Windows.Forms.Label();
            код_предмета_1Label = new System.Windows.Forms.Label();
            оценка_1Label = new System.Windows.Forms.Label();
            дата_экзамена_2Label = new System.Windows.Forms.Label();
            код_предмета_2Label = new System.Windows.Forms.Label();
            оценка_2Label = new System.Windows.Forms.Label();
            дата_экзамена_3Label = new System.Windows.Forms.Label();
            код_предмета_3Label = new System.Windows.Forms.Label();
            оценка_3Label = new System.Windows.Forms.Label();
            средний_баллLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.токмаков_Владислав_3834DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingNavigator)).BeginInit();
            this.оценкиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_студентаLabel
            // 
            код_студентаLabel.AutoSize = true;
            код_студентаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            код_студентаLabel.Location = new System.Drawing.Point(138, 90);
            код_студентаLabel.Name = "код_студентаLabel";
            код_студентаLabel.Size = new System.Drawing.Size(118, 20);
            код_студентаLabel.TabIndex = 1;
            код_студентаLabel.Text = "Код студента:";
            // 
            // дата_экзамена_1Label
            // 
            дата_экзамена_1Label.AutoSize = true;
            дата_экзамена_1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            дата_экзамена_1Label.Location = new System.Drawing.Point(115, 131);
            дата_экзамена_1Label.Name = "дата_экзамена_1Label";
            дата_экзамена_1Label.Size = new System.Drawing.Size(141, 20);
            дата_экзамена_1Label.TabIndex = 3;
            дата_экзамена_1Label.Text = "Дата экзамена 1:";
            // 
            // код_предмета_1Label
            // 
            код_предмета_1Label.AutoSize = true;
            код_предмета_1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            код_предмета_1Label.Location = new System.Drawing.Point(120, 173);
            код_предмета_1Label.Name = "код_предмета_1Label";
            код_предмета_1Label.Size = new System.Drawing.Size(136, 20);
            код_предмета_1Label.TabIndex = 5;
            код_предмета_1Label.Text = "Код предмета 1:";
            // 
            // оценка_1Label
            // 
            оценка_1Label.AutoSize = true;
            оценка_1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            оценка_1Label.Location = new System.Drawing.Point(170, 218);
            оценка_1Label.Name = "оценка_1Label";
            оценка_1Label.Size = new System.Drawing.Size(82, 20);
            оценка_1Label.TabIndex = 7;
            оценка_1Label.Text = "Оценка 1:";
            // 
            // дата_экзамена_2Label
            // 
            дата_экзамена_2Label.AutoSize = true;
            дата_экзамена_2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            дата_экзамена_2Label.Location = new System.Drawing.Point(115, 263);
            дата_экзамена_2Label.Name = "дата_экзамена_2Label";
            дата_экзамена_2Label.Size = new System.Drawing.Size(141, 20);
            дата_экзамена_2Label.TabIndex = 9;
            дата_экзамена_2Label.Text = "Дата экзамена 2:";
            // 
            // код_предмета_2Label
            // 
            код_предмета_2Label.AutoSize = true;
            код_предмета_2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            код_предмета_2Label.Location = new System.Drawing.Point(120, 305);
            код_предмета_2Label.Name = "код_предмета_2Label";
            код_предмета_2Label.Size = new System.Drawing.Size(136, 20);
            код_предмета_2Label.TabIndex = 11;
            код_предмета_2Label.Text = "Код предмета 2:";
            // 
            // оценка_2Label
            // 
            оценка_2Label.AutoSize = true;
            оценка_2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            оценка_2Label.Location = new System.Drawing.Point(170, 349);
            оценка_2Label.Name = "оценка_2Label";
            оценка_2Label.Size = new System.Drawing.Size(82, 20);
            оценка_2Label.TabIndex = 13;
            оценка_2Label.Text = "Оценка 2:";
            // 
            // дата_экзамена_3Label
            // 
            дата_экзамена_3Label.AutoSize = true;
            дата_экзамена_3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            дата_экзамена_3Label.Location = new System.Drawing.Point(115, 395);
            дата_экзамена_3Label.Name = "дата_экзамена_3Label";
            дата_экзамена_3Label.Size = new System.Drawing.Size(141, 20);
            дата_экзамена_3Label.TabIndex = 15;
            дата_экзамена_3Label.Text = "Дата экзамена 3:";
            // 
            // код_предмета_3Label
            // 
            код_предмета_3Label.AutoSize = true;
            код_предмета_3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            код_предмета_3Label.Location = new System.Drawing.Point(120, 438);
            код_предмета_3Label.Name = "код_предмета_3Label";
            код_предмета_3Label.Size = new System.Drawing.Size(136, 20);
            код_предмета_3Label.TabIndex = 17;
            код_предмета_3Label.Text = "Код предмета 3:";
            // 
            // оценка_3Label
            // 
            оценка_3Label.AutoSize = true;
            оценка_3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            оценка_3Label.Location = new System.Drawing.Point(170, 483);
            оценка_3Label.Name = "оценка_3Label";
            оценка_3Label.Size = new System.Drawing.Size(82, 20);
            оценка_3Label.TabIndex = 19;
            оценка_3Label.Text = "Оценка 3:";
            // 
            // средний_баллLabel
            // 
            средний_баллLabel.AutoSize = true;
            средний_баллLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            средний_баллLabel.Location = new System.Drawing.Point(134, 527);
            средний_баллLabel.Name = "средний_баллLabel";
            средний_баллLabel.Size = new System.Drawing.Size(122, 20);
            средний_баллLabel.TabIndex = 21;
            средний_баллLabel.Text = "Средний балл:";
            // 
            // токмаков_Владислав_3834DataSet
            // 
            this.токмаков_Владислав_3834DataSet.DataSetName = "Токмаков_Владислав_3834DataSet";
            this.токмаков_Владислав_3834DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "Оценки";
            this.оценкиBindingSource.DataSource = this.токмаков_Владислав_3834DataSet;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Проект_Токмаков.Токмаков_Владислав_3834DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = this.оценкиTableAdapter;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            this.tableAdapterManager.Таблица_оценкиTableAdapter = null;
            // 
            // оценкиBindingNavigator
            // 
            this.оценкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.оценкиBindingNavigator.BindingSource = this.оценкиBindingSource;
            this.оценкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.оценкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.оценкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.оценкиBindingNavigatorSaveItem});
            this.оценкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.оценкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.оценкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.оценкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.оценкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.оценкиBindingNavigator.Name = "оценкиBindingNavigator";
            this.оценкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.оценкиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.оценкиBindingNavigator.TabIndex = 0;
            this.оценкиBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // оценкиBindingNavigatorSaveItem
            // 
            this.оценкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.оценкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("оценкиBindingNavigatorSaveItem.Image")));
            this.оценкиBindingNavigatorSaveItem.Name = "оценкиBindingNavigatorSaveItem";
            this.оценкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.оценкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.оценкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.оценкиBindingNavigatorSaveItem_Click);
            // 
            // код_студентаTextBox
            // 
            this.код_студентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код студента", true));
            this.код_студентаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.код_студентаTextBox.Location = new System.Drawing.Point(262, 87);
            this.код_студентаTextBox.Name = "код_студентаTextBox";
            this.код_студентаTextBox.Size = new System.Drawing.Size(100, 26);
            this.код_студентаTextBox.TabIndex = 2;
            // 
            // дата_экзамена_1DateTimePicker
            // 
            this.дата_экзамена_1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "Дата экзамена 1", true));
            this.дата_экзамена_1DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.дата_экзамена_1DateTimePicker.Location = new System.Drawing.Point(262, 126);
            this.дата_экзамена_1DateTimePicker.Name = "дата_экзамена_1DateTimePicker";
            this.дата_экзамена_1DateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.дата_экзамена_1DateTimePicker.TabIndex = 4;
            // 
            // код_предмета_1TextBox
            // 
            this.код_предмета_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код предмета 1", true));
            this.код_предмета_1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.код_предмета_1TextBox.Location = new System.Drawing.Point(262, 170);
            this.код_предмета_1TextBox.Name = "код_предмета_1TextBox";
            this.код_предмета_1TextBox.Size = new System.Drawing.Size(100, 26);
            this.код_предмета_1TextBox.TabIndex = 6;
            // 
            // оценка_1TextBox
            // 
            this.оценка_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка 1", true));
            this.оценка_1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.оценка_1TextBox.Location = new System.Drawing.Point(262, 215);
            this.оценка_1TextBox.Name = "оценка_1TextBox";
            this.оценка_1TextBox.Size = new System.Drawing.Size(100, 26);
            this.оценка_1TextBox.TabIndex = 8;
            // 
            // дата_экзамена_2DateTimePicker
            // 
            this.дата_экзамена_2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "Дата экзамена 2", true));
            this.дата_экзамена_2DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.дата_экзамена_2DateTimePicker.Location = new System.Drawing.Point(262, 258);
            this.дата_экзамена_2DateTimePicker.Name = "дата_экзамена_2DateTimePicker";
            this.дата_экзамена_2DateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.дата_экзамена_2DateTimePicker.TabIndex = 10;
            // 
            // код_предмета_2TextBox
            // 
            this.код_предмета_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код предмета 2", true));
            this.код_предмета_2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.код_предмета_2TextBox.Location = new System.Drawing.Point(262, 302);
            this.код_предмета_2TextBox.Name = "код_предмета_2TextBox";
            this.код_предмета_2TextBox.Size = new System.Drawing.Size(100, 26);
            this.код_предмета_2TextBox.TabIndex = 12;
            // 
            // оценка_2TextBox
            // 
            this.оценка_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка 2", true));
            this.оценка_2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.оценка_2TextBox.Location = new System.Drawing.Point(262, 346);
            this.оценка_2TextBox.Name = "оценка_2TextBox";
            this.оценка_2TextBox.Size = new System.Drawing.Size(100, 26);
            this.оценка_2TextBox.TabIndex = 14;
            // 
            // дата_экзамена_3DateTimePicker
            // 
            this.дата_экзамена_3DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "Дата экзамена 3", true));
            this.дата_экзамена_3DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.дата_экзамена_3DateTimePicker.Location = new System.Drawing.Point(262, 390);
            this.дата_экзамена_3DateTimePicker.Name = "дата_экзамена_3DateTimePicker";
            this.дата_экзамена_3DateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.дата_экзамена_3DateTimePicker.TabIndex = 16;
            // 
            // код_предмета_3TextBox
            // 
            this.код_предмета_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Код предмета 3", true));
            this.код_предмета_3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.код_предмета_3TextBox.Location = new System.Drawing.Point(262, 435);
            this.код_предмета_3TextBox.Name = "код_предмета_3TextBox";
            this.код_предмета_3TextBox.Size = new System.Drawing.Size(100, 26);
            this.код_предмета_3TextBox.TabIndex = 18;
            // 
            // оценка_3TextBox
            // 
            this.оценка_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка 3", true));
            this.оценка_3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.оценка_3TextBox.Location = new System.Drawing.Point(262, 480);
            this.оценка_3TextBox.Name = "оценка_3TextBox";
            this.оценка_3TextBox.Size = new System.Drawing.Size(100, 26);
            this.оценка_3TextBox.TabIndex = 20;
            // 
            // средний_баллTextBox
            // 
            this.средний_баллTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Средний балл", true));
            this.средний_баллTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.средний_баллTextBox.Location = new System.Drawing.Point(262, 524);
            this.средний_баллTextBox.Name = "средний_баллTextBox";
            this.средний_баллTextBox.Size = new System.Drawing.Size(100, 26);
            this.средний_баллTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(155, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Таблица \"Оценки\"";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(412, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(средний_баллLabel);
            this.Controls.Add(this.средний_баллTextBox);
            this.Controls.Add(оценка_3Label);
            this.Controls.Add(this.оценка_3TextBox);
            this.Controls.Add(код_предмета_3Label);
            this.Controls.Add(this.код_предмета_3TextBox);
            this.Controls.Add(дата_экзамена_3Label);
            this.Controls.Add(this.дата_экзамена_3DateTimePicker);
            this.Controls.Add(оценка_2Label);
            this.Controls.Add(this.оценка_2TextBox);
            this.Controls.Add(код_предмета_2Label);
            this.Controls.Add(this.код_предмета_2TextBox);
            this.Controls.Add(дата_экзамена_2Label);
            this.Controls.Add(this.дата_экзамена_2DateTimePicker);
            this.Controls.Add(оценка_1Label);
            this.Controls.Add(this.оценка_1TextBox);
            this.Controls.Add(код_предмета_1Label);
            this.Controls.Add(this.код_предмета_1TextBox);
            this.Controls.Add(дата_экзамена_1Label);
            this.Controls.Add(this.дата_экзамена_1DateTimePicker);
            this.Controls.Add(код_студентаLabel);
            this.Controls.Add(this.код_студентаTextBox);
            this.Controls.Add(this.оценкиBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.токмаков_Владислав_3834DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingNavigator)).EndInit();
            this.оценкиBindingNavigator.ResumeLayout(false);
            this.оценкиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Токмаков_Владислав_3834DataSet токмаков_Владислав_3834DataSet;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private Токмаков_Владислав_3834DataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private Токмаков_Владислав_3834DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator оценкиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton оценкиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_студентаTextBox;
        private System.Windows.Forms.DateTimePicker дата_экзамена_1DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_1TextBox;
        private System.Windows.Forms.TextBox оценка_1TextBox;
        private System.Windows.Forms.DateTimePicker дата_экзамена_2DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_2TextBox;
        private System.Windows.Forms.TextBox оценка_2TextBox;
        private System.Windows.Forms.DateTimePicker дата_экзамена_3DateTimePicker;
        private System.Windows.Forms.TextBox код_предмета_3TextBox;
        private System.Windows.Forms.TextBox оценка_3TextBox;
        private System.Windows.Forms.TextBox средний_баллTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}