using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test256
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //První změna
            MessageBox.Show("Sdělení 1");
            //Druhá změna
            MessageBox.Show("Sdělení 1");
            //Třetí změna
            MessageBox.Show("Sdělení 3");

        }
    }
}
