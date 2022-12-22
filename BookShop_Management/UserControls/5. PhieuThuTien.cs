using BookShop_Management.DAO;
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
    public partial class PhieuThuTien : UserControl
    {
        readonly private DataTable ThongTinKH = KhachHangDAO.Instance.LayDSKhachHang();

        #region Methods
        public PhieuThuTien()
        {
            InitializeComponent();

            label_PhieuThuTien.Text = Variables.label_PhieuThuTien;
            label_PhieuThuTien.Left = (panel_PhieuThuTien.Width - label_PhieuThuTien.Width) / 2;
            label_PhieuThuTien.Top = (panel_PhieuThuTien.Height - label_PhieuThuTien.Height) / 2;

            label_PhieuThuTien.Text = Variables.label_PhieuThuTien;

            label_TenKH.Text = Variables.label_TenKH;
            label_DiaChi.Text = Variables.label_DiaChi;
            label_DienThoai.Text = Variables.label_DienThoai;
            label_Email.Text = Variables.label_Email;
            label_NgayThu.Text = Variables.label_NgayThu;
            label_SoTienThu.Text = Variables.label_SoTienThu;

            reLoad();
        }

        private void reLoad()
        {
            textBox_DiaChi.Text = "";
            textBox_Email.Text = "";
            textBox_SDT.Text = "";
            textBox_SoTienThu.Text = "";
            textBox_TenKH.Text = "";

            /////// Ten KH  //////////
            var source = new AutoCompleteStringCollection();
            foreach (DataRow dr in ThongTinKH.Rows)
                source.Add(dr.Field<string>("HoTen"));

            textBox_TenKH.AutoCompleteCustomSource = source;
            textBox_TenKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_TenKH.AutoCompleteSource = AutoCompleteSource.CustomSource;

            /////// SDT KH  //////////
            source = new AutoCompleteStringCollection();
            foreach (DataRow dr in ThongTinKH.Rows)
                source.Add(dr.Field<string>("SDT_KH"));

            textBox_SDT.AutoCompleteCustomSource = source;
            textBox_SDT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_SDT.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private bool ThemPhieuThuNo()
        {
            string query = " HoTen = '" + textBox_TenKH.Text + "' " +
                "And SDT_KH = '" + textBox_SDT.Text + "' " +
                "And DiaChi_KH = '" + textBox_DiaChi.Text + "' " +
                "And Email_KH = '" + textBox_Email.Text + "' ";
            DataRow[] data = ThongTinKH.Select(query);
            if (data.Length == 0)
                return false;

            DTO.KhachHang khach = new DTO.KhachHang(data[0]);
            if (khach.MaKH == null || khach.MaKH == "" || data.Length > 1 
                || textBox_SoTienThu.Text == "") 
            {
                MessageBox.Show("Yêu cầu nhập đúng và đầy đủ thông tin.", "Lập phiếu thu thất bại!");
                return false;
            }
            int QD4 = ThamSoDAO.Instance.LayGiaTriTu_TenThamSo("So tien thu");

            string maPTN = PhieuThuNoDAO.Instance.LayMaPTNKeTiep();

            decimal soTienno = khach.SoTienNo;

            decimal soTienthu = decimal.Parse(textBox_SoTienThu.Text);
            
            if (QD4 == 0) // không áp dụng quy định 4
            {
                soTienno = (soTienno >= soTienthu) ? (soTienno - soTienthu) : 0;
            }
            else // áp dụng quy định 4
            {
                if (soTienthu > soTienno)
                {
                    MessageBox.Show("Không thu quá số tiền khách đang nợ.");
                    textBox_SoTienThu.Text = soTienno.ToString();
                    return false;
                }
                else
                    soTienno -= soTienthu;
            }

            try
            {
                KhachHangDAO.Instance.CapNhatTienNo(khach.MaKH, soTienno);

                DTO.PhieuThuNo phieuThuNo = new DTO.PhieuThuNo(maPTN, khach.MaKH,
                    DateTime.Parse(dateTimePicker_NgayThu.Text),
                    soTienthu);

                PhieuThuNoDAO.Instance.ThemPTN(phieuThuNo);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
            return true;
        }

        #endregion

        #region Events

        private void PhieuThuTien_SizeChanged(object sender, EventArgs e)
        {
            label_PhieuThuTien.Left = (panel_PhieuThuTien.Width - label_PhieuThuTien.Width) / 2;
            label_PhieuThuTien.Top = (panel_PhieuThuTien.Height - label_PhieuThuTien.Height) / 2;

            int border_PhieuThuTien = this.Height * 10 / 566;
            panel_PhieuThuTien_Bottom.Height = border_PhieuThuTien;
            panel_PhieuThuTien_Top.Height = border_PhieuThuTien;
            panel_PhieuThuTien_Left.Width = border_PhieuThuTien;
            panel_PhieuThuTien_Right.Width = border_PhieuThuTien;
            panel_Ngang.Height = border_PhieuThuTien;

        }


        private void flowLayoutPanel_PhieuThuTien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string notification = "";

            notification = "Bạn đã kiểm tra thông tin kỹ chưa.";

            DialogResult dialogResult = MessageBox.Show(notification, "Thêm/Xóa sách", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (ThemPhieuThuNo())
                    notification = "Lập phiếu thu nợ thành công.";
                else
                    return;

                reLoad();
            }
            else
                return;

            MessageBox.Show(notification, "Lập phiếu thu nợ");
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {

            reLoad();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string query = " HoTen = '" + textBox_TenKH.Text + "' " +
                "And SDT_KH = '" + textBox_SDT.Text + "' ";
            DataRow[] data = ThongTinKH.Select(query);

            

            if(data.Length > 0)
            {
                DTO.KhachHang khachHang = new DTO.KhachHang(data[0]);

                textBox_DiaChi.Text = khachHang.DiaChi_KH;
                textBox_Email.Text = khachHang.Email_KH;
            }
            else
            {
                textBox_DiaChi.Text = "";
                textBox_Email.Text = "";
            }

        }

        // textbox only number
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

    }
}
