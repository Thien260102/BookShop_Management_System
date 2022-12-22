using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class KhachHang
    {

        public KhachHang(string maKH, string hoten, string sdt_kh, string email_kh, 
            string diachi_kh, string gioitinh_kh, DateTime ngaydktv, decimal soTienno)
        {
            this.maKH = maKH;
            this.hoten = hoten;
            this.sdt_kh = sdt_kh;
            this.email_kh = email_kh;
            this.diachi_kh = diachi_kh;
            this.gioitinh_kh = gioitinh_kh;
            this.ngaydktv = ngaydktv;
            this.soTienno = soTienno;
        }

        public KhachHang(DataRow row)
        {
            this.MaKH = row["MaKH"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.SDT_KH = row["SDT_KH"].ToString();
            this.Email_KH = row["Email_KH"].ToString();
            this.DiaChi_KH = row["DiaChi_KH"].ToString();
            this.GioiTinh_KH = row["GioiTinh_KH"].ToString();
            this.NgayDKTV = (DateTime)row["NgayDKTV"];

            if (row["SoTienNo"].ToString() != ""
                && row["SoTienNo"].ToString() != null)
                this.soTienno = (decimal)row["SoTienNo"];
            else
                this.soTienno = 0;
        }



        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private string hoten;
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }

        private string sdt_kh;
        public string SDT_KH
        {
            get { return sdt_kh; }
            set { sdt_kh = value; }
        }

        private string email_kh;
        public string Email_KH
        {
            get { return email_kh; }
            set { email_kh = value; }
        }

        private string diachi_kh;
        public string DiaChi_KH
        {
            get { return diachi_kh; }
            set { diachi_kh = value; }
        }

        private string gioitinh_kh;
        public string GioiTinh_KH
        {
            get { return gioitinh_kh; }
            set { gioitinh_kh = value; }
        }

        private DateTime ngaydktv;
        public DateTime NgayDKTV
        {
            get { return ngaydktv; }
            set { ngaydktv = value; }
        }

        private decimal soTienno;
        public decimal SoTienNo
        {
            get { return soTienno; }
            set { soTienno = value; }
        }

    }
}
