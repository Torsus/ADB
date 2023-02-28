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
            Int32 selectedRowCount =
                 dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                Datacontainer.personnummer = row.Cells[1].Value.ToString();
                Datacontainer.Familyname = row.Cells[2].Value.ToString();
                Datacontainer.fornamn = row.Cells[3].Value.ToString();
                //...
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void selectedRowsButton_Click(object sender, System.EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                //...
            }
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }
    }
}
