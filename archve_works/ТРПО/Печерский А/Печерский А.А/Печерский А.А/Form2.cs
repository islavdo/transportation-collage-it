using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Печерский_А.А
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "печерский_Александр_группа_3834DataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.печерский_Александр_группа_3834DataSet.Специальности);

        }

        private void специальностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.специальностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.печерский_Александр_группа_3834DataSet);

        }

        private void описание_специальностиTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void наименование_специальностиTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
