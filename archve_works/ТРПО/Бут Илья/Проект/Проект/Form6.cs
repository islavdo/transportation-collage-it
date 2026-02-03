using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бут_ИльяDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бут_ИльяDataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.бут_ИльяDataSet.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бут_ИльяDataSet._Запрос_Студенты_Оценки". При необходимости она может быть перемещена или удалена.
            this.запрос_Студенты_ОценкиTableAdapter.Fill(this.бут_ИльяDataSet._Запрос_Студенты_Оценки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бут_ИльяDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.бут_ИльяDataSet.Студенты);

        }

        private void фИО_студентаLabel_Click(object sender, EventArgs e)
        {

        }

        private void фИО_студентаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            студентыBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.бут_ИльяDataSet); //Поменять на свой DataSet
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бут_ИльяDataSet); //Поменять на свой DataSet
            MessageBox.Show("Данные Сохранены");
        }
    }
}
