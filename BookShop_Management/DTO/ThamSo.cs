using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Management.DTO
{
    public class ThamSo
    {
        public ThamSo(string maThamSo, string tenThamSo, int giatri)
        {
            this.maThamSo = maThamSo;
            this.tenThamSo = tenThamSo;
            this.giatri = giatri;
        }

        public ThamSo(DataRow row)
        {
            this.MaThamSo = row["MaThamSo"].ToString();
            this.TenThamSo = row["TenThamSo"].ToString();
            this.GiaTri = (int)row["GiaTri"];
        }
        private string maThamSo;
        public string MaThamSo
        {
            get { return maThamSo; }
            set { maThamSo = value; }
        }

        private string tenThamSo;
        public string TenThamSo
        {
            get { return tenThamSo; }
            set { tenThamSo = value; }
        }

        private int giatri;
        public int GiaTri
        {
            get { return giatri; }
            set { giatri = value; }
        }

    }
}
