using System.Windows.Forms;
namespace BookShop_Management.UserControls
{
    partial class LichSuBanSach
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
            this.panel_LichSuBanSach_Top = new System.Windows.Forms.Panel();
            this.label_LichSuBanSach = new System.Windows.Forms.Label();
            this.textBox_TraCuu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_LichSuBanSach_Fill = new System.Windows.Forms.DataGridView();
            this.panel_LichSuBanSach_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichSuBanSach_Fill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_LichSuBanSach_Top
            // 
            this.panel_LichSuBanSach_Top.Controls.Add(this.label_LichSuBanSach);
            this.panel_LichSuBanSach_Top.Controls.Add(this.textBox_TraCuu);
            this.panel_LichSuBanSach_Top.Controls.Add(this.panel1);
            this.panel_LichSuBanSach_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LichSuBanSach_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_LichSuBanSach_Top.Name = "panel_LichSuBanSach_Top";
            this.panel_LichSuBanSach_Top.Size = new System.Drawing.Size(862, 80);
            this.panel_LichSuBanSach_Top.TabIndex = 1;
            // 
            // label_LichSuBanSach
            // 
            this.label_LichSuBanSach.AutoSize = true;
            this.label_LichSuBanSach.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label_LichSuBanSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.label_LichSuBanSach.Location = new System.Drawing.Point(50, 25);
            this.label_LichSuBanSach.Name = "label_LichSuBanSach";
            this.label_LichSuBanSach.Size = new System.Drawing.Size(235, 26);
            this.label_LichSuBanSach.TabIndex = 3;
            this.label_LichSuBanSach.Text = "label_LichSuBanSach";
            // 
            // textBox_TraCuu
            // 
            this.textBox_TraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.textBox_TraCuu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TraCuu.Font = new System.Drawing.Font("Arial", 26F);
            this.textBox_TraCuu.ForeColor = System.Drawing.Color.White;
            this.textBox_TraCuu.Location = new System.Drawing.Point(427, 11);
            this.textBox_TraCuu.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_TraCuu.Name = "textBox_TraCuu";
            this.textBox_TraCuu.Size = new System.Drawing.Size(431, 40);
            this.textBox_TraCuu.TabIndex = 0;
            this.textBox_TraCuu.TextChanged += new System.EventHandler(this.textBox_TraCuu_TextChanged);
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
            // dataGridView_LichSuBanSach_Fill
            // 
            this.dataGridView_LichSuBanSach_Fill.AllowUserToAddRows = false;
            this.dataGridView_LichSuBanSach_Fill.AllowUserToDeleteRows = false;
            this.dataGridView_LichSuBanSach_Fill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LichSuBanSach_Fill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_LichSuBanSach_Fill.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView_LichSuBanSach_Fill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_LichSuBanSach_Fill.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_LichSuBanSach_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_LichSuBanSach_Fill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(180)))));
            this.dataGridView_LichSuBanSach_Fill.Location = new System.Drawing.Point(0, 80);
            this.dataGridView_LichSuBanSach_Fill.Name = "dataGridView_LichSuBanSach_Fill";
            this.dataGridView_LichSuBanSach_Fill.ReadOnly = true;
            this.dataGridView_LichSuBanSach_Fill.RowHeadersVisible = false;
            this.dataGridView_LichSuBanSach_Fill.RowHeadersWidth = 51;
            this.dataGridView_LichSuBanSach_Fill.RowTemplate.Height = 29;
            this.dataGridView_LichSuBanSach_Fill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_LichSuBanSach_Fill.Size = new System.Drawing.Size(862, 486);
            this.dataGridView_LichSuBanSach_Fill.TabIndex = 1;
            // 
            // LichSuBanSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.dataGridView_LichSuBanSach_Fill);
            this.Controls.Add(this.panel_LichSuBanSach_Top);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LichSuBanSach";
            this.Size = new System.Drawing.Size(862, 566);
            this.panel_LichSuBanSach_Top.ResumeLayout(false);
            this.panel_LichSuBanSach_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichSuBanSach_Fill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_LichSuBanSach_Top;
        private DataGridView dataGridView_LichSuBanSach_Fill;
        private TextBox textBox_TraCuu;
        private Panel panel1;
        private Label label_LichSuBanSach;
    }
}
