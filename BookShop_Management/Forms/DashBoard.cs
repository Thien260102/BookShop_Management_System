using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BookShop_Management.UserControls;

namespace BookShop_Management.Forms
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            this.WindowState = Variables.last_state;
            timer_CurrentTime.Enabled = true;

            DashBoard_NameApp.Text = Variables.Name_App;
            NameUser_label.Text = Login.taiKhoan.TenTK;
            RoleUser_label.Text = Login.taiKhoan.VaiTro;

            int x, y;
            x = this.ClientSize.Width;
            y = Panel_Header.Height;
            DashBoard_NameApp.Location = new System.Drawing.Point((x - DashBoard_NameApp.Width) / 2 - this.Panel_SideBar.Width, (y - DashBoard_NameApp.Height) / 2);


            ThongKe_button.Text = Variables.ThongKe_button;
            NhapSach_button.Text = Variables.NhapSach_button;
            BanSach_button.Text = Variables.BanSach_button;
            TraCuuSach_button.Text = Variables.TraCuuSach_button;
            PhieuThuTien_button.Text = Variables.PhieuThuTien_button;
            BaoCao_button.Text = Variables.BaoCao_button;
            button_BaoCaoCongNo.Text = Variables.button_BaoCaoCongNo;
            button_BaoCaoTon.Text = Variables.button_BaoCaoTon;
            LichSuBan_button.Text = Variables.LichSuBan_button;

            Setting_button.Text = Variables.Setting_button;

            Welcome_label.Text = Variables.Welcome_label;
            Role_label.Text = Variables.Role_label;


            ThongKe uch = new ThongKe();
            AddControlsToPanel(uch);

            Panel_BodySideBarRight.VerticalScroll.Visible = false;



        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MouseDown_MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void timer_CurrentTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            CurrentTime_label.Text = dt.ToString("HH:mm:ss");
            CurrentDate_label.Text = dt.ToString("d");
        }

        private void DashBoard_SizeChanged(object sender, EventArgs e)
        {
            int x, y;
            x = this.Panel_Header.Width + this.Panel_SideBar.Width;
            y = this.Panel_Header.Height;
            DashBoard_NameApp.Left = (x - DashBoard_NameApp.Width) / 2 - this.Panel_SideBar.Width;
            DashBoard_NameApp.Top = (y - DashBoard_NameApp.Height) / 2;
        }

        private void Panel_Header_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void U_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
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

        private void T_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Login login = new Login())
            {
                login.ShowDialog();
            }
            this.Dispose(true);
        }


        private void Panel_Select_ChangeLocation(int y, int height, EventArgs e)
        {
            int height_Panel_Select = Panel_Select.Height;
            
            y += (height - height_Panel_Select) / 2;
            //this.Panel_Select.Location = new System.Drawing.Point(0, y);
            this.Panel_Select.Top = y;
        }

        //#########################
        //BUTTON click
        //#########################
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            UserControl_panel.Controls.Clear();
            UserControl_panel.Controls.Add(c);
        }

        private void ThongKe_button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            Panel_Select_ChangeLocation(button.Location.Y, button.Height, e);
            
            ThongKe temp = new ThongKe();
            AddControlsToPanel(temp);
        }

        private void NhapSach_button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            Panel_Select_ChangeLocation(button.Location.Y, button.Height, e);

            NhapSach temp = new NhapSach();
            AddControlsToPanel(temp);
        }

        private void BanSach_button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            Panel_Select_ChangeLocation(button.Location.Y, button.Height, e);

            BanSach temp = new BanSach();
            AddControlsToPanel(temp);
        }

        private void TraCuuSach_button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            Panel_Select_ChangeLocation(button.Location.Y, button.Height, e);

            TraCuuSach temp = new TraCuuSach();
            AddControlsToPanel(temp);
        }

        private void PhieuThuTien_button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            Panel_Select_ChangeLocation(button.Location.Y, button.Height, e);

            PhieuThuTien temp = new PhieuThuTien();
            AddControlsToPanel(temp);
        }

        int isExpanded = -1;
        private void BaoCao_button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Panel_Select_ChangeLocation(button.Location.Y, button.Height, e);

            if (isExpanded == -1)
                BaoCao_button.Image = global::BookShop_Management.Properties.Resources.down_right_48px_1;
            else
                BaoCao_button.Image = global::BookShop_Management.Properties.Resources.icons8_google_forms_48px_1;

            isExpanded *= -1;


            timer_BaoCaoButton.Enabled = true;
            panel_BaoCaoButton_status = panel_BaoCaoButton.Height;
        }

        private void button_BaoCaoTon_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int y = button.Location.Y + BaoCao_button.Location.Y + BaoCao_button.Height;
            Panel_Select_ChangeLocation( y, button.Height, e);

            BaoCaoTon temp = new BaoCaoTon();
            AddControlsToPanel(temp);
        }

        private void button_BaoCaoCongNo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int y = button.Location.Y + BaoCao_button.Location.Y + BaoCao_button.Height;
            Panel_Select_ChangeLocation(y, button.Height, e);

            BaoCaoCongNo temp = new BaoCaoCongNo();
            AddControlsToPanel(temp);
        }

        private void LichSuBan_button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            Panel_Select_ChangeLocation(button.Location.Y, button.Height, e);

            LichSuBanSach temp = new LichSuBanSach();
            AddControlsToPanel(temp);
        }

        private void Setting_button_Click(object sender, EventArgs e)
        {
            
            using (Setting st = new Setting())
            {
                st.ShowDialog();
            }
            
        }


        //#########################
        //left Side Panel
        //#########################
        private void Adjust_Panel_Select(MouseEventArgs e)
        {
            int y = Panel_Select.Location.Y + Panel_Select.Height / 2;

            int thutu = Panel_Select.Location.Y + Panel_Select.Height / 2;
            thutu = thutu / Panel_Select.Height;
            //if (thutu < 0) thutu = 0;
            switch (thutu)
            {
                case 0:
                    ThongKe_button_Click(ThongKe_button, e);
                    break;
                case 1:
                    NhapSach_button_Click(NhapSach_button, e);
                    break;
                case 2:
                    BanSach_button_Click(BanSach_button, e);
                    break;
                case 3:
                    TraCuuSach_button_Click(TraCuuSach_button, e);
                    break;
                case 4:
                    PhieuThuTien_button_Click(PhieuThuTien_button, e);
                    break;
                case 5:
                    BaoCao_button_Click(BaoCao_button, e);
                    break;
                default:
                    LichSuBan_button_Click(LichSuBan_button, e);
                    break;
            }
            
        }

        private void Panel_BodySideBarLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel_Select.Top = e.Y - Panel_Select.Height / 2;
                Adjust_Panel_Select(e);
            }
        }


        Point Mouse_down_Location;
        private void Panel_Select_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Mouse_down_Location = e.Location;
            }
        }

        private void Panel_Select_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                 this.Panel_Select.Top += e.Y - Mouse_down_Location.Y;

            }
        }

        private void Panel_Select_MouseUp(object sender, MouseEventArgs e)
        {
            Adjust_Panel_Select(e);
        }

        int panel_status;
        private void Menu_button_Click(object sender, EventArgs e)
        {
            timer_Panel_SideBar.Enabled = true;
            panel_status = Panel_SideBar.Width;
        }
        private void timer_Panel_SideBar_Tick(object sender, EventArgs e)
        {
            if (panel_status == Panel_SideBar.MaximumSize.Width)
            {
                Panel_SideBar.Width -= 10;
                
            }
            else
            {
                Panel_SideBar.Width += 10;

            }

            if (Panel_SideBar.Width <= Panel_SideBar.MinimumSize.Width || Panel_SideBar.Width >= Panel_SideBar.MaximumSize.Width)
            {
                timer_Panel_SideBar.Enabled = false;
            }
        }

        int panel_BaoCaoButton_status;
        private void timer_BaoCaoButton_Tick(object sender, EventArgs e)
        {
            if (panel_BaoCaoButton_status == panel_BaoCaoButton.MaximumSize.Height)
            {
                panel_BaoCaoButton.Height -= 10;

            }
            else
            {
                panel_BaoCaoButton.Height += 10;

            }
            if (panel_BaoCaoButton.Height <= panel_BaoCaoButton.MinimumSize.Height || panel_BaoCaoButton.Height >= Panel_SideBar.MaximumSize.Height)
            {
                timer_BaoCaoButton.Enabled = false;
            }
        }
    }
}
