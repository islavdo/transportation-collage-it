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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void table_специальностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_специальностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сайтамирова_3834DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сайтамирова_3834DataSet.Table_специальности". При необходимости она может быть перемещена или удалена.
            this.table_специальностиTableAdapter.Fill(this.сайтамирова_3834DataSet.Table_специальности);

        }
    }
}
