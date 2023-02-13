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

            //      var Indikationlist = new System.Collections.ArrayList();
            Datacontainer.forskning = 0;
            Datacontainer.internbetalning = true;
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
            /////////////////Indikation
            Sql = "SELECT DISTINCT [Index],Indication FROM [dbo].[Indication] ORDER BY [Index]";

            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader5 = Datacontainer.command.ExecuteReader();
            //   var items = new[];
            // var items = new[];
            while (reader5.Read())
            {

                if (reader5.GetValue(1) != DBNull.Value)
                {
                    Datacontainer.Indication = (String)reader5.GetValue(1);


                    comboBox5.DisplayMember = "Text";
                    comboBox5.ValueMember = "Value";

                    var items = new[] {
                     new { Text = Datacontainer.Indication, Value = Datacontainer.Indication }
                    };
                    comboBox5.Items.Add(Datacontainer.Indication);
                   // Indikationlist.Add(Datacontainer.Indication);
                }

            }
            reader5.Close();
            comboBox5.SelectedIndex = 0;
            comboBox5.Refresh();
           

            ///////////////////////Result///////////////////////////////////////////////
            Sql = "SELECT DISTINCT [Index],Result FROM [dbo].[Result] ORDER BY Result";

            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader6 = Datacontainer.command.ExecuteReader();
            //   var items = new[];
            // var items = new[];
            while (reader6.Read())
            {

                if (reader6.GetValue(1) != DBNull.Value)
                {
                    Datacontainer.Result = (String)reader6.GetValue(1);


                    comboBox6.DisplayMember = "Text";
                    comboBox6.ValueMember = "Value";
                    comboBox7.DisplayMember = "Text";
                    comboBox7.ValueMember = "Value";

                    var items = new[] {
                     new { Text = Datacontainer.Result, Value = Datacontainer.Result }
                    };
                    comboBox6.Items.Add(Datacontainer.Result);
                    comboBox7.Items.Add(Datacontainer.Result);

                }

            }

            comboBox6.SelectedIndex = 0;
            comboBox6.Refresh();
            comboBox7.SelectedIndex = 0;
            comboBox7.Refresh();
            reader6.Close();

            ////Quality

            Sql = "SELECT DISTINCT [Index],Quality FROM [dbo].[Quality] ORDER BY Quality";

            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader7 = Datacontainer.command.ExecuteReader();
            //   var items = new[];
            // var items = new[];
            while (reader7.Read())
            {

                if (reader7.GetValue(1) != DBNull.Value)
                {
                    Datacontainer.Quality = (String)reader7.GetValue(1);


                    comboBox8.DisplayMember = "Text";
                    comboBox8.ValueMember = "Value";
                  

                    var items = new[] {
                     new { Text = Datacontainer.Quality, Value = Datacontainer.Quality }
                    };
                    comboBox8.Items.Add(Datacontainer.Quality);

                }

            }

            comboBox8.SelectedIndex = 0;
            comboBox8.Refresh();
            reader7.Close();


            /////Frågeställning

            Sql = "SELECT DISTINCT [Index],Diagnosis FROM [dbo].[Diagnosis List] ORDER BY Diagnosis";

            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader8 = Datacontainer.command.ExecuteReader();
            //   var items = new[];
            // var items = new[];
            while (reader8.Read())
            {

                if (reader8.GetValue(1) != DBNull.Value)
                {
                    Datacontainer.Diagnos= (String)reader8.GetValue(1);


                    comboBox9.DisplayMember = "Text";
                    comboBox9.ValueMember = "Value";


                    var items = new[] {
                     new { Text = Datacontainer.Diagnos, Value = Datacontainer.Diagnos }
                    };
                    comboBox9.Items.Add(Datacontainer.Diagnos);

                }

            }

            comboBox9.SelectedIndex = 0;
            comboBox9.Refresh();
            reader8.Close();

            /////Betalningsansvarig/////////////////////////////////////////////

            Sql = "SELECT DISTINCT [Index],[Customer Name],CustomerID FROM [dbo].[View Accountable] where Internal = 1 ORDER BY [Customer Name]";

            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            SqlDataReader reader9 = Datacontainer.command.ExecuteReader();
            //   var items = new[];
            // var items = new[];
            while (reader9.Read())
            {

                if (reader9.GetValue(1) != DBNull.Value)
                {
                    Datacontainer.Betalningsansvarig = (String)reader9.GetValue(1);


                    comboBox10.DisplayMember = "Text";
                    comboBox10.ValueMember = "Value";


                    var items = new[] {
                     new { Text = Datacontainer.Betalningsansvarig, Value = Datacontainer.Betalningsansvarig }
                    };
                    comboBox10.Items.Add(Datacontainer.Betalningsansvarig);

                }

            }

            comboBox10.SelectedIndex = 0;
            comboBox10.Refresh();
            reader9.Close();



            //////////////////////////Analystyp/////////////////////////////////

            switch (Datacontainer.analystyp)
            {
                case 1:
                    Sql = "SELECT [Index],[Type] FROM [dbo].[Type Blood] ORDER BY [Type]";
                    Datacontainer.tabell = "[dbo].[Type Blood]";
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
                    Sql = "SELECT DISTINCT [Index],[Type] FROM [dbo].[Type Amnion] ORDER BY [Type]";
                    break;
                case 8:
                    Sql = "SELECT DISTINCT [Index],[Type] FROM [dbo].[Type Fibroblast] ORDER BY [Type]";
                    break;
                case 9:
                    Sql = "SELECT DISTINCT [Index],[Type] FROM [dbo].[Type Chorion] ORDER BY [Type]";
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

            Datacontainer.fortur = 0;
            Datacontainer.indikation = 1;
           
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

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (Datacontainer.internbetalning)
            {
                Datacontainer.internbetalning = false;
                String Sql;
                Sql = "SELECT DISTINCT [Index],[Customer Name],CustomerID FROM [dbo].[View Accountable] where Internal = 0 ORDER BY [Customer Name]";

                comboBox10.Items.Clear();
                comboBox10.ResetText();

                Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
                Datacontainer.command.CommandType = CommandType.Text;
                SqlDataReader reader9 = Datacontainer.command.ExecuteReader();
                //   var items = new[];
                // var items = new[];
                while (reader9.Read())
                {

                    if (reader9.GetValue(1) != DBNull.Value)
                    {
                        Datacontainer.Betalningsansvarig = (String)reader9.GetValue(1);


                        comboBox10.DisplayMember = "Text";
                        comboBox10.ValueMember = "Value";


                        var items = new[] {
                     new { Text = Datacontainer.Betalningsansvarig, Value = Datacontainer.Betalningsansvarig }
                    };
                        comboBox10.Items.Add(Datacontainer.Betalningsansvarig);

                    }

                }

                comboBox10.SelectedIndex = 0;
                comboBox10.Refresh();
                reader9.Close();



            }
            else
            {
                Datacontainer.internbetalning = true;
                String Sql;
                Sql = "SELECT DISTINCT [Index],[Customer Name],CustomerID FROM [dbo].[View Accountable] where Internal = 1 ORDER BY [Customer Name]";

                comboBox10.Items.Clear();
                comboBox10.ResetText();

                Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
                Datacontainer.command.CommandType = CommandType.Text;
                SqlDataReader reader9 = Datacontainer.command.ExecuteReader();
                //   var items = new[];
                // var items = new[];
                while (reader9.Read())
                {

                    if (reader9.GetValue(1) != DBNull.Value)
                    {
                        Datacontainer.Betalningsansvarig = (String)reader9.GetValue(1);


                        comboBox10.DisplayMember = "Text";
                        comboBox10.ValueMember = "Value";


                        var items = new[] {
                     new { Text = Datacontainer.Betalningsansvarig, Value = Datacontainer.Betalningsansvarig }
                    };
                        comboBox10.Items.Add(Datacontainer.Betalningsansvarig);

                    }

                }

                comboBox10.SelectedIndex = 0;
                comboBox10.Refresh();
                reader9.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ///Inskrivning!
            if (comboBox3.SelectedItem.ToString().Length < 1)
            {
                MessageBox.Show("Typ av prov måste väljas!");
            }
            else
            {
                /////Inskrivning
                String Sql;

                String Sql2;
                Sql2 = "Select * from dbo.[Patients] where [Personal number] = '" + Datacontainer.personnummer + "'";
                Datacontainer.command = new SqlCommand(Sql2, Datacontainer.cnn);
                Datacontainer.command.CommandType = CommandType.Text;
                SqlDataReader reader2 = Datacontainer.command.ExecuteReader();
                reader2.Read();
                // int personnummerindex;
                Datacontainer.personnummerindex = (int)reader2.GetValue(0);

                reader2.Close();

                Sql = "sp_insert_enkel2";
                Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
                Datacontainer.command.CommandType = CommandType.StoredProcedure;



                Datacontainer.command.Parameters.Add(new SqlParameter("@tabell", Datacontainer.tabell));
                Datacontainer.command.Parameters.Add(new SqlParameter("@analystyp", Datacontainer.analystyp));
                Datacontainer.command.Parameters.Add(new SqlParameter("@patient", Datacontainer.personnummerindex));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Signature", textBox1.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@SubmitterName", textBox3.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Submitter", textBox2.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Type", Datacontainer.analystyp));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Urgent", Datacontainer.fortur));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Arriveddate_s", textBox6.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@InvoiceDate_s", textBox7.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Indication", Datacontainer.indikation));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Research", Datacontainer.forskning));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Savedmaterial", 0));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Canister", "NULL"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Box", "NULL"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Number", "NULL"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Remark", textBox8.Text));
                Datacontainer.command.Parameters.Add(new SqlParameter("@OrdererInternal", 1));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Orderer", 1));
                Datacontainer.command.Parameters.Add(new SqlParameter("@AccountableInternal", 1));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Accountable", 1));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Result", 7));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Quality", 8));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Diagnosis", "fel"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@McKusick_s", "12"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Answered", 1));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Price_s", "1000"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@AnsweredDate_s", "20230211"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@InvoiceNr", 10));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Doctor", 11));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Metaphase", "yyy"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Locked", 1));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Change", "zzz"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@ResultInternal", "tt"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Prenatal", 1));
                Datacontainer.command.Parameters.Add(new SqlParameter("@ResultInternal2", 100));
                Datacontainer.command.Parameters.Add(new SqlParameter("@Family", 200));
                Datacontainer.command.Parameters.Add(new SqlParameter("@CareDate_s", "20121003"));
                Datacontainer.command.Parameters.Add(new SqlParameter("@SpecimenType", "xxx"));

                Datacontainer.dataReader = Datacontainer.command.ExecuteReader();
                Datacontainer.dataReader.Close();
                MessageBox.Show("Inskrivning klar!");
            }
                
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(Datacontainer.fortur == 0)
            {
                Datacontainer.fortur = 1;
            }
            else if(Datacontainer.fortur == 1)
            {
                Datacontainer.fortur = 0;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           // int indikation = comboBox2.Items.IndexOf
             int index = comboBox5.FindString(comboBox5.SelectedItem.ToString());
            index++;
          //  comboBox5.SelectedIndex = index;
            Datacontainer.indikation = index;

            //String Sql;
            //Sql = "Select [Index],Indication from dbo.Indication where dbo.[Indication].Indication = " + comboBox2.SelectedItem.ToString() + "";

            //Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            //Datacontainer.command.CommandType = CommandType.Text;
            //SqlDataReader reader10 = Datacontainer.command.ExecuteReader();

            //Datacontainer.indikation = (int)reader10.GetValue(0);
            //reader10.Close();




        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(Datacontainer.forskning == 0)
            {
                Datacontainer.forskning = 1;
            }
            else if(Datacontainer.forskning == 1)
            {
                Datacontainer.forskning = 0;
            }
        }
    }
}
