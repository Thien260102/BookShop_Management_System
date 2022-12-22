using System.Windows.Forms;
namespace BookShop_Management.Forms
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LOGIN_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Login_button = new System.Windows.Forms.Button();
            this.Password_Label = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.Email_Label = new System.Windows.Forms.Label();
            this.textBox_TenTK = new System.Windows.Forms.TextBox();
            this.Login_header = new System.Windows.Forms.Panel();
            this.U_Button = new System.Windows.Forms.Button();
            this.I_Button = new System.Windows.Forms.Button();
            this.T_Button = new System.Windows.Forms.Button();
            this.UIT_logo = new System.Windows.Forms.PictureBox();
            this.Login_Name = new System.Windows.Forms.Label();
            this.Database_button = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Login_panel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.Login_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIT_logo)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_panel
            // 
            this.Login_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_panel.Controls.Add(this.panel5);
            this.Login_panel.Controls.Add(this.pictureBox1);
            this.Login_panel.Controls.Add(this.panel4);
            this.Login_panel.Location = new System.Drawing.Point(412, 86);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(376, 502);
            this.Login_panel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LOGIN_label);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 68);
            this.panel5.TabIndex = 2;
            // 
            // LOGIN_label
            // 
            this.LOGIN_label.AutoSize = true;
            this.LOGIN_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.LOGIN_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.LOGIN_label.Location = new System.Drawing.Point(85, 3);
            this.LOGIN_label.Name = "LOGIN_label";
            this.LOGIN_label.Size = new System.Drawing.Size(180, 32);
            this.LOGIN_label.TabIndex = 1;
            this.LOGIN_label.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Login_button);
            this.panel4.Controls.Add(this.Password_Label);
            this.panel4.Controls.Add(this.textBox_MatKhau);
            this.panel4.Controls.Add(this.Email_Label);
            this.panel4.Controls.Add(this.textBox_TenTK);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 233);
            this.panel4.TabIndex = 0;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Login_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Login_button.FlatAppearance.BorderSize = 0;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(0, 193);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(376, 40);
            this.Login_button.TabIndex = 2;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Password_Label.Location = new System.Drawing.Point(3, 81);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(75, 18);
            this.Password_Label.TabIndex = 5;
            this.Password_Label.Text = "Mật khẩu:";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BackColor = System.Drawing.Color.LightGray;
            this.textBox_MatKhau.Font = new System.Drawing.Font("Arial", 16.2F);
            this.textBox_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_MatKhau.Location = new System.Drawing.Point(0, 107);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.Size = new System.Drawing.Size(376, 32);
            this.textBox_MatKhau.TabIndex = 1;
            this.textBox_MatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NhanNut_Enter);
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Email_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Email_Label.Location = new System.Drawing.Point(0, 0);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(80, 18);
            this.Email_Label.TabIndex = 3;
            this.Email_Label.Text = "Tài khoản:";
            // 
            // textBox_TenTK
            // 
            this.textBox_TenTK.BackColor = System.Drawing.Color.LightGray;
            this.textBox_TenTK.Font = new System.Drawing.Font("Arial", 16.2F);
            this.textBox_TenTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_TenTK.Location = new System.Drawing.Point(0, 26);
            this.textBox_TenTK.Name = "textBox_TenTK";
            this.textBox_TenTK.Size = new System.Drawing.Size(376, 32);
            this.textBox_TenTK.TabIndex = 0;
            this.textBox_TenTK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NhanNut_Enter);
            // 
            // Login_header
            // 
            this.Login_header.BackColor = System.Drawing.Color.White;
            this.Login_header.Controls.Add(this.U_Button);
            this.Login_header.Controls.Add(this.I_Button);
            this.Login_header.Controls.Add(this.T_Button);
            this.Login_header.Controls.Add(this.UIT_logo);
            this.Login_header.Controls.Add(this.Login_Name);
            this.Login_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Login_header.Location = new System.Drawing.Point(0, 0);
            this.Login_header.Name = "Login_header";
            this.Login_header.Size = new System.Drawing.Size(1200, 79);
            this.Login_header.TabIndex = 0;
            this.Login_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // U_Button
            // 
            this.U_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.U_Button.BackColor = System.Drawing.Color.Transparent;
            this.U_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.U_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.U_Button.FlatAppearance.BorderSize = 0;
            this.U_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.U_Button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.U_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.U_Button.Location = new System.Drawing.Point(996, 0);
            this.U_Button.Name = "U_Button";
            this.U_Button.Size = new System.Drawing.Size(68, 79);
            this.U_Button.TabIndex = 4;
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
            this.I_Button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.I_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.I_Button.Location = new System.Drawing.Point(1064, 0);
            this.I_Button.Name = "I_Button";
            this.I_Button.Size = new System.Drawing.Size(68, 79);
            this.I_Button.TabIndex = 3;
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
            this.T_Button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.T_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.T_Button.Location = new System.Drawing.Point(1132, 0);
            this.T_Button.Name = "T_Button";
            this.T_Button.Size = new System.Drawing.Size(68, 79);
            this.T_Button.TabIndex = 2;
            this.T_Button.TabStop = false;
            this.T_Button.Text = "T";
            this.T_Button.UseVisualStyleBackColor = false;
            this.T_Button.Click += new System.EventHandler(this.T_Button_Click);
            // 
            // UIT_logo
            // 
            this.UIT_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.UIT_logo.Image = ((System.Drawing.Image)(resources.GetObject("UIT_logo.Image")));
            this.UIT_logo.Location = new System.Drawing.Point(0, 0);
            this.UIT_logo.Name = "UIT_logo";
            this.UIT_logo.Size = new System.Drawing.Size(68, 79);
            this.UIT_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UIT_logo.TabIndex = 1;
            this.UIT_logo.TabStop = false;
            this.UIT_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // Login_Name
            // 
            this.Login_Name.AutoSize = true;
            this.Login_Name.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.Login_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Login_Name.Location = new System.Drawing.Point(525, 23);
            this.Login_Name.Name = "Login_Name";
            this.Login_Name.Size = new System.Drawing.Size(117, 26);
            this.Login_Name.TabIndex = 1;
            this.Login_Name.Text = "Name App";
            this.Login_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // Database_button
            // 
            this.Database_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Database_button.BackColor = System.Drawing.Color.Transparent;
            this.Database_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Database_button.FlatAppearance.BorderSize = 0;
            this.Database_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Database_button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.Database_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.Database_button.Image = ((System.Drawing.Image)(resources.GetObject("Database_button.Image")));
            this.Database_button.Location = new System.Drawing.Point(1132, 573);
            this.Database_button.Name = "Database_button";
            this.Database_button.Size = new System.Drawing.Size(68, 68);
            this.Database_button.TabIndex = 3;
            this.Database_button.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.Database_button);
            this.panel6.Controls.Add(this.Login_panel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1200, 641);
            this.panel6.TabIndex = 1;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MoveWindow);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Login_header);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name App";
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.Login_panel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Login_header.ResumeLayout(false);
            this.Login_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIT_logo)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        //
        private Panel Login_panel;
        private Panel Login_header;
        private Label Login_Name;
        private PictureBox UIT_logo;
        private PictureBox pictureBox1;
        private Label LOGIN_label;
        private Button T_Button;
        private Button U_Button;
        private Button I_Button;
        private TextBox textBox_TenTK;
        private Label Email_Label;
        private Label Password_Label;
        private TextBox textBox_MatKhau;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button Login_button;
        private Button Database_button;
    }
}