using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class BaoCaoThuNo
    {


        public BaoCaoThuNo(string maBCTN, string maKH, 
            string thang, decimal nodau, decimal nocuoi, decimal sotienno, decimal sotienthanhtoan)
        {
            this.maBCTN = maBCTN;
            this.maKH = maKH;
            this.thang = thang;
            this.nodau = nodau;
            this.nocuoi = nocuoi;
            this.sotienno = sotienno;
            this.sotienthanhtoan = sotienthanhtoan;
        }

        public BaoCaoThuNo(DataRow row)
        {
            this.MaBCTN = row["MaBCTN"].ToString();
            this.MaKH = row["MaKH"].ToString();
            this.Thang = row["Thang"].ToString();
            this.NoDau = (decimal)row["NoDau"];
            this.NoCuoi = (decimal)row["NoCuoi"];
            this.SoTienNo = (decimal)row["SoTienNo"];
            this.SoTienThanhToan = (decimal)row["SoTienThanhToan"];
        }

        private string maBCTN;
        public string MaBCTN
        {
            get { return maBCTN; }
            set { maBCTN = value; }
        }

        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private string thang;
        public string Thang
        {
            get { return thang; }
            set { thang = value; }
        }

        private decimal nodau;
        public decimal NoDau
        {
            get { return nodau; }
            set { nodau = value; }
        }

        private decimal nocuoi;
        public decimal NoCuoi
        {
            get { return nocuoi; }
            set { nocuoi = value; }
        }

        private decimal sotienno;
        public decimal SoTienNo
        {
            get { return sotienno; }
            set { sotienno = value; }
        }

        private decimal sotienthanhtoan;
        public decimal SoTienThanhToan
        {
            get { return sotienthanhtoan; }
            set { sotienthanhtoan = value; }
        }
    }
}
