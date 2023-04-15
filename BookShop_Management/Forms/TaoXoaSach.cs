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
using System.IO;
using System.Drawing.Imaging;
using BookShop_Management.DAO;
using BookShop_Management.DTO;

namespace BookShop_Management.Forms
{
    public partial class TaoXoaSach : Form
    {
        private string path_with_image = "";
        private string repository = "";
        private List<string> List_IDSach = new List<string>();
        private List<string> List_TacGia = new List<string>();

        #region Methods

        public TaoXoaSach(bool IsTao)
        {
            InitializeComponent();
            label_TaoXoaSach.Text = Variables.label_TaoSach;

            label_MaSach.Text = Variables.label_MaSach;
            label_TenSach.Text = Variables.label_TenSach;
            label_TheLoai.Text = Variables.label_TheLoai;
            label_TacGia.Text = Variables.label_TacGia;
            label_NgayPhatHanh.Text = Variables.label_NgayPhatHanh;

            label_Decription.Hide();

            label_TaoXoaSach.Top = (panel_TaoXoaSach_Top.Height - label_TaoXoaSach.Height) / 2;
            label_TaoXoaSach.Left = (panel_TaoXoaSach_Top.Width - label_TaoXoaSach.Width) / 2;

            List_IDSach = ThongTinSachDAO.Instance.Lay_MaSach();

            if (!IsTao)
            {
                label_TaoXoaSach.Text = Variables.label_XoaSach;


                textBox_TenSach.ReadOnly = true;
                textBox_TheLoai.ReadOnly = true;
                textBox_TacGia.ReadOnly = true;
                dateTimePicker_NgayPhatHanh.Enabled = false;
                pictureBox_AddImage.Enabled = false;

                textBox_MaSach.ReadOnly = false;

                var source = new AutoCompleteStringCollection();
                foreach (string i in List_IDSach)
                    source.Add(i);

                textBox_MaSach.AutoCompleteCustomSource = source;
                textBox_MaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox_MaSach.AutoCompleteSource = AutoCompleteSource.CustomSource;

                button_Save.Text = Variables.label_XoaSach;
            }
            else
            {
                textBox_MaSach.ReadOnly = true;
                //textBox_IDSach.Enabled = false;
                button_Save.Text = Variables.label_TaoSach;
            }

            List_TacGia = TacGiaDAO.Instance.LayDS_TenTacGia();
            var source_tacgia = new AutoCompleteStringCollection();
            foreach (string i in List_TacGia)
                source_tacgia.Add(i);
            textBox_TacGia.AutoCompleteCustomSource = source_tacgia;
            textBox_TacGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_TacGia.AutoCompleteSource = AutoCompleteSource.CustomSource;

            repository += (Variables.Project_Source + "\\Picture\\");
        }

        private void GetImage()
        {
            Byte[] BytesOfImage;

            OpenFileDialog ofdPatient = new OpenFileDialog();

            DialogResult dgResult = ofdPatient.ShowDialog();
            
            if(dgResult == DialogResult.OK)
            {

                path_with_image = ofdPatient.FileName;

                try
                {
                    try
                    {
                        FileStream fsRead = new FileStream(path_with_image, FileMode.Open);
                        BytesOfImage = new Byte[fsRead.Length];
                        fsRead.Read(BytesOfImage, 0, BytesOfImage.Length);
                        fsRead.Close();
                    }
                    catch{ return; }

                    string filename = Path.GetFileName(path_with_image);

                    Bitmap bm = Image.FromFile(path_with_image) as Bitmap;
                    bm.Save(repository + filename, ImageFormat.Jpeg);


                }
                catch{}

            }



        }

        private bool ThemSachMoi()
        {
            string image_Name = Path.GetFileNameWithoutExtension(path_with_image);

            if(textBox_MaSach.Text == "" || textBox_TheLoai.Text == ""
                || textBox_TenSach.Text == "" || textBox_TacGia.Text == ""
                || image_Name == "")
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin và thêm ảnh.", "Thêm sách mới thất bại");
                return false;
            }

