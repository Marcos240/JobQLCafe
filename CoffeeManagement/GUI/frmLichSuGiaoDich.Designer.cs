namespace CoffeeManagement
{
    partial class frmLichSuGiaoDich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuGiaoDich));
            this.contextMenuHoaDon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.tbTTTo = new System.Windows.Forms.TextBox();
            this.cbNgayGD = new System.Windows.Forms.CheckBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.lbKhongCoGDNao = new System.Windows.Forms.Label();
            this.dtgHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbViewMode = new System.Windows.Forms.ComboBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelThang = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNam1 = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.panelNam = new System.Windows.Forms.Panel();
            this.cbNam2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelNangCao = new System.Windows.Forms.Panel();
            this.tbTTFrom = new System.Windows.Forms.TextBox();
            this.panelNgay = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.panelTuan = new System.Windows.Forms.Panel();
            this.dtpTuan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.panelThang.SuspendLayout();
            this.panelNam.SuspendLayout();
            this.panelNangCao.SuspendLayout();
            this.panelNgay.SuspendLayout();
            this.panelTuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuHoaDon
            // 
            this.contextMenuHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtToolStripMenuItem,
            this.xuấtHóaĐơnToolStripMenuItem});
            this.contextMenuHoaDon.Name = "contextMenuHoaDon";
            this.contextMenuHoaDon.Size = new System.Drawing.Size(146, 48);
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Image = global::CoffeeManagement.Properties.Resources.detail;
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.chiTiếtToolStripMenuItem.Text = "Chi tiết";
            this.chiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // xuấtHóaĐơnToolStripMenuItem
            // 
            this.xuấtHóaĐơnToolStripMenuItem.Image = global::CoffeeManagement.Properties.Resources.exportFile;
            this.xuấtHóaĐơnToolStripMenuItem.Name = "xuấtHóaĐơnToolStripMenuItem";
            this.xuấtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.xuấtHóaĐơnToolStripMenuItem.Text = "Xuất hóa đơn";
            this.xuấtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xuấtHóaĐơnToolStripMenuItem_Click);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(102, 3);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(90, 21);
            this.dtpDateFrom.TabIndex = 22;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // tbTTTo
            // 
            this.tbTTTo.Location = new System.Drawing.Point(533, 3);
            this.tbTTTo.Name = "tbTTTo";
            this.tbTTTo.Size = new System.Drawing.Size(90, 21);
            this.tbTTTo.TabIndex = 26;
            this.tbTTTo.Text = "0";
            this.tbTTTo.TextChanged += new System.EventHandler(this.tbTTTo_TextChanged);
            // 
            // cbNgayGD
            // 
            this.cbNgayGD.AutoSize = true;
            this.cbNgayGD.Location = new System.Drawing.Point(3, 4);
            this.cbNgayGD.Name = "cbNgayGD";
            this.cbNgayGD.Size = new System.Drawing.Size(96, 17);
            this.cbNgayGD.TabIndex = 20;
            this.cbNgayGD.Text = "Ngày giao dịch";
            this.cbNgayGD.UseVisualStyleBackColor = true;
            this.cbNgayGD.CheckedChanged += new System.EventHandler(this.cbNgayGD_CheckedChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(196, 3);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(90, 21);
            this.dtpDateTo.TabIndex = 25;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(340, 4);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(71, 17);
            this.cbTT.TabIndex = 21;
            this.cbTT.Text = "Tổng tiền";
            this.cbTT.UseVisualStyleBackColor = true;
            this.cbTT.CheckedChanged += new System.EventHandler(this.cbTT_CheckedChanged);
            // 
            // lbKhongCoGDNao
            // 
            this.lbKhongCoGDNao.AutoSize = true;
            this.lbKhongCoGDNao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhongCoGDNao.Location = new System.Drawing.Point(752, 90);
            this.lbKhongCoGDNao.Name = "lbKhongCoGDNao";
            this.lbKhongCoGDNao.Size = new System.Drawing.Size(169, 19);
            this.lbKhongCoGDNao.TabIndex = 45;
            this.lbKhongCoGDNao.Text = "DONT TOUCH THIS!";
            // 
            // dtgHoaDon
            // 
            this.dtgHoaDon.AllowUserToAddRows = false;
            this.dtgHoaDon.AllowUserToDeleteRows = false;
            this.dtgHoaDon.AllowUserToResizeColumns = false;
            this.dtgHoaDon.AllowUserToResizeRows = false;
            this.dtgHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtgHoaDon.Location = new System.Drawing.Point(23, 107);
            this.dtgHoaDon.Name = "dtgHoaDon";
            this.dtgHoaDon.ReadOnly = true;
            this.dtgHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgHoaDon.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHoaDon.Size = new System.Drawing.Size(917, 423);
            this.dtgHoaDon.TabIndex = 44;
            this.dtgHoaDon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgHoaDon_MouseDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayThanhToan";
            this.Column2.HeaderText = "Ngày thanh toán";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GiamGia";
            this.Column3.HeaderText = "Giảm giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IDBan";
            this.Column4.HeaderText = "Bàn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IDThanhVien";
            this.Column5.HeaderText = "Mã thành viên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "HoTen";
            this.Column9.HeaderText = "Tên thành viên";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TrangThai";
            this.Column6.HeaderText = "Trạng thái";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TongTien";
            this.Column7.HeaderText = "Tổng tiền";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ThanhTien";
            this.Column8.HeaderText = "Thành tiền";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // cbViewMode
            // 
            this.cbViewMode.FormattingEnabled = true;
            this.cbViewMode.Items.AddRange(new object[] {
            "Ngày",
            "Tuần",
            "Tháng",
            "Năm",
            "Nâng cao",
            "Tất cả"});
            this.cbViewMode.Location = new System.Drawing.Point(101, 24);
            this.cbViewMode.Name = "cbViewMode";
            this.cbViewMode.Size = new System.Drawing.Size(72, 21);
            this.cbViewMode.TabIndex = 31;
            this.cbViewMode.Text = "Ngày";
            this.cbViewMode.TextChanged += new System.EventHandler(this.cbViewMode_TextChanged);
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.cbViewMode);
            this.gbFilter.Controls.Add(this.label6);
            this.gbFilter.Controls.Add(this.panelThang);
            this.gbFilter.Controls.Add(this.tbHoTen);
            this.gbFilter.Controls.Add(this.panelNam);
            this.gbFilter.Controls.Add(this.panelNangCao);
            this.gbFilter.Controls.Add(this.panelNgay);
            this.gbFilter.Controls.Add(this.panelTuan);
            this.gbFilter.ForeColor = System.Drawing.Color.Black;
            this.gbFilter.Location = new System.Drawing.Point(23, 6);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(0);
            this.gbFilter.Size = new System.Drawing.Size(917, 84);
            this.gbFilter.TabIndex = 46;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Lọc và tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Xem theo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tìm kiếm theo thành viên";
            // 
            // panelThang
            // 
            this.panelThang.Controls.Add(this.label4);
            this.panelThang.Controls.Add(this.cbNam1);
            this.panelThang.Controls.Add(this.cbThang);
            this.panelThang.Location = new System.Drawing.Point(210, 24);
            this.panelThang.Name = "panelThang";
            this.panelThang.Size = new System.Drawing.Size(298, 25);
            this.panelThang.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn tháng";
            // 
            // cbNam1
            // 
            this.cbNam1.FormattingEnabled = true;
            this.cbNam1.Location = new System.Drawing.Point(124, 0);
            this.cbNam1.Name = "cbNam1";
            this.cbNam1.Size = new System.Drawing.Size(68, 21);
            this.cbNam1.TabIndex = 8;
            this.cbNam1.Text = "2019";
            this.cbNam1.TextChanged += new System.EventHandler(this.cbNam1_TextChanged);
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(68, 0);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(46, 21);
            this.cbThang.TabIndex = 9;
            this.cbThang.Text = "12";
            this.cbThang.TextChanged += new System.EventHandler(this.cbThang_TextChanged);
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(210, 56);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(204, 21);
            this.tbHoTen.TabIndex = 38;
            this.tbHoTen.TextChanged += new System.EventHandler(this.tbHoTen_TextChanged);
            this.tbHoTen.Enter += new System.EventHandler(this.tbHoTen_Enter);
            // 
            // panelNam
            // 
            this.panelNam.Controls.Add(this.cbNam2);
            this.panelNam.Controls.Add(this.label5);
            this.panelNam.Location = new System.Drawing.Point(210, 24);
            this.panelNam.Name = "panelNam";
            this.panelNam.Size = new System.Drawing.Size(298, 25);
            this.panelNam.TabIndex = 34;
            // 
            // cbNam2
            // 
            this.cbNam2.FormattingEnabled = true;
            this.cbNam2.Location = new System.Drawing.Point(68, 0);
            this.cbNam2.Name = "cbNam2";
            this.cbNam2.Size = new System.Drawing.Size(90, 21);
            this.cbNam2.TabIndex = 3;
            this.cbNam2.Text = "2019";
            this.cbNam2.TextChanged += new System.EventHandler(this.cbNam2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chọn năm";
            // 
            // panelNangCao
            // 
            this.panelNangCao.Controls.Add(this.dtpDateFrom);
            this.panelNangCao.Controls.Add(this.tbTTTo);
            this.panelNangCao.Controls.Add(this.cbNgayGD);
            this.panelNangCao.Controls.Add(this.dtpDateTo);
            this.panelNangCao.Controls.Add(this.cbTT);
            this.panelNangCao.Controls.Add(this.tbTTFrom);
            this.panelNangCao.Location = new System.Drawing.Point(210, 24);
            this.panelNangCao.Name = "panelNangCao";
            this.panelNangCao.Size = new System.Drawing.Size(638, 25);
            this.panelNangCao.TabIndex = 40;
            // 
            // tbTTFrom
            // 
            this.tbTTFrom.Location = new System.Drawing.Point(437, 3);
            this.tbTTFrom.Name = "tbTTFrom";
            this.tbTTFrom.Size = new System.Drawing.Size(90, 21);
            this.tbTTFrom.TabIndex = 24;
            this.tbTTFrom.Text = "0";
            this.tbTTFrom.TextChanged += new System.EventHandler(this.tbTTFrom_TextChanged);
            // 
            // panelNgay
            // 
            this.panelNgay.Controls.Add(this.label2);
            this.panelNgay.Controls.Add(this.dtpNgay);
            this.panelNgay.Location = new System.Drawing.Point(210, 24);
            this.panelNgay.Name = "panelNgay";
            this.panelNgay.Size = new System.Drawing.Size(298, 24);
            this.panelNgay.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn ngày";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(68, 0);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(90, 21);
            this.dtpNgay.TabIndex = 10;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // panelTuan
            // 
            this.panelTuan.Controls.Add(this.dtpTuan);
            this.panelTuan.Controls.Add(this.label3);
            this.panelTuan.Location = new System.Drawing.Point(210, 24);
            this.panelTuan.Name = "panelTuan";
            this.panelTuan.Size = new System.Drawing.Size(298, 25);
            this.panelTuan.TabIndex = 35;
            // 
            // dtpTuan
            // 
            this.dtpTuan.CustomFormat = "dd/MM/yyyy";
            this.dtpTuan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuan.Location = new System.Drawing.Point(68, 0);
            this.dtpTuan.Name = "dtpTuan";
            this.dtpTuan.Size = new System.Drawing.Size(90, 21);
            this.dtpTuan.TabIndex = 11;
            this.dtpTuan.ValueChanged += new System.EventHandler(this.dtpTuan_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn tuần";
            // 
            // frmLichSuGiaoDich
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 537);
            this.Controls.Add(this.lbKhongCoGDNao);
            this.Controls.Add(this.dtgHoaDon);
            this.Controls.Add(this.gbFilter);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLichSuGiaoDich";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BÁO CÁO DOANH THU THEO THỜI GIAN";
            this.contextMenuHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.panelThang.ResumeLayout(false);
            this.panelThang.PerformLayout();
            this.panelNam.ResumeLayout(false);
            this.panelNam.PerformLayout();
            this.panelNangCao.ResumeLayout(false);
            this.panelNangCao.PerformLayout();
            this.panelNgay.ResumeLayout(false);
            this.panelNgay.PerformLayout();
            this.panelTuan.ResumeLayout(false);
            this.panelTuan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.TextBox tbTTTo;
        private System.Windows.Forms.CheckBox cbNgayGD;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.Label lbKhongCoGDNao;
        private System.Windows.Forms.DataGridView dtgHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox cbViewMode;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNam1;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Panel panelNam;
        private System.Windows.Forms.ComboBox cbNam2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelNangCao;
        private System.Windows.Forms.TextBox tbTTFrom;
        private System.Windows.Forms.Panel panelNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Panel panelTuan;
        private System.Windows.Forms.DateTimePicker dtpTuan;
        private System.Windows.Forms.Label label3;
    }
}