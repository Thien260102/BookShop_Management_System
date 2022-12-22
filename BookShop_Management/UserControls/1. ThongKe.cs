using BookShop_Management.DAO;
using BookShop_Management.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_Management.UserControls
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();

            label_ThongKeH1.Text = Variables.label_ThongKeH1;
            label_ThongKeH1.Left = (panel_ThongKe.Width - label_ThongKeH1.Width) / 2;
            label_ThongKeH1.Top = (panel_ThongKe.Height - label_ThongKeH1.Height) / 2;

            label_NhapSachH1.Text = Variables.label_NhapSachH1;
            label_BanSachH1.Text = Variables.label_BanSachH1;
            label_KhachHangH1.Text = Variables.label_KhachHangH1;

            button_TaiKhoan.Text = Variables.button_TaiKhoan;

            if (Login.taiKhoan.VaiTro != "ADMIN")
                button_TaiKhoan.Enabled = false;
            else
                button_TaiKhoan.Enabled = true;

            LoadData();
        }

        #region Methods

        private void LoadData()
        {
            label_ValueNhapSachH1.Text = PhieuNhapSachDAO.Instance.LaySoLuongSachNhap().ToString("# ### ###");
            label_ValueBanSachH1.Text = CTHDDAO.Instance.LaySoLuongSachDaBan().ToString("# ### ###");
            label_ValueNguoiMuaH1.Text = KhachHangDAO.Instance.LaySoLuongKhachHang().ToString("# ### ###");
        }

        #endregion

        #region Events

        private void ThongKe_SizeChanged(object sender, EventArgs e)
        {
            label_ThongKeH1.Left = (panel_ThongKe.Width - label_ThongKeH1.Width) / 2;
            label_ThongKeH1.Top = (panel_ThongKe.Height - label_ThongKeH1.Height) / 2;

        }

        private void flowLayoutPanel_ThongKe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            using (Forms.TaiKhoan form_TaiKhoan = new TaiKhoan())
            {
                form_TaiKhoan.ShowDialog();
            }
        }

        #endregion


        //#########################
        //Bán Sách
        //#########################



        //#########################
        //Nhập Sách
        //#########################



        //#########################
        //Biểu Đồ
        //#########################
        /*
        Random rand = new Random();

        private void LoadChart()
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);

            dataPoint.addLabely("Jan", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Feb", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Mar", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Apr", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jun", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jul", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Aug", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sep", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Oct", rand.Next(0, 500).ToString());

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);

        }




        private Bunifu.DataViz.BunifuDataViz bunifuDataViz1;
        */
    }
}
