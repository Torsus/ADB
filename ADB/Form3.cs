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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String Sql, Output = "";
            int antal;
            Sql = "Select count(*) from dbo.[Analysis Blood]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox2.Text = antal.ToString();
            ////////////////////////////////////Fosterdiagnostik////////////
            Sql = "Select count(*) from dbo.[Analysis Foetus]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox3.Text = antal.ToString();
            ////////////////////////////////FISH///////////////////////////
            Sql = "Select count(*) from dbo.[Analysis FISH]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox4.Text = antal.ToString();
            ////////////////////////////DNA///////////////////////////////
            Sql = "Select count(*) from dbo.[Analysis DNA]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox5.Text = antal.ToString();
            /////////////////////////Tumör DNA////////////////////////////
            Sql = "Select count(*) from dbo.[Analysis Tumor]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox6.Text = antal.ToString();
            ////////////////////////Vägledning/////////////////////////////
            Sql = "Select count(*) from dbo.[Analysis Counselling]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox7.Text = antal.ToString();
            ////////////////////////Amion/////////////////////////////////
            Sql = "Select count(*) from dbo.[Analysis Amnion]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox8.Text = antal.ToString();
            //////////////////////Fibroblaster////////////////////////////
            Sql = "Select count(*) from dbo.[Analysis Fibroblast]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox9.Text = antal.ToString();
            /////////////////////Moderkaka///////////////////////////////
            Sql = "Select count(*) from dbo.[Analysis Chorion]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox10.Text = antal.ToString();
            ///////////////////Remisser/////////////////////////////////
            Sql = "Select count(*) from dbo.[Analysis Referral]";
            Datacontainer.command = new SqlCommand(Sql, Datacontainer.cnn);
            Datacontainer.command.CommandType = CommandType.Text;
            antal = (int)Datacontainer.command.ExecuteScalar();
            textBox11.Text = antal.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datacontainer.personnummer = textBox1.Text + textBox12.Text;
            Form4 f4 = new Form4();
            f4.ShowDialog(); // Shows Form4
        }
    }
}
