namespace Quanlycafe
{
    partial class fQuanlycafe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lst_hoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.cbo_chuyenban = new System.Windows.Forms.ComboBox();
            this.btn_chuyenban = new System.Windows.Forms.Button();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmsoluong = new System.Windows.Forms.NumericUpDown();
            this.btn_thêm = new System.Windows.Forms.Button();
            this.cbo_tenmonan = new System.Windows.Forms.ComboBox();
            this.cbo_loaidoan = new System.Windows.Forms.ComboBox();
            this.flpban = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmsoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảngToolStripMenuItem
            // 
            this.thôngTinTàiKhoảngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảngToolStripMenuItem.Name = "thôngTinTàiKhoảngToolStripMenuItem";
            this.thôngTinTàiKhoảngToolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.thôngTinTàiKhoảngToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lst_hoadon);
            this.panel2.Location = new System.Drawing.Point(579, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 339);
            this.panel2.TabIndex = 2;
            // 
            // lst_hoadon
            // 
            this.lst_hoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lst_hoadon.GridLines = true;
            this.lst_hoadon.Location = new System.Drawing.Point(3, 3);
            this.lst_hoadon.Name = "lst_hoadon";
            this.lst_hoadon.Size = new System.Drawing.Size(546, 307);
            this.lst_hoadon.TabIndex = 0;
            this.lst_hoadon.UseCompatibleStateImageBehavior = false;
            this.lst_hoadon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 229;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 114;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_tongtien);
            this.panel3.Controls.Add(this.cbo_chuyenban);
            this.panel3.Controls.Add(this.btn_chuyenban);
            this.panel3.Controls.Add(this.btn_thanhtoan);
            this.panel3.Location = new System.Drawing.Point(579, 508);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 114);
            this.panel3.TabIndex = 3;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(389, 65);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(160, 33);
            this.txt_tongtien.TabIndex = 8;
            this.txt_tongtien.Text = "0";
            this.txt_tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbo_chuyenban
            // 
            this.cbo_chuyenban.FormattingEnabled = true;
            this.cbo_chuyenban.Location = new System.Drawing.Point(6, 80);
            this.cbo_chuyenban.Name = "cbo_chuyenban";
            this.cbo_chuyenban.Size = new System.Drawing.Size(149, 28);
            this.cbo_chuyenban.TabIndex = 7;
            // 
            // btn_chuyenban
            // 
            this.btn_chuyenban.Location = new System.Drawing.Point(6, 3);
            this.btn_chuyenban.Name = "btn_chuyenban";
            this.btn_chuyenban.Size = new System.Drawing.Size(149, 71);
            this.btn_chuyenban.TabIndex = 6;
            this.btn_chuyenban.Text = "Chuyển bàn";
            this.btn_chuyenban.UseVisualStyleBackColor = true;
            this.btn_chuyenban.Click += new System.EventHandler(this.btn_chuyenban_Click);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(389, 0);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(160, 58);
            this.btn_thanhtoan.TabIndex = 3;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmsoluong);
            this.panel4.Controls.Add(this.btn_thêm);
            this.panel4.Controls.Add(this.cbo_tenmonan);
            this.panel4.Controls.Add(this.cbo_loaidoan);
            this.panel4.Location = new System.Drawing.Point(582, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 124);
            this.panel4.TabIndex = 4;
            // 
            // nmsoluong
            // 
            this.nmsoluong.Location = new System.Drawing.Point(70, 95);
            this.nmsoluong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmsoluong.Name = "nmsoluong";
            this.nmsoluong.Size = new System.Drawing.Size(68, 26);
            this.nmsoluong.TabIndex = 3;
            this.nmsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_thêm
            // 
            this.btn_thêm.Location = new System.Drawing.Point(168, 89);
            this.btn_thêm.Name = "btn_thêm";
            this.btn_thêm.Size = new System.Drawing.Size(109, 36);
            this.btn_thêm.TabIndex = 2;
            this.btn_thêm.Text = "Thêm món";
            this.btn_thêm.UseVisualStyleBackColor = true;
            this.btn_thêm.Click += new System.EventHandler(this.btn_thêm_Click);
            // 
            // cbo_tenmonan
            // 
            this.cbo_tenmonan.FormattingEnabled = true;
            this.cbo_tenmonan.Location = new System.Drawing.Point(3, 52);
            this.cbo_tenmonan.Name = "cbo_tenmonan";
            this.cbo_tenmonan.Size = new System.Drawing.Size(274, 28);
            this.cbo_tenmonan.TabIndex = 1;
            // 
            // cbo_loaidoan
            // 
            this.cbo_loaidoan.FormattingEnabled = true;
            this.cbo_loaidoan.Location = new System.Drawing.Point(3, 18);
            this.cbo_loaidoan.Name = "cbo_loaidoan";
            this.cbo_loaidoan.Size = new System.Drawing.Size(274, 28);
            this.cbo_loaidoan.TabIndex = 0;
            this.cbo_loaidoan.SelectedIndexChanged += new System.EventHandler(this.cbo_loaidoan_SelectedIndexChanged);
            // 
            // flpban
            // 
            this.flpban.AutoScroll = true;
            this.flpban.Location = new System.Drawing.Point(0, 36);
            this.flpban.Name = "flpban";
            this.flpban.Size = new System.Drawing.Size(573, 586);
            this.flpban.TabIndex = 5;
            // 
            // fQuanlycafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 628);
            this.Controls.Add(this.flpban);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fQuanlycafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí cafe";
            this.Load += new System.EventHandler(this.fQuanlycafe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmsoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lst_hoadon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmsoluong;
        private System.Windows.Forms.Button btn_thêm;
        private System.Windows.Forms.ComboBox cbo_tenmonan;
        private System.Windows.Forms.ComboBox cbo_loaidoan;
        private System.Windows.Forms.FlowLayoutPanel flpban;
        private System.Windows.Forms.ComboBox cbo_chuyenban;
        private System.Windows.Forms.Button btn_chuyenban;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_tongtien;
    }
}