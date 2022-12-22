using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class PhieuThuNo
    {
        public PhieuThuNo(string maPTN, string maKH, DateTime ngaythutien,
            decimal sotienthanhtoan, string ghichu = "")
        {
            this.maPTN = maPTN;
            this.maKH = maKH;
            this.ngaythutien = ngaythutien;
            this.sotienthanhtoan = sotienthanhtoan;
            this.ghichu = ghichu;
        }
        
        public PhieuThuNo(DataRow row)
        {
            this.MaPTN = row["MaPTN"].ToString();
            this.MaKH = row["MaKH"].ToString();
            this.NgayThuTien = (DateTime)row["NgayThuTien"];
            this.SoTienThanhToan = (decimal)row["SoTienThanhToan"];
            this.GhiChu = row["GhiChu"].ToString();
        }

        private string maPTN;
        public string MaPTN
        {
            get { return maPTN; }
            set { maPTN = value; }
        }

        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private DateTime ngaythutien;
        public DateTime NgayThuTien
        {
            get { return ngaythutien; }
            set { ngaythutien = value; }
        }

        private decimal sotienthanhtoan;
        public decimal SoTienThanhToan
        {
            get { return sotienthanhtoan; }
            set { sotienthanhtoan = value; }
        }

        private string ghichu;
        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }
}
