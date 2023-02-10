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
            //////////////////////////7Analystyp/////////////////////////////////

            switch(Datacontainer.analystyp)
            {
                case 1:
                    Sql = "SELECT [Index],[Type] FROM [dbo].[Type Blood] ORDER BY [Type]";
                    break;
                case 2:
                    Sql = "SELECT [Index],[Type] FROM [dbo].[Type Foetus] ORDER BY [Type]";
                    break;
                case 3:
                    Sql = "SELECT DISTINCT [Index],[Type] FROM [dbo].[Type FISH] ORDER BY [Type]";
                    break;
                case 4:
                    Sql = "SELECT DISTINCT [Index],[Type] FROM [dbo].[Type DNA] ORDER BY [Type]";
                    break;
                case 5:
                    Sql = "SELECT DISTINCT [Index],[Type] FROM [dbo].[Type Tumor] ORDER BY [Type]";
                    break;
                case 6:
                    Sql = "SELECT DISTINCT [Index],[Type] FROM [dbo].[Type Counselling] ORDER BY [Type]";
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    Sql = "SELECT DISTINCT [Index],[Type] FROM [dbo].[Type Referral] ORDER BY [Type]";
                    break;

            }

            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader4 = Datacontainer.command.ExecuteReader();
            //   var items = new[];
            // var items = new[];
            while (reader4.Read())
            {
                String typ;
                typ = "x";
                if ((reader4.GetValue(1) != DBNull.Value) && reader4.GetValue(1).ToString().Length > 0)
                {
                    typ = (String)reader4.GetValue(1);
                   
                }

                if (reader4.GetValue(1) != DBNull.Value && typ[0] != 'ö' && typ[0] != 'Ö')
                {
                    Datacontainer.analystyp_klartext = (String)reader4.GetValue(1);


                    comboBox4.DisplayMember = "Text";
                    comboBox4.ValueMember = "Value";

                    var items = new[] {
                     new { Text = Datacontainer.analystyp_klartext, Value = Datacontainer.analystyp_klartext }
                    };
                    comboBox4.Items.Add(Datacontainer.analystyp_klartext);

                }

            }

            comboBox4.SelectedIndex = 0;
            comboBox4.Refresh();
            reader4.Close();


           
        }

        /// 
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox4.SetBounds(226, 265, 182, 24);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
    }
}
