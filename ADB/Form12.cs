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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            // dataGridView1.co
            dataGridView1.Columns.Add("Analys", "Analys");
            dataGridView1.Columns.Add("Analysnr", "Analysnr");
            dataGridView1.Columns.Add("Typ av analys", "Typ av analys");
            dataGridView1.Columns.Add("Anmärkning", "Anmärkning");
            

        }
    }
}
