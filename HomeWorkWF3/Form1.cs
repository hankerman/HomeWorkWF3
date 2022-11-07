using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkWF3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Task1_Click(object sender, EventArgs e)
        {
            Task1 task = new Task1();
            task.Show();
        }

        private void task2_Click(object sender, EventArgs e)
        {
            Task2 task = new Task2();
            task.Show();
        }

        private void task3_Click(object sender, EventArgs e)
        {
            Task3 task = new Task3();
            task.Show();
        }

        private void task4_Click(object sender, EventArgs e)
        {
            Task4 task = new Task4();
            task.Show();
        }
    }
}

