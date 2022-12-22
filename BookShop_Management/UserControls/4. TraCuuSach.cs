using BookShop_Management.DAO;
using BookShop_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_Management.UserControls
{
    public partial class TraCuuSach : UserControl
    {
        DataTable ThongTinSach;
        DataTable temp;

        #region Methods

        public TraCuuSach()
        {
            InitializeComponent();

            label_TraCuuSach.Text = Variables.label_TraCuuSach;
            label_TenSach.Text = Variables.label_TenSach;
            label_TheLoai.Text = Variables.label_TheLoai;

            LoadData();
        }

        void LoadData()
        {
            ThongTinSach = ThongTinSachDAO.Instance.LayDS_ThongTinSachVaTacGia();

            Handle_Data();
        }

        private void Change_columnName()
        {

            if (temp.Columns["TenSach"] != null)
                temp.Columns["TenSach"].ColumnName = "Tên Sách";
            if (temp.Columns["TheLoai"] != null)
                temp.Columns["TheLoai"].ColumnName = "Thể Loại";
            if (temp.Columns["TenTacGia"] != null)
                temp.Columns["TenTacGia"].ColumnName = "Tên Tác Giả";
            if (temp.Columns["SoLuong"] != null)
                temp.Columns["SoLuong"].ColumnName = "Số Lượng";
            if (temp.Columns["GiaBan"] != null)
                temp.Columns["GiaBan"].ColumnName = "Giá Bán";
            if (temp.Columns["NgayPhatHanh"] != null)
                temp.Columns["NgayPhatHanh"].ColumnName = "Ngày Phát Hành";
            if (temp.Columns["Image"] != null)
                temp.Columns["Image"].ColumnName = "Ảnh";
        }

        private void Handle_Data()
        {
            ThongTinSach.Columns.Add("STT", typeof(int));
            ThongTinSach.Columns.Add("Image", typeof(byte[]));

            int i = 1;
            foreach (DataRow dr in ThongTinSach.Rows)
            {
                byte[] img = File.ReadAllBytes(Variables.Project_Source + "\\Picture\\" + dr["TenAnh"] + ".jpg");
                dr["Image"] = img;
                dr["STT"] = (i++).ToString();
            }

            ThongTinSach.Columns.Remove("TenAnh");
            ThongTinSach.Columns["STT"].SetOrdinal(0);


            dataGridView_TraCuuSach_Fill.CellFormatting += dataGridView_TraCuuSach_Fill_CellFormatting;

            temp = ThongTinSach.Clone();
            foreach(DataRow dr in ThongTinSach.Rows)
                    temp.Rows.Add(dr.ItemArray);

            Change_columnName();
            dataGridView_TraCuuSach_Fill.DataSource = temp;
        }

        #endregion

        #region Events


        private void TraCuuSach_Ten_TheLoai(object sender, EventArgs e)
        {
            if (textBox_TenSach.Text == "" && textBox_TheLoai.Text == "")
                dataGridView_TraCuuSach_Fill.DataSource = ThongTinSach;
            else
            {
                DataRow[] data = ThongTinSach.Select(string.Format("TenSach like '%{0}%' and TheLoai like '%{1}%'", 
                    textBox_TenSach.Text, textBox_TheLoai.Text));

                temp.Clear();
                foreach (DataRow dr in data)
                    temp.Rows.Add(dr.ItemArray);

                Change_columnName();
                dataGridView_TraCuuSach_Fill.DataSource = temp;
            }
        }

        private void dataGridView_TraCuuSach_Fill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView_TraCuuSach_Fill.Columns[e.ColumnIndex].Name == "GiaBan")
            {
                if (e.Value != null)
                {
                    try
                    {
                        e.Value = String.Format("{0:# ### ###}", e.Value);
                        e.FormattingApplied = true;
                    }
                    catch (FormatException)
                    {
                        e.FormattingApplied = false;
                    }
                }
            }
        }


        #endregion

    }
}
