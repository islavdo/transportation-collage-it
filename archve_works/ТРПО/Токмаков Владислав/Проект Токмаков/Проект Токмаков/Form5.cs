using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_Токмаков
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.токмаков_Владислав_3834DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "токмаков_Владислав_3834DataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.токмаков_Владислав_3834DataSet.Оценки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mark1 = Convert.ToDouble(оценка_1TextBox.Text);
            double mark2 = Convert.ToDouble(оценка_2TextBox.Text);
            double mark3 = Convert.ToDouble(оценка_3TextBox.Text);

            double average = (mark1 + mark2 + mark3) / 3;

            средний_баллTextBox.Text = average.ToString("0.00");
        }
    }
}
