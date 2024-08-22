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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          //  Form1 obj = (Form1)Application.OpenForms["Form1"];
          //  obj.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog(); // Shows Form2
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
