using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotelli
{
    internal class Yhdista
    {
        private readonly MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port 3306; username=root; password=; database=hotelli");

        public MySqlConnection OtaYhteys()
        { 
            return yhteys;
        }

        public void AvaaYhteys()
        {
            if(yhteys.State == System.Data.ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void SuljeYhteys()
        {
            if (yhteys.State == System.Data.ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
