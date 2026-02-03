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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void специальностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.специальностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.шегрикян_КDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шегрикян_КDataSet4.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter2.Fill(this.шегрикян_КDataSet4.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шегрикян_КDataSet3.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.шегрикян_КDataSet3.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шегрикян_КDataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter1.Fill(this.шегрикян_КDataSet.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шегрикян_КDataSet1.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.шегрикян_КDataSet1.Специальности);

        }

        private void наименование_специальностиComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
