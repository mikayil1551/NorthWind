using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace NorthWind.ORM.Facade
{
    class Kategoriler
    {

        //Select Metotu
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("UrunListele",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
    

        }
        //Insert
        //Update
        //Delete
        
    }
}
