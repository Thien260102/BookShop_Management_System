using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class NguoiDung
    {
        public NguoiDung(string maNguoiDung, string hoten, string sdt, string email,
           string diachi, string gioitinh)
        {
            this.maNguoiDung = maNguoiDung;
            this.hoten = hoten;
            this.sdt = sdt;
            this.email = email;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
        }

        public NguoiDung(DataRow row)
        {
            this.MaNguoiDung = row["MaNguoiDung"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Email = row["Email"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
        }

        private string maNguoiDung;
        public string MaNguoiDung
        {
            get { return maNguoiDung; }
            set { maNguoiDung = value; }
        }

        private string hoten;
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }

        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string diachi;
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string gioitinh;
        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

    }
}
