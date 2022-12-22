using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class BaoCaoTonKhoDAO
    {
        private static BaoCaoTonKhoDAO instance;

        public static BaoCaoTonKhoDAO Instance
        {
            get { if (instance == null) instance = new BaoCaoTonKhoDAO(); return instance; }
            private set { instance = value; }
        }

        private BaoCaoTonKhoDAO() { }

        public DataTable LayDS_BCTK(int thang)
        {
            string query = "Select MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi" +
                " from BaoCaoTonKho" +
                " where Thang = @thang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { thang });

            return data;
        }

        //public int LaySoLuongSachNhap()
        //{
        //    return (int)DataProvider.Instance.ExecuteScalar("Select Sum(SachDaNhap) From BaoCaoTonKho");
        //}

        //public int LaySoLuongSachDaBan()
        //{
        //    return (int)DataProvider.Instance.ExecuteScalar("Select Sum(SachDaBan) From BaoCaoTonKho");
        //}

        // Lay luong ton cuoi cung tu thang truoc do
        public int LayTonCuoiTu_MaSach(string MaSach, int Thang)
        {
            string query = "Select TonCuoi " +
                "from BaoCaoTonKho " +
                "where MaSach = @MaSach And Thang = @Thang ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSach, Thang });

            if (data.Rows.Count != 0)
                return (int)data.Rows[0][0];

            return 0;
        }

        public bool ThemBaoCaoTonKho(BaoCaoTonKho baoCao)
        {
            string query = "Insert into BaoCaoTonKho " +
                "values ( @MaBCTK , @MaSach , @TonDau , @SachDaNhap , @SachDaBan , @TonCuoi , @Thang )";

            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { baoCao.MaBCTK, baoCao.MaSach, baoCao.TonDau, baoCao.SachDaNhap,
                baoCao.SachDaBan, baoCao.TonCuoi, baoCao.Thang }) > 0)
                return true;

            return false;
        }

        public string LayMaBCTK_CuoiCung()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select Top 1(MaBCTK) from BaoCaoTonKho" +
                " Order by MaBCTK DESC");

            if (data.Rows.Count == 0)
                return "";

            return data.Rows[0][0].ToString();
        }

        public string LayMaBCTK_KeTiep()
        {
            string maBCTK = LayMaBCTK_CuoiCung();

            string answer = "BCT";

            if (maBCTK != null && maBCTK != "")
            {
                string number = "";
                for (int i = 0; i < maBCTK.Length; i++)
                    if (Char.IsDigit(maBCTK[i]))
                        number += maBCTK[i];
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

        public BaoCaoTonKho LayBCTKTu(string MaSach, int Thang)
        {
            string query = "Select * from BaoCaoTonKho " +
                "where MaSach = @MaSach And Thang = @Thang ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSach, Thang });

            foreach(DataRow dr in data.Rows)
                return new BaoCaoTonKho(dr);

            return null;
        }

        public bool XoaTatCa()
        {
            if (DataProvider.Instance.ExecuteNonQuery("Delete from BaoCaoTonKho") > 0)
                return true;

            return false;
        }

    }
}
