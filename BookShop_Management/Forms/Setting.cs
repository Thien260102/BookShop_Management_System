using BookShop_Management.DAO;
using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_Management.Forms
{
    public partial class Setting : Form
    {
        List<BookShop_Management.DTO.ThamSo> list_setting;

        public Setting()
        {
            InitializeComponent();
            label_Setting.Text = Variables.Setting_button;

            label_SLNhapToiThieu.Text = Variables.label_SLNhapToiThieu;
            label_LuongTonToiThieu.Text = Variables.label_LuongTonToiThieu;
            label_TienNoToiDa.Text = Variables.label_TienNoToiDa;
            button_Save.Text = Variables.button_Save;

            label_Setting.Top = (panel_Setting_Top.Height - label_Setting.Height) / 2;
            label_Setting.Left = (panel_Setting_Top.Width - label_Setting.Width) / 2;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Load_Data()
        {
            list_setting = ThamSoDAO.Instance.LayDS_ThamSo();

            foreach (DTO.ThamSo st in list_setting)
            {
                switch (st.TenThamSo)
                {
                    case "So luong nhap toi thieu":
                        textBox_SLNhapToiThieu.Text = st.GiaTri.ToString();
                        break;

                    case "Luong ton toi thieu":
                        textBox_LuongTonToiThieu.Text = st.GiaTri.ToString();
                        break;

                    case "Tien no toi da":
                        textBox_TienNoToiDa.Text = st.GiaTri.ToString("# ### ###");
                        break;

                    case "So tien thu":
                        if (st.GiaTri == 1)
                            checkBox_SoTienThu.Checked = true;
                        else
                            checkBox_SoTienThu.Checked = false;
                        break;
                }
            }
        }

        #region Events

        private void MouseDown_MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void panel_Setting_Top_SizeChanged(object sender, EventArgs e)
        {
            label_Setting.Top = (panel_Setting_Top.Height - label_Setting.Height) / 2;
            label_Setting.Left = (panel_Setting_Top.Width - label_Setting.Width) / 2;
        }

        private void button_Setting_Top_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }


        private void Setting_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            int change;
            
            // thay đổi số lượng nhập tối thiểu
            if(textBox_SLNhapToiThieu.Text != "")
            {
                change = int.Parse(textBox_SLNhapToiThieu.Text);

                int current_value = list_setting.Find(x => x.TenThamSo == "So luong nhap toi thieu").GiaTri;

                if (change > 0 && change != current_value
                    && ThamSoDAO.Instance.CapNhat_SLNhapToiThieu(change))
                    MessageBox.Show("Cập nhật 'Số lượng nhập tối thiểu' thành công");
                
            }

            // thay đổi lượng tồn tối thiểu
            if(textBox_LuongTonToiThieu.Text != "")
            {
                change = int.Parse(textBox_LuongTonToiThieu.Text);

                int current_value = list_setting.Find(x => x.TenThamSo == "Luong ton toi thieu").GiaTri;

                if (change >= 0 && change != current_value
                    && ThamSoDAO.Instance.CapNhat_LuongTonToiThieu(change))
                    MessageBox.Show("Cập nhật 'Lượng tồn tối thiểu' thành công.");
            }

            // thay đổi tiền nợ tối đa
            if(textBox_TienNoToiDa.Text != "")
            {
                string original_string = textBox_TienNoToiDa.Text;

                string[] temp = original_string.Split(' ');

                original_string = "";
                foreach (string i in temp)
                    original_string += i;

                change = int.Parse(original_string);

                int current_value = list_setting.Find(x => x.TenThamSo == "Tien no toi da").GiaTri;

                if (change >= 0 && change != current_value
                    && ThamSoDAO.Instance.CapNhat_TienNoToiDa(change))
                    MessageBox.Show("Cập nhật 'Tiền nợ tối đa' thành công.");
            }

            // thay đổi quy định 4
            switch(list_setting.Find(x => x.TenThamSo == "So tien thu").GiaTri)
            {
                case 0:
                    if (checkBox_SoTienThu.Checked == true
                        && ThamSoDAO.Instance.CapNhat_SoTienThu(1))
                        MessageBox.Show("Áp dụng quy định 'Số tiền thu không vượt quá số tiền khách đang nợ'");
                    break;
                case 1:
                    if (checkBox_SoTienThu.Checked == false
                        && ThamSoDAO.Instance.CapNhat_SoTienThu(0))
                        MessageBox.Show("Không áp dụng quy định 'Số tiền thu không vượt quá số tiền khách đang nợ'");
                    break;
            }

            //reload
            Load_Data();
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
