using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Столярова_Лиза
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.столярова_ЕлизаветаDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "столярова_ЕлизаветаDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.столярова_ЕлизаветаDataSet.Студенты);

        }

        private void дата_рожденияDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void дата_рожденияLabel_Click(object sender, EventArgs e)
        {

        }

        private void очная_фороома_обученияCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void очная_фороома_обученияLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
