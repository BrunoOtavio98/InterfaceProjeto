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


       public static String DBUsers()
        {
            string connStr = "server=localhost;user=root;database=domo;port=3306;password=subruno98";
            MySqlConnection myConection = new MySqlConnection(connStr);
            String toReturn = null;

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
                    toReturn = rdr[1].ToString();
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
