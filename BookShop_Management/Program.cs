using BookShop_Management.Forms;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookShop_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Get source 
            string full_source = Directory.GetCurrentDirectory();
            Variables.Project_Source = Directory.GetParent(full_source).Parent.FullName;

            Application.Run(new Login());
        }
    }
    internal struct Colors
    {
        public static readonly Color Chinh_Dam = Color.FromArgb(55, 107, 180);
        public static readonly Color Chinh_Dam_alpha_200 = Color.FromArgb(200, 55, 107, 180);
        public static readonly Color Chinh_Nhat = Color.White;
        public static readonly Color Nen_Chinh = Color.LightGray;
        public static readonly Color Selected = Color.Red;
    }

    internal struct Variables
    {
        public static FormWindowState last_state = FormWindowState.Normal;

        //Source project
        public static String Project_Source;

        //DashBoard && Login && Setting
        public static String Name_App = "QUẢN LÝ NHÀ SÁCH";

        public static String Welcome_label = "Chào: ";
        public static String Role_label = "Vai Trò: ";

        public static String ThongKe_button = "Thống kê";
        public static String LichSuBan_button = "Lịch sử bán sách";
        public static String BaoCao_button = "Báo Cáo";
        public static String button_BaoCaoTon = "Báo Cáo Tồn";
        public static String button_BaoCaoCongNo = "Báo Cáo Công Nợ";
        public static String PhieuThuTien_button = "Phiếu thu tiền";
        public static String TraCuuSach_button = "Tra cứu sách";
        public static String BanSach_button = "Bán sách";
        public static String NhapSach_button = "Nhập sách";

        public static String Setting_button = "Tùy chỉnh";
        public static String label_TienNoToiDa = "Tiền Nợ Tối Đa";
        public static String label_LuongTonToiThieu = "Lượng Tồn Tối Thiểu";
        public static String label_SLNhapToiThieu = "Số Lượng Nhập Tối Thiểu";
        public static String button_Save = "Lưu Lại";


        public static String NameUser_label = "Name User";
        public static String RoleUser_label = "Role";

        //ThongKe.cs
        public static String label_ThongKeH1 = "Thống Kê Chung";
        public static String label_ThongKeH2 = "Thống Kê Hằng Năm";
        public static String label_KhachHangH1 = "Khách Hàng";
        public static String button_TaiKhoan = "DS Tài Khoản";

        //NhapSach.cs
        public static String label_NhapSachH1 = "Nhập Sách";


        public static String label_TheLoai = "Thể Loại";
        public static String label_TacGia = "Tác Giả";
        public static String label_SoLuong = "Số Lượng";
        public static String label_DonGia = "Đơn Giá";
        public static String label_NgayNhap = "Ngày Nhập";

        public static String label_TaoSach = "Tạo Sách";
        public static String label_XoaSach = "Xóa Sách";


        public static String label_MaSach = "Mã Sách";
        public static String label_TenSach = "Tên Sách";
        public static String label_NgayPhatHanh = "Ngày Phát Hành";


        //BanSach.cs
        public static String label_BanSachH1 = "Bán Sách";
        public static String label_MaKH = "Mã Khách Hàng";
        public static String label_TenKH = "Tên Khách Hàng";
        public static String label_NgayBan = "Ngày Bán";
        public static String label_TongTien = "Tổng Tiền";
        public static String label_TienTra = "Số Tiền Trả";
        public static String label_ConLai = "Còn Lại";
        public static String label_TonKho = "Tồn Kho";
        public static String label_MaHD = "Mã Hóa Đơn";
        public static String label_TongHoaDon = "Tổng Hóa Đơn";
        //TraCuuSach.cs
        public static String label_TraCuuSach = "Tra Cứu Sách";


        //PhieuThuTien.cs
        public static String label_PhieuThuTien = "Phiếu Thu Tiền";
        public static String label_DiaChi = "Địa Chỉ";
        public static String label_DienThoai = "Số Điện Thoại";
        public static String label_Email = "Email";
        public static String label_NgayThu = "Ngày Thu";
        public static String label_SoTienThu = "Số Tiền Thu";

        //BaoCao
        public static String label_Thang = "Tháng";
        public static String label_Nam = "Năm";
        //BaoCaoTon.cs
        public static String label_BaoCaoTon = "Báo Cáo Tồn";
        //BaoCaoCongNo.cs
        public static String label_BaoCaoCongNo = "Báo Cáo Công Nợ";


        //LichSuBanSach.cs
        //public static String label_LichSuBanSach = "Lịch Sử Bán Sách";
        public static String label_LichSuBanSach = "LỊCH SỬ BÁN SÁCH";

        //TaiKhoan.cs
        public static String label_MaTK = "Mã Tài Khoản: ";
        public static String label_TenTK = "Tên Tài Khoản: ";
        public static String label_MatKhau = "Mật Khẩu: ";
        public static String label_MaNguoiDung = "Mã Người Dùng: ";
        public static String label_VaiTro = "Vai Trò: ";

    }
}
