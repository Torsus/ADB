using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADB
{
    class Datacontainer
    {
        public static string connectionString;
        public static string anvandarnamn;
        public static string losen;
        public static string connectsource;
        public static string connectstring;
        public static SqlConnection cnn;
        public static SqlCommand command,command2;
        public static SqlDataReader dataReader;
        public static string personnummer;
        public static string Familyname;
        public static string fornamn;
        public static string Signature;
        public static string Familjenummer;
        public static string Doctor;
        public static string Customer_name;
        public static string Spicemen_type;
        public static string Indication;
        public static string Result;
        public static Boolean knappdisable1;
        public static Boolean knappdisable2;
        public static int analystyp;
        public static string analystyp_klartext;
        //  public Form1 f1 = new Form1();
        // public Form2 f2 = new Form2();
    }
}
