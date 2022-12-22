using System.Windows.Forms;
namespace BookShop_Management.Forms
{
    partial class DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.Setting_button = new System.Windows.Forms.Button();
            this.Panel_SideBar = new System.Windows.Forms.Panel();
            this.Panel_BodySideBar = new System.Windows.Forms.Panel();
            this.Panel_BodySideBarRight = new System.Windows.Forms.Panel();
            this.LichSuBan_button = new System.Windows.Forms.Button();
            this.panel_BaoCaoButton = new System.Windows.Forms.Panel();
            this.button_BaoCaoCongNo = new System.Windows.Forms.Button();
            this.button_BaoCaoTon = new System.Windows.Forms.Button();
            this.BaoCao_button = new System.Windows.Forms.Button();
            this.PhieuThuTien_button = new System.Windows.Forms.Button();
            this.TraCuuSach_button = new System.Windows.Forms.Button();
            this.BanSach_button = new System.Windows.Forms.Button();
            this.NhapSach_button = new System.Windows.Forms.Button();
            this.ThongKe_button = new System.Windows.Forms.Button();
            this.Panel_BodySideBarLeft = new System.Windows.Forms.Panel();
            this.Panel_Select = new System.Windows.Forms.Panel();
            this.Panel_FooterSideBar = new System.Windows.Forms.Panel();
            this.Panel_TopSideBar = new System.Windows.Forms.Panel();
            this.Menu_button = new System.Windows.Forms.Button();
            this.Panel_LogoUIT = new System.Windows.Forms.Panel();
            this.DashBoard_LogoUIT = new System.Windows.Forms.PictureBox();
            this.Panel_TopBody = new System.Windows.Forms.Panel();
            this.CurrentDate_label = new System.Windows.Forms.Label();
            this.CurrentTime_label = new System.Windows.Forms.Label();
            this.Role_label = new System.Windows.Forms.Label();
            this.RoleUser_label = new System.Windows.Forms.Label();
            this.NameUser_label = new System.Windows.Forms.Label();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.DashBoard_NameApp = new System.Windows.Forms.Label();
            this.U_Button = new System.Windows.Forms.Button();
            this.I_Button = new System.Windows.Forms.Button();
            this.T_Button = new System.Windows.Forms.Button();
            this.UserControl_panel = new System.Windows.Forms.Panel();
            this.timer_Panel_SideBar = new System.Windows.Forms.Timer(this.components);
            this.timer_CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.timer_BaoCaoButton = new System.Windows.Forms.Timer(this.components);
            this.Panel_SideBar.SuspendLayout();
            this.Panel_BodySideBar.SuspendLayout();
            this.Panel_BodySideBarRight.SuspendLayout();
            this.panel_BaoCaoButton.SuspendLayout();
            this.Panel_BodySideBarLeft.SuspendLayout();
            this.Panel_FooterSideBar.SuspendLayout();
            this.Panel_TopSideBar.SuspendLayout();
            this.Panel_LogoUIT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoard_LogoUIT)).BeginInit();
            this.Panel_TopBody.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting_button
            // 
            this.Setting_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Setting_button.FlatAppearance.BorderSize = 3;
            this.Setting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_button.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Setting_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Setting_button.Image = global::BookShop_Management.Properties.Resources.settings_48px;
            this.Setting_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting_button.Location = new System.Drawing.Point(0, 0);
            this.Setting_button.Name = "Setting_button";
            this.Setting_button.Size = new System.Drawing.Size(338, 75);
            this.Setting_button.TabIndex = 9;
            this.Setting_button.Text = "Setting_button";
            this.Setting_button.UseVisualStyleBackColor = true;
            this.Setting_button.Click += new System.EventHandler(this.Setting_button_Click);
            // 
            // Panel_SideBar
            // 
            this.Panel_SideBar.BackColor = System.Drawing.Color.White;
            this.Panel_SideBar.Controls.Add(this.Panel_BodySideBar);
            this.Panel_SideBar.Controls.Add(this.Panel_FooterSideBar);
            this.Panel_SideBar.Controls.Add(this.Panel_TopSideBar);
            this.Panel_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_SideBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_SideBar.MaximumSize = new System.Drawing.Size(338, 10000);
            this.Panel_SideBar.MinimumSize = new System.Drawing.Size(82, 720);
            this.Panel_SideBar.Name = "Panel_SideBar";
            this.Panel_SideBar.Size = new System.Drawing.Size(338, 720);
            this.Panel_SideBar.TabIndex = 0;
            // 
            // Panel_BodySideBar
            // 
            this.Panel_BodySideBar.Controls.Add(this.Panel_BodySideBarRight);
            this.Panel_BodySideBar.Controls.Add(this.Panel_BodySideBarLeft);
            this.Panel_BodySideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_BodySideBar.Location = new System.Drawing.Point(0, 154);
            this.Panel_BodySideBar.Name = "Panel_BodySideBar";
            this.Panel_BodySideBar.Size = new System.Drawing.Size(338, 491);
            this.Panel_BodySideBar.TabIndex = 0;
            // 
            // Panel_BodySideBarRight
            // 
            this.Panel_BodySideBarRight.AutoScroll = true;
            this.Panel_BodySideBarRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Panel_BodySideBarRight.Controls.Add(this.LichSuBan_button);
            this.Panel_BodySideBarRight.Controls.Add(this.panel_BaoCaoButton);
            this.Panel_BodySideBarRight.Controls.Add(this.BaoCao_button);
            this.Panel_BodySideBarRight.Controls.Add(this.PhieuThuTien_button);
            this.Panel_BodySideBarRight.Controls.Add(this.TraCuuSach_button);
            this.Panel_BodySideBarRight.Controls.Add(this.BanSach_button);
            this.Panel_BodySideBarRight.Controls.Add(this.NhapSach_button);
            this.Panel_BodySideBarRight.Controls.Add(this.ThongKe_button);
            this.Panel_BodySideBarRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_BodySideBarRight.ForeColor = System.Drawing.Color.White;
            this.Panel_BodySideBarRight.Location = new System.Drawing.Point(19, 0);
            this.Panel_BodySideBarRight.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_BodySideBarRight.Name = "Panel_BodySideBarRight";
            this.Panel_BodySideBarRight.Size = new System.Drawing.Size(319, 491);
            this.Panel_BodySideBarRight.TabIndex = 0;
            // 
            // LichSuBan_button
            // 
            this.LichSuBan_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.LichSuBan_button.FlatAppearance.BorderSize = 0;
            this.LichSuBan_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LichSuBan_button.Image = global::BookShop_Management.Properties.Resources.icons8_timesheet_48px_1;
            this.LichSuBan_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LichSuBan_button.Location = new System.Drawing.Point(0, 382);
            this.LichSuBan_button.Name = "LichSuBan_button";
            this.LichSuBan_button.Size = new System.Drawing.Size(319, 62);
            this.LichSuBan_button.TabIndex = 8;
            this.LichSuBan_button.Text = "LichSuBan_button";
            this.LichSuBan_button.UseVisualStyleBackColor = true;
            this.LichSuBan_button.Click += new System.EventHandler(this.LichSuBan_button_Click);
            // 
            // panel_BaoCaoButton
            // 
            this.panel_BaoCaoButton.Controls.Add(this.button_BaoCaoCongNo);
            this.panel_BaoCaoButton.Controls.Add(this.button_BaoCaoTon);
            this.panel_BaoCaoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BaoCaoButton.Location = new System.Drawing.Point(0, 372);
            this.panel_BaoCaoButton.MaximumSize = new System.Drawing.Size(319, 124);
            this.panel_BaoCaoButton.MinimumSize = new System.Drawing.Size(319, 0);
            this.panel_BaoCaoButton.Name = "panel_BaoCaoButton";
            this.panel_BaoCaoButton.Size = new System.Drawing.Size(319, 10);
            this.panel_BaoCaoButton.TabIndex = 0;
            // 
            // button_BaoCaoCongNo
            // 
            this.button_BaoCaoCongNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_BaoCaoCongNo.FlatAppearance.BorderSize = 0;
            this.button_BaoCaoCongNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BaoCaoCongNo.Image = global::BookShop_Management.Properties.Resources.minus_48px_1;
            this.button_BaoCaoCongNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BaoCaoCongNo.Location = new System.Drawing.Point(0, 62);
            this.button_BaoCaoCongNo.Name = "button_BaoCaoCongNo";
            this.button_BaoCaoCongNo.Size = new System.Drawing.Size(319, 62);
            this.button_BaoCaoCongNo.TabIndex = 8;
            this.button_BaoCaoCongNo.Text = "button_BaoCaoCongNo";
            this.button_BaoCaoCongNo.UseVisualStyleBackColor = true;
            this.button_BaoCaoCongNo.Click += new System.EventHandler(this.button_BaoCaoCongNo_Click);
            // 
            // button_BaoCaoTon
            // 
            this.button_BaoCaoTon.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_BaoCaoTon.FlatAppearance.BorderSize = 0;
            this.button_BaoCaoTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BaoCaoTon.Image = global::BookShop_Management.Properties.Resources.minus_48px_1;
            this.button_BaoCaoTon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BaoCaoTon.Location = new System.Drawing.Point(0, 0);
            this.button_BaoCaoTon.Name = "button_BaoCaoTon";
            this.button_BaoCaoTon.Size = new System.Drawing.Size(319, 62);
            this.button_BaoCaoTon.TabIndex = 7;
            this.button_BaoCaoTon.Text = "button_BaoCaoTon";
            this.button_BaoCaoTon.UseVisualStyleBackColor = true;
            this.button_BaoCaoTon.Click += new System.EventHandler(this.button_BaoCaoTon_Click);
            // 
            // BaoCao_button
            // 
            this.BaoCao_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaoCao_button.FlatAppearance.BorderSize = 0;
            this.BaoCao_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaoCao_button.Image = global::BookShop_Management.Properties.Resources.icons8_google_forms_48px_1;
            this.BaoCao_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BaoCao_button.Location = new System.Drawing.Point(0, 310);
            this.BaoCao_button.Name = "BaoCao_button";
            this.BaoCao_button.Size = new System.Drawing.Size(319, 62);
            this.BaoCao_button.TabIndex = 6;
            this.BaoCao_button.Text = "BaoCao_button";
            this.BaoCao_button.UseVisualStyleBackColor = true;
            this.BaoCao_button.Click += new System.EventHandler(this.BaoCao_button_Click);
            // 
            // PhieuThuTien_button
            // 
            this.PhieuThuTien_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhieuThuTien_button.FlatAppearance.BorderSize = 0;
            this.PhieuThuTien_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhieuThuTien_button.Image = global::BookShop_Management.Properties.Resources.bill_48px_1;
            this.PhieuThuTien_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhieuThuTien_button.Location = new System.Drawing.Point(0, 248);
            this.PhieuThuTien_button.Name = "PhieuThuTien_button";
            this.PhieuThuTien_button.Size = new System.Drawing.Size(319, 62);
            this.PhieuThuTien_button.TabIndex = 5;
            this.PhieuThuTien_button.Text = "PhieuThuTien_button";
            this.PhieuThuTien_button.UseVisualStyleBackColor = true;
            this.PhieuThuTien_button.Click += new System.EventHandler(this.PhieuThuTien_button_Click);
            // 
            // TraCuuSach_button
            // 
            this.TraCuuSach_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.TraCuuSach_button.FlatAppearance.BorderSize = 0;
            this.TraCuuSach_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TraCuuSach_button.Image = global::BookShop_Management.Properties.Resources.search_48px_1;
            this.TraCuuSach_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TraCuuSach_button.Location = new System.Drawing.Point(0, 186);
            this.TraCuuSach_button.Name = "TraCuuSach_button";
            this.TraCuuSach_button.Size = new System.Drawing.Size(319, 62);
            this.TraCuuSach_button.TabIndex = 4;
            this.TraCuuSach_button.Text = "TraCuuSach_button";
            this.TraCuuSach_button.UseVisualStyleBackColor = true;
            this.TraCuuSach_button.Click += new System.EventHandler(this.TraCuuSach_button_Click);
            // 
            // BanSach_button
            // 
            this.BanSach_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.BanSach_button.FlatAppearance.BorderSize = 0;
            this.BanSach_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BanSach_button.Image = global::BookShop_Management.Properties.Resources.cash_48px_1;
            this.BanSach_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BanSach_button.Location = new System.Drawing.Point(0, 124);
            this.BanSach_button.Name = "BanSach_button";
            this.BanSach_button.Size = new System.Drawing.Size(319, 62);
            this.BanSach_button.TabIndex = 3;
            this.BanSach_button.Text = "BanSach_button";
            this.BanSach_button.UseVisualStyleBackColor = true;
            this.BanSach_button.Click += new System.EventHandler(this.BanSach_button_Click);
            // 
            // NhapSach_button
            // 
            this.NhapSach_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.NhapSach_button.FlatAppearance.BorderSize = 0;
            this.NhapSach_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NhapSach_button.Image = global::BookShop_Management.Properties.Resources.import_48px_1;
            this.NhapSach_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NhapSach_button.Location = new System.Drawing.Point(0, 62);
            this.NhapSach_button.Name = "NhapSach_button";
            this.NhapSach_button.Size = new System.Drawing.Size(319, 62);
            this.NhapSach_button.TabIndex = 2;
            this.NhapSach_button.Text = "NhapSach_button";
            this.NhapSach_button.UseVisualStyleBackColor = false;
            this.NhapSach_button.Click += new System.EventHandler(this.NhapSach_button_Click);
            // 
            // ThongKe_button
            // 
            this.ThongKe_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongKe_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.ThongKe_button.FlatAppearance.BorderSize = 0;
            this.ThongKe_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThongKe_button.Image = global::BookShop_Management.Properties.Resources.bar_chart_48px_2;
            this.ThongKe_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThongKe_button.Location = new System.Drawing.Point(0, 0);
            this.ThongKe_button.Name = "ThongKe_button";
            this.ThongKe_button.Size = new System.Drawing.Size(319, 62);
            this.ThongKe_button.TabIndex = 1;
            this.ThongKe_button.Text = "ThongKe_button";
            this.ThongKe_button.UseVisualStyleBackColor = false;
            this.ThongKe_button.Click += new System.EventHandler(this.ThongKe_button_Click);
            // 
            // Panel_BodySideBarLeft
            // 
            this.Panel_BodySideBarLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Panel_BodySideBarLeft.Controls.Add(this.Panel_Select);
            this.Panel_BodySideBarLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_BodySideBarLeft.Location = new System.Drawing.Point(0, 0);
            this.Panel_BodySideBarLeft.Name = "Panel_BodySideBarLeft";
            this.Panel_BodySideBarLeft.Size = new System.Drawing.Size(19, 491);
            this.Panel_BodySideBarLeft.TabIndex = 0;
            this.Panel_BodySideBarLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_BodySideBarLeft_MouseDown);
            // 
            // Panel_Select
            // 
            this.Panel_Select.BackColor = System.Drawing.Color.White;
            this.Panel_Select.Location = new System.Drawing.Point(0, 0);
            this.Panel_Select.Name = "Panel_Select";
            this.Panel_Select.Size = new System.Drawing.Size(19, 62);
            this.Panel_Select.TabIndex = 1;
            this.Panel_Select.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Select_MouseDown);
            this.Panel_Select.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Select_MouseMove);
            this.Panel_Select.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Select_MouseUp);
            // 
            // Panel_FooterSideBar
            // 
            this.Panel_FooterSideBar.Controls.Add(this.Setting_button);
            this.Panel_FooterSideBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_FooterSideBar.Location = new System.Drawing.Point(0, 645);
            this.Panel_FooterSideBar.Name = "Panel_FooterSideBar";
            this.Panel_FooterSideBar.Size = new System.Drawing.Size(338, 75);
            this.Panel_FooterSideBar.TabIndex = 0;
            // 
            // Panel_TopSideBar
            // 
            this.Panel_TopSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Panel_TopSideBar.Controls.Add(this.Menu_button);
            this.Panel_TopSideBar.Controls.Add(this.Panel_LogoUIT);
            this.Panel_TopSideBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TopSideBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_TopSideBar.Name = "Panel_TopSideBar";
            this.Panel_TopSideBar.Size = new System.Drawing.Size(338, 154);
            this.Panel_TopSideBar.TabIndex = 0;
            // 
            // Menu_button
            // 
            this.Menu_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Menu_button.FlatAppearance.BorderSize = 2;
            this.Menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_button.Image = ((System.Drawing.Image)(resources.GetObject("Menu_button.Image")));
            this.Menu_button.Location = new System.Drawing.Point(274, 0);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(64, 154);
            this.Menu_button.TabIndex = 2;
            this.Menu_button.UseVisualStyleBackColor = true;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // Panel_LogoUIT
            // 
            this.Panel_LogoUIT.BackColor = System.Drawing.Color.White;
            this.Panel_LogoUIT.Controls.Add(this.DashBoard_LogoUIT);
            this.Panel_LogoUIT.Location = new System.Drawing.Point(93, 23);
            this.Panel_LogoUIT.Name = "Panel_LogoUIT";
            this.Panel_LogoUIT.Size = new System.Drawing.Size(131, 107);
            this.Panel_LogoUIT.TabIndex = 1;
            // 
            // DashBoard_LogoUIT
            // 
            this.DashBoard_LogoUIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoard_LogoUIT.Image = ((System.Drawing.Image)(resources.GetObject("DashBoard_LogoUIT.Image")));
            this.DashBoard_LogoUIT.Location = new System.Drawing.Point(0, 0);
            this.DashBoard_LogoUIT.Name = "DashBoard_LogoUIT";
            this.DashBoard_LogoUIT.Size = new System.Drawing.Size(131, 107);
            this.DashBoard_LogoUIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashBoard_LogoUIT.TabIndex = 0;
            this.DashBoard_LogoUIT.TabStop = false;
            // 
            // Panel_TopBody
            // 
            this.Panel_TopBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Panel_TopBody.Controls.Add(this.CurrentDate_label);
            this.Panel_TopBody.Controls.Add(this.CurrentTime_label);
            this.Panel_TopBody.Controls.Add(this.Role_label);
            this.Panel_TopBody.Controls.Add(this.RoleUser_label);
            this.Panel_TopBody.Controls.Add(this.NameUser_label);
            this.Panel_TopBody.Controls.Add(this.Welcome_label);
            this.Panel_TopBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TopBody.Location = new System.Drawing.Point(338, 41);
            this.Panel_TopBody.Name = "Panel_TopBody";
            this.Panel_TopBody.Size = new System.Drawing.Size(862, 113);
            this.Panel_TopBody.TabIndex = 0;
            // 
            // CurrentDate_label
            // 
            this.CurrentDate_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentDate_label.AutoSize = true;
            this.CurrentDate_label.ForeColor = System.Drawing.Color.White;
            this.CurrentDate_label.Location = new System.Drawing.Point(659, 66);
            this.CurrentDate_label.Name = "CurrentDate_label";
            this.CurrentDate_label.Size = new System.Drawing.Size(169, 23);
            this.CurrentDate_label.TabIndex = 1;
            this.CurrentDate_label.Text = "CurrentDate_label";
            this.CurrentDate_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentTime_label
            // 
            this.CurrentTime_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentTime_label.AutoSize = true;
            this.CurrentTime_label.ForeColor = System.Drawing.Color.White;
            this.CurrentTime_label.Location = new System.Drawing.Point(659, 25);
            this.CurrentTime_label.Name = "CurrentTime_label";
            this.CurrentTime_label.Size = new System.Drawing.Size(169, 23);
            this.CurrentTime_label.TabIndex = 1;
            this.CurrentTime_label.Text = "CurrentTime_label";
            this.CurrentTime_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Role_label
            // 
            this.Role_label.AutoSize = true;
            this.Role_label.ForeColor = System.Drawing.Color.White;
            this.Role_label.Location = new System.Drawing.Point(62, 66);
            this.Role_label.Name = "Role_label";
            this.Role_label.Size = new System.Drawing.Size(56, 23);
            this.Role_label.TabIndex = 0;
            this.Role_label.Text = "Role:";
            // 
            // RoleUser_label
            // 
            this.RoleUser_label.AutoSize = true;
            this.RoleUser_label.ForeColor = System.Drawing.Color.White;
            this.RoleUser_label.Location = new System.Drawing.Point(166, 66);
            this.RoleUser_label.Name = "RoleUser_label";
            this.RoleUser_label.Size = new System.Drawing.Size(143, 23);
            this.RoleUser_label.TabIndex = 0;
            this.RoleUser_label.Text = "RoleUser_label";
            // 
            // NameUser_label
            // 
            this.NameUser_label.AutoSize = true;
            this.NameUser_label.ForeColor = System.Drawing.Color.White;
            this.NameUser_label.Location = new System.Drawing.Point(166, 25);
            this.NameUser_label.Name = "NameUser_label";
            this.NameUser_label.Size = new System.Drawing.Size(154, 23);
            this.NameUser_label.TabIndex = 0;
            this.NameUser_label.Text = "NameUser_label";
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.ForeColor = System.Drawing.Color.White;
            this.Welcome_label.Location = new System.Drawing.Point(62, 25);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(98, 23);
            this.Welcome_label.TabIndex = 0;
            this.Welcome_label.Text = "Welcome:";
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.White;
            this.Panel_Header.Controls.Add(this.DashBoard_NameApp);
            this.Panel_Header.Controls.Add(this.U_Button);
            this.Panel_Header.Controls.Add(this.I_Button);
            this.Panel_Header.Controls.Add(this.T_Button);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(338, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(862, 41);
            this.Panel_Header.TabIndex = 0;
            this.Panel_Header.SizeChanged += new System.EventHandler(this.Panel_Header_SizeChanged);
            this.Panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // DashBoard_NameApp
            // 
            this.DashBoard_NameApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashBoard_NameApp.AutoSize = true;
            this.DashBoard_NameApp.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoard_NameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.DashBoard_NameApp.Location = new System.Drawing.Point(220, 4);
            this.DashBoard_NameApp.Name = "DashBoard_NameApp";
            this.DashBoard_NameApp.Size = new System.Drawing.Size(150, 32);
            this.DashBoard_NameApp.TabIndex = 8;
            this.DashBoard_NameApp.Text = "Name App";
            this.DashBoard_NameApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DashBoard_NameApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // U_Button
            // 
            this.U_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.U_Button.BackColor = System.Drawing.Color.Transparent;
            this.U_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.U_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.U_Button.FlatAppearance.BorderSize = 0;
            this.U_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.U_Button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.U_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.U_Button.Location = new System.Drawing.Point(739, 0);
            this.U_Button.Name = "U_Button";
            this.U_Button.Size = new System.Drawing.Size(41, 41);
            this.U_Button.TabIndex = 7;
            this.U_Button.TabStop = false;
            this.U_Button.Text = "U";
            this.U_Button.UseVisualStyleBackColor = false;
            this.U_Button.Click += new System.EventHandler(this.U_Button_Click);
            // 
            // I_Button
            // 
            this.I_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.I_Button.BackColor = System.Drawing.Color.Transparent;
            this.I_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.I_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.I_Button.FlatAppearance.BorderSize = 0;
            this.I_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I_Button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.I_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.I_Button.Location = new System.Drawing.Point(780, 0);
            this.I_Button.Name = "I_Button";
            this.I_Button.Size = new System.Drawing.Size(41, 41);
            this.I_Button.TabIndex = 6;
            this.I_Button.TabStop = false;
            this.I_Button.Text = "I";
            this.I_Button.UseVisualStyleBackColor = false;
            this.I_Button.Click += new System.EventHandler(this.I_Button_Click);
            // 
            // T_Button
            // 
            this.T_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.T_Button.BackColor = System.Drawing.Color.Transparent;
            this.T_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.T_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_Button.FlatAppearance.BorderSize = 0;
            this.T_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.T_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T_Button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.T_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.T_Button.Location = new System.Drawing.Point(821, 0);
            this.T_Button.Name = "T_Button";
            this.T_Button.Size = new System.Drawing.Size(41, 41);
            this.T_Button.TabIndex = 5;
            this.T_Button.TabStop = false;
            this.T_Button.Text = "T";
            this.T_Button.UseVisualStyleBackColor = false;
            this.T_Button.Click += new System.EventHandler(this.T_Button_Click);
            // 
            // UserControl_panel
            // 
            this.UserControl_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl_panel.Location = new System.Drawing.Point(338, 154);
            this.UserControl_panel.Name = "UserControl_panel";
            this.UserControl_panel.Size = new System.Drawing.Size(862, 566);
            this.UserControl_panel.TabIndex = 1;
            // 
            // timer_Panel_SideBar
            // 
            this.timer_Panel_SideBar.Interval = 10;
            this.timer_Panel_SideBar.Tick += new System.EventHandler(this.timer_Panel_SideBar_Tick);
            // 
            // timer_CurrentTime
            // 
            this.timer_CurrentTime.Tick += new System.EventHandler(this.timer_CurrentTime_Tick);
            // 
            // timer_BaoCaoButton
            // 
            this.timer_BaoCaoButton.Interval = 10;
            this.timer_BaoCaoButton.Tick += new System.EventHandler(this.timer_BaoCaoButton_Tick);
            // 
            // DashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.UserControl_panel);
            this.Controls.Add(this.Panel_TopBody);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_SideBar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.SizeChanged += new System.EventHandler(this.DashBoard_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            this.Panel_SideBar.ResumeLayout(false);
            this.Panel_BodySideBar.ResumeLayout(false);
            this.Panel_BodySideBarRight.ResumeLayout(false);
            this.panel_BaoCaoButton.ResumeLayout(false);
            this.Panel_BodySideBarLeft.ResumeLayout(false);
            this.Panel_FooterSideBar.ResumeLayout(false);
            this.Panel_TopSideBar.ResumeLayout(false);
            this.Panel_LogoUIT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DashBoard_LogoUIT)).EndInit();
            this.Panel_TopBody.ResumeLayout(false);
            this.Panel_TopBody.PerformLayout();
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Panel_SideBar;
        private Panel Panel_TopBody;
        private Panel Panel_Header;
        private Panel Panel_TopSideBar;
        private Button ThongKe_button;
        private Button LichSuBan_button;
        private Button BaoCao_button;
        private Button PhieuThuTien_button;
        private Button TraCuuSach_button;
        private Button BanSach_button;
        private Button NhapSach_button;
        private Panel Panel_BodySideBar;
        private Button Setting_button;
        private Panel Panel_BodySideBarRight;
        private Panel Panel_BodySideBarLeft;
        private PictureBox DashBoard_LogoUIT;
        private Button U_Button;
        private Button I_Button;
        private Button T_Button;
        private Panel Panel_Select;
        private Panel Panel_LogoUIT;
        private Panel UserControl_panel;
        private Button Menu_button;
        private Label DashBoard_NameApp;
        private System.Windows.Forms.Timer timer_Panel_SideBar;
        private Label Welcome_label;
        private Label Role_label;
        private Label RoleUser_label;
        private Label NameUser_label;
        private Panel Panel_FooterSideBar;
        private Label CurrentTime_label;
        private System.Windows.Forms.Timer timer_CurrentTime;
        private Label CurrentDate_label;
        private Panel panel_BaoCaoButton;
        private Button button_BaoCaoTon;
        private Button button_BaoCaoCongNo;
        private System.Windows.Forms.Timer timer_BaoCaoButton;
    }
}