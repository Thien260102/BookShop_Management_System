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
    public partial class LichSuBanSach : UserControl
    {
        DataTable DS_LichSuBanSach;
        DataTable temp;

        #region Methods

        public LichSuBanSach()
        {
            InitializeComponent();

            label_LichSuBanSach.Text = Variables.label_LichSuBanSach;

            LoadData();
        }

        private void Change_ColumnName()
        {
            // thay đổi column name
            if (temp.Columns["MaHD"] != null)
                temp.Columns["MaHD"].ColumnName = "Mã HD";
            if (temp.Columns["MaKH"] != null)
                temp.Columns["MaKH"].ColumnName = "Mã KH";
            if (temp.Columns["NgayHD"] != null)
                temp.Columns["NgayHD"].ColumnName = "Ngày HD";
            if (temp.Columns["TongHoaDon"] != null)
                temp.Columns["TongHoaDon"].ColumnName = "Tổng HD";
            if (temp.Columns["SoTienDaThanhToan"] != null)
                temp.Columns["SoTienDaThanhToan"].ColumnName = "Số Tiền Đã Thanh Toán";
            if (temp.Columns["MaNguoiDung"] != null)
                temp.Columns["MaNguoiDung"].ColumnName = "Mã ND";
        }

        private void LoadData()
        {
            DS_LichSuBanSach = HoaDonDAO.Instance.LayDS_HD();

            Handle_Data();
        }


        private void Handle_Data()
        {
            DS_LichSuBanSach.Columns.Add("STT", typeof(int));

            int i = 1;
            foreach (DataRow dr in DS_LichSuBanSach.Rows)
                dr["STT"] = (i++).ToString();


            DS_LichSuBanSach.Columns["STT"].SetOrdinal(0);
            DS_LichSuBanSach.Columns.Remove("GiamGia");

            

            dataGridView_LichSuBanSach_Fill.CellFormatting += dataGridView_LichSuBanSach_Fill_CellFormatting;

            temp = DS_LichSuBanSach.Clone();
            foreach (DataRow dr in DS_LichSuBanSach.Rows)
                temp.Rows.Add(dr.ItemArray);

            Change_ColumnName();

            dataGridView_LichSuBanSach_Fill.DataSource = temp;
        }
        #endregion

        #region Events

        //format money
        private void dataGridView_LichSuBanSach_Fill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView_LichSuBanSach_Fill.Columns[e.ColumnIndex].Name == "Tổng HD"
                || this.dataGridView_LichSuBanSach_Fill.Columns[e.ColumnIndex].Name == "Số Tiền Đã Thanh Toán")
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

        private void textBox_TraCuu_TextChanged(object sender, EventArgs e)
        {
            if (textBox_TraCuu.Text == "")
                dataGridView_LichSuBanSach_Fill.DataSource = DS_LichSuBanSach;
            else
            {
                DataRow[] data = DS_LichSuBanSach.Select(string.Format("MaKH like '%{0}%'",
                    textBox_TraCuu.Text));

                if (data.Length == 0)
                {
                    data = DS_LichSuBanSach.Select(string.Format("MaHD like '%{0}%'",
                    textBox_TraCuu.Text));
                }

                temp.Clear();
                foreach (DataRow dr in data)
                    temp.Rows.Add(dr.ItemArray);

                Change_ColumnName();
                dataGridView_LichSuBanSach_Fill.DataSource = temp;
            }
        }

        #endregion

    }
}
