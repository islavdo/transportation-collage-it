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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void table_оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сайтамирова_3834DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сайтамирова_3834DataSet.Table_оценки". При необходимости она может быть перемещена или удалена.
            this.table_оценкиTableAdapter.Fill(this.сайтамирова_3834DataSet.Table_оценки);

        }
    }
}
