using BookShop_Management.DAO;
using BookShop_Management.DTO;
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
    public partial class BaoCaoCongNo : UserControl
    {

        #region Methods
        public BaoCaoCongNo()
        {
            InitializeComponent();  

            label_BaoCaoCongNo.Text = Variables.label_BaoCaoCongNo;
            label_Thang.Text = Variables.label_Thang;

            maskedTextBox_Thang.Text = DateTime.Now.Month.ToString();
            LoadData();
        }


        private void LoadData()
        {
            int month;

            bool result = int.TryParse(maskedTextBox_Thang.Text, out month);
            if (result)
                Handle_Data(month);
            else
                dataGridView_BaoCaoCongNo_Fill.DataSource = null;
        }

        private void Handle_Data(int month)
        {
            DataTable dataTable = BaoCaoThuNoDAO.Instance.LayDS_BCTN(month);

            dataTable.Columns.Add("STT", typeof(int));

            int i = 1;
            foreach (DataRow dr in dataTable.Rows)
                dr["STT"] = (i++).ToString();

            dataTable.Columns["STT"].SetOrdinal(0);

            //thay đổi column name
            if (dataTable.Columns["MaBCTN"] != null)
                dataTable.Columns["MaBCTN"].ColumnName = "Mã BCTN";
            if (dataTable.Columns["HoTen"] != null)
                dataTable.Columns["HoTen"].ColumnName = "Họ Tên";
            if (dataTable.Columns["NoDau"] != null)
                dataTable.Columns["NoDau"].ColumnName = "Nợ Đầu";
            if (dataTable.Columns["NoCuoi"] != null)
                dataTable.Columns["NoCuoi"].ColumnName = "Nợ Cuối";
            if (dataTable.Columns["SoTienNo"] != null)
                dataTable.Columns["SoTienNo"].ColumnName = "Số Tiền Nợ";
            if (dataTable.Columns["SoTienThanhToan"] != null)
                dataTable.Columns["SoTienThanhToan"].ColumnName = "Số Tiền Thanh Toán";

            dataGridView_BaoCaoCongNo_Fill.CellFormatting += dataGridView_BaoCaoCongNo_Fill_CellFormatting;

            dataGridView_BaoCaoCongNo_Fill.DataSource = dataTable;
        }


        #endregion

        #region Events

        private void maskedTextBox_Thang_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }


        private void dataGridView_BaoCaoCongNo_Fill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView_BaoCaoCongNo_Fill.Columns[e.ColumnIndex].Name == "Nợ Đầu"
                || this.dataGridView_BaoCaoCongNo_Fill.Columns[e.ColumnIndex].Name == "Nợ Cuối"
                || this.dataGridView_BaoCaoCongNo_Fill.Columns[e.ColumnIndex].Name == "Số Tiền Nợ"
                || this.dataGridView_BaoCaoCongNo_Fill.Columns[e.ColumnIndex].Name == "Số Tiền Thanh Toán")
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


        private void pictureBox_XuatBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoThuNoDAO.Instance.XoaTatCa();

            List<string> DS_MaKH = new List<string>();
            foreach (string i in KhachHangDAO.Instance.LayDS_MaKH())
                if (i != "Null")
                    DS_MaKH.Add(i);

            int current_year = int.Parse(DateTime.Now.Year.ToString());


            for (int i = 0; i < DS_MaKH.Count; i++)
            {
                DataTable DS_PTN = PhieuThuNoDAO.Instance.LayDS_PTNTU(DS_MaKH[i]);
                List<HoaDon> DS_HoaDon = HoaDonDAO.Instance.LayDSHDTu(DS_MaKH[i]);

                for (int j = 1; j <= 12 ; j++)
                {
                    List<PhieuThuNo> DS_PTN_HienTai = new List<PhieuThuNo>();
                    foreach (DataRow dr in DS_PTN.Rows)
                        if (dr.Field<DateTime>("NgayThuTien").Year == current_year
                            && dr.Field<DateTime>("NgayThuTien").Month == j)
                            DS_PTN_HienTai.Add(new PhieuThuNo(dr));

                    List<HoaDon> DS_HD_HienTai = new List<HoaDon>();
                    foreach (HoaDon hoaDon in DS_HoaDon)
                        if (hoaDon.NgayHD.Year == current_year
                            && hoaDon.NgayHD.Month == j)
                            DS_HD_HienTai.Add(hoaDon);

                    //if (DS_PTN_HienTai.Count == 0 && DS_HD_HienTai.Count == 0)
                    //    continue;

                    decimal NoDau = BaoCaoThuNoDAO.Instance.LayNoCuoiTu_MaKH(DS_MaKH[i], (j == 1) ? 0 : j - 1);
                    if (NoDau == 0 && DS_PTN_HienTai.Count == 0 && DS_HD_HienTai.Count == 0)
                        continue;

                    string MaBCTN = BaoCaoThuNoDAO.Instance.LayMaBCTN_KeTiep();
                    decimal SoTienNo = 0;
                    decimal SoTienDaThanhToan = 0;
                    decimal NoCuoi = NoDau;

                    foreach(HoaDon hoaDon in DS_HD_HienTai)
                    {
                        SoTienNo += hoaDon.TongHoaDon;
                        SoTienDaThanhToan += hoaDon.SoTienDaThanhToan;

                        NoCuoi += (hoaDon.TongHoaDon - hoaDon.SoTienDaThanhToan);
                    }
                    foreach(PhieuThuNo phieuThu in DS_PTN_HienTai)
                    {
                        SoTienDaThanhToan += phieuThu.SoTienThanhToan;

                        NoCuoi -= (phieuThu.SoTienThanhToan);
                    }

                    BaoCaoThuNo baoCao = new BaoCaoThuNo(MaBCTN, DS_MaKH[i], j.ToString(), 
                        NoDau, NoCuoi, SoTienNo, SoTienDaThanhToan);

                    if (BaoCaoThuNoDAO.Instance.ThemBaoCaoThuNo(baoCao) == false)
                    {
                        MessageBox.Show("Trích xuất báo cáo thất bại.", "Báo cáo công nợ");
                        return;
                    }

                }

            }
            MessageBox.Show("Trích xuất báo cáo thành công.", "Báo cáo công nợ");
            LoadData();
        }

        #endregion

    }
}
