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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шегрикян_КDataSet.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter1.Fill(this.шегрикян_КDataSet.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шегрикян_КDataSet3.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.шегрикян_КDataSet3.Предметы);

        }

        private void предметыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.предметыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.шегрикян_КDataSet3);

        }
    }
}
