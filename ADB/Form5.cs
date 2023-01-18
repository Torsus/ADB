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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.Form5_Load);
          //  textBox1.Text = Datacontainer.personnummer;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
           textBox1.Text = Datacontainer.personnummer;
            textBox2.Text = Datacontainer.personnummer;
            textBox3.Text = Datacontainer.Familyname;
            textBox4.Text = Datacontainer.fornamn;
            textBox5.Text = Datacontainer.Signature;
            textBox7.Text = Datacontainer.Familyname;

            textBox8.Text = (String)(Datacontainer.Familjenummer);

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
