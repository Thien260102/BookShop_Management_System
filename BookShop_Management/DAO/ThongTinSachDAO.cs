using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class ThongTinSachDAO
    {
        private static ThongTinSachDAO instance;

        public static ThongTinSachDAO Instance
        {
            get { if (instance == null) instance = new ThongTinSachDAO(); return instance; }
            private set { instance = value; }
        }

        private ThongTinSachDAO() { }

        public DataTable LayDS_ThongTinSach()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from ThongTinSach");
            
            return data;
        }

        public DataTable LayDS_ThongTinSachVaTacGia()
        {
            string query = "Select TenSach, TheLoai, TenTacGia, SoLuong, GiaBan, NgayPhatHanh, TenAnh " +
                "from ThongTinSach, CT_TacGia, TacGia " +
                "where ThongTinSach.MaSach = CT_TacGia.MaSach and CT_TacGia.MaTacGia = TacGia.MaTacGia ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public List<string> Lay_MaSach()
        {
            List<string> List_ID = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select MaSach from ThongTinSach");

            foreach (DataRow dr in data.Rows)
                List_ID.Add(dr[0].ToString());

            return List_ID;
        }

        public int Lay_LuongTon(string maSach)
        {
            string query = "Select SoLuong " +
                "from ThongTinSach " +
                "where MaSach = @maSach";

            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { maSach });
        }

        public bool CapNhat_SoLuong_GiaBan(string maSach, int SoLuong, decimal GiaBan)
        {
            string query = "Update ThongTinSach" +
                " Set SoLuong = @SoLuong , GiaBan = @GiaBan" +
                " Where MaSach = @maSach";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { SoLuong, GiaBan, maSach }) > 0)
                return true;

            return false;
        }

        public bool CapNhat_SoLuong(string maSach, int SoLuong)
        {
            string query = "Update ThongTinSach" +
                " Set SoLuong = @SoLuong " +
                " Where MaSach = @maSach";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { SoLuong, maSach }) > 0)
                return true;

            return false;
        }

        public bool ThemSachMoi(ThongTinSach Sach)
        {
            string query = "Insert into ThongTinSach" +
                "(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) " +
                "values( @maSach , @TheLoai , @TenSach , @SoLuong , @GiaBan , @NgayPhatHanh , @TenAnh )";
            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] {Sach.MaSach, Sach.TheLoai, Sach.TenSach,
                    Sach.SoLuong, Sach.GiaBan, Sach.NgayPhatHanh, Sach.TenAnh}) > 0)
                return true;

            return false;
        }

        public bool XoaSach(string maSach)
        {
            string query = "Delete from ThongTinSach " +
                "where MaSach = @maSach";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { maSach }) > 0)
                return true;

            return false;
        }

        public ThongTinSach LayThongTinSachTu_MaSach(string MaSach)
        {
            string query = "Select * from ThongTinSach " +
                "where MaSach = @maSach";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSach });

            ThongTinSach answer = new ThongTinSach(data.Rows[0]);

            return answer;
        }

        public bool KiemTraSachDaTonTaiChua(string theLoai, string tenSach, DateTime ngayPhatHanh)
        {
            string query = "Select * from ThongTinSach " +
                "where TheLoai = @theLoai " +
                "and TenSach = @tenSach " +
                "and NgayPhatHanh = @ngayPhatHanh ";

            if (DataProvider.Instance.ExecuteQuery(query, new object[] { theLoai, tenSach, ngayPhatHanh }).Rows.Count != 0)
                return true;

            return false;
        }
    }
}
