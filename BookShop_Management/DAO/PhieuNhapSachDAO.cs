using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class PhieuNhapSachDAO
    {
        private static PhieuNhapSachDAO instance;

        public static PhieuNhapSachDAO Instance
        {
            get { if (instance == null) instance = new PhieuNhapSachDAO(); return instance; }
            private set { instance = value; }
        }

        private PhieuNhapSachDAO() { }

        public bool NhapSach(PhieuNhapSach sach)
        {
            string query = "Insert into PhieuNhapSach(NgayNhap, MaSach, SoLuongNhap, GiaNhap) " +
                "values ( @NgayNhap , @MaSach , @SoLuongNhap , @GiaNhap ) ";

            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { sach.NgayNhap, sach.MaSach, sach.SoLuongNhap, sach.GiaNhap }) >= 1)
                return true;

            return false;
        }

        public List<PhieuNhapSach> LayDS_PhieuNhapSachTu(string MaSach)
        {
            List<PhieuNhapSach> answer = new List<PhieuNhapSach>();
            string query = "select * from PHIEUNHAPSACH " +
                "where MaSach = @MaSach ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSach });

            foreach (DataRow dr in data.Rows)
                answer.Add(new PhieuNhapSach(dr));

            return answer;
        }

        public int LayTonCuoiTu(string MaSach, int Thang)
        {
            string query = "Select TonCuoi From BaoCaoTonKho " +
                "where MaSach = @MaSach And Thang = @Thang ";

            int TonCuoi = 0;
                
            TonCuoi = (int)DataProvider.Instance.ExecuteQuery(query, new object[] { MaSach, Thang }).Rows[0][0];

            return TonCuoi;
        }

        public int LaySoLuongSachNhap()
        {
            object soLuong = DataProvider.Instance.ExecuteScalar("Select Sum(SoLuongNhap) From PhieuNhapSach");

            return (soLuong == DBNull.Value ? 0: (int)soLuong);
        }

    }
}
