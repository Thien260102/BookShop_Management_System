using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    class NguoiDungDAO
    {
        private static NguoiDungDAO instance;

        public static NguoiDungDAO Instance
        {
            get { if (instance == null) instance = new NguoiDungDAO(); return instance; }
            private set { instance = value; }
        }

        private NguoiDungDAO() { }

        public List<string> LayDS_MaNguoiDung()
        {
            List<string> DS_MaND = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from NguoiDung");

            foreach (DataRow dr in data.Rows)
                DS_MaND.Add(dr["MaNguoiDung"].ToString());
            return DS_MaND;
        }

    }
}
