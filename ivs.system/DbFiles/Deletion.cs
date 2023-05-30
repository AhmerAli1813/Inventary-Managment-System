using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ivs.system.DbFiles
{
    class Deletion
    {
        public  void deleting(object val , string proc , string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, val);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMsg("delecting successfully ", "success", "success");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }

        }
    }
}
