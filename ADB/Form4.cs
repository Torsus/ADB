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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // dataGridView1.co
            dataGridView1.Columns.Add("Index", "Index");
            dataGridView1.Columns.Add("Personnummer", "Personnummer");
            dataGridView1.Columns.Add("Efternamn", "Efternamn");
            dataGridView1.Columns.Add("Fornamn", "Fornamn");
            dataGridView1.Rows.Add("Value for column#1"); // [,"column 2",...]
            dataGridView1.Rows[0].Cells[0].Value = "1";
            dataGridView1.Rows[0].Cells[1].Value = Datacontainer.personnummer;
            dataGridView1.Rows[0].Cells[2].Value = Datacontainer.Familyname;
            dataGridView1.Rows[0].Cells[3].Value = Datacontainer.fornamn;
            if (Datacontainer.knappdisable1)
            {
                button1.Enabled = false;
            }
            if (Datacontainer.knappdisable2)
            {
                button2.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Text = "Formulär 5";
            f5.ShowDialog(); // Shows Form4
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Text = "Formulär 5";
            f5.ShowDialog(); // Shows Form4
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
