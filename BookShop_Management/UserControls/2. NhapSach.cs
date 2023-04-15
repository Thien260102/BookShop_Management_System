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
using BookShop_Management.DTO;

namespace BookShop_Management.UserControls
{
    public partial class NhapSach : UserControl
    {
        private DataTable ThongTinSach = ThongTinSachDAO.Instance.LayDS_ThongTinSach();

        #region Methods

        public NhapSach()
        {
            InitializeComponent();

            label_NhapSachH1.Text = Variables.label_NhapSachH1;
            label_NhapSachH1.Left = (panel_NhapSachTop.Width - label_NhapSachH1.Width) / 2;
            label_NhapSachH1.Top = (panel_NhapSachTop.Height - label_NhapSachH1.Height) / 2;

            button_Save.Text = Variables.button_Save;

            label_MaSach.Text = Variables.label_MaSach;
            label_TenSach.Text = Variables.label_TenSach;
            label_TheLoai.Text = Variables.label_TheLoai;
            label_TacGia.Text = Variables.label_TacGia;
            label_SoLuong.Text = Variables.label_SoLuong;
            label_DonGia.Text = Variables.label_DonGia;
            label_NgayNhap.Text = Variables.label_NgayNhap;

            textBox_TenSach.ReadOnly = true;
            textBox_TheLoai.ReadOnly = true;
            textBox_TacGia.ReadOnly = true;

        }

        private void ReFresh()
        {
            textBox_DonGia.Text = "";
            listView_NhapSach.Items.Clear();
        }

        private void ListView_Add()
        {
            int position = -1;
            for(int i = 0; i < listView_NhapSach.Items.Count; i++)
                if (listView_NhapSach.Items[i].SubItems[1].Text == comboBox_MaSach.SelectedItem.ToString())
                {
                    position = i;
                    break;
                }

            if(position == -1)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (listView_NhapSach.Items.Count + 1).ToString();

                item.SubItems.Add(comboBox_MaSach.SelectedItem.ToString());
                item.SubItems.Add(textBox_TenSach.Text);
                item.SubItems.Add(textBox_TheLoai.Text);
                item.SubItems.Add(textBox_TacGia.Text);
                item.SubItems.Add(textBox_SoLuong.Text);
                item.SubItems.Add(double.Parse(textBox_DonGia.Text).ToString("# ### ###"));
                item.SubItems.Add((dateTimePicker_NgayNhap.Value).ToString("yyyy-MM-dd HH:mm:ss"));

                listView_NhapSach.Items.Add(item);
            }
            else
            {
                listView_NhapSach.Items[position].SubItems[5].Text =
                    (int.Parse(listView_NhapSach.Items[position].SubItems[5].Text) +
                    int.Parse(textBox_SoLuong.Text)).ToString();
            }
        }

        #endregion

        #region Events

        private void NhapSach_Load(object sender, EventArgs e)
        {
            textBox_SoLuong.Text = ThamSoDAO.Instance.LayGiaTriTu_TenThamSo("So luong nhap toi thieu").ToString();

            for (int i = 0; i < ThongTinSach.Rows.Count; i++) 
            {
                comboBox_MaSach.Items.Add(ThongTinSach.Rows[i]["MaSach"]);
            }
            if(comboBox_MaSach.Items.Count > 0)
                comboBox_MaSach.SelectedIndex = 0;
        }

        private void panel_NhapSachTop_SizeChanged(object sender, EventArgs e)
        {
            label_NhapSachH1.Left = (panel_NhapSachTop.Width - label_NhapSachH1.Width) / 2;
            label_NhapSachH1.Top = (panel_NhapSachTop.Height - label_NhapSachH1.Height) / 2;
        }

