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
            Datacontainer.analystyp = 1;
        }

        private void Skriv_Click(object sender, EventArgs e)
        {
            Datacontainer.first_time_price = true;
            Form6 f6 = new Form6();
            f6.Text = "Formulär 6";
            f6.ShowDialog(); // Shows Form4
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 1;
        }

        private void Radiobutton2_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 4;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 5;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 6;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 10;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 2;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 8;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 7;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Datacontainer.analystyp = 9;
        }
    }
}
