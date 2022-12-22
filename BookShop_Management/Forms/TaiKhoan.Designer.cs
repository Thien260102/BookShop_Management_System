using System.Windows.Forms;

namespace BookShop_Management.Forms
{
    partial class TaiKhoan
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
            this.panel_TaiKhoan_Top = new System.Windows.Forms.Panel();
            this.pictureBox_TaiKhoan = new System.Windows.Forms.PictureBox();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.button_TaiKhoan_Top = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.dataGridView_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel_TenSach = new System.Windows.Forms.Panel();
            this.label_MaTK = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_TenTK = new System.Windows.Forms.Label();
            this.textBox_TenTK = new System.Windows.Forms.TextBox();
            this.comboBox_MaTK = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_MatKhau = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_MaNguoiDung = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label_VaiTro = new System.Windows.Forms.Label();
            this.comboBox_VaiTro = new System.Windows.Forms.ComboBox();
            this.comboBox_MaND = new System.Windows.Forms.ComboBox();
            this.label_Xoa = new System.Windows.Forms.Label();
            this.panel_TaiKhoan_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).BeginInit();
            this.panel_TenSach.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TaiKhoan_Top
            // 
            this.panel_TaiKhoan_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.panel_TaiKhoan_Top.Controls.Add(this.pictureBox_TaiKhoan);
            this.panel_TaiKhoan_Top.Controls.Add(this.label_TaiKhoan);
            this.panel_TaiKhoan_Top.Controls.Add(this.button_TaiKhoan_Top);
            this.panel_TaiKhoan_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TaiKhoan_Top.ForeColor = System.Drawing.Color.White;
            this.panel_TaiKhoan_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_TaiKhoan_Top.Name = "panel_TaiKhoan_Top";
            this.panel_TaiKhoan_Top.Size = new System.Drawing.Size(900, 36);
            this.panel_TaiKhoan_Top.TabIndex = 0;
            // 
            // pictureBox_TaiKhoan
            // 
            this.pictureBox_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_TaiKhoan.Image = global::BookShop_Management.Properties.Resources.icons8_registration_48px_1;
            this.pictureBox_TaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_TaiKhoan.Name = "pictureBox_TaiKhoan";
            this.pictureBox_TaiKhoan.Size = new System.Drawing.Size(36, 36);
            this.pictureBox_TaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TaiKhoan.TabIndex = 2;
            this.pictureBox_TaiKhoan.TabStop = false;
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.AutoSize = true;
            this.label_TaiKhoan.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TaiKhoan.Location = new System.Drawing.Point(328, 4);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(218, 32);
            this.label_TaiKhoan.TabIndex = 1;
            this.label_TaiKhoan.Text = "label_TaiKhoan";
            // 
            // button_TaiKhoan_Top
            // 
            this.button_TaiKhoan_Top.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_TaiKhoan_Top.FlatAppearance.BorderSize = 0;
            this.button_TaiKhoan_Top.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_TaiKhoan_Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TaiKhoan_Top.Image = global::BookShop_Management.Properties.Resources.x_coordinate_36px_1;
            this.button_TaiKhoan_Top.Location = new System.Drawing.Point(864, 0);
            this.button_TaiKhoan_Top.Name = "button_TaiKhoan_Top";
            this.button_TaiKhoan_Top.Size = new System.Drawing.Size(36, 36);
            this.button_TaiKhoan_Top.TabIndex = 0;
            this.button_TaiKhoan_Top.UseVisualStyleBackColor = true;
            this.button_TaiKhoan_Top.Click += new System.EventHandler(this.button_TaiKhoan_Top_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 690);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 644);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(890, 10);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(890, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 654);
            this.panel5.TabIndex = 4;
            // 
            // button_Save
            // 
            this.button_Save.AutoSize = true;
            this.button_Save.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.button_Save.Location = new System.Drawing.Point(294, 636);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(312, 48);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "button_Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // dataGridView_TaiKhoan
            // 
            this.dataGridView_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_TaiKhoan.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaiKhoan.Location = new System.Drawing.Point(33, 68);
            this.dataGridView_TaiKhoan.Name = "dataGridView_TaiKhoan";
            this.dataGridView_TaiKhoan.RowHeadersWidth = 51;
            this.dataGridView_TaiKhoan.RowTemplate.Height = 24;
            this.dataGridView_TaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TaiKhoan.Size = new System.Drawing.Size(835, 420);
            this.dataGridView_TaiKhoan.TabIndex = 6;
            this.dataGridView_TaiKhoan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_TaiKhoan_MouseDown);
            // 
            // panel_TenSach
            // 
            this.panel_TenSach.Controls.Add(this.comboBox_MaTK);
            this.panel_TenSach.Controls.Add(this.label_MaTK);
            this.panel_TenSach.Location = new System.Drawing.Point(96, 517);
            this.panel_TenSach.Name = "panel_TenSach";
            this.panel_TenSach.Size = new System.Drawing.Size(334, 30);
            this.panel_TenSach.TabIndex = 7;
            // 
            // label_MaTK
            // 
            this.label_MaTK.AutoSize = true;
            this.label_MaTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_MaTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_MaTK.Location = new System.Drawing.Point(3, 3);
            this.label_MaTK.Name = "label_MaTK";
            this.label_MaTK.Size = new System.Drawing.Size(98, 19);
            this.label_MaTK.TabIndex = 2;
            this.label_MaTK.Text = "label_MaTK";
            this.label_MaTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_TenTK);
            this.panel1.Controls.Add(this.textBox_TenTK);
            this.panel1.Location = new System.Drawing.Point(96, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 30);
            this.panel1.TabIndex = 8;
            // 
            // label_TenTK
            // 
            this.label_TenTK.AutoSize = true;
            this.label_TenTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TenTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_TenTK.Location = new System.Drawing.Point(3, 3);
            this.label_TenTK.Name = "label_TenTK";
            this.label_TenTK.Size = new System.Drawing.Size(104, 19);
            this.label_TenTK.TabIndex = 2;
            this.label_TenTK.Text = "label_TenTK";
            this.label_TenTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_TenTK
            // 
            this.textBox_TenTK.BackColor = System.Drawing.Color.LightGray;
            this.textBox_TenTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TenTK.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_TenTK.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_TenTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_TenTK.Location = new System.Drawing.Point(180, 0);
            this.textBox_TenTK.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_TenTK.MaxLength = 30;
            this.textBox_TenTK.Name = "textBox_TenTK";
            this.textBox_TenTK.Size = new System.Drawing.Size(154, 26);
            this.textBox_TenTK.TabIndex = 0;
            // 
            // comboBox_MaTK
            // 
            this.comboBox_MaTK.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_MaTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.comboBox_MaTK.FormattingEnabled = true;
            this.comboBox_MaTK.Location = new System.Drawing.Point(180, 0);
            this.comboBox_MaTK.MaxLength = 5;
            this.comboBox_MaTK.Name = "comboBox_MaTK";
            this.comboBox_MaTK.Size = new System.Drawing.Size(154, 26);
            this.comboBox_MaTK.TabIndex = 3;
            this.comboBox_MaTK.SelectedValueChanged += new System.EventHandler(this.comboBox_MaTK_SelectedValueChanged);
            this.comboBox_MaTK.TextChanged += new System.EventHandler(this.comboBox_MaTK_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label_MatKhau);
            this.panel6.Controls.Add(this.textBox_MatKhau);
            this.panel6.Location = new System.Drawing.Point(96, 589);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(334, 30);
            this.panel6.TabIndex = 9;
            // 
            // label_MatKhau
            // 
            this.label_MatKhau.AutoSize = true;
            this.label_MatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_MatKhau.Location = new System.Drawing.Point(3, 3);
            this.label_MatKhau.Name = "label_MatKhau";
            this.label_MatKhau.Size = new System.Drawing.Size(122, 19);
            this.label_MatKhau.TabIndex = 2;
            this.label_MatKhau.Text = "label_MatKhau";
            this.label_MatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BackColor = System.Drawing.Color.LightGray;
            this.textBox_MatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_MatKhau.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_MatKhau.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_MatKhau.Location = new System.Drawing.Point(180, 0);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_MatKhau.MaxLength = 30;
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(154, 26);
            this.textBox_MatKhau.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.comboBox_MaND);
            this.panel7.Controls.Add(this.label_MaNguoiDung);
            this.panel7.Location = new System.Drawing.Point(474, 553);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(334, 30);
            this.panel7.TabIndex = 10;
            // 
            // label_MaNguoiDung
            // 
            this.label_MaNguoiDung.AutoSize = true;
            this.label_MaNguoiDung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_MaNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_MaNguoiDung.Location = new System.Drawing.Point(3, 3);
            this.label_MaNguoiDung.Name = "label_MaNguoiDung";
            this.label_MaNguoiDung.Size = new System.Drawing.Size(164, 19);
            this.label_MaNguoiDung.TabIndex = 2;
            this.label_MaNguoiDung.Text = "label_MaNguoiDung";
            this.label_MaNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.comboBox_VaiTro);
            this.panel8.Controls.Add(this.label_VaiTro);
            this.panel8.Location = new System.Drawing.Point(474, 589);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(334, 30);
            this.panel8.TabIndex = 11;
            // 
            // label_VaiTro
            // 
            this.label_VaiTro.AutoSize = true;
            this.label_VaiTro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_VaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_VaiTro.Location = new System.Drawing.Point(3, 3);
            this.label_VaiTro.Name = "label_VaiTro";
            this.label_VaiTro.Size = new System.Drawing.Size(102, 19);
            this.label_VaiTro.TabIndex = 2;
            this.label_VaiTro.Text = "label_VaiTro";
            this.label_VaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_VaiTro
            // 
            this.comboBox_VaiTro.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_VaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.comboBox_VaiTro.FormattingEnabled = true;
            this.comboBox_VaiTro.Items.AddRange(new object[] {
            "ADMIN",
            "Nhân Viên"});
            this.comboBox_VaiTro.Location = new System.Drawing.Point(180, 0);
            this.comboBox_VaiTro.MaxLength = 20;
            this.comboBox_VaiTro.Name = "comboBox_VaiTro";
            this.comboBox_VaiTro.Size = new System.Drawing.Size(154, 26);
            this.comboBox_VaiTro.TabIndex = 4;
            // 
            // comboBox_MaND
            // 
            this.comboBox_MaND.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_MaND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MaND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.comboBox_MaND.FormattingEnabled = true;
            this.comboBox_MaND.Location = new System.Drawing.Point(180, 0);
            this.comboBox_MaND.MaxLength = 5;
            this.comboBox_MaND.Name = "comboBox_MaND";
            this.comboBox_MaND.Size = new System.Drawing.Size(154, 26);
            this.comboBox_MaND.TabIndex = 4;
            // 
            // label_Xoa
            // 
            this.label_Xoa.AutoSize = true;
            this.label_Xoa.BackColor = System.Drawing.Color.White;
            this.label_Xoa.Location = new System.Drawing.Point(756, 491);
            this.label_Xoa.Name = "label_Xoa";
            this.label_Xoa.Size = new System.Drawing.Size(112, 18);
            this.label_Xoa.TabIndex = 12;
            this.label_Xoa.Text = "Xóa Tài Khoản";
            this.label_Xoa.Click += new System.EventHandler(this.label_Xoa_Click);
            this.label_Xoa.MouseLeave += new System.EventHandler(this.label_Xoa_MouseLeave);
            this.label_Xoa.MouseHover += new System.EventHandler(this.label_Xoa_MouseHover);
            // 
            // TaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.label_Xoa);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_TenSach);
            this.Controls.Add(this.dataGridView_TaiKhoan);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_TaiKhoan_Top);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaiKhoan";
            this.panel_TaiKhoan_Top.ResumeLayout(false);
            this.panel_TaiKhoan_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).EndInit();
            this.panel_TenSach.ResumeLayout(false);
            this.panel_TenSach.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Panel panel_TaiKhoan_Top;
        private Button button_TaiKhoan_Top;
        private Label label_TaiKhoan;
        private PictureBox pictureBox_TaiKhoan;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button button_Save;
        private DataGridView dataGridView_TaiKhoan;
        private Panel panel_TenSach;
        private ComboBox comboBox_MaTK;
        private Label label_MaTK;
        private Panel panel1;
        private Label label_TenTK;
        private TextBox textBox_TenTK;
        private Panel panel6;
        private Label label_MatKhau;
        private TextBox textBox_MatKhau;
        private Panel panel7;
        private ComboBox comboBox_MaND;
        private Label label_MaNguoiDung;
        private Panel panel8;
        private ComboBox comboBox_VaiTro;
        private Label label_VaiTro;
        private Label label_Xoa;
    }
}