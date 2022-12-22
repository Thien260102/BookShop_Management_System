using System.Windows.Forms;
namespace BookShop_Management.UserControls
{
    partial class TraCuuSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_TraCuuSach_Top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_TheLoai = new System.Windows.Forms.Label();
            this.textBox_TheLoai = new System.Windows.Forms.TextBox();
            this.panel_TenSach = new System.Windows.Forms.Panel();
            this.label_TenSach = new System.Windows.Forms.Label();
            this.textBox_TenSach = new System.Windows.Forms.TextBox();
            this.label_TraCuuSach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_TraCuuSach_Fill = new System.Windows.Forms.DataGridView();
            this.panel_TraCuuSach_Top.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_TenSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuSach_Fill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TraCuuSach_Top
            // 
            this.panel_TraCuuSach_Top.Controls.Add(this.panel2);
            this.panel_TraCuuSach_Top.Controls.Add(this.panel_TenSach);
            this.panel_TraCuuSach_Top.Controls.Add(this.label_TraCuuSach);
            this.panel_TraCuuSach_Top.Controls.Add(this.panel1);
            this.panel_TraCuuSach_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TraCuuSach_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_TraCuuSach_Top.Name = "panel_TraCuuSach_Top";
            this.panel_TraCuuSach_Top.Size = new System.Drawing.Size(862, 80);
            this.panel_TraCuuSach_Top.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_TheLoai);
            this.panel2.Controls.Add(this.textBox_TheLoai);
            this.panel2.Location = new System.Drawing.Point(290, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 30);
            this.panel2.TabIndex = 6;
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
            this.textBox_TheLoai.TabIndex = 0;
            this.textBox_TheLoai.TextChanged += new System.EventHandler(this.TraCuuSach_Ten_TheLoai);
            // 
            // panel_TenSach
            // 
            this.panel_TenSach.Controls.Add(this.label_TenSach);
            this.panel_TenSach.Controls.Add(this.textBox_TenSach);
            this.panel_TenSach.Location = new System.Drawing.Point(290, 3);
            this.panel_TenSach.Name = "panel_TenSach";
            this.panel_TenSach.Size = new System.Drawing.Size(334, 30);
            this.panel_TenSach.TabIndex = 5;
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
            this.textBox_TenSach.TextChanged += new System.EventHandler(this.TraCuuSach_Ten_TheLoai);
            // 
            // label_TraCuuSach
            // 
            this.label_TraCuuSach.AutoSize = true;
            this.label_TraCuuSach.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label_TraCuuSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_TraCuuSach.Location = new System.Drawing.Point(50, 25);
            this.label_TraCuuSach.Name = "label_TraCuuSach";
            this.label_TraCuuSach.Size = new System.Drawing.Size(199, 26);
            this.label_TraCuuSach.TabIndex = 3;
            this.label_TraCuuSach.Text = "label_TraCuuSach";
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
            // dataGridView_TraCuuSach_Fill
            // 
            this.dataGridView_TraCuuSach_Fill.AllowUserToAddRows = false;
            this.dataGridView_TraCuuSach_Fill.AllowUserToDeleteRows = false;
            this.dataGridView_TraCuuSach_Fill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_TraCuuSach_Fill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_TraCuuSach_Fill.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView_TraCuuSach_Fill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_TraCuuSach_Fill.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_TraCuuSach_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_TraCuuSach_Fill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.dataGridView_TraCuuSach_Fill.Location = new System.Drawing.Point(0, 80);
            this.dataGridView_TraCuuSach_Fill.Name = "dataGridView_TraCuuSach_Fill";
            this.dataGridView_TraCuuSach_Fill.ReadOnly = true;
            this.dataGridView_TraCuuSach_Fill.RowHeadersVisible = false;
            this.dataGridView_TraCuuSach_Fill.RowHeadersWidth = 51;
            this.dataGridView_TraCuuSach_Fill.RowTemplate.Height = 29;
            this.dataGridView_TraCuuSach_Fill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_TraCuuSach_Fill.Size = new System.Drawing.Size(862, 486);
            this.dataGridView_TraCuuSach_Fill.TabIndex = 1;
            // 
            // TraCuuSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.dataGridView_TraCuuSach_Fill);
            this.Controls.Add(this.panel_TraCuuSach_Top);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TraCuuSach";
            this.Size = new System.Drawing.Size(862, 566);
            this.panel_TraCuuSach_Top.ResumeLayout(false);
            this.panel_TraCuuSach_Top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_TenSach.ResumeLayout(false);
            this.panel_TenSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuSach_Fill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_TraCuuSach_Top;
        private DataGridView dataGridView_TraCuuSach_Fill;
        private Panel panel1;
        private Label label_TraCuuSach;
        private Panel panel2;
        private Label label_TheLoai;
        private TextBox textBox_TheLoai;
        private Panel panel_TenSach;
        private Label label_TenSach;
        private TextBox textBox_TenSach;
    }
}
