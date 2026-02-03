using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace настя
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void table_студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сайтамирова_3834DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сайтамирова_3834DataSet.Table_студенты". При необходимости она может быть перемещена или удалена.
            this.table_студентыTableAdapter.Fill(this.сайтамирова_3834DataSet.Table_студенты);

        }
    }
}
