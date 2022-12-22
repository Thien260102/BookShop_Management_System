using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan()
        {
            tenTK = "";
            matKhau = "";
            maNguoiDung = "";
            vaiTro = "";
        }
        public TaiKhoan(string maTK, string tenTK, string matKhau, string maNguoiDung, string vaiTro)
        {
            this.maTK = maTK;
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.maNguoiDung = maNguoiDung;
            this.vaiTro = vaiTro;
        }

        public TaiKhoan(DataRow row)
        {
            this.MaTK = row["MaTK"].ToString();
            this.TenTK = row["TenTK"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.MaNguoiDung = row["MaNguoiDung"].ToString();
            this.VaiTro = row["VaiTro"].ToString();
        }

        private string maTK;
        public string MaTK
        {
            get { return maTK; }
            set { maTK = value; }
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }

        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string maNguoiDung;
        public string MaNguoiDung
        {
            get { return maNguoiDung; }
            set { maNguoiDung = value; }
        }

        private string vaiTro;
        public string VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }
    }
}
