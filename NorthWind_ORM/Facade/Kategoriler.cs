using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NorthWind_ORM.Entity;

namespace NorthWind_ORM.Facade
{
    public class Kategoriler
    {
        //Select
        public static DataTable Select()
        {
            

        SqlDataAdapter adp = new SqlDataAdapter("prc_Kategoriler_Select", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
       
        //Insert
        public static bool Insert(Kategori k)
        {
            SqlCommand cmd = new SqlCommand("KategorilerYeni", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kategoriAdi", k.KategoriAdi);
            cmd.Parameters.AddWithValue("@tanimi", k.Tanimi);

            return Tools.ExecuteNonQuery(cmd);

        }


    }
}
