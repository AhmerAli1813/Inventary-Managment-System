using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivs.system.DbFiles
{
    class retrieval
    {
        public static string _UName
        {
            get;
            private set;
        }
        public static string _Username
        {
            get;
            set;
        }
        public static string _Pass
        {
            get;
            set;
        }
        public static int _UId
        {
            get;
            private set;
        }
        public static bool checkLogin
        {

            get;
            set;
        }
        public string[] prodArr = new string[4];
        
        public static bool getUserDetail(string name, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_GetUserDetails", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User", name);
                cmd.Parameters.AddWithValue("@pass", password);
                Mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        _UId = Convert.ToInt32(dr["Id"].ToString());
                        _Pass = dr["Password"].ToString();
                        _UName = dr["Name"].ToString();
                        _Username = dr["Username"].ToString();
                    }
                }
                else
                {
                    if (name != null && password != null)
                    {
                        if (_Username != name && _Pass == password)
                        {
                            Mainclass.showMsg(name + " invalid Username ", "Error", "Error");
                        }
                        else if (_Username == name && _Pass != password)
                        {
                            Mainclass.showMsg("invalid Password", "Error", "Error");
                        }
                        else if (_Username != name && _Pass != password)
                        {
                            Mainclass.showMsg("invalid Name and Password", "Error", "Error");
                        }
                    }
                }
                Mainclass.con.Close();


            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Error", "Error");
            }


            return checkLogin;
        }

        // drop  Down list this function is dynamic create list of any type of table and proceduce
        public void ShowDropDownList(string proc, ComboBox cb, string DisplayMember, string ValueMember)
        {
            try
            {
                
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                DataRow dr = tb.NewRow();
                dr.ItemArray = new object[] { 0, "Select ...." };
                tb.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = tb;

            }
            catch (Exception ex)
            {
                Mainclass.showMsg(ex.Message, "Error", "Error");
            }
        }
        public void ShowDropDownListWTRTwoParam(string proc, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1, string param2 ,object val2 )
        {
            try
            {
                
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                DataRow dr = tb.NewRow();
                dr.ItemArray = new object[] { 0, "Select ...." };
                tb.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = tb;

            }
            catch (Exception ex)
            {
                Mainclass.showMsg(ex.Message, "Error", "Error");
            }
        }
        public void showUser(DataGridView gv, DataGridViewColumn U_IdGv, DataGridViewColumn U_NameGv, DataGridViewColumn U_UsernameGv, DataGridViewColumn U_EmailGv, DataGridViewColumn passGv, DataGridViewColumn U_StsGv, string data = null)
        {
            SqlCommand cmd;
            try
            {
                if (data == null)
                {
                    cmd = new SqlCommand("st_GetUsersData", Mainclass.con);
                }
                else
                {
                    cmd = new SqlCommand("GetUserDataLike", Mainclass.con);
                    cmd.Parameters.AddWithValue("@searchVal", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                U_IdGv.DataPropertyName = tb.Columns["ID"].ToString();
                U_NameGv.DataPropertyName = tb.Columns["Name"].ToString();
                U_EmailGv.DataPropertyName = tb.Columns["Email"].ToString();
                passGv.DataPropertyName = tb.Columns["Password"].ToString();
                U_UsernameGv.DataPropertyName = tb.Columns["Username"].ToString();
                U_StsGv.DataPropertyName = tb.Columns["Status"].ToString();
                gv.DataSource = tb;
            }
            catch (Exception ex)
            {
                Mainclass.showMsg(ex.Message, "Error ...", "Error");
            }
        }
        public void showCat(DataGridView gv, DataGridViewColumn IdGv, DataGridViewColumn NameGv, DataGridViewColumn StsGv, string data = null)
        {
            SqlCommand cmd;
            try
            {
                if (data == null)
                {
                    cmd = new SqlCommand("st_GetCatData", Mainclass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_GetCatDataLike", Mainclass.con);
                    cmd.Parameters.AddWithValue("@searchVal", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                IdGv.DataPropertyName = tb.Columns["ID"].ToString();
                NameGv.DataPropertyName = tb.Columns["Name"].ToString();
                StsGv.DataPropertyName = tb.Columns["Status"].ToString();
                gv.DataSource = tb;
            }
            catch (Exception ex)
            {
                Mainclass.showMsg(ex.Message, "Error ...", "Error");
            }
        }
        public void showProducts(DataGridView gv, DataGridViewColumn IdGv, DataGridViewColumn BarchorGv, DataGridViewColumn NameGv, DataGridViewColumn CatIDGV, DataGridViewColumn CatNameGv, DataGridViewColumn PrizeGv, DataGridViewColumn ExDateGv, DataGridViewColumn StsGv, string data = null)
        {
            SqlCommand cmd;
            try
            {
                if (data == null)
                {
                    cmd = new SqlCommand("st_GetProductData", Mainclass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_GetProductDataLike", Mainclass.con);
                    cmd.Parameters.AddWithValue("@searchVal", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                IdGv.DataPropertyName = tb.Columns["ID"].ToString();
                BarchorGv.DataPropertyName = tb.Columns["Barchor"].ToString();
                NameGv.DataPropertyName = tb.Columns["Name"].ToString();
                CatNameGv.DataPropertyName = tb.Columns["CatName"].ToString();
                CatIDGV.DataPropertyName = tb.Columns["CatId"].ToString();
                ExDateGv.DataPropertyName = tb.Columns["ExpiryDate"].ToString();
                PrizeGv.DataPropertyName = tb.Columns["Prize"].ToString();
                StsGv.DataPropertyName = tb.Columns["Status"].ToString();
                gv.DataSource = tb;
            }
            catch (Exception ex)
            {
                Mainclass.showMsg(ex.Message, "Error ...", "Error");
            }
        }
        public void showSuppliers(DataGridView gv, DataGridViewColumn IdGv, DataGridViewColumn CompGv, DataGridViewColumn EmpNameGv, DataGridViewColumn AddressGv, DataGridViewColumn NTNGv, DataGridViewColumn Phone1Gv, DataGridViewColumn Phone2Gv, DataGridViewColumn StsGv, string data = null)
        {
            SqlCommand cmd;
            try
            {
                if (data == null)
                {
                    cmd = new SqlCommand("st_getSuppliersData", Mainclass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getSuppliersDataLike", Mainclass.con);
                    cmd.Parameters.AddWithValue("@SearchVal", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                IdGv.DataPropertyName = tb.Columns["ID"].ToString();
                CompGv.DataPropertyName = tb.Columns["Company"].ToString();
                EmpNameGv.DataPropertyName = tb.Columns["Employee"].ToString();
                AddressGv.DataPropertyName = tb.Columns["Address"].ToString();
                NTNGv.DataPropertyName = tb.Columns["NTN"].ToString();
                Phone1Gv.DataPropertyName = tb.Columns["Phone1"].ToString();
                Phone2Gv.DataPropertyName = tb.Columns["Phone2"].ToString();
                StsGv.DataPropertyName = tb.Columns["Status"].ToString();
                gv.DataSource = tb;
            }
            catch (Exception ex)
            {
                Mainclass.showMsg(ex.Message, "Error ...", "Error");
            }
        }
        public string[] showProductWRTBarchoe(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductDataWSRBarchode", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                Mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        prodArr[0] = dr[0].ToString();
                        prodArr[1] = dr[1].ToString();
                        prodArr[2] = dr[2].ToString();
                        prodArr[3] = dr[3].ToString();
                    }
                }   
                Mainclass.con.Close();
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Error", "Error");
            }
         
            return prodArr;
        }
        public void showPurInvDetailWRTPurID(Int64 PurInvId, DataGridView gv, DataGridViewColumn mPurInvDtlIdGv, DataGridViewColumn proIdGv, DataGridViewColumn ProductGv, DataGridViewColumn PrizeGv, DataGridViewColumn QtyGv, DataGridViewColumn TotalAmountGv)
        {
            SqlCommand cmd;
            try
            {
                    cmd = new SqlCommand("st_getPurInvDetailWRTPurInvID", Mainclass.con);
                    cmd.Parameters.AddWithValue("@id", PurInvId);
                

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                mPurInvDtlIdGv.DataPropertyName = tb.Columns["PurInvDtl_Id"].ToString();
                
                proIdGv.DataPropertyName = tb.Columns["ProId"].ToString();
                ProductGv.DataPropertyName = tb.Columns["Product"].ToString();
                PrizeGv.DataPropertyName = tb.Columns["Prize"].ToString();
                QtyGv.DataPropertyName = tb.Columns["Quatity"].ToString();
                TotalAmountGv.DataPropertyName = tb.Columns[""].ToString();
                gv.DataSource = tb;
            }
            catch (Exception ex)
            {
                Mainclass.showMsg(ex.Message, "Error ...", "Error");
            }
        }
        private object ProQtyCount = 0;
        public object GetProductStockQuatity(int ProId)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_getProStockQty", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pro_Id", ProId);
                Mainclass.con.Open();
                ProQtyCount = cmd.ExecuteScalar();
                Mainclass.con.Close();

            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMsg(ex.Message, "Expection Error", "Error");

            }
            return ProQtyCount;
        }
        public void showStocks( DataGridView gv, DataGridViewColumn stkIdGv, DataGridViewColumn ProIdGv, DataGridViewColumn BarcodeGv, DataGridViewColumn Catgoery, DataGridViewColumn ProductGv, DataGridViewColumn PrizeGv, DataGridViewColumn QtyGv, DataGridViewColumn TotalAmountGv , DataGridViewColumn ExdateGv , DataGridViewColumn StsGv)
        {
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("st_GetStocksData", Mainclass.con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                stkIdGv.DataPropertyName = tb.Columns["stk_Id"].ToString();
                ProIdGv.DataPropertyName = tb.Columns["ProId"].ToString();
                ProductGv.DataPropertyName = tb.Columns["Product"].ToString();
                PrizeGv.DataPropertyName = tb.Columns["Prize"].ToString();
                QtyGv.DataPropertyName = tb.Columns["Qty"].ToString();
                TotalAmountGv.DataPropertyName = tb.Columns["Total Amount"].ToString();
                BarcodeGv.DataPropertyName = tb.Columns["Barcode"].ToString();
                Catgoery.DataPropertyName = tb.Columns["Catgory"].ToString();
                ExdateGv.DataPropertyName = tb.Columns["ExDate"].ToString();
                StsGv.DataPropertyName = tb.Columns["Status"].ToString();
                gv.DataSource = tb;
            }
            catch (Exception ex)
            {
                Mainclass.showMsg(ex.Message, "Error ...", "Error");
            }
        }
    }
}
