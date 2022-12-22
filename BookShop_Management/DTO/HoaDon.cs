using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class HoaDon
    {

        public HoaDon(string maHD, string maKH, DateTime ngayHD, decimal giamgia, 
            decimal tonghoadon, decimal sotiendathanhtoan, string manguoidung)
        {
            this.maHD = maHD;
            this.maKH = maKH;
            this.ngayHD = ngayHD;
            this.giamgia = giamgia;
            this.tonghoadon = tonghoadon;
            this.sotiendathanhtoan = sotiendathanhtoan;
            this.manguoidung = manguoidung;
        }
        public HoaDon(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaKH = row["MaKH"].ToString();
            this.NgayHD = (DateTime)row["NgayHD"];

            if (row["GiamGia"].ToString() != ""
               && row["GiamGia"] != null)
                this.GiamGia = (decimal)row["GiamGia"];
            else
                this.GiamGia = 0;
            this.TongHoaDon = (decimal)row["TongHoaDon"];
            this.SoTienDaThanhToan = (decimal)row["SoTienDaThanhToan"];
            this.MaNguoiDung = row["MaNguoiDung"].ToString();
        }

        private string maHD;
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private DateTime ngayHD;
        public DateTime NgayHD
        {
            get { return ngayHD; }
            set { ngayHD = value; }
        }

        private decimal giamgia;
        public decimal GiamGia
        {
            get { return giamgia; }
            set { giamgia = value; }
        }

        private decimal tonghoadon;
        public decimal TongHoaDon
        {
            get { return tonghoadon; }
            set { tonghoadon = value; }
        }

        private decimal sotiendathanhtoan;
        public decimal SoTienDaThanhToan
        {
            get { return sotiendathanhtoan; }
            set { sotiendathanhtoan = value; }
        }

        private string manguoidung;
        public string MaNguoiDung
        {
            get { return manguoidung; }
            set { manguoidung = value; }
        }

    }
}
