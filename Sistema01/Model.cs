using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Sistema01
{
    class Model
    {
        public static string Nombre;
        public static string Apellido;
        public static string Fecha;
        public static string Edad;
        public static string Sexo;
        public static string Telefono;
        public static string Correo;
        public static string Estado;
        public static string Municipio;
        //SANTANA MIRANDA FEDRA PAULINA
        //RAMIREZ GASPAR KARLA
        //CATARINO ROBLEDO LUCIA
        //AVILA MORALES RICARDO
        //IBM901

        public static void ConsultaDato()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=Grupo951;SSLMode=None";
            string query = "SELECT * FROM clientes";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), };
                        
                        var nombreLabel = row[1];
                        var apellidoLabel = row[2];
                        var fechaLabel = row[3];
                        var edadLabel = row[4];
                        var sexoLabel = row[5];
                        var telefonoLabel = row[6];
                        var correoLabel = row[7];
                        var estadoLabel = row[8];
                        var municipioLabel = row[9];
                        
                        Nombre = nombreLabel;
                        Apellido = apellidoLabel;
                        Fecha = fechaLabel;
                        Edad = edadLabel;
                        Sexo = sexoLabel;
                        Telefono = telefonoLabel;
                        Correo = correoLabel;
                        Estado = estadoLabel;
                        Municipio = municipioLabel;
                        


                    }
                }
                else
                {
                    Console.WriteLine("Fallo obteniendo Datos");
                }
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }


        }

    }
}
