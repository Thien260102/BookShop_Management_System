using BookShop_Management.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace BookShop_Management.Forms
{
    public partial class TaiKhoan : Form
    {
        DataTable DS_TaiKhoan;
        List<string> DS_MaNguoiDung;
        public TaiKhoan()
        {
            InitializeComponent();

            button_Save.Text = Variables.button_Save;

            label_TaiKhoan.Text = Variables.button_TaiKhoan;
            label_MaNguoiDung.Text = Variables.label_MaNguoiDung;
            label_MaTK.Text = Variables.label_MaTK;
            label_MatKhau.Text = Variables.label_MatKhau;
            label_TenTK.Text = Variables.label_TenTK;
            label_VaiTro.Text = Variables.label_VaiTro;

            label_Xoa.Visible = false;

            label_TaiKhoan.Top = (panel_TaiKhoan_Top.Height - label_TaiKhoan.Height) / 2;
            label_TaiKhoan.Left = (panel_TaiKhoan_Top.Width - label_TaiKhoan.Width) / 2;

            LoadData();

        }

        private void LoadData()
        {
            DS_TaiKhoan = TaiKhoanDAO.Instance.LayDS_TaiKhoan();

            Handle_Data();

            dataGridView_TaiKhoan.DataSource = DS_TaiKhoan;

            DS_MaNguoiDung = NguoiDungDAO.Instance.LayDS_MaNguoiDung();
            comboBox_MaND.DataSource = DS_MaNguoiDung;

            List<string> DS_MaTK = new List<string>();
            foreach (DataRow dr in DS_TaiKhoan.Rows)
                DS_MaTK.Add(dr["MaTK"].ToString());
            comboBox_MaTK.DataSource = DS_MaTK;

        }

        private void Handle_Data()
        {
            DS_TaiKhoan.Columns.Add("STT", typeof(int));

            int i = 1;
            foreach (DataRow dr in DS_TaiKhoan.Rows)
            {
                dr["STT"] = (i++).ToString();
            }

            DS_TaiKhoan.Columns["STT"].SetOrdinal(0);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region Events
        private void button_TaiKhoan_Top_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string notify = "";
            if (comboBox_MaTK.Text == "" || comboBox_MaND.Text == "" || comboBox_VaiTro.Text == ""
                || textBox_TenTK.Text == "" || textBox_MatKhau.Text == "")
            {
                notify = "Yêu cầu nhập đủ thông tin.";
            }
            else
            {
                bool flag = false;

                if (dataGridView_TaiKhoan.Rows.Count != 0)
                {
                    foreach(DataGridViewRow i in dataGridView_TaiKhoan.Rows)
                        if(i.Cells["TenTK"].Value != null
                            && i.Cells["TenTK"].Value.ToString() == textBox_TenTK.Text)
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại.", "Tài Khoản.");
                            return;
                        }

                    foreach (var i in comboBox_MaTK.Items)
                        if (i.ToString() == comboBox_MaTK.Text)
                        {
                            flag = true;
                            break;
                        }
                }    

                DTO.TaiKhoan tk = new DTO.TaiKhoan(comboBox_MaTK.Text, textBox_TenTK.Text,
                textBox_MatKhau.Text, comboBox_MaND.Text, comboBox_VaiTro.Text);

                

                if (flag)
                {
                    if (TaiKhoanDAO.Instance.CapNhatTK(tk))
                        notify = "Cập nhật tài khoản thành công.";
                    else
                        notify = "Cập nhật tài khoản thất bại.";

                    flag = false;
                }
                else
                {
                    if (TaiKhoanDAO.Instance.ThemTK(tk))
                        notify = "Thêm mới tài khoản thành công.";
                    else
                        notify = "Thêm mới tài khoản thất bại.";
                }


            }

            MessageBox.Show(notify, "Tài Khoản");
            LoadData();
        }

        private void comboBox_MaTK_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow[] data = DS_TaiKhoan.Select("MaTK = '" + comboBox_MaTK.Text + "'");

                if (data.Length > 0)
                {
                    DTO.TaiKhoan tk = new DTO.TaiKhoan(data[0]);

                    textBox_MatKhau.Text = tk.MatKhau;
                    textBox_TenTK.Text = tk.TenTK;
                    comboBox_MaND.Text = tk.MaNguoiDung;
                    comboBox_VaiTro.Text = tk.VaiTro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox_MaTK_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_MaTK.Text != "")
            {
                try
                {
                    DataRow[] data = DS_TaiKhoan.Select("MaTK = '" + comboBox_MaTK.Text + "'");


                    DTO.TaiKhoan tk = new DTO.TaiKhoan();

                    if (data.Length != 0)
                    {
                        tk = new DTO.TaiKhoan(data[0]);
                    }

                    textBox_MatKhau.Text = tk.MatKhau;
                    textBox_TenTK.Text = tk.TenTK;
                    comboBox_MaND.Text = tk.MaNguoiDung;
                    comboBox_VaiTro.Text = tk.VaiTro;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void dataGridView_TaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                label_Xoa.Visible = false;
                return;
            }
            else
            {
                
                var hit = dataGridView_TaiKhoan.HitTest(e.X, e.Y);
                dataGridView_TaiKhoan.ClearSelection();
                dataGridView_TaiKhoan.Rows[hit.RowIndex].Selected = true;

                label_Xoa.Visible = true;

                Point location = new Point(e.X + dataGridView_TaiKhoan.Location.X,
                    e.Y + dataGridView_TaiKhoan.Location.Y - label_Xoa.Size.Height);
                label_Xoa.Location = location;

            }
        }

        private void label_Xoa_MouseHover(object sender, EventArgs e)
        {
            label_Xoa.BackColor = Color.Aqua;
        }

        private void label_Xoa_MouseLeave(object sender, EventArgs e)
        {
            label_Xoa.BackColor = Color.White;
        }

        private void label_Xoa_Click(object sender, EventArgs e)
        {
            label_Xoa.BackColor = Color.White;
            label_Xoa.Visible = false;

            DataGridViewSelectedRowCollection data = dataGridView_TaiKhoan.SelectedRows;

            if (data == null || data.Count == 0 || data[0].Cells["MaTK"].Value == null)
                return;

            string maTK = data[0].Cells["MaTK"].Value.ToString();

            if(maTK != "" && TaiKhoanDAO.Instance.XoaTK(maTK))
            {
                LoadData();
            }
            
        }
        #endregion

    }
}
