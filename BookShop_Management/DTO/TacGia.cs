using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class TacGia
    {
        public TacGia(string maTacGia, string tenTacGia, DateTime ngaySinh)
        {
            this.maTacGia = maTacGia;
            this.tenTacGia = tenTacGia;
            this.ngaySinh = ngaySinh;
        }

        public TacGia(DataRow row)
        {
            this.MaTacGia = row["MaTacGia"].ToString();
            this.TenTacGia = row["TenTacGia"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
        }

        private string maTacGia;
        public string MaTacGia
        {
            get { return maTacGia; }
            set { maTacGia = value; }
        }

        private string tenTacGia;
        public string TenTacGia
        {
            get { return tenTacGia; }
            set { tenTacGia = value; }
        }

        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

    }
}
