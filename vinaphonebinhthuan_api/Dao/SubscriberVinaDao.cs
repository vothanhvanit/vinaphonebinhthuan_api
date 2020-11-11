using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using vinaphonebinhthuan_api.Models;

namespace vinaphonebinhthuan_api.Dao
{
    public class SubscriberVinaDao
    {
        public IEnumerable<SubscriberVina> FindSubsVNP(string mobilevina)
        {
            List<SubscriberVina> result = new List<SubscriberVina>();
            SqlConnection sqlCnn = new SqlConnection(ConfigurationManager.ConnectionStrings["AppVNPConnectionString"].ConnectionString);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCnn;
            SqlDataAdapter sqlAdapter = null;

            try {
                sqlCmd.CommandTimeout = 50000;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "findSubsVinaByMobileNo";
                sqlCmd.Parameters.AddWithValue("@mobileNo", mobilevina);
                sqlAdapter = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                result = DatatableToList(dt);
                return result;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        private List<SubscriberVina> DatatableToList(DataTable dt)
        {

            List<SubscriberVina> result = new List<SubscriberVina>();
            foreach(DataRow iRow in dt.Rows)
            {
                SubscriberVina iSubcriber = new SubscriberVina();
                iSubcriber.Mobile         = iRow["subcriber"].ToString();
                
                if(iRow["bal_tkc"] != DBNull.Value)
                {
                    iSubcriber.Tkc_bal = Convert.ToInt32(iRow["bal_tkc"].ToString());
                }

                if (iRow["total_tkc"] != DBNull.Value)
                {
                    iSubcriber.Tkc_n = Convert.ToInt32(iRow["total_tkc"].ToString());
                }

                if (iRow["total_data"] != DBNull.Value)
                {
                    iSubcriber.Total_data_n = Convert.ToInt32(iRow["total_data"].ToString());
                }

                if (iRow["total_tkc_thang_truoc"] != DBNull.Value)
                {
                    iSubcriber.Tkc_n_1 = Convert.ToInt32(iRow["total_tkc_thang_truoc"].ToString());
                }

                if (iRow["total_tkc_thang_truoc_nua"] != DBNull.Value)
                {
                    iSubcriber.Tkc_n_2 = Convert.ToInt32(iRow["total_tkc_thang_truoc_nua"].ToString());
                }

                if (iRow["total_tkc_n_3"] != DBNull.Value)
                {
                    iSubcriber.Tkc_n_3 = Convert.ToInt32(iRow["total_tkc_n_3"].ToString());
                }

                if (iRow["tkc_average"] != DBNull.Value)
                {
                    iSubcriber.Tkc_TrungBinh = Convert.ToInt32(iRow["tkc_average"].ToString());
                }

                if (iRow["ds_goicuoc"] != DBNull.Value)
                {
                    iSubcriber.ds_goi_cuoc_use = iRow["ds_goicuoc"].ToString();
                }

                if (iRow["goi_cuoc_recommend"] != DBNull.Value)
                {
                    iSubcriber.Goi_cuoc_recommend = iRow["goi_cuoc_recommend"].ToString();
                }

                if (iRow["diachi"] != DBNull.Value)
                {
                    iSubcriber.DiaChi = iRow["diachi"].ToString();
                }


                if (iRow["smartphone"] != DBNull.Value)
                {
                    iSubcriber.SmartPhone = iRow["smartphone"].ToString();
                }

                result.Add(iSubcriber);
            }

            return result;
            
        }
    }
}