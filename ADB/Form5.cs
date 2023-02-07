using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
           // textBox8.Text = "0";
           // textBox8.Update();
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

            dataGridView1.Columns.Add("Inkommande datum", "Inkommande datum");
            dataGridView1.Columns.Add("Analystyp", "Analystyp");
            dataGridView1.Columns.Add("Arbetsnr", "Arbetsnr");
            dataGridView1.Columns.Add("Frågeställning", "Frågeställning");
            dataGridView1.Columns.Add("Typ av analys", "Typ av analys");
            dataGridView1.Columns.Add("Resultat", "Resultat");
            dataGridView1.Columns.Add("Typ av prov", "Typ av prov");
            dataGridView1.Columns.Add("pris", "pris");

            String Sql;
            Sql = "Select * from dbo.[Patients] where [Personal number] = '" + Datacontainer.personnummer + "'";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader = Datacontainer.command.ExecuteReader();
            reader.Read();
            int index;
             index = (int)reader.GetValue(0);

            //Now, we have the correct indexnumber from the patient...
            reader.Close();
            ///new reader...
            ///
            Sql = "Select * from dbo.[Analysis Blood] where dbo.[Analysis Blood].Patient = " + index + "";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader2 = Datacontainer.command.ExecuteReader();
            int varv;
            varv = -1;
            List<int> list = new List<int>();
            while (reader2.Read())
            {
                varv++;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[varv].Cells[0].Value = reader2.GetValue(1);
                dataGridView1.Rows[varv].Cells[1].Value = "B";
                dataGridView1.Rows[varv].Cells[2].Value = reader2.GetValue(0);
                dataGridView1.Rows[varv].Cells[3].Value = reader2.GetValue(2);
                list.Add((int)reader2.GetValue(6));
                ///Now we must find out the type////
                //Sql = "select * from dbo.[type Blood] where index = " + reader2.GetValue(6) + "";
                //Datacontainer.command2 = new SqlCommand(Sql, Datacontainer.cnn2);
                //Datacontainer.command2.CommandType = CommandType.Text;
                //SqlDataReader reader3 = Datacontainer.command.ExecuteReader();
                //reader3.Read();
                //dataGridView1.Rows[varv].Cells[4].Value = reader3.GetValue(1);
            }
            reader2.Close();
          //  Datacontainer.command2 = new SqlCommand(Sql, Datacontainer.cnn);
          //  Datacontainer.command2.CommandType = CommandType.Text;
         //   SqlDataReader reader3 = Datacontainer.command.ExecuteReader();
            for (int a=0;a<=varv;a++)
            {
                int b;
                Sql = "select * from dbo.[Type Blood] where dbo.[Type Blood].[Index] = " + list[a] + "";
                Datacontainer.command2 = new SqlCommand(Sql, Datacontainer.cnn);
                Datacontainer.command2.CommandType = CommandType.Text;
                SqlDataReader reader3 = Datacontainer.command2.ExecuteReader();
                reader3.Read();
                dataGridView1.Rows[a].Cells[4].Value = reader3.GetValue(1);
                reader3.Close();
            }
          //  reader3.Close();
            //String Sql;
            //Sql = SELECT[dbo_View All Analyses].[Type Name], Count([dbo_View All Analyses].Index) AS Ordered, " & _
            //     "COUNT([dbo_View All Analyses].[Answered Date]) AS Answered, 0 AS Invoiced, " & _
            //     "SUM([dbo_View All Analyses].Price) AS Debited " & _
            //     "INTO [Temp Statistics Accountable] " & _
            //     "FROM [dbo_View All Analyses] " & _
            //     "WHERE ((([dbo_View All Analyses].[Customer Name]) " & _
            //     "LIKE """ & Forms![Form Statistics Accountable]![Accountable] & """) " & _
            //     "AND (([dbo_View All Analyses].[Arrived date]) >= [Forms]![Form Statistics Accountable]![Low] " & _
            //     "AND ([dbo_View All Analyses].[Arrived date]) <= [Forms]![Form Statistics Accountable]![High] " & _
            //     "AND ([dbo_View All Analyses].[Price] > 0)) " & _
            //     "GROUP BY [dbo_View All Analyses].[Type Name];"
            //Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            //Datacontainer.command.CommandType = CommandType.Text;
            ////  Datacontainer.command.Parameters.AddWithValue("[Personal number]",Datacontainer.personnummer);
            //SqlDataReader reader = Datacontainer.command.ExecuteReader();
            //reader.Read();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int famnummer;
            if (textBox3.Text.Length < 1)
            {
                MessageBox.Show("Du måste skriva in efternamn!");
            }
            if (textBox7.Text.Length < 1)
            {
                MessageBox.Show("Du måste skriva in familjenamn!");
            }
            //if (textBox8.Text.Length < 1)
            //{
            //    MessageBox.Show("Du måste skriva in familjenummer!");
            //}
            //Förbered anrop store procedure
            famnummer = 0;
          //  textBox8.Text = "0";
            Boolean giltigt_famnummer = true;
            //  do
            //  {
            if (textBox8.Text.Length > 0)
            {
                try
                {
                    famnummer = Int32.Parse(textBox8.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Du måste ange giltigt numeriskt värde för familjenummer!");
                    giltigt_famnummer = false;
                }
            }
            else
            {
                famnummer = 0;
            }
            // } while (!giltigt_famnummer);
            // Output: Unable to parse ''
            if (giltigt_famnummer)
            {
                String Sql;
                int VFChecked = 0;
                int IdxPVFChecked = 0;
                Sql = "sp_insert_patient";
                Datacontainer.command = new System.Data.SqlClient.SqlCommand(Sql, Datacontainer.cnn);
                Datacontainer.command.CommandType = CommandType.StoredProcedure;
                Datacontainer.command.Parameters.Add(new SqlParameter("@personnummer", textBox1.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Familyname", textBox3.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@FirstName", textBox4.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Indexpersonalnumber", textBox1.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Other_s", "NULL"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Signature", textBox5.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Family", famnummer));
                Datacontainer.command.Parameters.Add(new SqlParameter("@VFChecked", VFChecked));
                Datacontainer.command.Parameters.Add(new SqlParameter("@IdxPVFChecked", IdxPVFChecked));
                Datacontainer.dataReader = Datacontainer.command.ExecuteReader();
                Datacontainer.dataReader.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
