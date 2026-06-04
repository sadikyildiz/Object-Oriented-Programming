using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    internal class VeriTabaniIslemleri
    {
        string baglanticumlesi = ConfigurationManager.ConnectionStrings["KutuphaneBaglantiCumlesi"].ConnectionString;
        public MySqlConnection baglan()
        {
            MySqlConnection baglanti=new MySqlConnection(baglanticumlesi);
            MySqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}
