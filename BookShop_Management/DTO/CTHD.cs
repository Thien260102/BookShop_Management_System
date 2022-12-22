using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class CTHD
    {
        public CTHD(string maHD, string maSach, int sl_hd)
        {
            this.maHD = maHD;
            this.maSach = maSach;
            this.sl_hd = sl_hd;
        }

        public CTHD(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaSach = row["MaSach"].ToString();
            this.SL_HD = (int)row["SL_HD"];
        }

        private string maHD;
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        private string maSach;
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        private int sl_hd;
        public int SL_HD
        {
            get { return sl_hd; }
            set { sl_hd = value; }
        }
    }
}
