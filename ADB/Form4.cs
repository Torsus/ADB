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
            dataGridView1.Rows[0].Cells[1].Value = "Baqar";
        }
    }
}
