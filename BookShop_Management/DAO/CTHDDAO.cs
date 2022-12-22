using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class CTHDDAO
    {
        private static CTHDDAO instance;

        public static CTHDDAO Instance
        {
            get { if (instance == null) instance = new CTHDDAO(); return instance; }
            private set { instance = value; }
        }

        private CTHDDAO() { }

        public bool ThemCTHD(CTHD cthd)
        {
            string query = "Insert into CTHD " +
                "values ( @MaHD , @MaSach , @SL_HD )";

            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { cthd.MaHD, cthd.MaSach, cthd.SL_HD }) > 0)
                return true;

            return false;
        }

        public DataTable LayCTHD_Tu(string MaHD)
        {
            string query = "Select * from CTHD " +
                "where MaHD = @MaHD ";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { MaHD });
        }

        public int LaySoLuongSachDaBan()
        {
            object soLuong = DataProvider.Instance.ExecuteScalar("Select Sum(SL_HD) From CTHD");

            return (soLuong == DBNull.Value ? 0 : (int)soLuong);
        }

        public List<CTHD> LayDS_CTHD_Tu(int year, int month, string MaSach)
        {
            List<CTHD> answer = new List<CTHD>();

            string query = "Select CTHD.MaHD, MaSach, SL_HD " +
                "from HoaDon HD, CTHD " +
                "where HD.MaHD = CTHD.MaHD And " +
                "Year(NgayHD) = @year And Month(NgayHD) = @month " +
                "And MaSach = @MaSach ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { year, month, MaSach });

            foreach (DataRow dr in data.Rows)
                answer.Add(new CTHD(dr));

            return answer;

        }
    }
}
