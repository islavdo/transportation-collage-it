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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.печерский_Александр_группа_3834DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "печерский_Александр_группа_3834DataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.печерский_Александр_группа_3834DataSet.Оценки);

        }

        private void дата_экзамена_3DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void дата_экзамена_3Label_Click(object sender, EventArgs e)
        {

        }

        private void дата_экзамена_1DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void дата_экзамена_1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
