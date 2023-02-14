using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Mastermind_VideoIgra
{
    internal class Class1
    {
        class Konekcija2
        {
            static public SqlConnection Connect()
            {
                string CS;
                CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
                // MessageBox.Show(CS);
                SqlConnection conn = new SqlConnection(CS);
                return conn;
            }
            static public DataTable Unos(string Komanda)
            {
                DataTable Tabela = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(Komanda, Konekcija2.Connect());
                adapter.Fill(Tabela);
                return Tabela;
            }
        }
    }
}
