using BookShop_Management.DAO;
using BookShop_Management.DTO;
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
    public partial class BanSach : UserControl
    {
        List<string> List_MaSach = ThongTinSachDAO.Instance.Lay_MaSach();
        List<string> List_MaKH = KhachHangDAO.Instance.LayDS_MaKH();

        #region Methods
        public BanSach()
        {
            InitializeComponent();

            label_BanSachH1.Text = Variables.label_BanSachH1;
            label_BanSachH1.Left = (panel_BanSachTop.Width - label_BanSachH1.Width) / 2;
            label_BanSachH1.Top = (panel_BanSachTop.Height - label_BanSachH1.Height) / 2;

            label_DonGia.Text = Variables.label_DonGia;
            label_MaKH.Text = Variables.label_MaKH;
            label_TenKH.Text = Variables.label_TenKH;
            label_MaSach.Text = Variables.label_MaSach;
            label_TenSach.Text = Variables.label_TenSach;
            label_TonKho.Text = Variables.label_TonKho;
            label_TongTien.Text = Variables.label_TongTien;
            label_NgayBan.Text = Variables.label_NgayBan;
            label_SoLuong.Text = Variables.label_SoLuong;
            label_MaHD.Text = Variables.label_MaHD;
            label_TongHoaDon.Text = Variables.label_TongHoaDon;
            label_SoTienTra.Text = Variables.label_TienTra;
            label_ConLai.Text = Variables.label_ConLai;
            label_SDT.Text = Variables.label_DienThoai;

            button_Save.Text = Variables.button_Save;
            ReFresh();
        }

        private void ListView_Add()
        {
            int position = -1;
            for (int i = 0; i < listView_BanSach.Items.Count; i++)
                if (listView_BanSach.Items[i].SubItems[3].Text == comboBox_MaSach.SelectedItem.ToString())
                {
                    position = i;
                    break;
                }

            if(position == -1)
            {
                KhachHang khach = KhachHangDAO.Instance.LayThongTinKHTu_MaKH(comboBox_MaKH.SelectedItem.ToString());

                ListViewItem item = new ListViewItem();
                item.Text = (listView_BanSach.Items.Count + 1).ToString();

                item.SubItems.Add(khach.MaKH);
                item.SubItems.Add(khach.HoTen);
                item.SubItems.Add(comboBox_MaSach.SelectedItem.ToString());
                item.SubItems.Add(dateTimePicker_NgayBan.Text);
                item.SubItems.Add(textBox_SoLuong.Text);
                item.SubItems.Add(textBox_DonGia.Text);
                item.SubItems.Add(textBox_TongTien.Text);

                listView_BanSach.Items.Add(item);
                comboBox_MaKH.Enabled = false;
            }
            else
            {
                listView_BanSach.Items[position].SubItems[5].Text =
                        (int.Parse(listView_BanSach.Items[position].SubItems[5].Text) +
                        int.Parse(textBox_SoLuong.Text)).ToString();
            }
        }

        private decimal string_to_decimal(string input)
        {
            string number = "0";
            foreach (char i in input)
                if (Char.IsDigit(i))
                    number += i;

            return decimal.Parse(number);
        }

        private bool ThemHoaDon()
        {
            decimal TongHoaDon = string_to_decimal(textBox_TongHoaDon.Text);
            decimal SoTienTra = string_to_decimal(textBox_SoTienTra.Text);

            HoaDon hoaDon = new HoaDon(textBox_MaHD.Text, comboBox_MaKH.SelectedItem.ToString(),
                DateTime.Parse(dateTimePicker_NgayBan.Text), 0, TongHoaDon, SoTienTra, Login.taiKhoan.MaNguoiDung);

            if(HoaDonDAO.Instance.ThemHoaDon(hoaDon) == false)
            {
                MessageBox.Show("Kiểm tra hóa đơn.", "Lỗi thêm hóa đơn.");
                return false;
            }

            for(int i = 0; i < listView_BanSach.Items.Count; i++)
            {
                CTHD cthd = new CTHD(hoaDon.MaHD, listView_BanSach.Items[i].SubItems[3].Text,
                    int.Parse(listView_BanSach.Items[i].SubItems[5].Text));

                if (CTHDDAO.Instance.ThemCTHD(cthd) == false)
                {
                    MessageBox.Show("Kiểm tra hóa đơn.", "Lỗi thêm chi tiết hóa đơn.");
                    return false;
                }
            }

            return true;
        }

        private void ReFresh()
        {
            listView_BanSach.Items.Clear();
            textBox_ConLai.Text = "0";
            textBox_TongHoaDon.Text = "0";
            textBox_SoTienTra.Text = "0";

            textBox_MaHD.Text = HoaDonDAO.Instance.LayMaHD_KeTiep(HoaDonDAO.Instance.LayMaHD_CuoiCung());
            comboBox_MaKH.DataSource = List_MaKH;
            comboBox_MaSach.DataSource = List_MaSach;
        }
        #endregion

        #region Events

        private void panel_BanSachTop_SizeChanged(object sender, EventArgs e)
        {
            label_BanSachH1.Left = (panel_BanSachTop.Width - label_BanSachH1.Width) / 2;
            label_BanSachH1.Top = (panel_BanSachTop.Height - label_BanSachH1.Height) / 2;
        }

        Point panel_BanSachBottom_BorderTop_Moving;
        private void panel_BanSachBottom_BorderTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panel_BanSachBottom_BorderTop_Moving = e.Location;
            }
        }

        private void panel_BanSachBottom_BorderTop_MouseMove(object sender, MouseEventArgs e)
        {
            int distance = e.Y - panel_BanSachBottom_BorderTop_Moving.Y;

            bool condition1 = e.Button == MouseButtons.Left;
            bool condition2 = panel_BanSachFill_Bottom.Height - distance > panel_BanSachFill_Bottom.MinimumSize.Height;
            bool condition3 = panel_BanSachFill_Bottom.Height - distance < panel_BanSachFill.Height * 3 / 4;

            if (condition1 && condition2 && condition3)
            {
                this.panel_BanSachFill_Bottom.Top += distance;
                this.panel_BanSachFill_Bottom.Height -= distance;
            }
        }

        private void button_BanSach_Add_Click(object sender, EventArgs e)
        {
            if (comboBox_MaKH.Items.Count == 0)
                return;

            string Notify = "";

            decimal TienNo = KhachHangDAO.Instance.LayTienNoTuMaKH(comboBox_MaKH.SelectedItem.ToString());
            decimal TienNoToiDa = ThamSoDAO.Instance.LayGiaTriTu_TenThamSo("Tien no toi da");
            int LuongTonToiThieu = ThamSoDAO.Instance.LayGiaTriTu_TenThamSo("Luong ton toi thieu");
            int TonKho = int.Parse(textBox_TonKho.Text);

            int soLuongDaThem = 0;
            foreach(ListViewItem i in listView_BanSach.Items)
                if(i.SubItems[2].Text == comboBox_MaSach.SelectedItem.ToString())
                {
                    soLuongDaThem = int.Parse(i.SubItems[5].Text);
                    break;
                }

            int SoLuongMua;
            if (int.TryParse(textBox_SoLuong.Text, out SoLuongMua) == false
                || int.Parse(textBox_SoLuong.Text) < 1)
                Notify = "Yêu cầu nhập vào số lượng cần mua";
            else if (TienNo >= TienNoToiDa)
                Notify = "Khách hàng đã nợ quá " + TienNoToiDa.ToString("# ### ###") +
                    "\nYêu cầu thanh toán nợ trước khi mua sách.";
            else if((TonKho - SoLuongMua - soLuongDaThem) < LuongTonToiThieu )
                Notify = "Chỉ có thể bán sách này với số lượng <= " + (TonKho - LuongTonToiThieu);
            else
            {
                ListView_Add();
                Notify = "Thêm vào danh sách thành công";

                // tính toán tổng hóa đơn
                decimal TongHoaDon = 0;
                foreach (ListViewItem item in listView_BanSach.Items)
                {
                    string TongTien = String.Concat(item.SubItems[7].Text.Where(c => !Char.IsWhiteSpace(c)));

                    TongHoaDon += decimal.Parse(TongTien);
                }
                textBox_TongHoaDon.Text = TongHoaDon.ToString("# ### ###");
            }    

            MessageBox.Show(Notify, Variables.Name_App, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button_BanSach_Remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_BanSach.SelectedItems)
            {
                MessageBox.Show("Loại bỏ thành công " + item.SubItems[3].Text, Variables.Name_App, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_TongHoaDon.Text = (string_to_decimal(textBox_TongHoaDon.Text) -
                    string_to_decimal(item.SubItems[7].Text)).ToString();
                listView_BanSach.Items.Remove(item);
            }
            if (listView_BanSach.Items.Count == 0)
                comboBox_MaKH.Enabled = true;
        }


        private void button_Save_Click(object sender, EventArgs e)
        {
            string Notify = "";
            if (listView_BanSach.Items.Count == 0)
                Notify += "Chưa thêm sách vào danh sách mua hàng.";
            else
            {
                decimal TienNo = KhachHangDAO.Instance.LayTienNoTuMaKH(comboBox_MaKH.SelectedItem.ToString());
                decimal TienNoToiDa = ThamSoDAO.Instance.LayGiaTriTu_TenThamSo("Tien no toi da");
                decimal TongHD = string_to_decimal(textBox_TongHoaDon.Text);
                decimal SoTienTra = string_to_decimal(textBox_SoTienTra.Text);

                if(SoTienTra >= TongHD)
                {
                    textBox_ConLai.Text = (SoTienTra - TongHD).ToString();
     
                    if(ThemHoaDon())
                    {
                        Notify += "Lập hóa đơn bán sách thành công. \n Tiền thừa: " + textBox_ConLai.Text;
                        ReFresh();
                    }
                }
                else
                {
                    if (listView_BanSach.Items[0].SubItems[1].Text == "Null")
                    {
                        Notify += "Khách hàng phải trả " + TongHD;
                    }
                    else
                    {
                        if (TienNoToiDa < (TienNo + TongHD - SoTienTra))
                            Notify += "Khách hàng phải trả ít nhất " + (TienNo + TongHD - TienNoToiDa);
                        else
                        {
                            if(ThemHoaDon())
                            {
                                textBox_ConLai.Text = "0";

                                TienNo += (TongHD - SoTienTra);

                                KhachHangDAO.Instance.CapNhatTienNo(listView_BanSach.Items[0].SubItems[1].Text,
                                    TienNo);
                                foreach(ListViewItem i in listView_BanSach.Items)
                                {
                                    string MaSach = i.SubItems[3].Text;
                                    int luongTon = ThongTinSachDAO.Instance.Lay_LuongTon(MaSach);

                                    ThongTinSachDAO.Instance.CapNhat_SoLuong(MaSach,
                                        luongTon - int.Parse(i.SubItems[5].Text));
                                }

                                Notify += "Lập hóa đơn bán sách thành công. \n Tiền nợ hiện tại của khách: " + TienNo;
                                ReFresh();
                            }
                        }    
                    }
                }
                
            }

            MessageBox.Show(Notify, Variables.Name_App, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // chỉ cho phép nhập số.
        private void textBox_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_MaKH_SelectedValueChanged(object sender, EventArgs e)
        {
            KhachHang khachHang = KhachHangDAO.Instance.LayThongTinKHTu_MaKH(comboBox_MaKH.SelectedItem.ToString());

            textBox_TenKH.Text = khachHang.HoTen;
            textBox_SDT.Text = khachHang.SDT_KH;
        }

        private void comboBox_MaSach_SelectedValueChanged(object sender, EventArgs e)
        {
            ThongTinSach thongTinSach = ThongTinSachDAO.Instance.LayThongTinSachTu_MaSach(comboBox_MaSach.SelectedItem.ToString());

            textBox_TenSach.Text = thongTinSach.TenSach;
            textBox_TonKho.Text = thongTinSach.SoLuong.ToString();
            textBox_DonGia.Text = thongTinSach.GiaBan.ToString("# ### ###");

            textBox_TongTien.Text = (thongTinSach.GiaBan * decimal.Parse(textBox_SoLuong.Text)).ToString("# ### ###");
        }


        private void textBox_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SoLuong.Text == "" || int.Parse(textBox_SoLuong.Text) == 0)
                return;

            string gia = textBox_DonGia.Text;
            gia = String.Concat(gia.Where(c => !Char.IsWhiteSpace(c)));
            decimal GiaBan = decimal.Parse(gia);

            textBox_TongTien.Text = (GiaBan * int.Parse(textBox_SoLuong.Text)).ToString("# ### ###");

        }

        private void textBox_SoTienTra_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SoTienTra.Text == ""
                || int.Parse(textBox_SoTienTra.Text) == 0)
                return;

            if (textBox_TongHoaDon.Text == "")
                return;

            string[] split = textBox_TongHoaDon.Text.Split(' ');

            string tongHD = "";
            foreach (string i in split)
                tongHD += i;

            decimal tongHoaDon = decimal.Parse(tongHD);
            decimal soTienTra = decimal.Parse(textBox_SoTienTra.Text);

            textBox_ConLai.Text = (tongHoaDon - soTienTra).ToString();
        }


        private void button_Refresh_Click(object sender, EventArgs e)
        {
            ReFresh();
        }

        #endregion

    }
}
