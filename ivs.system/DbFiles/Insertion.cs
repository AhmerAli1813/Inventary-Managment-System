using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ivs.system
{
    class Insertion
    {
        public  void insertUser(string Fname , string username , string email , string pass ,Int16 sts)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUser" , Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Fname);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email) ;
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@sts", sts);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMsg(Fname+ "insert successfully ", "success", "success");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
        }
        public void insertCat(string name, Int16 sts)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCat", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Status", sts);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMsg("insert successfully ", "success", "success");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
        }
        public void insertProduct(string barchor, string name, int catId, float prize, Int16 Sts, DateTime? exDate=null)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProducts", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Barchor", barchor);
                cmd.Parameters.AddWithValue("@CatId", catId);
                cmd.Parameters.AddWithValue("@Prize", prize);
                if(exDate != null)
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
                Mainclass.showMsg("insert successfully ", "success", "success");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
        }
        public void insertSuppliers(string Company, string Employee, string Address, int phone1, Int16 Sts, int? phone2 =null, string NTN=null)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSuppliers", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompName",Company );
                cmd.Parameters.AddWithValue("@EmpName", Employee);
                cmd.Parameters.AddWithValue("@phone1",phone1 );
                if (phone2 != null)
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2 );
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
                cmd.Parameters.AddWithValue("@CompAddress",Address );
                cmd.Parameters.AddWithValue("@Status", Sts);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMsg("insert successfully ", "success", "success");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
        }
        private Int64 PurcInvId;
        public Int64 insertPurchaseInvoice( DateTime Date ,int UserId , int SupplierId)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurInv", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Date",Date);
                cmd.Parameters.AddWithValue("@fk_Uid",UserId);
                cmd.Parameters.AddWithValue("@fk_SuppId", SupplierId);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "st_getPurInvLastID";
                cmd.Parameters.Clear();
                PurcInvId = Convert.ToInt64(cmd.ExecuteScalar());

                Mainclass.con.Close();
                         }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
            return PurcInvId;
        }
        private int CountInsert ;
        public int insertPurchaseInvoiceDetails(Int64 PurchuaseInvID , int ProId ,int Qty,float PrizePerUnit)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPureInvDetails", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fk_PInv_Id", PurchuaseInvID);
                cmd.Parameters.AddWithValue("@fk_Pro_Id", ProId);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@PrizePerUnit", PrizePerUnit);
                Mainclass.con.Open();
                CountInsert = cmd.ExecuteNonQuery(); // this function  used when we now only                  
                Mainclass.con.Close();
            }
            catch (Exception)
            {

                Mainclass.con.Close();
            }
            return CountInsert;
        }

        public void insertStock(int ProId , int qty)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proId",  ProId);
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

        
        public void insertDelItemTranck(Int64 PurInvId,  int ProId, int qty , DateTime date)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("TrackDelItemWRTPurchaseID", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Pur_Id", PurInvId);
                cmd.Parameters.AddWithValue("@Pro_Id", ProId);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Qty", qty);
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
