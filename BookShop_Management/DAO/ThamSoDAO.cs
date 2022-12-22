using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DAO
{
    public class ThamSoDAO
    {
        private static ThamSoDAO instance;

        public static ThamSoDAO Instance
        {
            get { if (instance == null) instance = new ThamSoDAO(); return instance; }
            private set { instance = value; }
        }

        private ThamSoDAO() { }

        public List<ThamSo> LayDS_ThamSo()
        {
            List<ThamSo> list = new List<ThamSo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from ThamSo");

            foreach(DataRow dr in data.Rows)
                list.Add(new ThamSo(dr));

            return list;
        }

        public bool CapNhat_SLNhapToiThieu(int SLnhaptoithieu)
        {
            string query = "Update ThamSo " +
                "Set GiaTri = @giatri " +
                "where TenThamSo = 'So luong nhap toi thieu' ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { SLnhaptoithieu }) > 0) 
                return true;

            return false;
        }

        public bool CapNhat_LuongTonToiThieu(int Luongtontoithieu)
        {
            string query = "Update ThamSo " +
                "Set GiaTri = @giatri " +
                "where TenThamSo = 'Luong ton toi thieu' ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { Luongtontoithieu }) > 0)
                return true;

            return false;
        }

        public bool CapNhat_TienNoToiDa(int Tiennotoida)
        {
            string query = "Update ThamSo " +
                "Set GiaTri = @giatri " +
                "where TenThamSo = 'Tien no toi da' ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { Tiennotoida }) > 0)
                return true;

            return false;
        }

        public bool CapNhat_SoTienThu(int Sotienthu)
        {
            string query = "Update ThamSo " +
                "Set GiaTri = @giatri " +
                "where TenThamSo = 'So tien thu' ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { Sotienthu }) > 0)
                return true;

            return false;
        }

        public int LayGiaTriTu_TenThamSo(string tenThamSo)
        {
            string query = "Select GiaTri " +
                "from ThamSo " +
                "where TenThamSo = @tenThamSo";

            object giatri = DataProvider.Instance.ExecuteScalar(query, new object[] { tenThamSo });

            return (giatri == DBNull.Value ? 0 : (int)giatri);
        }
    }
}
