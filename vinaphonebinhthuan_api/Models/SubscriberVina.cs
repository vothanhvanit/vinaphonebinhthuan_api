using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vinaphonebinhthuan_api.Models
{
    
    public class SubscriberVina
    {
      
        public string Mobile { get; set; }
        public int Tkc_bal { get; set; }
        public int Tkc_n { get; set; }
        public int Total_data_n { get; set; }
        public int Tkc_n_1 { get; set; }
        public int Tkc_n_2 { get; set; }
        public int Tkc_n_3 { get; set; }
        public int Tkc_TrungBinh { get; set; }
        public string Goi_cuoc_recommend { get; set; }
        public string ds_goi_cuoc_use { get; set; }
        public string SmartPhone { get; set; }
        public string DiaChi { get; set; }

        public SubscriberVina(string Mobile
                            , int Tkc_bal
                            , int Tkc_n
                            , int Total_data_n
                            , int Tkc_n_1
                            , int Tkc_n_2
                            , int Tkc_n_3
                            , int Tkc_TrungBinh
                            , string Goi_cuoc_recommend
                            , string ds_goi_cuoc_use
                            , string SmartPhone
                            , string DiaChi

                            )
        {
            this.Mobile = Mobile;
            this.Tkc_bal = Tkc_bal;
            this.Tkc_n = Tkc_n;
            this.Total_data_n = Total_data_n;
            this.Tkc_n_1 = Tkc_n_1;
            this.Tkc_n_2 = Tkc_n_2;
            this.Tkc_n_3 = Tkc_n_3;
            this.Tkc_TrungBinh = Tkc_TrungBinh;
            this.Goi_cuoc_recommend = Goi_cuoc_recommend;
            this.ds_goi_cuoc_use = ds_goi_cuoc_use;
            this.SmartPhone = SmartPhone;
            this.DiaChi = DiaChi;
        }

        public SubscriberVina() { }


    }


}