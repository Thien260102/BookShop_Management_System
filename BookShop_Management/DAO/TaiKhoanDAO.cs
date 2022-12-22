using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        public DataTable LayDS_TaiKhoan()
        {
            string query = "Select * " +
                "from TaiKhoan";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public TaiKhoan LayTaiKhoanTu(string tenTK)
        {
            string query = "Select * from TaiKhoan " +
                "where TenTK = @TenTK ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenTK });

            TaiKhoan taiKhoan = new TaiKhoan();

            if (data.Rows.Count == 1)
                taiKhoan = new TaiKhoan(data.Rows[0]);

            if (taiKhoan.TenTK != tenTK)
                taiKhoan = new TaiKhoan();
            return taiKhoan;
        }

        public bool CapNhatTK(DTO.TaiKhoan tk)
        {
            if (tk.MaTK == "")
                return false;

            string query = "Update TaiKhoan " +
                " Set TenTK = @TenTK , MatKhau = @MatKhau , MaNguoiDung = @MaNguoiDung , VaiTro = @VaiTro " +
                " where MaTK = @MaTK ";

            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { tk.TenTK, tk.MatKhau, tk.MaNguoiDung, tk.VaiTro, tk.MaTK }) == 0)
                return false;

            return true; ;
        }

        public bool ThemTK(DTO.TaiKhoan tk)
        {
            if (tk.MaTK == "")
                return false;

            string query = "Insert into TaiKhoan " +
                "values ( @MaTK , @TenTK , @MatKhau , @MaNguoiDung , @VaiTro )";

            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] {tk.MaTK, tk.TenTK, tk.MatKhau, tk.MaNguoiDung, tk.VaiTro }) == 0)
                return false;

            return true;
        }

        public bool XoaTK(string MaTK)
        {
            string query = "Delete from TaiKhoan " +
                "where MaTK = @Matk";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaTK }) == 0)
                return false;

            return true;
        }
    }
}
