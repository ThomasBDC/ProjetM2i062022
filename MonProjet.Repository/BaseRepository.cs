using MySql.Data.MySqlClient;
using System;

namespace MonProjet.Repository
{
    public class BaseRepository
    {
        public BaseRepository()
        {

        }
        private readonly string ConnectionString = "server=mysql-devtechwatch.alwaysdata.net;database=devtechwatch_bddprojetm2i;uid=267041;pwd=NYV8e@6u4$j4Wc7Eh;";

        public MySqlConnection OpenConnexion()
        {
            MySqlConnection cnn = new MySqlConnection(ConnectionString);
            try
            {
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
