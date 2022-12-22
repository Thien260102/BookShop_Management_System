using System.Windows.Forms;
namespace BookShop_Management.UserControls
{
    partial class NhapSach
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_NhapSachFill = new System.Windows.Forms.Panel();
            this.panel_NhapSachFill_Bottom = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_MaSach = new System.Windows.Forms.ComboBox();
            this.label_MaSach = new System.Windows.Forms.Label();
            this.panel_TenSach = new System.Windows.Forms.Panel();
            this.label_TenSach = new System.Windows.Forms.Label();
            this.textBox_TenSach = new System.Windows.Forms.TextBox();
            this.panel_TheLoai = new System.Windows.Forms.Panel();
            this.textBox_TheLoai = new System.Windows.Forms.TextBox();
            this.label_TheLoai = new System.Windows.Forms.Label();
            this.panel_DonGia = new System.Windows.Forms.Panel();
            this.textBox_DonGia = new System.Windows.Forms.TextBox();
            this.label_DonGia = new System.Windows.Forms.Label();
            this.panel_TacGia = new System.Windows.Forms.Panel();
            this.label_TacGia = new System.Windows.Forms.Label();
            this.textBox_TacGia = new System.Windows.Forms.TextBox();
            this.panel_NhapSachFill_Bottom_Right = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel_NhapSachBottom_Top = new System.Windows.Forms.Panel();
            this.dateTimePicker_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.label_SoLuong = new System.Windows.Forms.Label();
            this.label_NgayNhap = new System.Windows.Forms.Label();
            this.button_NhapSach_Remove = new System.Windows.Forms.Button();
            this.button_NhapSach_Add = new System.Windows.Forms.Button();
            this.panel_NhapSachBottom_BorderTop = new System.Windows.Forms.Panel();
            this.listView_NhapSach = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TheLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGiaNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_NhapSachTop = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.label_NhapSachH1 = new System.Windows.Forms.Label();
            this.panel_NhapSachFill.SuspendLayout();
            this.panel_NhapSachFill_Bottom.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_TenSach.SuspendLayout();
            this.panel_TheLoai.SuspendLayout();
            this.panel_DonGia.SuspendLayout();
            this.panel_TacGia.SuspendLayout();
            this.panel_NhapSachFill_Bottom_Right.SuspendLayout();
            this.panel_NhapSachBottom_Top.SuspendLayout();
            this.panel_NhapSachTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_NhapSachFill
            // 
            this.panel_NhapSachFill.Controls.Add(this.panel_NhapSachFill_Bottom);
            this.panel_NhapSachFill.Controls.Add(this.listView_NhapSach);
            this.panel_NhapSachFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_NhapSachFill.Location = new System.Drawing.Point(0, 80);
            this.panel_NhapSachFill.Name = "panel_NhapSachFill";
            this.panel_NhapSachFill.Size = new System.Drawing.Size(862, 486);
            this.panel_NhapSachFill.TabIndex = 1;
            // 
            // panel_NhapSachFill_Bottom
            // 
            this.panel_NhapSachFill_Bottom.Controls.Add(this.flowLayoutPanel1);
            this.panel_NhapSachFill_Bottom.Controls.Add(this.panel_NhapSachFill_Bottom_Right);
            this.panel_NhapSachFill_Bottom.Controls.Add(this.panel8);
            this.panel_NhapSachFill_Bottom.Controls.Add(this.panel_NhapSachBottom_Top);
            this.panel_NhapSachFill_Bottom.Controls.Add(this.panel_NhapSachBottom_BorderTop);
            this.panel_NhapSachFill_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_NhapSachFill_Bottom.Location = new System.Drawing.Point(0, 286);
            this.panel_NhapSachFill_Bottom.MinimumSize = new System.Drawing.Size(862, 200);
            this.panel_NhapSachFill_Bottom.Name = "panel_NhapSachFill_Bottom";
            this.panel_NhapSachFill_Bottom.Size = new System.Drawing.Size(862, 200);
            this.panel_NhapSachFill_Bottom.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel_TenSach);
            this.flowLayoutPanel1.Controls.Add(this.panel_TheLoai);
            this.flowLayoutPanel1.Controls.Add(this.panel_DonGia);
            this.flowLayoutPanel1.Controls.Add(this.panel_TacGia);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(680, 138);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_MaSach);
            this.panel1.Controls.Add(this.label_MaSach);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 30);
            this.panel1.TabIndex = 5;
            // 
            // comboBox_MaSach
            // 
            this.comboBox_MaSach.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_MaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MaSach.FormattingEnabled = true;
            this.comboBox_MaSach.Location = new System.Drawing.Point(180, 3);
            this.comboBox_MaSach.Name = "comboBox_MaSach";
            this.comboBox_MaSach.Size = new System.Drawing.Size(154, 24);
            this.comboBox_MaSach.TabIndex = 4;
            this.comboBox_MaSach.SelectedValueChanged += new System.EventHandler(this.comboBox_MaSach_SelectedValueChanged);
            // 
            // label_MaSach
            // 
            this.label_MaSach.AutoSize = true;
            this.label_MaSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_MaSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_MaSach.Location = new System.Drawing.Point(3, 3);
            this.label_MaSach.Name = "label_MaSach";
            this.label_MaSach.Size = new System.Drawing.Size(115, 19);
            this.label_MaSach.TabIndex = 2;
            this.label_MaSach.Text = "label_MaSach";
            this.label_MaSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_TenSach
            // 
            this.panel_TenSach.Controls.Add(this.label_TenSach);
            this.panel_TenSach.Controls.Add(this.textBox_TenSach);
            this.panel_TenSach.Location = new System.Drawing.Point(343, 3);
            this.panel_TenSach.Name = "panel_TenSach";
            this.panel_TenSach.Size = new System.Drawing.Size(334, 30);
            this.panel_TenSach.TabIndex = 4;
            // 
            // label_TenSach
            // 
            this.label_TenSach.AutoSize = true;
            this.label_TenSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_TenSach.Location = new System.Drawing.Point(3, 3);
            this.label_TenSach.Name = "label_TenSach";
            this.label_TenSach.Size = new System.Drawing.Size(121, 19);
            this.label_TenSach.TabIndex = 2;
            this.label_TenSach.Text = "label_TenSach";
            this.label_TenSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_TenSach
            // 
            this.textBox_TenSach.BackColor = System.Drawing.Color.LightGray;
            this.textBox_TenSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TenSach.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_TenSach.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_TenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_TenSach.Location = new System.Drawing.Point(180, 0);
            this.textBox_TenSach.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_TenSach.Name = "textBox_TenSach";
            this.textBox_TenSach.Size = new System.Drawing.Size(154, 26);
            this.textBox_TenSach.TabIndex = 0;
            // 
            // panel_TheLoai
            // 
            this.panel_TheLoai.Controls.Add(this.textBox_TheLoai);
            this.panel_TheLoai.Controls.Add(this.label_TheLoai);
            this.panel_TheLoai.Location = new System.Drawing.Point(3, 39);
            this.panel_TheLoai.Name = "panel_TheLoai";
            this.panel_TheLoai.Size = new System.Drawing.Size(334, 30);
            this.panel_TheLoai.TabIndex = 4;
            // 
            // textBox_TheLoai
            // 
            this.textBox_TheLoai.BackColor = System.Drawing.Color.LightGray;
            this.textBox_TheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TheLoai.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_TheLoai.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_TheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_TheLoai.Location = new System.Drawing.Point(180, 0);
            this.textBox_TheLoai.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_TheLoai.Name = "textBox_TheLoai";
            this.textBox_TheLoai.Size = new System.Drawing.Size(154, 26);
            this.textBox_TheLoai.TabIndex = 1;
            // 
            // label_TheLoai
            // 
            this.label_TheLoai.AutoSize = true;
            this.label_TheLoai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_TheLoai.Location = new System.Drawing.Point(3, 3);
            this.label_TheLoai.Name = "label_TheLoai";
            this.label_TheLoai.Size = new System.Drawing.Size(116, 19);
            this.label_TheLoai.TabIndex = 2;
            this.label_TheLoai.Text = "label_TheLoai";
            this.label_TheLoai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_DonGia
            // 
            this.panel_DonGia.Controls.Add(this.textBox_DonGia);
            this.panel_DonGia.Controls.Add(this.label_DonGia);
            this.panel_DonGia.Location = new System.Drawing.Point(343, 39);
            this.panel_DonGia.Name = "panel_DonGia";
            this.panel_DonGia.Size = new System.Drawing.Size(334, 30);
            this.panel_DonGia.TabIndex = 4;
            // 
            // textBox_DonGia
            // 
            this.textBox_DonGia.BackColor = System.Drawing.Color.LightGray;
            this.textBox_DonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_DonGia.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_DonGia.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_DonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_DonGia.Location = new System.Drawing.Point(180, 0);
            this.textBox_DonGia.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_DonGia.Name = "textBox_DonGia";
            this.textBox_DonGia.Size = new System.Drawing.Size(154, 26);
            this.textBox_DonGia.TabIndex = 3;
            this.textBox_DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SoLuong_KeyPress);
            // 
            // label_DonGia
            // 
            this.label_DonGia.AutoSize = true;
            this.label_DonGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_DonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_DonGia.Location = new System.Drawing.Point(3, 3);
            this.label_DonGia.Name = "label_DonGia";
            this.label_DonGia.Size = new System.Drawing.Size(111, 19);
            this.label_DonGia.TabIndex = 2;
            this.label_DonGia.Text = "label_DonGia";
            this.label_DonGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_TacGia
            // 
            this.panel_TacGia.Controls.Add(this.label_TacGia);
            this.panel_TacGia.Controls.Add(this.textBox_TacGia);
            this.panel_TacGia.Location = new System.Drawing.Point(3, 75);
            this.panel_TacGia.Name = "panel_TacGia";
            this.panel_TacGia.Size = new System.Drawing.Size(334, 30);
            this.panel_TacGia.TabIndex = 4;
            // 
            // label_TacGia
            // 
            this.label_TacGia.AutoSize = true;
            this.label_TacGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TacGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_TacGia.Location = new System.Drawing.Point(3, 3);
            this.label_TacGia.Name = "label_TacGia";
            this.label_TacGia.Size = new System.Drawing.Size(106, 19);
            this.label_TacGia.TabIndex = 2;
            this.label_TacGia.Text = "label_TacGia";
            this.label_TacGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_TacGia
            // 
            this.textBox_TacGia.BackColor = System.Drawing.Color.LightGray;
            this.textBox_TacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TacGia.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_TacGia.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_TacGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_TacGia.Location = new System.Drawing.Point(180, 0);
            this.textBox_TacGia.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_TacGia.Name = "textBox_TacGia";
            this.textBox_TacGia.Size = new System.Drawing.Size(154, 26);
            this.textBox_TacGia.TabIndex = 2;
            // 
            // panel_NhapSachFill_Bottom_Right
            // 
            this.panel_NhapSachFill_Bottom_Right.Controls.Add(this.button_Save);
            this.panel_NhapSachFill_Bottom_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_NhapSachFill_Bottom_Right.Location = new System.Drawing.Point(680, 62);
            this.panel_NhapSachFill_Bottom_Right.Name = "panel_NhapSachFill_Bottom_Right";
            this.panel_NhapSachFill_Bottom_Right.Size = new System.Drawing.Size(182, 138);
            this.panel_NhapSachFill_Bottom_Right.TabIndex = 5;
            // 
            // button_Save
            // 
            this.button_Save.AutoSize = true;
            this.button_Save.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.button_Save.Location = new System.Drawing.Point(0, 42);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(179, 48);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "button_save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(862, 138);
            this.panel8.TabIndex = 1;
            // 
            // panel_NhapSachBottom_Top
            // 
            this.panel_NhapSachBottom_Top.BackColor = System.Drawing.Color.LightGray;
            this.panel_NhapSachBottom_Top.Controls.Add(this.dateTimePicker_NgayNhap);
            this.panel_NhapSachBottom_Top.Controls.Add(this.textBox_SoLuong);
            this.panel_NhapSachBottom_Top.Controls.Add(this.label_SoLuong);
            this.panel_NhapSachBottom_Top.Controls.Add(this.label_NgayNhap);
            this.panel_NhapSachBottom_Top.Controls.Add(this.button_NhapSach_Remove);
            this.panel_NhapSachBottom_Top.Controls.Add(this.button_NhapSach_Add);
            this.panel_NhapSachBottom_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NhapSachBottom_Top.Location = new System.Drawing.Point(0, 10);
            this.panel_NhapSachBottom_Top.Name = "panel_NhapSachBottom_Top";
            this.panel_NhapSachBottom_Top.Size = new System.Drawing.Size(862, 52);
            this.panel_NhapSachBottom_Top.TabIndex = 1;
            // 
            // dateTimePicker_NgayNhap
            // 
            this.dateTimePicker_NgayNhap.CustomFormat = "hh:mm:ss dddd MMMM dd, yyyy";
            this.dateTimePicker_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayNhap.Location = new System.Drawing.Point(159, 12);
            this.dateTimePicker_NgayNhap.Name = "dateTimePicker_NgayNhap";
            this.dateTimePicker_NgayNhap.Size = new System.Drawing.Size(178, 24);
            this.dateTimePicker_NgayNhap.TabIndex = 7;
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.BackColor = System.Drawing.Color.LightGray;
            this.textBox_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_SoLuong.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_SoLuong.Location = new System.Drawing.Point(533, 11);
            this.textBox_SoLuong.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(80, 26);
            this.textBox_SoLuong.TabIndex = 4;
            this.textBox_SoLuong.Text = "150";
            this.textBox_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SoLuong_KeyPress);
            // 
            // label_SoLuong
            // 
            this.label_SoLuong.AutoSize = true;
            this.label_SoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_SoLuong.Location = new System.Drawing.Point(353, 14);
            this.label_SoLuong.Name = "label_SoLuong";
            this.label_SoLuong.Size = new System.Drawing.Size(125, 19);
            this.label_SoLuong.TabIndex = 2;
            this.label_SoLuong.Text = "label_SoLuong";
            this.label_SoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_NgayNhap
            // 
            this.label_NgayNhap.AutoSize = true;
            this.label_NgayNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_NgayNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_NgayNhap.Location = new System.Drawing.Point(3, 14);
            this.label_NgayNhap.Name = "label_NgayNhap";
            this.label_NgayNhap.Size = new System.Drawing.Size(135, 19);
            this.label_NgayNhap.TabIndex = 2;
            this.label_NgayNhap.Text = "label_NgayNhap";
            this.label_NgayNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_NhapSach_Remove
            // 
            this.button_NhapSach_Remove.BackColor = System.Drawing.Color.Red;
            this.button_NhapSach_Remove.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_NhapSach_Remove.FlatAppearance.BorderSize = 0;
            this.button_NhapSach_Remove.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.button_NhapSach_Remove.Image = global::BookShop_Management.Properties.Resources.minus_sign_48px_1;
            this.button_NhapSach_Remove.Location = new System.Drawing.Point(662, 0);
            this.button_NhapSach_Remove.Name = "button_NhapSach_Remove";
            this.button_NhapSach_Remove.Size = new System.Drawing.Size(100, 52);
            this.button_NhapSach_Remove.TabIndex = 1;
            this.button_NhapSach_Remove.UseVisualStyleBackColor = false;
            this.button_NhapSach_Remove.Click += new System.EventHandler(this.button_NhapSach_Remove_Click);
            // 
            // button_NhapSach_Add
            // 
            this.button_NhapSach_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.button_NhapSach_Add.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_NhapSach_Add.FlatAppearance.BorderSize = 0;
            this.button_NhapSach_Add.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.button_NhapSach_Add.Image = global::BookShop_Management.Properties.Resources.plus_48px_1;
            this.button_NhapSach_Add.Location = new System.Drawing.Point(762, 0);
            this.button_NhapSach_Add.Name = "button_NhapSach_Add";
            this.button_NhapSach_Add.Size = new System.Drawing.Size(100, 52);
            this.button_NhapSach_Add.TabIndex = 1;
            this.button_NhapSach_Add.UseVisualStyleBackColor = false;
            this.button_NhapSach_Add.Click += new System.EventHandler(this.button_NhapSach_Add_Click);
            // 
            // panel_NhapSachBottom_BorderTop
            // 
            this.panel_NhapSachBottom_BorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.panel_NhapSachBottom_BorderTop.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel_NhapSachBottom_BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NhapSachBottom_BorderTop.Location = new System.Drawing.Point(0, 0);
            this.panel_NhapSachBottom_BorderTop.Name = "panel_NhapSachBottom_BorderTop";
            this.panel_NhapSachBottom_BorderTop.Size = new System.Drawing.Size(862, 10);
            this.panel_NhapSachBottom_BorderTop.TabIndex = 1;
            this.panel_NhapSachBottom_BorderTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_NhapSachBottom_BorderTop_MouseDown);
            this.panel_NhapSachBottom_BorderTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_NhapSachBottom_BorderTop_MouseMove);
            // 
            // listView_NhapSach
            // 
            this.listView_NhapSach.BackColor = System.Drawing.Color.LightGray;
            this.listView_NhapSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_NhapSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.TacGia,
            this.SoLuong,
            this.DonGiaNhap,
            this.NgayNhap});
            this.listView_NhapSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_NhapSach.FullRowSelect = true;
            this.listView_NhapSach.GridLines = true;
            this.listView_NhapSach.HideSelection = false;
            this.listView_NhapSach.Location = new System.Drawing.Point(0, 0);
            this.listView_NhapSach.Name = "listView_NhapSach";
            this.listView_NhapSach.Size = new System.Drawing.Size(862, 486);
            this.listView_NhapSach.TabIndex = 2;
            this.listView_NhapSach.UseCompatibleStateImageBehavior = false;
            this.listView_NhapSach.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // MaSach
            // 
            this.MaSach.Text = "Mã Sách";
            this.MaSach.Width = 74;
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên Sách";
            this.TenSach.Width = 150;
            // 
            // TheLoai
            // 
            this.TheLoai.Text = "Thể Loại";
            this.TheLoai.Width = 126;
            // 
            // TacGia
            // 
            this.TacGia.Text = "Tác Giả";
            this.TacGia.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số Lượng";
            this.SoLuong.Width = 100;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.Text = "Đơn Giá Nhập";
            this.DonGiaNhap.Width = 100;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Text = "Ngày Nhập";
            this.NgayNhap.Width = 100;
            // 
            // panel_NhapSachTop
            // 
            this.panel_NhapSachTop.Controls.Add(this.button_Delete);
            this.panel_NhapSachTop.Controls.Add(this.button_New);
            this.panel_NhapSachTop.Controls.Add(this.label_NhapSachH1);
            this.panel_NhapSachTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NhapSachTop.Location = new System.Drawing.Point(0, 0);
            this.panel_NhapSachTop.Name = "panel_NhapSachTop";
            this.panel_NhapSachTop.Size = new System.Drawing.Size(862, 80);
            this.panel_NhapSachTop.TabIndex = 1;
            this.panel_NhapSachTop.SizeChanged += new System.EventHandler(this.panel_NhapSachTop_SizeChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.LightGray;
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.button_Delete.Image = global::BookShop_Management.Properties.Resources.delete_file_80px;
            this.button_Delete.Location = new System.Drawing.Point(702, 0);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(80, 80);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_New
            // 
            this.button_New.BackColor = System.Drawing.Color.LightGray;
            this.button_New.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_New.FlatAppearance.BorderSize = 0;
            this.button_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_New.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.button_New.Image = global::BookShop_Management.Properties.Resources.add_book_80px;
            this.button_New.Location = new System.Drawing.Point(782, 0);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(80, 80);
            this.button_New.TabIndex = 3;
            this.button_New.UseVisualStyleBackColor = false;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // label_NhapSachH1
            // 
            this.label_NhapSachH1.AutoSize = true;
            this.label_NhapSachH1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label_NhapSachH1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_NhapSachH1.Location = new System.Drawing.Point(301, 24);
            this.label_NhapSachH1.Name = "label_NhapSachH1";
            this.label_NhapSachH1.Size = new System.Drawing.Size(205, 26);
            this.label_NhapSachH1.TabIndex = 2;
            this.label_NhapSachH1.Text = "label_NhapSachH1";
            this.label_NhapSachH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NhapSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel_NhapSachFill);
            this.Controls.Add(this.panel_NhapSachTop);
            this.Font = new System.Drawing.Font("Arial", 10.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NhapSach";
            this.Size = new System.Drawing.Size(862, 566);
            this.Load += new System.EventHandler(this.NhapSach_Load);
            this.panel_NhapSachFill.ResumeLayout(false);
            this.panel_NhapSachFill_Bottom.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_TenSach.ResumeLayout(false);
            this.panel_TenSach.PerformLayout();
            this.panel_TheLoai.ResumeLayout(false);
            this.panel_TheLoai.PerformLayout();
            this.panel_DonGia.ResumeLayout(false);
            this.panel_DonGia.PerformLayout();
            this.panel_TacGia.ResumeLayout(false);
            this.panel_TacGia.PerformLayout();
            this.panel_NhapSachFill_Bottom_Right.ResumeLayout(false);
            this.panel_NhapSachFill_Bottom_Right.PerformLayout();
            this.panel_NhapSachBottom_Top.ResumeLayout(false);
            this.panel_NhapSachBottom_Top.PerformLayout();
            this.panel_NhapSachTop.ResumeLayout(false);
            this.panel_NhapSachTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_NhapSachFill;
        private Panel panel_NhapSachTop;
        private Panel panel_NhapSachFill_Bottom;
        private Panel panel_NhapSachBottom_BorderTop;
        private Panel panel8;
        private Panel panel_NhapSachBottom_Top;
        private ListView listView_NhapSach;
        private ColumnHeader STT;
        private ColumnHeader TheLoai;
        private ColumnHeader TacGia;
        private ColumnHeader TenSach;
        private Label label_NhapSachH1;
        private ColumnHeader SoLuong;
        private ColumnHeader DonGiaNhap;
        private ColumnHeader NgayNhap;
        private Button button_NhapSach_Add;
        private Button button_NhapSach_Remove;
        private Label label_NgayNhap;
        private TextBox textBox_TenSach;
        private Label label_TenSach;
        private TextBox textBox_TheLoai;
        private Label label_TheLoai;
        private TextBox textBox_DonGia;
        private TextBox textBox_TacGia;
        private Label label_DonGia;
        private Label label_TacGia;
        private TextBox textBox_SoLuong;
        private Label label_SoLuong;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel_TenSach;
        private Panel panel_TheLoai;
        private Panel panel_TacGia;
        private Panel panel_DonGia;
        private DateTimePicker dateTimePicker_NgayNhap;
        private Panel panel_NhapSachFill_Bottom_Right;
        private Button button_New;
        private Button button_Delete;
        private Panel panel1;
        private Label label_MaSach;
        private ComboBox comboBox_MaSach;
        private ColumnHeader MaSach;
        private Button button_Save;
    }
}
