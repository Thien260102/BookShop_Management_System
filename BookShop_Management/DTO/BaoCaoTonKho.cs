using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class BaoCaoTonKho
    {


        public BaoCaoTonKho(string maBCTK, string maSach, int tondau,
            int sachDaNhap, int sachDaBan, int toncuoi, string thang)
        {
            this.maBCTK = maBCTK;
            this.maSach = maSach;
            this.tondau = tondau;
            this.sachDaNhap = sachDaNhap;
            this.sachDaBan = sachDaBan;
            this.toncuoi = toncuoi;
            this.thang = thang;
        }

        public BaoCaoTonKho(DataRow row)
        {
            this.MaBCTK = row["MaBCTK"].ToString();
            this.MaSach = row["MaSach"].ToString();
            this.TonDau = (int)row["TonDau"];
            this.SachDaNhap = (int)row["SachDaNhap"];
            this.SachDaBan = (int)row["SachDaBan"];
            this.TonCuoi = (int)row["TonCuoi"];
            this.Thang = row["Thang"].ToString();
        }

        private string maBCTK;
        public string MaBCTK
        {
            get { return maBCTK; }
            set { maBCTK = value; }
        }

        private string maSach;
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        private int tondau;
        public int TonDau
        {
            get { return tondau; }
            set { tondau = value; }
        }

        private int sachDaNhap;
        public int SachDaNhap
        {
            get { return sachDaNhap; }
            set { sachDaNhap = value; }
        }

        private int sachDaBan;
        public int SachDaBan
        {
            get { return sachDaBan; }
            set { sachDaBan = value; }
        }

        private int toncuoi;
        public int TonCuoi
        {
            get { return toncuoi; }
            set { toncuoi = value; }
        }

        private string thang;
        public string Thang
        {
            get { return thang; }
            set { thang = value; }
        }
    }
}
