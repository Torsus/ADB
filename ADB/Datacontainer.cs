using System;
using System.Collections;
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
        public static int personnummerindex;
        public static string tabell;
        public static string Familyname;
        public static string fornamn;
        public static string Signature;
        public static string Familjenummer;
        public static string Doctor;
        public static string Customer_name;
        public static string Spicemen_type;
        public static string Indication;
        public static string Result;
        public static string Quality;
        public static int Qualityint;
        public static int besvarad;
        public static string Diagnos;
        public static string Betalningsansvarig;
        public static Boolean knappdisable1;
        public static Boolean knappdisable2;
        public static int analystyp;
        public static int fortur;
        public static int indikation;
        public static int forskning;
        public static string analystyp_klartext;
        public static bool internbetalning;
        public static int orderer_internal;
        public static int betalansvarnummer;
        public static int Resultat;
        //  public Form1 f1 = new Form1();
        // public Form2 f2 = new Form2();
    }
}
