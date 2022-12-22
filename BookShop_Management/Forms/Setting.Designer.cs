using System.Windows.Forms;
namespace BookShop_Management.Forms
{
    partial class Setting
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
            this.panel_Setting_Top = new System.Windows.Forms.Panel();
            this.pictureBox_Setting = new System.Windows.Forms.PictureBox();
            this.label_Setting = new System.Windows.Forms.Label();
            this.button_Setting_Top = new System.Windows.Forms.Button();
            this.panel_SLToiThieu = new System.Windows.Forms.Panel();
            this.textBox_SLNhapToiThieu = new System.Windows.Forms.TextBox();
            this.label_SLNhapToiThieu = new System.Windows.Forms.Label();
            this.panel_TonToiThieu = new System.Windows.Forms.Panel();
            this.textBox_LuongTonToiThieu = new System.Windows.Forms.TextBox();
            this.label_LuongTonToiThieu = new System.Windows.Forms.Label();
            this.panel_Nhap_ChinhSua = new System.Windows.Forms.Panel();
            this.checkBox_SoTienThu = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_TienNoToiDa = new System.Windows.Forms.TextBox();
            this.label_TienNoToiDa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel_Setting_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setting)).BeginInit();
            this.panel_SLToiThieu.SuspendLayout();
            this.panel_TonToiThieu.SuspendLayout();
            this.panel_Nhap_ChinhSua.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Setting_Top
            // 
            this.panel_Setting_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.panel_Setting_Top.Controls.Add(this.pictureBox_Setting);
            this.panel_Setting_Top.Controls.Add(this.label_Setting);
            this.panel_Setting_Top.Controls.Add(this.button_Setting_Top);
            this.panel_Setting_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Setting_Top.ForeColor = System.Drawing.Color.White;
            this.panel_Setting_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Setting_Top.Name = "panel_Setting_Top";
            this.panel_Setting_Top.Size = new System.Drawing.Size(500, 36);
            this.panel_Setting_Top.TabIndex = 0;
            this.panel_Setting_Top.SizeChanged += new System.EventHandler(this.panel_Setting_Top_SizeChanged);
            this.panel_Setting_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // pictureBox_Setting
            // 
            this.pictureBox_Setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Setting.Image = global::BookShop_Management.Properties.Resources.settings_48px_1;
            this.pictureBox_Setting.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Setting.Name = "pictureBox_Setting";
            this.pictureBox_Setting.Size = new System.Drawing.Size(36, 36);
            this.pictureBox_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Setting.TabIndex = 2;
            this.pictureBox_Setting.TabStop = false;
            this.pictureBox_Setting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // label_Setting
            // 
            this.label_Setting.AutoSize = true;
            this.label_Setting.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label_Setting.Location = new System.Drawing.Point(188, 8);
            this.label_Setting.Name = "label_Setting";
            this.label_Setting.Size = new System.Drawing.Size(101, 18);
            this.label_Setting.TabIndex = 1;
            this.label_Setting.Text = "label_Setting";
            // 
            // button_Setting_Top
            // 
            this.button_Setting_Top.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Setting_Top.FlatAppearance.BorderSize = 0;
            this.button_Setting_Top.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_Setting_Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting_Top.Image = global::BookShop_Management.Properties.Resources.x_coordinate_36px_1;
            this.button_Setting_Top.Location = new System.Drawing.Point(464, 0);
            this.button_Setting_Top.Name = "button_Setting_Top";
            this.button_Setting_Top.Size = new System.Drawing.Size(36, 36);
            this.button_Setting_Top.TabIndex = 0;
            this.button_Setting_Top.UseVisualStyleBackColor = true;
            this.button_Setting_Top.Click += new System.EventHandler(this.button_Setting_Top_Click);
            // 
            // panel_SLToiThieu
            // 
            this.panel_SLToiThieu.AutoSize = true;
            this.panel_SLToiThieu.Controls.Add(this.textBox_SLNhapToiThieu);
            this.panel_SLToiThieu.Controls.Add(this.label_SLNhapToiThieu);
            this.panel_SLToiThieu.Location = new System.Drawing.Point(20, 23);
            this.panel_SLToiThieu.Name = "panel_SLToiThieu";
            this.panel_SLToiThieu.Size = new System.Drawing.Size(370, 29);
            this.panel_SLToiThieu.TabIndex = 1;
            // 
            // textBox_SLNhapToiThieu
            // 
            this.textBox_SLNhapToiThieu.BackColor = System.Drawing.Color.LightGray;
            this.textBox_SLNhapToiThieu.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_SLNhapToiThieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_SLNhapToiThieu.Location = new System.Drawing.Point(198, 0);
            this.textBox_SLNhapToiThieu.Name = "textBox_SLNhapToiThieu";
            this.textBox_SLNhapToiThieu.Size = new System.Drawing.Size(172, 26);
            this.textBox_SLNhapToiThieu.TabIndex = 1;
            this.textBox_SLNhapToiThieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_SLNhapToiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label_SLNhapToiThieu
            // 
            this.label_SLNhapToiThieu.AutoSize = true;
            this.label_SLNhapToiThieu.Location = new System.Drawing.Point(3, 3);
            this.label_SLNhapToiThieu.Name = "label_SLNhapToiThieu";
            this.label_SLNhapToiThieu.Size = new System.Drawing.Size(165, 18);
            this.label_SLNhapToiThieu.TabIndex = 0;
            this.label_SLNhapToiThieu.Text = "label_SLNhapToiThieu";
            // 
            // panel_TonToiThieu
            // 
            this.panel_TonToiThieu.AutoSize = true;
            this.panel_TonToiThieu.Controls.Add(this.textBox_LuongTonToiThieu);
            this.panel_TonToiThieu.Controls.Add(this.label_LuongTonToiThieu);
            this.panel_TonToiThieu.Location = new System.Drawing.Point(20, 58);
            this.panel_TonToiThieu.Name = "panel_TonToiThieu";
            this.panel_TonToiThieu.Size = new System.Drawing.Size(370, 29);
            this.panel_TonToiThieu.TabIndex = 1;
            // 
            // textBox_LuongTonToiThieu
            // 
            this.textBox_LuongTonToiThieu.BackColor = System.Drawing.Color.LightGray;
            this.textBox_LuongTonToiThieu.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_LuongTonToiThieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_LuongTonToiThieu.Location = new System.Drawing.Point(198, 0);
            this.textBox_LuongTonToiThieu.Name = "textBox_LuongTonToiThieu";
            this.textBox_LuongTonToiThieu.Size = new System.Drawing.Size(172, 26);
            this.textBox_LuongTonToiThieu.TabIndex = 1;
            this.textBox_LuongTonToiThieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_LuongTonToiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label_LuongTonToiThieu
            // 
            this.label_LuongTonToiThieu.AutoSize = true;
            this.label_LuongTonToiThieu.Location = new System.Drawing.Point(3, 3);
            this.label_LuongTonToiThieu.Name = "label_LuongTonToiThieu";
            this.label_LuongTonToiThieu.Size = new System.Drawing.Size(175, 18);
            this.label_LuongTonToiThieu.TabIndex = 0;
            this.label_LuongTonToiThieu.Text = "label_LuongTonToiThieu";
            // 
            // panel_Nhap_ChinhSua
            // 
            this.panel_Nhap_ChinhSua.Controls.Add(this.checkBox_SoTienThu);
            this.panel_Nhap_ChinhSua.Controls.Add(this.panel1);
            this.panel_Nhap_ChinhSua.Controls.Add(this.panel_TonToiThieu);
            this.panel_Nhap_ChinhSua.Controls.Add(this.panel_SLToiThieu);
            this.panel_Nhap_ChinhSua.Location = new System.Drawing.Point(40, 52);
            this.panel_Nhap_ChinhSua.Name = "panel_Nhap_ChinhSua";
            this.panel_Nhap_ChinhSua.Size = new System.Drawing.Size(414, 183);
            this.panel_Nhap_ChinhSua.TabIndex = 3;
            this.panel_Nhap_ChinhSua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // checkBox_SoTienThu
            // 
            this.checkBox_SoTienThu.AutoSize = true;
            this.checkBox_SoTienThu.Location = new System.Drawing.Point(26, 128);
            this.checkBox_SoTienThu.Name = "checkBox_SoTienThu";
            this.checkBox_SoTienThu.Size = new System.Drawing.Size(370, 22);
            this.checkBox_SoTienThu.TabIndex = 3;
            this.checkBox_SoTienThu.Text = "Số tiền thu không vượt quá số tiền khách đang nợ";
            this.checkBox_SoTienThu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.textBox_TienNoToiDa);
            this.panel1.Controls.Add(this.label_TienNoToiDa);
            this.panel1.Location = new System.Drawing.Point(20, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 29);
            this.panel1.TabIndex = 2;
            // 
            // textBox_TienNoToiDa
            // 
            this.textBox_TienNoToiDa.BackColor = System.Drawing.Color.LightGray;
            this.textBox_TienNoToiDa.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_TienNoToiDa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_TienNoToiDa.Location = new System.Drawing.Point(198, 0);
            this.textBox_TienNoToiDa.Name = "textBox_TienNoToiDa";
            this.textBox_TienNoToiDa.Size = new System.Drawing.Size(172, 26);
            this.textBox_TienNoToiDa.TabIndex = 1;
            this.textBox_TienNoToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_TienNoToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label_TienNoToiDa
            // 
            this.label_TienNoToiDa.AutoSize = true;
            this.label_TienNoToiDa.Location = new System.Drawing.Point(3, 3);
            this.label_TienNoToiDa.Name = "label_TienNoToiDa";
            this.label_TienNoToiDa.Size = new System.Drawing.Size(140, 18);
            this.label_TienNoToiDa.TabIndex = 0;
            this.label_TienNoToiDa.Text = "label_TienNoToiDa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 258);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 10);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(490, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 268);
            this.panel5.TabIndex = 4;
            // 
            // button_Save
            // 
            this.button_Save.AutoSize = true;
            this.button_Save.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.button_Save.Location = new System.Drawing.Point(142, 241);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(202, 48);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "button_save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Setting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(500, 314);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Nhap_ChinhSua);
            this.Controls.Add(this.panel_Setting_Top);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            this.panel_Setting_Top.ResumeLayout(false);
            this.panel_Setting_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setting)).EndInit();
            this.panel_SLToiThieu.ResumeLayout(false);
            this.panel_SLToiThieu.PerformLayout();
            this.panel_TonToiThieu.ResumeLayout(false);
            this.panel_TonToiThieu.PerformLayout();
            this.panel_Nhap_ChinhSua.ResumeLayout(false);
            this.panel_Nhap_ChinhSua.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_Setting_Top;
        private Button button_Setting_Top;
        private Label label_Setting;
        private Panel panel_SLToiThieu;
        private Label label_SLNhapToiThieu;
        private PictureBox pictureBox_Setting;
        private Panel panel_TonToiThieu;
        private Label label_LuongTonToiThieu;
        private Panel panel_Nhap_ChinhSua;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button button_Save;
        private CheckBox checkBox_SoTienThu;
        private Panel panel1;
        private Label label_TienNoToiDa;
        private TextBox textBox_SLNhapToiThieu;
        private TextBox textBox_LuongTonToiThieu;
        private TextBox textBox_TienNoToiDa;
    }
}