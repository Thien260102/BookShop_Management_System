using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class CT_TacGia
    {
        public CT_TacGia(string maSach, string maTacGia)
        {
            this.maSach = maSach;
            this.maTacGia = maTacGia;
        }

        public CT_TacGia(DataRow row)
        {
            this.MaTacGia = row["MaTacGia"].ToString();
            this.MaSach = row["MaSach"].ToString();
        }

        private string maSach;
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        private string maTacGia;
        public string MaTacGia
        {
            get { return maTacGia; }
            set { maTacGia = value; }
        }

    }
}
