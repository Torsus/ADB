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
            for (int a = 0; a < Datacontainer.Indexarray.Count; a++) {
                dataGridView1.Rows.Add("Value for column#1"); // [,"column 2",...]
                dataGridView1.Rows[a].Cells[0].Value = Datacontainer.Indexarray[a];
                dataGridView1.Rows[a].Cells[1].Value = Datacontainer.personnummerarray[a];
                dataGridView1.Rows[a].Cells[2].Value = Datacontainer.Familynamearray[a];
                dataGridView1.Rows[a].Cells[3].Value = Datacontainer.Fornamnarray[a];
            }
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
