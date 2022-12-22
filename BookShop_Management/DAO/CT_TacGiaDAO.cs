using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class CT_TacGiaDAO
    {
        private static CT_TacGiaDAO instance;

        public static CT_TacGiaDAO Instance
        {
            get { if (instance == null) instance = new CT_TacGiaDAO(); return instance; }
            private set { instance = value; }
        }

        private CT_TacGiaDAO() { }

        public bool ThemChiTietTacGia(string MaSach, string MaTacGia)
        {
            string query = "Insert into CT_TacGia(MaSach, MaTacGia) " +
                "values( @MaSach , @MaTacGia )";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaSach, MaTacGia }) > 0)
                return true;

            return false;
        }

        public bool XoaCTTacGiaTu_MaSach(string MaSach)
        {
            string query = "Delete from CT_TacGia " +
                "Where MaSach = @MaSach";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaSach }) > 0)
                return true;

            return false;
        }

        public List<string> LayMaTacGiaTu_MaSach(string MaSach)
        {
            List<string> List_TacGia = new List<string>();
            DataTable data =
                DataProvider.Instance.ExecuteQuery("Select MaTacGia From CT_TacGia " +
                "where MaSach = @MaSach", new object[] { MaSach });

            foreach (DataRow dr in data.Rows)
                List_TacGia.Add(dr[0].ToString());

            return List_TacGia;
        }
    }
}
