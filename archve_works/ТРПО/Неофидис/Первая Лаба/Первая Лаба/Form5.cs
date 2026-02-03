using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Первая_Лаба
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
            this.tableAdapterManager.UpdateAll(this.неофидис_ХристофорDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "неофидис_ХристофорDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.неофидис_ХристофорDataSet.Оценки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            средний_балTextBox.Text = ((int.Parse(оценка_1TextBox.Text) + int.Parse(оценка_2TextBox.Text) + int.Parse(оценка_3TextBox.Text)) / 3).ToString();
        }

        private void средний_балLabel_Click(object sender, EventArgs e)
        {

        }

        private void средний_балTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
