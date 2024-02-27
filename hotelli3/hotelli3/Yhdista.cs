using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace hotelli3
{
    internal class Yhdista
    {
        private readonly MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=hotelli");
        
        public MySqlConnection OtaYhteys() 
        {
            return yhteys;
        }

        public void AvaaYhteys()
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void SuljeYhteys() 
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
