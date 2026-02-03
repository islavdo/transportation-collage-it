using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лукьяненко_Олег
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Оценки оценки = new Оценки();
            оценки.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Студенты студенты = new Студенты();
            студенты.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Предметы предметы = new Предметы();
            предметы.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Специальности специальности  = new Специальности();
            специальности.Show();
        }
    }
}