            ThongTinSach Sach = new ThongTinSach(textBox_MaSach.Text, textBox_TheLoai.Text, 
                textBox_TenSach.Text, 0, 0,
                DateTime.Parse(dateTimePicker_NgayPhatHanh.Text), image_Name);

            if(ThongTinSachDAO.Instance.KiemTraSachDaTonTaiChua(textBox_TheLoai.Text,
                textBox_TenSach.Text, DateTime.Parse(dateTimePicker_NgayPhatHanh.Text)))
            {
                MessageBox.Show("Sách đã tồn tại.");
                return false;
            }

            if(!ThongTinSachDAO.Instance.ThemSachMoi(Sach))
            {
                MessageBox.Show("Thêm sách mới thất bại");
                return false;
            }

            /////////// xử lý về table CT_TacGia và TacGia //////////
            string[] split = textBox_TacGia.Text.Split(',');

            for(int i = 0; i < split.Length; i++)
            {
                string MaTacGia = TacGiaDAO.Instance.LayMaTacGiaTuTen(split[i]);
                if (MaTacGia == "")
                {
                    MaTacGia = TacGiaDAO.Instance.LayMaTacGiaTiepTheo();

                    if (TacGiaDAO.Instance.ThemTacGia(MaTacGia, split[i]) == false)
                    {
                        MessageBox.Show("Thêm tác giả thất bại", "Thêm sách mới thất bại");
                        return false;
                    }
                    if (CT_TacGiaDAO.Instance.ThemChiTietTacGia(textBox_MaSach.Text, MaTacGia) == false)
                    {
                        MessageBox.Show("Thêm chi tiết tác giả thất bại", "Thêm sách mới thất bại");
                        return false;
                    }
                }
                else
                {
                    if (CT_TacGiaDAO.Instance.ThemChiTietTacGia(textBox_MaSach.Text, MaTacGia) == false)
                    {
                        MessageBox.Show("Thêm chi tiết tác giả thất bại", "Thêm sách mới thất bại");
                        return false;
                    }
                }
            }

            return true;
        }

        private void clear_all()
        {
            textBox_MaSach.Text = "";
            textBox_TacGia.Text = "";
            textBox_TenSach.Text = "";
            textBox_TheLoai.Text = "";
            pictureBox_AddImage.Image = Properties.Resources.Add_Image;
        }

        #endregion

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region Events

        private void panel_TaoXoaSach_Top_SizeChanged(object sender, EventArgs e)
        {
            label_TaoXoaSach.Top = (panel_TaoXoaSach_Top.Height - label_TaoXoaSach.Height) / 2;
            label_TaoXoaSach.Left = (panel_TaoXoaSach_Top.Width - label_TaoXoaSach.Width) / 2;
        }

        private void MouseDown_MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_TaoXoaSach_Top_Click(object sender, EventArgs e)
        {
            pictureBox_AddImage.Image = null;

            this.Dispose(true);
        }

        private void pictureBox_AddImage_Click(object sender, EventArgs e)
        {
            GetImage();

            // load 
            try
            {
                Bitmap bm = Image.FromFile(path_with_image) as Bitmap;

                pictureBox_AddImage.Image = bm;
            }
            catch { }

            string filename = Path.GetFileNameWithoutExtension(path_with_image);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string notification = "";

            // xác định là tạo hay là xóa
            if (textBox_MaSach.ReadOnly == false)
                notification = "Bạn chắc chắn muốn xóa sách này?";
            else
                notification = "Bạn chắc chắn muốn thêm sách này?";


            DialogResult dialogResult = MessageBox.Show(notification, "Thêm/Xóa sách", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (textBox_MaSach.ReadOnly == true)
                {
                    if (ThemSachMoi())
                        MessageBox.Show("Thêm sách mới vào kho thành công!");
                    List_IDSach = ThongTinSachDAO.Instance.Lay_MaSach();

                }
                else
                {
                    try
                    {
                        if ((CT_TacGiaDAO.Instance.XoaCTTacGiaTu_MaSach(textBox_MaSach.Text.Trim())
                            && ThongTinSachDAO.Instance.XoaSach(textBox_MaSach.Text.Trim())))
                            MessageBox.Show("Xóa sách thành công");
                        List_IDSach = ThongTinSachDAO.Instance.Lay_MaSach();
                    }
                    catch
                    {
                        MessageBox.Show("Không xóa được sách.", "Lỗi xóa sách");
                    }
                }
                clear_all();
            }
        }

