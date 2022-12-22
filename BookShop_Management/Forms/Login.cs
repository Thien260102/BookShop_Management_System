using System;
using System.Windows.Forms;
using BookShop_Management.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using BookShop_Management.DTO;
using BookShop_Management.DAO;

namespace BookShop_Management.Forms
{
    public partial class Login : Form
    {
        public static DTO.TaiKhoan taiKhoan;
        private int login_header_footer_propotion = 5;

        public Login()
        {
            InitializeComponent();
            this.Login_Name.Text = Variables.Name_App;

            this.Login_header.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height * login_header_footer_propotion / 100);

            this.WindowState = Variables.last_state;


        }

        private void ShowError(string message)
        {
            throw new NotImplementedException();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DangNhap()
        {
            taiKhoan = TaiKhoanDAO.Instance.LayTaiKhoanTu(textBox_TenTK.Text);
            if (taiKhoan.TenTK == "")
            {
                if(textBox_TenTK.Text != "")
                    MessageBox.Show("Sai tài khoản.", "Đăng nhập");
                else
                    MessageBox.Show("Nhập tài khoản và mật khẩu.", "Đăng nhập");
                return;
            }
            else if (taiKhoan.MatKhau != textBox_MatKhau.Text)
            {
                if (textBox_MatKhau.Text == "")
                    MessageBox.Show("Yêu cầu nhập mật khẩu.", "Đăng nhập");
                else
                    MessageBox.Show("Sai mật khẩu.", "Đăng nhập");

                return;
            }

            MessageBox.Show("Đăng nhập thành công.", "Đăng nhập");

            this.Hide();
            using (DashBoard db = new DashBoard())
            {
                db.ShowDialog();
            }
            this.Dispose(true);
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


        private void T_Button_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void I_Button_Click(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            }

            Variables.last_state = this.WindowState;
        }

        private void U_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }


        private void Login_SizeChanged(object sender, EventArgs e)
        {

            this.Login_header.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height * login_header_footer_propotion / 100);


            this.Login_Name.Location = new System.Drawing.Point((this.Login_header.Size.Width - this.Login_Name.Size.Width) / 2, (this.Login_header.Size.Height - this.Login_Name.Size.Height) / 2);
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            DangNhap();
        }


        private void NhanNut_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender.Equals(this.textBox_TenTK))
                    textBox_MatKhau.Focus();
                else DangNhap();
            }
                //DangNhap();
        }

        #endregion

    }
}