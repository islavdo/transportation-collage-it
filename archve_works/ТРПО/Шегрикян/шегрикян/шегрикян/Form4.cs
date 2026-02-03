using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace шегрикян
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
            this.tableAdapterManager.UpdateAll(this.шегрикян_КDataSet5);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шегрикян_КDataSet5.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.шегрикян_КDataSet5.Студенты);

        }

        private void очная_форма_обученияCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void очная_форма_обученияLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Кнопка первая
        {
            студентыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e) // Кнопка предыдущая
        {
            студентыBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e) // Кнопка последняя
        {
            студентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e) // Кнопка следующая
        {
            студентыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e) // Кнопка новая
        {
            студентыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e) // Кнопка удалить
        {
            студентыBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.DataSet); //Поменять на свой DataSet
        }

        private void button7_Click(object sender, EventArgs e) // Кнопка сохранить
        {
            this.Validate();

            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet); //Поменять на свой DataSet
            MessageBox.Show("Данные Сохранены");
        }
    }
}
