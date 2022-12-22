using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }


        private KhachHangDAO() { }

        public DataTable LayDSKhachHang()
        {
            string query = "Select * from KhachHang";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int LaySoLuongKhachHang()
        {
            object soLuong = DataProvider.Instance.ExecuteScalar("Select Count(MaKH) From KhachHang");

            return (soLuong == DBNull.Value ? 0 : (int)soLuong);
        }

        public List<string> LayDS_MaKH()
        {
            List<string> List_MaKH = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select MaKH from KhachHang");

            foreach (DataRow dr in data.Rows)
                List_MaKH.Add(dr[0].ToString());

            return List_MaKH;
        }

        // Mã khách hàng phải chính xác
        public KhachHang LayThongTinKHTu_MaKH(string MaKH)
        {
            string query = "select * from KhachHang " +
                "where MaKH = @MaKH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaKH });
            if (data.Rows.Count == 0)
                return null;

            return new KhachHang(data.Rows[0]);
        }

        public bool CapNhatTienNo(string maKH, decimal TienNo)
        {
            if (DataProvider.Instance.ExecuteNonQuery("Update KhachHang " +
                "set SoTienNo = @SoTienNo " +
                "where MaKH = @MaKH", new object[] { TienNo, maKH }) > 0)
                return true;

            return false;
        }

        public decimal LayTienNoTuMaKH(string maKH)
        {
            object soLuong = DataProvider.Instance.ExecuteScalar("Select SoTienNo From KhachHang " +
                "where MaKH = @maKH", new object[] { maKH });

            return (soLuong == DBNull.Value ? 0 : (decimal)soLuong);
        }
    }
}
