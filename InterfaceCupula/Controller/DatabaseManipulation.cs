using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using InterfaceCupula.Models;


namespace InterfaceCupula.Controller
{
    static class DatabaseManipulation
    {


       public static List<Usuario> DBUsers()
        {
            string connStr = "server=localhost;user=root;database=domo;port=3306;password=subruno98";
            MySqlConnection myConection = new MySqlConnection(connStr);
            List<Usuario> toReturn = new List<Usuario>();

            try
            {
                Console.WriteLine("Connectando ao banco");
                myConection.Open();

                string query = "SELECT * FROM usuarios";
                MySqlCommand newCmd = new MySqlCommand(query, myConection);

                MySqlDataReader rdr = newCmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + "-- " + rdr[1]);
                    toReturn.Add(new Usuario(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString()));
                }
                rdr.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            return toReturn;
        }

       
    }
}
