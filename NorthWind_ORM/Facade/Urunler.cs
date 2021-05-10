using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind_ORM.Entity;

namespace NorthWind_ORM.Facade
{
    public class Urunler
    {
        //Select Metotu
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Urunler_Select", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }
        //Insert Metotu
        public static bool Insert(Urun u)
        {
            SqlCommand cmd = new SqlCommand("UrunEkle",Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@urunAdi", u.UrunAdi);
            cmd.Parameters.AddWithValue("@birimfiyati", u.BirimFiyati);
            cmd.Parameters.AddWithValue("@hedefStokDuzeyi", u.Stok);
            cmd.Parameters.AddWithValue("@kId", u.KategoriID);
            cmd.Parameters.AddWithValue("@tId", u.TedarikciID);

            return Tools.ExecuteNonQuery(cmd);
           

        }
    }
}
