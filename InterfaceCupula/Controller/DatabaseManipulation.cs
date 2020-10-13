using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using InterfaceCupula.Models;
using InterfaceCupula.Enums;

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
                    toReturn.Add(new Usuario(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), (TiposDeUsuarios)Enum.Parse(typeof(Enums.TiposDeUsuarios), rdr[3].ToString()) ));
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            myConection.Close();
            return toReturn;
        }

       public static bool userRegister(Usuario user)
        {
            string connStr = "server=localhost;user=root;database=domo;port=3306;password=subruno98";
            MySqlConnection myConection = new MySqlConnection(connStr);

            try
            {
                myConection.Open();
                 
                string query = "SELECT * FROM usuarios where nome = '" + user.Nome + "'and senha = MD5('" + user.Senha + "')" ;
                MySqlCommand newCmd = new MySqlCommand(query, myConection);

                MySqlDataReader rdr = newCmd.ExecuteReader();

                if (rdr.Read() != false)          //se o banco já possui algum  usuário com as mesmas credenciais
                {
                    return true;
                    
                }
                else
                {
                    
                    rdr.Close();
                    query = "INSERT INTO usuarios (nome, senha, TipoAcesso) VALUES('" + user.Nome + "', MD5('" + user.Senha + "'), " + (int)(user.TipoUsuario) + ")";
                    
                    newCmd = new MySqlCommand(query, myConection);
                    newCmd.Prepare();
                    newCmd.ExecuteNonQuery();

                    myConection.Close();
                    return false;
                }
                
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }

            return false;
        }

        public static List<ConfigMqtt> DBConfigMqtt()
        {
            List<ConfigMqtt> toReturn = new List<ConfigMqtt>();

            string connStr = "server=localhost;user=root;database=domo;port=3306;password=subruno98";
            MySqlConnection myConection = new MySqlConnection(connStr);
           
            try
            {
                Console.WriteLine("Connectando ao banco");
                myConection.Open();

                string query = "SELECT * FROM config_mqtt";
                MySqlCommand newCmd = new MySqlCommand(query, myConection);

                MySqlDataReader rdr = newCmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + "-- " + rdr[1]);
                    toReturn.Add(new ConfigMqtt(int.Parse(rdr[0].ToString()), rdr[1].ToString()));
                }
                 rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            myConection.Close();
            return toReturn;
        }

        public static void changeConfigMqtt(int id, string newVal)
        {

            string connStr = "server=localhost;user=root;database=domo;port=3306;password=subruno98";
            MySqlConnection myConection = new MySqlConnection(connStr);
            string query;
            MySqlCommand newCmd;

            try
            {
                myConection.Open();
                
        
                query = "update config_mqtt" +
                        " set valor = '" + newVal + "'" +
                        "where idconfig_mqtt = " + id;

                newCmd = new MySqlCommand(query, myConection);
                newCmd.Prepare();
                newCmd.ExecuteNonQuery();

                myConection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
