using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ivs.system.DbFiles
{
    class Updatation
    {
        public  void updateUser(int id ,string Fname, string username, string email, string pass , Int16 Sts)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUser", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", Fname);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@Sts", Sts);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMsg(" Update successfully ", "success", "success");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
        }

        public void updateCat(int id, string name, Int16 Sts)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCat", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Status", Sts);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMsg(" Update successfully ", "success", "success");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
        }
        public void updateProduct(int id, string barchor, string name,int catId, float prize, Int16 Sts, DateTime? exDate = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProducts", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Barchor", barchor);
                cmd.Parameters.AddWithValue("@CatId", catId);
                cmd.Parameters.AddWithValue("@Prize",prize );
                if (exDate != null)
                {
                    cmd.Parameters.AddWithValue("@ExpiryDate", exDate);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ExpiryDate", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@Status", Sts);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMsg(" Update successfully ", "success", "success");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
        }

        public void updateSuppliers( int id ,string Company, string Employee, string Address, int phone1, Int16 Sts, int? phone2 = null, string NTN = null)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSuppliers", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompName", Company);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@EmpName", Employee);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 != null)
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                if (NTN != null)
                {
                    cmd.Parameters.AddWithValue("@NTN", NTN);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NTN", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@CompAddress", Address);
                cmd.Parameters.AddWithValue("@Status", Sts);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMsg("Updated successfully ", "success", "success");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
        }
        public void updateStock(int ProId, int qty)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proId", ProId);
                cmd.Parameters.AddWithValue("@qty", qty);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();

            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
        }
    }
}
