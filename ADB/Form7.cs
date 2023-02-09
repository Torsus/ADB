using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Skriv_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Text = "Formulär 6";
            f6.ShowDialog(); // Shows Form4
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
