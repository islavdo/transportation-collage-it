using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_Прокопенко
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.прокопенко_Алексей_3834DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокопенко_Алексей_3834DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.прокопенко_Алексей_3834DataSet.Студенты);

        }

        private void очная_форма_обученияLabel_Click(object sender, EventArgs e)
        {

        }

        private void очная_форма_обученияCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void код_специальностиLabel_Click(object sender, EventArgs e)
        {

        }

        private void код_специальностиTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void курсLabel_Click(object sender, EventArgs e)
        {

        }

        private void курсTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void группаLabel_Click(object sender, EventArgs e)
        {

        }

        private void группаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void дата_поступленияLabel_Click(object sender, EventArgs e)
        {

        }

        private void дата_поступленияDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void номер_зачеткиLabel_Click(object sender, EventArgs e)
        {

        }

        private void паспортные_данныеLabel_Click(object sender, EventArgs e)
        {

        }

        private void паспортные_данныеTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void телефонLabel_Click(object sender, EventArgs e)
        {

        }

        private void телефонTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void адресLabel_Click(object sender, EventArgs e)
        {

        }

        private void адресTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void родителиLabel_Click(object sender, EventArgs e)
        {

        }

        private void родителиTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void дата_рожденияLabel_Click(object sender, EventArgs e)
        {

        }

        private void дата_рожденияDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void полLabel_Click(object sender, EventArgs e)
        {

        }

        private void полTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void фИОLabel_Click(object sender, EventArgs e)
        {

        }

        private void фИОTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            студентыBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.прокопенко_Алексей_3834DataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.прокопенко_Алексей_3834DataSet);
            MessageBox.Show("Данные Сохранены");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
