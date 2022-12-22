using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using BookShop_Management.DTO;

namespace BookShop_Management.DAO
{
    public class BaoCaoThuNoDAO 
    {
        private static BaoCaoThuNoDAO instance;
        public static BaoCaoThuNoDAO Instance
        {
            get { if (instance == null) instance = new BaoCaoThuNoDAO(); return instance; }
            private set { instance = value; }
        }
        private BaoCaoThuNoDAO() {}

        public DataTable LayDS_BCTN(int thang)
        {
            string query = "select HoTen, NoDau, BaoCaoThuNo.SoTienNo, SoTienThanhToan, NoCuoi"
                + " from BaoCaoThuNo, KhachHang"
                + " where Thang = @thang And BaoCaoThuNo.MaKH = KhachHang.MaKH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { thang });

            return data;
        }

        public decimal LayNoCuoiTu_MaKH(string MaKH, int Thang)
        {
            string query = "Select NoCuoi " +
                "from BaoCaoThuNo " +
                "where MaKH = @MaKH And Thang = @Thang ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaKH, Thang });

            if(data.Rows.Count != 0)
                return (decimal)data.Rows[0][0];

            return 0;
        }

        public bool ThemBaoCaoThuNo(BaoCaoThuNo baoCao)
        {
            string query = "Insert into BaoCaoThuNo " +
                "values ( @MaBCTN , @MaKH , @Thang , @NoDau , @NoCuoi , @SoTienNo , @SoTienThanhToan )";

            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { baoCao.MaBCTN, baoCao.MaKH, baoCao.Thang, baoCao.NoDau,
                baoCao.NoCuoi, baoCao.SoTienNo, baoCao.SoTienThanhToan }) > 0) 
                return true;

            return false;
        }

        public string LayMaBCTN_CuoiCung()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select Top 1(MaBCTN) from BaoCaoThuNo" +
                " Order by MaBCTN DESC");

            if (data.Rows.Count == 0)
                return "";

            return data.Rows[0][0].ToString();
        }

        public string LayMaBCTN_KeTiep()
        {
            string maBCTN = LayMaBCTN_CuoiCung();

            string answer = "BCN";

            if (maBCTN != null && maBCTN != "")
            {
                string number = "";
                for (int i = 0; i < maBCTN.Length; i++)
                    if (Char.IsDigit(maBCTN[i]))
                        number += maBCTN[i];
                int number_digit = int.Parse(number) + 1;

                int size = 6 - number_digit.ToString().Length;

                for (int i = 1; i <= size; i++)
                    answer += "0";
                answer += number_digit.ToString();
            }
            else
                answer += "000001";

            return answer;
        }

        public bool XoaTatCa()
        {
            if (DataProvider.Instance.ExecuteNonQuery("Delete from BaoCaoThuNo") > 0)
                return true;

            return false;
        }

    }
}
