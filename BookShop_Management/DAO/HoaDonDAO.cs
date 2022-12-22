using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set { instance = value; }
        }

        private HoaDonDAO() { }

        public DataTable LayDS_HD()
        {
            DataTable dataTable = new DataTable();

            string query = "Select * From HoaDon";

            dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public DataTable LayDS_HD_CTHD()
        {
            DataTable dataTable = new DataTable();

            string query = "Select MaKH, TenSach, SL_HD SoLuong, NgayHD NgayMua, GiamGia, TongHoaDon, SoTienDaThanhToan " +
                "From HoaDon, CTHD, ThongTinSach " +
                "Where HoaDon.MaHD = CTHD.MaHD and CTHD.MaSach = ThongTinSach.MaSach ";

            dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public string LayMaHD_CuoiCung()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select Top 1(MaHD) from HoaDon " +
                "Order by MaHD DESC");

            if(data.Rows.Count != 0)
                return data.Rows[0][0].ToString();

            return "";
        }

        public string LayMaHD_KeTiep(string maHD)
        {
            string answer = "HD";

            if (maHD != null && maHD != "")
            {
                string number = "";
                for (int i = 0; i < maHD.Length; i++)
                    if (Char.IsDigit(maHD[i]))
                        number += maHD[i];
                int number_digit = int.Parse(number) + 1;

                if (number_digit / 10 >= 1)
                    answer += ("" + number_digit.ToString());
                else if (number_digit <= 9)
                    answer += ("0" + number_digit.ToString());
            }
            else
                answer += "001";

            return answer;
        }

        public bool ThemHoaDon(HoaDon hoaDon)
        {
            string query = "Insert into HoaDon " +
                "values ( @MaHD , @MaKH , @MaNguoiDung , @NgayHD , @GiamGia , @TongHoaDon , @SoTienDaThanhToan )";
            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] {hoaDon.MaHD, hoaDon.MaKH, hoaDon.MaNguoiDung, hoaDon.NgayHD,
                hoaDon.GiamGia, hoaDon.TongHoaDon, hoaDon.SoTienDaThanhToan}) > 0)
                return true;

            return false;
        }

        public List<HoaDon> LayDSHDTu(string MaKH)
        {
            List<HoaDon> answer = new List<HoaDon>();

            string query = "Select * from HoaDon " +
                "where MaKH = @MaKH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaKH });

            foreach (DataRow dr in data.Rows)
                answer.Add(new HoaDon(dr));

            return answer;
        }

    }
}