        // ID_Sach được tạo tự động dựa trên thể loại
        private void textBox_TheLoai_Leave(object sender, EventArgs e)
        {
            if (textBox_TheLoai.ReadOnly == true || textBox_TheLoai.Text == "")
                return;

            string original = textBox_TheLoai.Text;

            string[] split = original.Split(' ');

            int size = split.Length;

            // 2 kí tự đầu của thể loại
            try
            {
                if (size >= 2)
                    textBox_MaSach.Text = split[0][0].ToString() + split[1][0];
                else if (size == 1)
                    textBox_MaSach.Text = split[0][0].ToString() + split[0][split[0].Length / 2 + 1];
            }
            catch { }

            // tìm ID_Sach cuối cùng có chứa 2 kí tự ở trên
            string element = List_IDSach.FindLast(
                delegate (string ID)
                {
                    return ID.Contains(textBox_MaSach.Text);
                });

            // thêm số vô đuôi cho phù hợp
            if (element != null)
            {
                string number = "";
                for (int i = 0; i < element.Length; i++)
                    if (Char.IsDigit(element[i]))
                        number += element[i];
                int number_digit = int.Parse(number) + 1;

                if (number_digit / 100 >= 1)
                    textBox_MaSach.Text += number_digit.ToString();
                else if (number_digit / 10 >= 1)
                    textBox_MaSach.Text += ("0" + number_digit.ToString());
                else if (number_digit <= 9)
                    textBox_MaSach.Text += ("00" + number_digit.ToString());
            }
            else
                textBox_MaSach.Text += "001";
        }


        private void textBox_TacGia_TextChanged(object sender, EventArgs e)
        {
            label_Decription.Show();
        }

        private void textBox_TacGia_Leave(object sender, EventArgs e)
        {
            label_Decription.Hide();
        }

        private void textBox_MaSach_TextChanged(object sender, EventArgs e)
        {
            if (textBox_TenSach.ReadOnly == false)
                return;

            textBox_MaSach.Text = textBox_MaSach.Text.TrimStart();
            foreach (string id in List_IDSach)
                if (id == textBox_MaSach.Text)
                {
                    ThongTinSach sach = ThongTinSachDAO.Instance.LayThongTinSachTu_MaSach(textBox_MaSach.Text);

                    textBox_TenSach.Text = sach.TenSach;
                    textBox_TheLoai.Text = sach.TheLoai;
                    dateTimePicker_NgayPhatHanh.Value = sach.NgayPhatHanh;

                    List<string> List_MaTG = CT_TacGiaDAO.Instance.LayMaTacGiaTu_MaSach(textBox_MaSach.Text);

                    string tacGia = "";
                    for (int i = 0; i < List_MaTG.Count; i++)
                    {
                        if (i != 0)
                            tacGia += ",";
                        tacGia += (TacGiaDAO.Instance.LayTenTacGiaTuMa(List_MaTG[i]));
                    }


                    textBox_TacGia.Text = String.Concat(tacGia.Where(c => !Char.IsWhiteSpace(c)));

                    try
                    {

                        Bitmap image = Image.FromFile(repository + sach.TenAnh + ".jpg") as Bitmap;
                        pictureBox_AddImage.Image = image;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }

                    break;
                }

        }


        #endregion

    }
}
