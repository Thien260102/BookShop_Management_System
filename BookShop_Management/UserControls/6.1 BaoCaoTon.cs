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
    public partial class BaoCaoTon : UserControl
    {
        public BaoCaoTon()
        {
            InitializeComponent();

            label_BaoCaoTon.Text = Variables.label_BaoCaoTon;
            label_Thang.Text = Variables.label_Thang;

            maskedTextBox_Thang.Text = DateTime.Now.Month.ToString();
            LoadData();
        }

        #region Methods

        private void LoadData()
        {
            int month;

            bool result = int.TryParse(maskedTextBox_Thang.Text, out month);
            if (result)
                Handle_Data(month);
            else
                dataGridView_BaoCaoTon_Fill.DataSource = null;
        }

        // thêm cột stt
        private void Handle_Data(int month)
        {
            DataTable dataTable = BaoCaoTonKhoDAO.Instance.LayDS_BCTK(month);

            dataTable.Columns.Add("STT", typeof(int));

            int i = 1;
            foreach (DataRow dr in dataTable.Rows)
                dr["STT"] = (i++).ToString();

            dataTable.Columns["STT"].SetOrdinal(0);

            //thay đổi column name
            if (dataTable.Columns["MaBCTK"] != null)
                dataTable.Columns["MaBCTK"].ColumnName = "Mã BCTK";
            if (dataTable.Columns["MaSach"] != null)
                dataTable.Columns["MaSach"].ColumnName = "Mã Sách";
            if (dataTable.Columns["TonDau"] != null)
                dataTable.Columns["TonDau"].ColumnName = "Tồn Đầu";
            if (dataTable.Columns["SachDaNhap"] != null)
                dataTable.Columns["SachDaNhap"].ColumnName = "Sách Đã Nhập";
            if (dataTable.Columns["SachDaBan"] != null)
                dataTable.Columns["SachDaBan"].ColumnName = "Sách Đã Bán";
            if (dataTable.Columns["TonCuoi"] != null)
                dataTable.Columns["TonCuoi"].ColumnName = "Tồn Cuối";

            dataGridView_BaoCaoTon_Fill.DataSource = dataTable;

        }
        #endregion

        #region Events
        private void maskedTextBox_Thang_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox_XuatBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoTonKhoDAO.Instance.XoaTatCa();

            List<string> DS_MaSach = ThongTinSachDAO.Instance.Lay_MaSach();

            int current_year = int.Parse(DateTime.Now.Year.ToString());


            for (int i = 0; i < DS_MaSach.Count; i++)
            {
                List<PhieuNhapSach> DS_PNS = PhieuNhapSachDAO.Instance.LayDS_PhieuNhapSachTu(DS_MaSach[i]);

                for (int j = 1; j <= 12; j++)
                {
                    List<PhieuNhapSach> DS_PNS_HienTai = new List<PhieuNhapSach>();

                    foreach (PhieuNhapSach phieu in DS_PNS)
                        if ((int)phieu.NgayNhap.Year == current_year && phieu.NgayNhap.Month == j)
                            DS_PNS_HienTai.Add(phieu);

                    List<CTHD> DS_CTHD_HienTai = CTHDDAO.Instance.LayDS_CTHD_Tu(current_year, j, DS_MaSach[i]);

                    int TonDau = BaoCaoTonKhoDAO.Instance.LayTonCuoiTu_MaSach(DS_MaSach[i], (j == 1) ? 0 : j - 1);
                    if (DS_PNS_HienTai.Count == 0 && DS_CTHD_HienTai.Count == 0 && TonDau == 0)
                        continue;

                    string MaBCTK = BaoCaoTonKhoDAO.Instance.LayMaBCTK_KeTiep();
                    int SachDaBan = 0;
                    int SachDaNhap = 0;
                    int TonCuoi = TonDau;

                    


                    foreach (CTHD ct in DS_CTHD_HienTai)
                    {
                        SachDaBan += ct.SL_HD;
                    }
                    TonCuoi -= SachDaBan;

                    foreach (PhieuNhapSach phieuNhap in DS_PNS_HienTai)
                    {
                        SachDaNhap += phieuNhap.SoLuongNhap;
                    }

                    TonCuoi += SachDaNhap;
                    
                    BaoCaoTonKho baoCao = new BaoCaoTonKho(MaBCTK, DS_MaSach[i],
                        TonDau, SachDaNhap, SachDaBan, TonCuoi, j.ToString());

                    if (BaoCaoTonKhoDAO.Instance.ThemBaoCaoTonKho(baoCao) == false)
                    {
                        MessageBox.Show("Trích xuất báo cáo thất bại.", "Báo cáo tồn kho");
                        return;
                    }

                }
            }
            MessageBox.Show("Trích xuất báo cáo thành công.", "Báo cáo tồn kho");
            LoadData();
        }
        #endregion

    }
}
