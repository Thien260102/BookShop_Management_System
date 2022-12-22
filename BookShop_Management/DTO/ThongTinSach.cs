using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BookShop_Management.DTO
{
    public class ThongTinSach
    {

        public ThongTinSach(string maSach, string theloai, string tensach, 
            int soluong, decimal giaban, DateTime ngayphathanh, string tenAnh)
        {
            this.maSach = maSach;
            this.theloai = theloai;
            this.tensach = tensach;
            this.soluong = soluong;
            this.giaban = giaban;
            this.ngayphathanh = ngayphathanh;
            this.tenAnh = tenAnh;
        }

        public ThongTinSach(DataRow row)
        {
            this.MaSach = row["MaSach"].ToString();
            this.TheLoai = row["TheLoai"].ToString();
            this.TenSach = row["TenSach"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.GiaBan = (decimal)row["GiaBan"];
            this.NgayPhatHanh = (DateTime)row["NgayPhatHanh"];
            this.TenAnh = row["TenAnh"].ToString();
        }

        private string maSach;
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        private string theloai;
        public string TheLoai
        {
            get { return theloai; }
            set { theloai = value; }
        }

        private string tensach;
        public string TenSach
        {
            get { return tensach; }
            set { tensach = value; }
        }

        private int soluong;
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private decimal giaban;
        public decimal GiaBan
        {
            get { return giaban; }
            set { giaban = value; }
        }

        private DateTime ngayphathanh;
        public DateTime NgayPhatHanh
        {
            get { return ngayphathanh; }
            set { ngayphathanh = value; }
        }

        private string tenAnh;
        public string TenAnh
        {
            get { return tenAnh; }
            set { tenAnh = value; }
        }

    }
}
