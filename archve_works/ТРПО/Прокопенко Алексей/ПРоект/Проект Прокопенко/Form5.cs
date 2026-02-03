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
            this.tableAdapterManager.UpdateAll(this.прокопенко_Алексей_3834DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "прокопенко_Алексей_3834DataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.прокопенко_Алексей_3834DataSet.Оценки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            средний_баллTextBox.Text = ((int.Parse(оценка_1TextBox.Text) + int.Parse(оценка_2TextBox.Text) + int.Parse(оценка_3TextBox.Text)) / 3).ToString();
        }
    }
}