        Point panel_NhapSachBottom_BorderTop_Moving;
        private void panel_NhapSachBottom_BorderTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panel_NhapSachBottom_BorderTop_Moving = e.Location;
            }
        }

        private void panel_NhapSachBottom_BorderTop_MouseMove(object sender, MouseEventArgs e)
        {
            int distance = e.Y - panel_NhapSachBottom_BorderTop_Moving.Y;

            bool condition1 = e.Button == MouseButtons.Left;
            bool condition2 = panel_NhapSachFill_Bottom.Height - distance > panel_NhapSachFill_Bottom.MinimumSize.Height;
            bool condition3 = panel_NhapSachFill_Bottom.Height - distance < panel_NhapSachFill.Height * 3 / 4;

            if (condition1 && condition2 && condition3)
            {
                this.panel_NhapSachFill_Bottom.Top += distance;
                this.panel_NhapSachFill_Bottom.Height -= distance;
            }
        }

        private void button_NhapSach_Add_Click(object sender, EventArgs e)
        {
            if (comboBox_MaSach.Items.Count == 0)
                return;

            int current_stock = ThongTinSachDAO.Instance.Lay_LuongTon(comboBox_MaSach.SelectedItem.ToString());

            int SoLuongNhapToiThieu = ThamSoDAO.Instance.LayGiaTriTu_TenThamSo("So luong nhap toi thieu");

            int DonGia = 0;
            int.TryParse(textBox_DonGia.Text, out DonGia);

            string Output = "";

            if (textBox_SoLuong.Text == "")
                Output = "Yêu cầu nhập số lượng";
            else if (int.Parse(textBox_SoLuong.Text) >= SoLuongNhapToiThieu && comboBox_MaSach.SelectedItem != null
                && DonGia > 0 && current_stock < 300)
            {
                ListView_Add();
                Output = "Thêm vào danh sách thành công";
            }
            else if (int.Parse(textBox_SoLuong.Text) < SoLuongNhapToiThieu)
                Output = "Số lượng nhập tối thiểu phải lớn hơn hoặc bằng " + SoLuongNhapToiThieu;
            else if (current_stock >= 300)
                Output = "Chỉ nhập được sách có lượng tồn ít hơn 300";
            else if (DonGia <= 0)
                Output = "Yêu cầu nhập đơn giá";

            MessageBox.Show(Output, Variables.Name_App, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button_NhapSach_Remove_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView_NhapSach.SelectedItems)
            {
                MessageBox.Show("Loại bỏ thành công " + item.SubItems[2].Text, Variables.Name_App, MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView_NhapSach.Items.Remove(item);
            }
        }


        private void button_Save_Click(object sender, EventArgs e)
        {
            string Output = "";

            foreach (ListViewItem item in listView_NhapSach.Items)
            {
                int current_stock = ThongTinSachDAO.Instance.Lay_LuongTon(item.SubItems[1].Text);

                string id_sach = item.SubItems[1].Text;
                int SoLuong = int.Parse(item.SubItems[5].Text);

                string gia = item.SubItems[6].Text;
                gia = String.Concat(gia.Where(c => !Char.IsWhiteSpace(c)));
                decimal GiaNhap = decimal.Parse(gia);

                DTO.PhieuNhapSach Sach = new DTO.PhieuNhapSach(DateTime.Parse(item.SubItems[7].Text),
                    id_sach, SoLuong, GiaNhap);

                if (PhieuNhapSachDAO.Instance.NhapSach(Sach)
                    && ThongTinSachDAO.Instance.CapNhat_SoLuong_GiaBan(
                        id_sach, current_stock + SoLuong, GiaNhap * (decimal)1.05))
                    Output = "Nhập sách thành công";
                else
                {
                    Output = "Nhập sách thất bại";
                    break;
                }
            }
            if (listView_NhapSach.Items.Count == 0)
                Output = "Chưa thêm vô danh sách.";

            ReFresh();
            MessageBox.Show(Output, Variables.Name_App, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button_New_Click(object sender, EventArgs e)
        {
            using (TaoXoaSach temp = new TaoXoaSach(true))
            {
                temp.ShowDialog();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            using (TaoXoaSach temp = new TaoXoaSach(false))
            {
                temp.ShowDialog();
            }
        }

        // chỉ cho nhập số
        private void textBox_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_MaSach_SelectedValueChanged(object sender, EventArgs e)
        {
            DTO.ThongTinSach data = new DTO.ThongTinSach(ThongTinSach.Rows[comboBox_MaSach.SelectedIndex]);

            textBox_TenSach.Text = data.TenSach;
            textBox_TheLoai.Text = data.TheLoai;

            List<string> List_MaTG = CT_TacGiaDAO.Instance.LayMaTacGiaTu_MaSach(data.MaSach);

            string tacGia = "";
            for (int i = 0; i < List_MaTG.Count; i++)
            {
                if (i != 0)
                    tacGia += ",";
                tacGia += (TacGiaDAO.Instance.LayTenTacGiaTuMa(List_MaTG[i]));
            }

            textBox_TacGia.Text = String.Concat(tacGia.Where(c => !Char.IsWhiteSpace(c)));
        }

        #endregion


    }
}
