using System.Windows.Forms;
namespace BookShop_Management.UserControls
{
    partial class PhieuThuTien
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
            this.label_PhieuThuTien = new System.Windows.Forms.Label();
            this.panel_PhieuThuTien = new System.Windows.Forms.Panel();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.flowLayoutPanel_PhieuThuTien = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_TenKH = new System.Windows.Forms.Panel();
            this.label_TenKH = new System.Windows.Forms.Label();
            this.panel_DiaChi = new System.Windows.Forms.Panel();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.panel_DienThoai = new System.Windows.Forms.Panel();
            this.label_DienThoai = new System.Windows.Forms.Label();
            this.panel_Email = new System.Windows.Forms.Panel();
            this.label_Email = new System.Windows.Forms.Label();
            this.panel_NgayThu = new System.Windows.Forms.Panel();
            this.dateTimePicker_NgayThu = new System.Windows.Forms.DateTimePicker();
            this.label_NgayThu = new System.Windows.Forms.Label();
            this.panel_SoTienThu = new System.Windows.Forms.Panel();
            this.textBox_SoTienThu = new System.Windows.Forms.TextBox();
            this.label_SoTienThu = new System.Windows.Forms.Label();
            this.panel_PhieuThuTien_Top = new System.Windows.Forms.Panel();
            this.panel_PhieuThuTien_Right = new System.Windows.Forms.Panel();
            this.panel_PhieuThuTien_Bottom = new System.Windows.Forms.Panel();
            this.panel_PhieuThuTien_Left = new System.Windows.Forms.Panel();
            this.panel_Ngang = new System.Windows.Forms.Panel();
            this.textBox_TenKH = new System.Windows.Forms.TextBox();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.panel_PhieuThuTien.SuspendLayout();
            this.flowLayoutPanel_PhieuThuTien.SuspendLayout();
            this.panel_TenKH.SuspendLayout();
            this.panel_DiaChi.SuspendLayout();
            this.panel_DienThoai.SuspendLayout();
            this.panel_Email.SuspendLayout();
            this.panel_NgayThu.SuspendLayout();
            this.panel_SoTienThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_PhieuThuTien
            // 
            this.label_PhieuThuTien.AutoSize = true;
            this.label_PhieuThuTien.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label_PhieuThuTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_PhieuThuTien.Location = new System.Drawing.Point(235, 20);
            this.label_PhieuThuTien.Name = "label_PhieuThuTien";
            this.label_PhieuThuTien.Size = new System.Drawing.Size(278, 32);
            this.label_PhieuThuTien.TabIndex = 0;
            this.label_PhieuThuTien.Text = "label_PhieuThuTien";
            this.label_PhieuThuTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_PhieuThuTien
            // 
            this.panel_PhieuThuTien.Controls.Add(this.button_Clear);
            this.panel_PhieuThuTien.Controls.Add(this.button_Confirm);
            this.panel_PhieuThuTien.Controls.Add(this.label_PhieuThuTien);
            this.panel_PhieuThuTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_PhieuThuTien.Location = new System.Drawing.Point(10, 10);
            this.panel_PhieuThuTien.Name = "panel_PhieuThuTien";
            this.panel_PhieuThuTien.Size = new System.Drawing.Size(842, 80);
            this.panel_PhieuThuTien.TabIndex = 3;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.White;
            this.button_Clear.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Image = global::BookShop_Management.Properties.Resources.broom_48px;
            this.button_Clear.Location = new System.Drawing.Point(0, 0);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(80, 80);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.BackColor = System.Drawing.Color.Lime;
            this.button_Confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Confirm.FlatAppearance.BorderSize = 0;
            this.button_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Confirm.Image = global::BookShop_Management.Properties.Resources.checkmark_48px_1;
            this.button_Confirm.Location = new System.Drawing.Point(762, 0);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(80, 80);
            this.button_Confirm.TabIndex = 2;
            this.button_Confirm.UseVisualStyleBackColor = false;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // flowLayoutPanel_PhieuThuTien
            // 
            this.flowLayoutPanel_PhieuThuTien.AutoScroll = true;
            this.flowLayoutPanel_PhieuThuTien.Controls.Add(this.panel_TenKH);
            this.flowLayoutPanel_PhieuThuTien.Controls.Add(this.panel_DiaChi);
            this.flowLayoutPanel_PhieuThuTien.Controls.Add(this.panel_DienThoai);
            this.flowLayoutPanel_PhieuThuTien.Controls.Add(this.panel_Email);
            this.flowLayoutPanel_PhieuThuTien.Controls.Add(this.panel_NgayThu);
            this.flowLayoutPanel_PhieuThuTien.Controls.Add(this.panel_SoTienThu);
            this.flowLayoutPanel_PhieuThuTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_PhieuThuTien.Location = new System.Drawing.Point(10, 100);
            this.flowLayoutPanel_PhieuThuTien.Name = "flowLayoutPanel_PhieuThuTien";
            this.flowLayoutPanel_PhieuThuTien.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.flowLayoutPanel_PhieuThuTien.Size = new System.Drawing.Size(842, 456);
            this.flowLayoutPanel_PhieuThuTien.TabIndex = 4;
            this.flowLayoutPanel_PhieuThuTien.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_PhieuThuTien_Paint);
            // 
            // panel_TenKH
            // 
            this.panel_TenKH.Controls.Add(this.textBox_TenKH);
            this.panel_TenKH.Controls.Add(this.label_TenKH);
            this.panel_TenKH.Location = new System.Drawing.Point(53, 3);
            this.panel_TenKH.Name = "panel_TenKH";
            this.panel_TenKH.Size = new System.Drawing.Size(329, 125);
            this.panel_TenKH.TabIndex = 1;
            // 
            // label_TenKH
            // 
            this.label_TenKH.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label_TenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_TenKH.Location = new System.Drawing.Point(26, 17);
            this.label_TenKH.Name = "label_TenKH";
            this.label_TenKH.Size = new System.Drawing.Size(277, 32);
            this.label_TenKH.TabIndex = 0;
            this.label_TenKH.Text = "label_TenKH";
            this.label_TenKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_DiaChi
            // 
            this.panel_DiaChi.Controls.Add(this.textBox_DiaChi);
            this.panel_DiaChi.Controls.Add(this.label_DiaChi);
            this.panel_DiaChi.Location = new System.Drawing.Point(388, 3);
            this.panel_DiaChi.Name = "panel_DiaChi";
            this.panel_DiaChi.Size = new System.Drawing.Size(329, 125);
            this.panel_DiaChi.TabIndex = 1;
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label_DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_DiaChi.Location = new System.Drawing.Point(26, 17);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(277, 32);
            this.label_DiaChi.TabIndex = 0;
            this.label_DiaChi.Text = "label_DiaChi";
            this.label_DiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_DienThoai
            // 
            this.panel_DienThoai.Controls.Add(this.textBox_SDT);
            this.panel_DienThoai.Controls.Add(this.label_DienThoai);
            this.panel_DienThoai.Location = new System.Drawing.Point(53, 134);
            this.panel_DienThoai.Name = "panel_DienThoai";
            this.panel_DienThoai.Size = new System.Drawing.Size(329, 125);
            this.panel_DienThoai.TabIndex = 1;
            // 
            // label_DienThoai
            // 
            this.label_DienThoai.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label_DienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_DienThoai.Location = new System.Drawing.Point(26, 17);
            this.label_DienThoai.Name = "label_DienThoai";
            this.label_DienThoai.Size = new System.Drawing.Size(277, 32);
            this.label_DienThoai.TabIndex = 0;
            this.label_DienThoai.Text = "label_DienThoai";
            this.label_DienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Email
            // 
            this.panel_Email.Controls.Add(this.textBox_Email);
            this.panel_Email.Controls.Add(this.label_Email);
            this.panel_Email.Location = new System.Drawing.Point(388, 134);
            this.panel_Email.Name = "panel_Email";
            this.panel_Email.Size = new System.Drawing.Size(329, 125);
            this.panel_Email.TabIndex = 1;
            // 
            // label_Email
            // 
            this.label_Email.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_Email.Location = new System.Drawing.Point(26, 17);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(277, 32);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "label_Email";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_NgayThu
            // 
            this.panel_NgayThu.Controls.Add(this.dateTimePicker_NgayThu);
            this.panel_NgayThu.Controls.Add(this.label_NgayThu);
            this.panel_NgayThu.Location = new System.Drawing.Point(53, 265);
            this.panel_NgayThu.Name = "panel_NgayThu";
            this.panel_NgayThu.Size = new System.Drawing.Size(329, 125);
            this.panel_NgayThu.TabIndex = 1;
            // 
            // dateTimePicker_NgayThu
            // 
            this.dateTimePicker_NgayThu.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_NgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayThu.Location = new System.Drawing.Point(26, 68);
            this.dateTimePicker_NgayThu.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker_NgayThu.Name = "dateTimePicker_NgayThu";
            this.dateTimePicker_NgayThu.Size = new System.Drawing.Size(277, 32);
            this.dateTimePicker_NgayThu.TabIndex = 2;
            // 
            // label_NgayThu
            // 
            this.label_NgayThu.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label_NgayThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_NgayThu.Location = new System.Drawing.Point(26, 17);
            this.label_NgayThu.Name = "label_NgayThu";
            this.label_NgayThu.Size = new System.Drawing.Size(277, 32);
            this.label_NgayThu.TabIndex = 0;
            this.label_NgayThu.Text = "label_NgayThu";
            this.label_NgayThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_SoTienThu
            // 
            this.panel_SoTienThu.Controls.Add(this.textBox_SoTienThu);
            this.panel_SoTienThu.Controls.Add(this.label_SoTienThu);
            this.panel_SoTienThu.Location = new System.Drawing.Point(388, 265);
            this.panel_SoTienThu.Name = "panel_SoTienThu";
            this.panel_SoTienThu.Size = new System.Drawing.Size(329, 125);
            this.panel_SoTienThu.TabIndex = 1;
            // 
            // textBox_SoTienThu
            // 
            this.textBox_SoTienThu.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.textBox_SoTienThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_SoTienThu.Location = new System.Drawing.Point(26, 68);
            this.textBox_SoTienThu.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_SoTienThu.Name = "textBox_SoTienThu";
            this.textBox_SoTienThu.Size = new System.Drawing.Size(277, 32);
            this.textBox_SoTienThu.TabIndex = 2;
            this.textBox_SoTienThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label_SoTienThu
            // 
            this.label_SoTienThu.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label_SoTienThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_SoTienThu.Location = new System.Drawing.Point(26, 17);
            this.label_SoTienThu.Name = "label_SoTienThu";
            this.label_SoTienThu.Size = new System.Drawing.Size(277, 32);
            this.label_SoTienThu.TabIndex = 0;
            this.label_SoTienThu.Text = "label_SoTienThu";
            this.label_SoTienThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_PhieuThuTien_Top
            // 
            this.panel_PhieuThuTien_Top.BackColor = System.Drawing.Color.Red;
            this.panel_PhieuThuTien_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_PhieuThuTien_Top.Location = new System.Drawing.Point(10, 0);
            this.panel_PhieuThuTien_Top.Name = "panel_PhieuThuTien_Top";
            this.panel_PhieuThuTien_Top.Size = new System.Drawing.Size(842, 10);
            this.panel_PhieuThuTien_Top.TabIndex = 3;
            // 
            // panel_PhieuThuTien_Right
            // 
            this.panel_PhieuThuTien_Right.BackColor = System.Drawing.Color.Red;
            this.panel_PhieuThuTien_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_PhieuThuTien_Right.Location = new System.Drawing.Point(852, 0);
            this.panel_PhieuThuTien_Right.Name = "panel_PhieuThuTien_Right";
            this.panel_PhieuThuTien_Right.Size = new System.Drawing.Size(10, 556);
            this.panel_PhieuThuTien_Right.TabIndex = 5;
            // 
            // panel_PhieuThuTien_Bottom
            // 
            this.panel_PhieuThuTien_Bottom.BackColor = System.Drawing.Color.Red;
            this.panel_PhieuThuTien_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_PhieuThuTien_Bottom.Location = new System.Drawing.Point(0, 556);
            this.panel_PhieuThuTien_Bottom.Name = "panel_PhieuThuTien_Bottom";
            this.panel_PhieuThuTien_Bottom.Size = new System.Drawing.Size(862, 10);
            this.panel_PhieuThuTien_Bottom.TabIndex = 6;
            // 
            // panel_PhieuThuTien_Left
            // 
            this.panel_PhieuThuTien_Left.BackColor = System.Drawing.Color.Red;
            this.panel_PhieuThuTien_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_PhieuThuTien_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_PhieuThuTien_Left.Name = "panel_PhieuThuTien_Left";
            this.panel_PhieuThuTien_Left.Size = new System.Drawing.Size(10, 556);
            this.panel_PhieuThuTien_Left.TabIndex = 7;
            // 
            // panel_Ngang
            // 
            this.panel_Ngang.BackColor = System.Drawing.Color.Red;
            this.panel_Ngang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Ngang.Location = new System.Drawing.Point(10, 90);
            this.panel_Ngang.Name = "panel_Ngang";
            this.panel_Ngang.Size = new System.Drawing.Size(842, 10);
            this.panel_Ngang.TabIndex = 8;
            // 
            // textBox_TenKH
            // 
            this.textBox_TenKH.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.textBox_TenKH.Location = new System.Drawing.Point(26, 74);
            this.textBox_TenKH.Name = "textBox_TenKH";
            this.textBox_TenKH.Size = new System.Drawing.Size(277, 32);
            this.textBox_TenKH.TabIndex = 1;
            this.textBox_TenKH.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.textBox_DiaChi.Location = new System.Drawing.Point(26, 74);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(277, 32);
            this.textBox_DiaChi.TabIndex = 2;
            this.textBox_DiaChi.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.textBox_SDT.Location = new System.Drawing.Point(26, 73);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.Size = new System.Drawing.Size(277, 32);
            this.textBox_SDT.TabIndex = 3;
            this.textBox_SDT.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.textBox_Email.Location = new System.Drawing.Point(26, 73);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(277, 32);
            this.textBox_Email.TabIndex = 3;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // PhieuThuTien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.flowLayoutPanel_PhieuThuTien);
            this.Controls.Add(this.panel_Ngang);
            this.Controls.Add(this.panel_PhieuThuTien);
            this.Controls.Add(this.panel_PhieuThuTien_Top);
            this.Controls.Add(this.panel_PhieuThuTien_Right);
            this.Controls.Add(this.panel_PhieuThuTien_Left);
            this.Controls.Add(this.panel_PhieuThuTien_Bottom);
            this.Font = new System.Drawing.Font("Arial", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PhieuThuTien";
            this.Size = new System.Drawing.Size(862, 566);
            this.SizeChanged += new System.EventHandler(this.PhieuThuTien_SizeChanged);
            this.panel_PhieuThuTien.ResumeLayout(false);
            this.panel_PhieuThuTien.PerformLayout();
            this.flowLayoutPanel_PhieuThuTien.ResumeLayout(false);
            this.panel_TenKH.ResumeLayout(false);
            this.panel_TenKH.PerformLayout();
            this.panel_DiaChi.ResumeLayout(false);
            this.panel_DiaChi.PerformLayout();
            this.panel_DienThoai.ResumeLayout(false);
            this.panel_DienThoai.PerformLayout();
            this.panel_Email.ResumeLayout(false);
            this.panel_Email.PerformLayout();
            this.panel_NgayThu.ResumeLayout(false);
            this.panel_SoTienThu.ResumeLayout(false);
            this.panel_SoTienThu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_PhieuThuTien;
        private Panel panel_PhieuThuTien;
        private FlowLayoutPanel flowLayoutPanel_PhieuThuTien;
        private Panel panel_PhieuThuTien_Top;
        private Panel panel_PhieuThuTien_Right;
        private Panel panel_PhieuThuTien_Bottom;
        private Panel panel_PhieuThuTien_Left;
        private Panel panel_TenKH;
        private Label label_TenKH;
        private Panel panel_DiaChi;
        private Label label_DiaChi;
        private Panel panel_DienThoai;
        private Label label_DienThoai;
        private Panel panel_Email;
        private Label label_Email;
        private Panel panel_SoTienThu;
        private Label label_SoTienThu;
        private Panel panel_NgayThu;
        private Label label_NgayThu;
        private DateTimePicker dateTimePicker_NgayThu;
        private TextBox textBox_SoTienThu;
        private Panel panel_Ngang;
        private Button button_Confirm;
        private Button button_Clear;
        private TextBox textBox_TenKH;
        private TextBox textBox_DiaChi;
        private TextBox textBox_SDT;
        private TextBox textBox_Email;
    }
}
