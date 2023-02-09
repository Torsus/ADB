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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();


            String Sql;

            Sql = "Select * from [dbo].[Doctor] order by Doctor";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader = Datacontainer.command.ExecuteReader();
            //   var items = new[];
            // var items = new[];
            while (reader.Read())
            {
                
                if (reader.GetValue(1) != DBNull.Value)
                {
                    Datacontainer.Doctor = (String)reader.GetValue(1);
                    

                    comboBox2.DisplayMember = "Text";
                    comboBox2.ValueMember = "Value";

                    var items = new[] {
                     new { Text = Datacontainer.Doctor, Value = Datacontainer.Doctor }
                    };
                    comboBox1.Items.Add(Datacontainer.Doctor);
                    
                }
             
            }
           
            comboBox1.SelectedIndex = 0;
            comboBox1.Refresh();
            reader.Close();

            ///Avd/sjukhus
            ///
          //  Sql = "Select [Index],[Arrived Date],Analysistype,Diagnosis,[Specimen Type],Price,Type,Result from dbo.[Analysis Blood] where dbo.[Analysis Blood].Patient = " + index + "";


            Sql = "SELECT DISTINCT [Index],[Customer name],CustomerID FROM [dbo].Orderer ";
            Sql+= "WHERE Internal = 1 ORDER BY [Customer name]";

            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader2 = Datacontainer.command.ExecuteReader();
            //   var items = new[];
            // var items = new[];
            while (reader2.Read())
            {

                if (reader2.GetValue(1) != DBNull.Value)
                {
                    Datacontainer.Customer_name = (String)reader2.GetValue(1);


                    comboBox2.DisplayMember = "Text";
                    comboBox2.ValueMember = "Value";

                    var items = new[] {
                     new { Text = Datacontainer.Customer_name, Value = Datacontainer.Customer_name }
                    };
                    comboBox2.Items.Add(Datacontainer.Customer_name);

                }

            }

            comboBox2.SelectedIndex = 0;
            comboBox2.Refresh();
            reader2.Close();

            /////////////////////////////////////////
            Sql = "SELECT [Idx],[Specimen Type] FROM [dbo].[Specimen Type] ORDER BY [Specimen Type]";

            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader3 = Datacontainer.command.ExecuteReader();
            //   var items = new[];
            // var items = new[];
            while (reader3.Read())
            {

                if (reader3.GetValue(1) != DBNull.Value)
                {
                    Datacontainer.Spicemen_type = (String)reader3.GetValue(1);


                    comboBox3.DisplayMember = "Text";
                    comboBox3.ValueMember = "Value";

                    var items = new[] {
                     new { Text = Datacontainer.Spicemen_type, Value = Datacontainer.Spicemen_type }
                    };
                    comboBox3.Items.Add(Datacontainer.Spicemen_type);

                }

            }

            comboBox3.SelectedIndex = 0;
            comboBox3.Refresh();
            reader3.Close();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          //  Form7.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
    }
}
