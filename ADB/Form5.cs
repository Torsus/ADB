﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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
            if(textBox3.Text.Length < 1)
            {
                MessageBox.Show("Du måste skriva in efternamn!");
            }
        }
    }
}
