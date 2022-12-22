using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class PhieuThuNoDAO
    {
        private static PhieuThuNoDAO instance;

        public static PhieuThuNoDAO Instance
        {
            get { if (instance == null) instance = new PhieuThuNoDAO(); return instance; }
            private set { instance = value; }
        }

        private PhieuThuNoDAO() { }

        public bool ThemPTN(DTO.PhieuThuNo phieuThuNo)
        {
            string query = "Insert into PHIEUTHUNO (MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) " +
                "values ( @MaPTN , @MaKH , @NgayThuTien , @SoTienThanhToan , @Ghichu )";

            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] {phieuThuNo.MaPTN, phieuThuNo.MaKH, phieuThuNo.NgayThuTien,
                phieuThuNo.SoTienThanhToan, phieuThuNo.GhiChu}) > 0)
                return true;

            return false;
        }

        public string LayMaPTNKeTiep()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select Top 1(MaPTN) from PhieuThuNo " +
                "Order by MaPTN DESC");

            string maTacGia = "";
            if (data.Rows.Count != 0)
            {
                maTacGia = data.Rows[0][0].ToString();
                var matches = Regex.Matches(maTacGia, @"\d+");

                string number = "";
                foreach (var match in matches)
                    number += match;

                int number_digit = (int.Parse(number) != 0) ? int.Parse(number) : 0;

                number_digit++;

                number = "PTN";

                if (number_digit / 100 >= 1)
                    return "";
                else if (number_digit / 10 >= 1)
                    number += (number_digit.ToString());
                else if (number_digit <= 9)
                    number += ("0" + number_digit.ToString());

                return number;
            }
            else
                return "PTN01";

        }
    
        public DataTable LayDS_PTNTU(string MaKH)
        {
            string query = "Select * from PhieuThuNo " +
                "where MaKH = @MaKH";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { MaKH });
        }

    }
}
