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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "неофидис_ХристофорDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.неофидис_ХристофорDataSet.Студенты);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите поле для сортировки!");
            }

            DataGridViewColumn col = null;

            switch (listBox1.SelectedIndex)
            {
                case 0: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn2"]; break;
                case 1: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn3"]; break;
                case 2: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn4"]; break;
                case 3: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn5"]; break;
                case 4: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn6"]; break;
                case 5: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn7"]; break;
                case 6: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn8"]; break;
                case 7: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn9"]; break;
                case 8: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn10"]; break;
                case 9: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn11"]; break;
                case 10: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn12"]; break;
                case 11: col = студентыDataGridView.Columns["dataGridViewTextBoxColumn14"]; break;
                default: MessageBox.Show("Неверный выбор поля."); return;
            }

            var direction = radioButton1.Checked
                ? System.ComponentModel.ListSortDirection.Ascending
                : System.ComponentModel.ListSortDirection.Descending;

            студентыDataGridView.Sort(col, direction);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                студентыBindingSource.Filter = $"ФИО = '{comboBox1.Text.Replace("'", "''")}'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Введите текст для поиска!");
                return;
            }

            foreach (DataGridViewRow row in студентыDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Style.ForeColor = Color.Black;
                }
            }

            foreach (DataGridViewRow row in студентыDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        cell.Style.BackColor = Color.LightBlue;
                        cell.Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
