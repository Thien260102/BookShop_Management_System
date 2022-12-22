using System.Windows.Forms;
namespace BookShop_Management.UserControls
{
    partial class BaoCaoCongNo
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
            this.panel_BaoCaoCongNo_Top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBox_Thang = new System.Windows.Forms.MaskedTextBox();
            this.label_Thang = new System.Windows.Forms.Label();
            this.label_BaoCaoCongNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_BaoCaoCongNo_Fill = new System.Windows.Forms.DataGridView();
            this.pictureBox_XuatBaoCao = new System.Windows.Forms.PictureBox();
            this.panel_BaoCaoCongNo_Top.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BaoCaoCongNo_Fill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XuatBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_BaoCaoCongNo_Top
            // 
            this.panel_BaoCaoCongNo_Top.Controls.Add(this.pictureBox_XuatBaoCao);
            this.panel_BaoCaoCongNo_Top.Controls.Add(this.panel2);
            this.panel_BaoCaoCongNo_Top.Controls.Add(this.label_BaoCaoCongNo);
            this.panel_BaoCaoCongNo_Top.Controls.Add(this.panel1);
            this.panel_BaoCaoCongNo_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BaoCaoCongNo_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_BaoCaoCongNo_Top.Name = "panel_BaoCaoCongNo_Top";
            this.panel_BaoCaoCongNo_Top.Size = new System.Drawing.Size(862, 80);
            this.panel_BaoCaoCongNo_Top.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskedTextBox_Thang);
            this.panel2.Controls.Add(this.label_Thang);
            this.panel2.Location = new System.Drawing.Point(458, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 25);
            this.panel2.TabIndex = 5;
            // 
            // maskedTextBox_Thang
            // 
            this.maskedTextBox_Thang.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBox_Thang.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_Thang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maskedTextBox_Thang.Location = new System.Drawing.Point(134, -1);
            this.maskedTextBox_Thang.Mask = "00";
            this.maskedTextBox_Thang.Name = "maskedTextBox_Thang";
            this.maskedTextBox_Thang.Size = new System.Drawing.Size(27, 29);
            this.maskedTextBox_Thang.TabIndex = 7;
            this.maskedTextBox_Thang.Text = "00";
            this.maskedTextBox_Thang.TextChanged += new System.EventHandler(this.maskedTextBox_Thang_TextChanged);
            // 
            // label_Thang
            // 
            this.label_Thang.AutoSize = true;
            this.label_Thang.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label_Thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_Thang.Location = new System.Drawing.Point(3, 0);
            this.label_Thang.Name = "label_Thang";
            this.label_Thang.Size = new System.Drawing.Size(125, 22);
            this.label_Thang.TabIndex = 5;
            this.label_Thang.Text = "label_Thang";
            // 
            // label_BaoCaoCongNo
            // 
            this.label_BaoCaoCongNo.AutoSize = true;
            this.label_BaoCaoCongNo.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label_BaoCaoCongNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_BaoCaoCongNo.Location = new System.Drawing.Point(0, 25);
            this.label_BaoCaoCongNo.Name = "label_BaoCaoCongNo";
            this.label_BaoCaoCongNo.Size = new System.Drawing.Size(237, 26);
            this.label_BaoCaoCongNo.TabIndex = 3;
            this.label_BaoCaoCongNo.Text = "label_BaoCaoCongNo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 10);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView_BaoCaoCongNo_Fill
            // 
            this.dataGridView_BaoCaoCongNo_Fill.AllowUserToAddRows = false;
            this.dataGridView_BaoCaoCongNo_Fill.AllowUserToDeleteRows = false;
            this.dataGridView_BaoCaoCongNo_Fill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BaoCaoCongNo_Fill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_BaoCaoCongNo_Fill.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView_BaoCaoCongNo_Fill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BaoCaoCongNo_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_BaoCaoCongNo_Fill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.dataGridView_BaoCaoCongNo_Fill.Location = new System.Drawing.Point(0, 80);
            this.dataGridView_BaoCaoCongNo_Fill.Name = "dataGridView_BaoCaoCongNo_Fill";
            this.dataGridView_BaoCaoCongNo_Fill.ReadOnly = true;
            this.dataGridView_BaoCaoCongNo_Fill.RowHeadersVisible = false;
            this.dataGridView_BaoCaoCongNo_Fill.RowHeadersWidth = 51;
            this.dataGridView_BaoCaoCongNo_Fill.RowTemplate.Height = 29;
            this.dataGridView_BaoCaoCongNo_Fill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BaoCaoCongNo_Fill.Size = new System.Drawing.Size(862, 486);
            this.dataGridView_BaoCaoCongNo_Fill.TabIndex = 1;
            // 
            // pictureBox_XuatBaoCao
            // 
            this.pictureBox_XuatBaoCao.Image = global::BookShop_Management.Properties.Resources.plus_48px;
            this.pictureBox_XuatBaoCao.InitialImage = null;
            this.pictureBox_XuatBaoCao.Location = new System.Drawing.Point(793, 3);
            this.pictureBox_XuatBaoCao.Name = "pictureBox_XuatBaoCao";
            this.pictureBox_XuatBaoCao.Size = new System.Drawing.Size(66, 61);
            this.pictureBox_XuatBaoCao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_XuatBaoCao.TabIndex = 6;
            this.pictureBox_XuatBaoCao.TabStop = false;
            this.pictureBox_XuatBaoCao.Click += new System.EventHandler(this.pictureBox_XuatBaoCao_Click);
            // 
            // BaoCaoCongNo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.dataGridView_BaoCaoCongNo_Fill);
            this.Controls.Add(this.panel_BaoCaoCongNo_Top);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BaoCaoCongNo";
            this.Size = new System.Drawing.Size(862, 566);
            this.panel_BaoCaoCongNo_Top.ResumeLayout(false);
            this.panel_BaoCaoCongNo_Top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BaoCaoCongNo_Fill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XuatBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_BaoCaoCongNo_Top;
        private DataGridView dataGridView_BaoCaoCongNo_Fill;
        private Panel panel1;
        private Label label_BaoCaoCongNo;
        private Panel panel2;
        private MaskedTextBox maskedTextBox_Thang;
        private Label label_Thang;
        private PictureBox pictureBox_XuatBaoCao;
    }
}
