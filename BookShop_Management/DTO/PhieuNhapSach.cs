using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class PhieuNhapSach
    {
        public PhieuNhapSach(DateTime ngaynhap, string maSach, int soluongnhap, decimal gianhap)
        {
            this.ngaynhap = ngaynhap;
            this.maSach = maSach;
            this.soluongnhap = soluongnhap;
            this.gianhap = gianhap;
        }

        public PhieuNhapSach(DataRow row)
        {
            this.NgayNhap = (DateTime)row["NgayNhap"];
            this.MaSach = row["MaSach"].ToString();
            this.SoLuongNhap = (int)row["SoLuongNhap"];
            this.GiaNhap = (decimal)row["GiaNhap"];
        }


        private DateTime ngaynhap;
        public DateTime NgayNhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }

        private string maSach;
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        private int soluongnhap;
        public int SoLuongNhap
        {
            get { return soluongnhap; }
            set { soluongnhap = value; }
        }

        private decimal gianhap;
        public decimal GiaNhap
        {
            get { return gianhap; }
            set { gianhap = value; }
        }
    }
}
