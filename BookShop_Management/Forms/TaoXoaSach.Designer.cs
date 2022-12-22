using System.Windows.Forms;

namespace BookShop_Management.Forms
{
    partial class TaoXoaSach
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
            this.panel_TaoXoaSach_Top = new System.Windows.Forms.Panel();
            this.pictureBox_TaoXoaSach = new System.Windows.Forms.PictureBox();
            this.label_TaoXoaSach = new System.Windows.Forms.Label();
            this.button_TaoXoaSach_Top = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel_TenSach = new System.Windows.Forms.Panel();
            this.label_TenSach = new System.Windows.Forms.Label();
            this.textBox_TenSach = new System.Windows.Forms.TextBox();
            this.panel_TheLoai = new System.Windows.Forms.Panel();
            this.textBox_TheLoai = new System.Windows.Forms.TextBox();
            this.label_TheLoai = new System.Windows.Forms.Label();
            this.panel_TacGia = new System.Windows.Forms.Panel();
            this.label_TacGia = new System.Windows.Forms.Label();
            this.textBox_TacGia = new System.Windows.Forms.TextBox();
            this.panel_IDSach = new System.Windows.Forms.Panel();
            this.textBox_MaSach = new System.Windows.Forms.TextBox();
            this.label_MaSach = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayPhatHanh = new System.Windows.Forms.DateTimePicker();
            this.label_NgayPhatHanh = new System.Windows.Forms.Label();
            this.pictureBox_AddImage = new System.Windows.Forms.PictureBox();
            this.label_Decription = new System.Windows.Forms.Label();
            this.panel_TaoXoaSach_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TaoXoaSach)).BeginInit();
            this.panel_TenSach.SuspendLayout();
            this.panel_TheLoai.SuspendLayout();
            this.panel_TacGia.SuspendLayout();
            this.panel_IDSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AddImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TaoXoaSach_Top
            // 
            this.panel_TaoXoaSach_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.panel_TaoXoaSach_Top.Controls.Add(this.pictureBox_TaoXoaSach);
            this.panel_TaoXoaSach_Top.Controls.Add(this.label_TaoXoaSach);
            this.panel_TaoXoaSach_Top.Controls.Add(this.button_TaoXoaSach_Top);
            this.panel_TaoXoaSach_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TaoXoaSach_Top.ForeColor = System.Drawing.Color.White;
            this.panel_TaoXoaSach_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_TaoXoaSach_Top.Name = "panel_TaoXoaSach_Top";
            this.panel_TaoXoaSach_Top.Size = new System.Drawing.Size(720, 36);
            this.panel_TaoXoaSach_Top.TabIndex = 0;
            this.panel_TaoXoaSach_Top.SizeChanged += new System.EventHandler(this.panel_TaoXoaSach_Top_SizeChanged);
            this.panel_TaoXoaSach_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // pictureBox_TaoXoaSach
            // 
            this.pictureBox_TaoXoaSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_TaoXoaSach.Image = global::BookShop_Management.Properties.Resources.settings_48px_1;
            this.pictureBox_TaoXoaSach.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_TaoXoaSach.Name = "pictureBox_TaoXoaSach";
            this.pictureBox_TaoXoaSach.Size = new System.Drawing.Size(36, 36);
            this.pictureBox_TaoXoaSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_TaoXoaSach.TabIndex = 2;
            this.pictureBox_TaoXoaSach.TabStop = false;
            this.pictureBox_TaoXoaSach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // label_TaoXoaSach
            // 
            this.label_TaoXoaSach.AutoSize = true;
            this.label_TaoXoaSach.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TaoXoaSach.Location = new System.Drawing.Point(292, 8);
            this.label_TaoXoaSach.Name = "label_TaoXoaSach";
            this.label_TaoXoaSach.Size = new System.Drawing.Size(256, 32);
            this.label_TaoXoaSach.TabIndex = 1;
            this.label_TaoXoaSach.Text = "label_TaoXoaSach";
            // 
            // button_TaoXoaSach_Top
            // 
            this.button_TaoXoaSach_Top.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_TaoXoaSach_Top.FlatAppearance.BorderSize = 0;
            this.button_TaoXoaSach_Top.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_TaoXoaSach_Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TaoXoaSach_Top.Image = global::BookShop_Management.Properties.Resources.x_coordinate_36px_1;
            this.button_TaoXoaSach_Top.Location = new System.Drawing.Point(684, 0);
            this.button_TaoXoaSach_Top.Name = "button_TaoXoaSach_Top";
            this.button_TaoXoaSach_Top.Size = new System.Drawing.Size(36, 36);
            this.button_TaoXoaSach_Top.TabIndex = 0;
            this.button_TaoXoaSach_Top.UseVisualStyleBackColor = true;
            this.button_TaoXoaSach_Top.Click += new System.EventHandler(this.button_TaoXoaSach_Top_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 664);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(710, 10);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(710, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 674);
            this.panel5.TabIndex = 4;
            // 
            // button_Save
            // 
            this.button_Save.AutoSize = true;
            this.button_Save.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.button_Save.Location = new System.Drawing.Point(193, 656);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(334, 48);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "button_Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // panel_TenSach
            // 
            this.panel_TenSach.Controls.Add(this.label_TenSach);
            this.panel_TenSach.Controls.Add(this.textBox_TenSach);
            this.panel_TenSach.Location = new System.Drawing.Point(193, 129);
            this.panel_TenSach.Name = "panel_TenSach";
            this.panel_TenSach.Size = new System.Drawing.Size(334, 30);
            this.panel_TenSach.TabIndex = 6;
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
            this.textBox_TenSach.MaxLength = 50;
            this.textBox_TenSach.Name = "textBox_TenSach";
            this.textBox_TenSach.Size = new System.Drawing.Size(154, 26);
            this.textBox_TenSach.TabIndex = 0;
            // 
            // panel_TheLoai
            // 
            this.panel_TheLoai.Controls.Add(this.textBox_TheLoai);
            this.panel_TheLoai.Controls.Add(this.label_TheLoai);
            this.panel_TheLoai.Location = new System.Drawing.Point(193, 165);
            this.panel_TheLoai.Name = "panel_TheLoai";
            this.panel_TheLoai.Size = new System.Drawing.Size(334, 30);
            this.panel_TheLoai.TabIndex = 7;
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
            this.textBox_TheLoai.MaxLength = 20;
            this.textBox_TheLoai.Name = "textBox_TheLoai";
            this.textBox_TheLoai.Size = new System.Drawing.Size(154, 26);
            this.textBox_TheLoai.TabIndex = 1;
            this.textBox_TheLoai.Leave += new System.EventHandler(this.textBox_TheLoai_Leave);
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
            // panel_TacGia
            // 
            this.panel_TacGia.Controls.Add(this.label_TacGia);
            this.panel_TacGia.Controls.Add(this.textBox_TacGia);
            this.panel_TacGia.Location = new System.Drawing.Point(193, 201);
            this.panel_TacGia.Name = "panel_TacGia";
            this.panel_TacGia.Size = new System.Drawing.Size(334, 30);
            this.panel_TacGia.TabIndex = 8;
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
            this.textBox_TacGia.MaxLength = 30;
            this.textBox_TacGia.Name = "textBox_TacGia";
            this.textBox_TacGia.Size = new System.Drawing.Size(154, 26);
            this.textBox_TacGia.TabIndex = 2;
            this.textBox_TacGia.TextChanged += new System.EventHandler(this.textBox_TacGia_TextChanged);
            this.textBox_TacGia.Leave += new System.EventHandler(this.textBox_TacGia_Leave);
            // 
            // panel_IDSach
            // 
            this.panel_IDSach.Controls.Add(this.textBox_MaSach);
            this.panel_IDSach.Controls.Add(this.label_MaSach);
            this.panel_IDSach.Location = new System.Drawing.Point(193, 93);
            this.panel_IDSach.Name = "panel_IDSach";
            this.panel_IDSach.Size = new System.Drawing.Size(334, 30);
            this.panel_IDSach.TabIndex = 7;
            // 
            // textBox_MaSach
            // 
            this.textBox_MaSach.BackColor = System.Drawing.Color.LightGray;
            this.textBox_MaSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_MaSach.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_MaSach.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_MaSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_MaSach.Location = new System.Drawing.Point(180, 0);
            this.textBox_MaSach.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_MaSach.MaxLength = 5;
            this.textBox_MaSach.Name = "textBox_MaSach";
            this.textBox_MaSach.ReadOnly = true;
            this.textBox_MaSach.Size = new System.Drawing.Size(154, 26);
            this.textBox_MaSach.TabIndex = 1;
            this.textBox_MaSach.TextChanged += new System.EventHandler(this.textBox_MaSach_TextChanged);
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
            // dateTimePicker_NgayPhatHanh
            // 
            this.dateTimePicker_NgayPhatHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayPhatHanh.Location = new System.Drawing.Point(373, 257);
            this.dateTimePicker_NgayPhatHanh.Name = "dateTimePicker_NgayPhatHanh";
            this.dateTimePicker_NgayPhatHanh.Size = new System.Drawing.Size(154, 26);
            this.dateTimePicker_NgayPhatHanh.TabIndex = 10;
            // 
            // label_NgayPhatHanh
            // 
            this.label_NgayPhatHanh.AutoSize = true;
            this.label_NgayPhatHanh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_NgayPhatHanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_NgayPhatHanh.Location = new System.Drawing.Point(196, 257);
            this.label_NgayPhatHanh.Name = "label_NgayPhatHanh";
            this.label_NgayPhatHanh.Size = new System.Drawing.Size(170, 19);
            this.label_NgayPhatHanh.TabIndex = 9;
            this.label_NgayPhatHanh.Text = "label_NgayPhatHanh";
            this.label_NgayPhatHanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AddImage
            // 
            this.pictureBox_AddImage.Image = global::BookShop_Management.Properties.Resources.Add_Image;
            this.pictureBox_AddImage.Location = new System.Drawing.Point(193, 283);
            this.pictureBox_AddImage.Name = "pictureBox_AddImage";
            this.pictureBox_AddImage.Size = new System.Drawing.Size(334, 367);
            this.pictureBox_AddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_AddImage.TabIndex = 11;
            this.pictureBox_AddImage.TabStop = false;
            this.pictureBox_AddImage.Click += new System.EventHandler(this.pictureBox_AddImage_Click);
            // 
            // label_Decription
            // 
            this.label_Decription.AutoSize = true;
            this.label_Decription.ForeColor = System.Drawing.Color.Black;
            this.label_Decription.Location = new System.Drawing.Point(298, 230);
            this.label_Decription.Name = "label_Decription";
            this.label_Decription.Size = new System.Drawing.Size(229, 18);
            this.label_Decription.TabIndex = 12;
            this.label_Decription.Text = "Tác giả cách nhau bởi dấu phẩy";
            // 
            // TaoXoaSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.label_Decription);
            this.Controls.Add(this.pictureBox_AddImage);
            this.Controls.Add(this.dateTimePicker_NgayPhatHanh);
            this.Controls.Add(this.label_NgayPhatHanh);
            this.Controls.Add(this.panel_TenSach);
            this.Controls.Add(this.panel_IDSach);
            this.Controls.Add(this.panel_TheLoai);
            this.Controls.Add(this.panel_TacGia);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_TaoXoaSach_Top);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaoXoaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaoXoaSach";
            this.panel_TaoXoaSach_Top.ResumeLayout(false);
            this.panel_TaoXoaSach_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TaoXoaSach)).EndInit();
            this.panel_TenSach.ResumeLayout(false);
            this.panel_TenSach.PerformLayout();
            this.panel_TheLoai.ResumeLayout(false);
            this.panel_TheLoai.PerformLayout();
            this.panel_TacGia.ResumeLayout(false);
            this.panel_TacGia.PerformLayout();
            this.panel_IDSach.ResumeLayout(false);
            this.panel_IDSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AddImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_TaoXoaSach_Top;
        private Button button_TaoXoaSach_Top;
        private Label label_TaoXoaSach;
        private PictureBox pictureBox_TaoXoaSach;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button button_Save;
        private Panel panel_TenSach;
        private Label label_TenSach;
        private TextBox textBox_TenSach;
        private Panel panel_TheLoai;
        private TextBox textBox_TheLoai;
        private Label label_TheLoai;
        private Panel panel_TacGia;
        private Label label_TacGia;
        private TextBox textBox_TacGia;
        private Panel panel_IDSach;
        private TextBox textBox_MaSach;
        private Label label_MaSach;
        private DateTimePicker dateTimePicker_NgayPhatHanh;
        private Label label_NgayPhatHanh;
        private PictureBox pictureBox_AddImage;
        private Label label_Decription;
    }
}