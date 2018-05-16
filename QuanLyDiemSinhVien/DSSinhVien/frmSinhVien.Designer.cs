namespace QuanLyDiemSinhVien
{
    partial class frmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.radioTenSV = new System.Windows.Forms.RadioButton();
            this.radioTatCa = new System.Windows.Forms.RadioButton();
            this.radioMaSV = new System.Windows.Forms.RadioButton();
            this.radioMaLop = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiemDiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tvDSSV = new System.Windows.Forms.TreeView();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV:";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton1.Text = "Thêm mới";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton2.Text = "Sửa";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton3.Text = "Xóa";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton4.Text = "Thoát";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(368, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(338, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(368, 194);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(338, 20);
            this.txtMaSV.TabIndex = 14;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.GioiTinh,
            this.NgaySinh,
            this.NoiSinh,
            this.MaLop});
            this.dataGridView5.Location = new System.Drawing.Point(279, 380);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(638, 345);
            this.dataGridView5.TabIndex = 13;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 80;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Tên SV";
            this.TenSV.Name = "TenSV";
            this.TenSV.ReadOnly = true;
            this.TenSV.Width = 120;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // NoiSinh
            // 
            this.NoiSinh.DataPropertyName = "NoiSinh";
            this.NoiSinh.HeaderText = "Nơi Sinh";
            this.NoiSinh.Name = "NoiSinh";
            this.NoiSinh.ReadOnly = true;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(368, 331);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(338, 20);
            this.txtMaLop.TabIndex = 12;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(368, 303);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(338, 20);
            this.txtNoiSinh.TabIndex = 11;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(368, 248);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(338, 20);
            this.txtGioiTinh.TabIndex = 9;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(368, 220);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(338, 20);
            this.txtTenSV.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nơi sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên SV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(327, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Sinh Viên";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.radioTenSV);
            this.groupbox.Controls.Add(this.radioTatCa);
            this.groupbox.Controls.Add(this.radioMaSV);
            this.groupbox.Controls.Add(this.radioMaLop);
            this.groupbox.Controls.Add(this.label8);
            this.groupbox.Controls.Add(this.label9);
            this.groupbox.Controls.Add(this.txtTimKiemDiem);
            this.groupbox.Controls.Add(this.btnTimKiem);
            this.groupbox.Controls.Add(this.tvDSSV);
            this.groupbox.Controls.Add(this.dateTimePicker1);
            this.groupbox.Controls.Add(this.txtMaSV);
            this.groupbox.Controls.Add(this.dataGridView5);
            this.groupbox.Controls.Add(this.txtMaLop);
            this.groupbox.Controls.Add(this.txtNoiSinh);
            this.groupbox.Controls.Add(this.txtGioiTinh);
            this.groupbox.Controls.Add(this.txtTenSV);
            this.groupbox.Controls.Add(this.label7);
            this.groupbox.Controls.Add(this.label6);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Location = new System.Drawing.Point(-35, -91);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(923, 725);
            this.groupbox.TabIndex = 5;
            this.groupbox.TabStop = false;
            this.groupbox.Enter += new System.EventHandler(this.groupbox_Enter);
            // 
            // radioTenSV
            // 
            this.radioTenSV.AutoSize = true;
            this.radioTenSV.Location = new System.Drawing.Point(60, 531);
            this.radioTenSV.Name = "radioTenSV";
            this.radioTenSV.Size = new System.Drawing.Size(135, 17);
            this.radioTenSV.TabIndex = 41;
            this.radioTenSV.TabStop = true;
            this.radioTenSV.Text = "Tìm Kiếm Theo Tên SV";
            this.radioTenSV.UseVisualStyleBackColor = true;
            // 
            // radioTatCa
            // 
            this.radioTatCa.AutoSize = true;
            this.radioTatCa.Location = new System.Drawing.Point(60, 554);
            this.radioTatCa.Name = "radioTatCa";
            this.radioTatCa.Size = new System.Drawing.Size(190, 17);
            this.radioTatCa.TabIndex = 40;
            this.radioTatCa.TabStop = true;
            this.radioTatCa.Text = "Tìm Kiếm Theo Tất Cả Các Trường";
            this.radioTatCa.UseVisualStyleBackColor = true;
            // 
            // radioMaSV
            // 
            this.radioMaSV.AutoSize = true;
            this.radioMaSV.Location = new System.Drawing.Point(62, 508);
            this.radioMaSV.Name = "radioMaSV";
            this.radioMaSV.Size = new System.Drawing.Size(131, 17);
            this.radioMaSV.TabIndex = 39;
            this.radioMaSV.TabStop = true;
            this.radioMaSV.Text = "Tìm Kiếm Theo Mã SV";
            this.radioMaSV.UseVisualStyleBackColor = true;
            // 
            // radioMaLop
            // 
            this.radioMaLop.AutoSize = true;
            this.radioMaLop.Location = new System.Drawing.Point(62, 485);
            this.radioMaLop.Name = "radioMaLop";
            this.radioMaLop.Size = new System.Drawing.Size(135, 17);
            this.radioMaLop.TabIndex = 38;
            this.radioMaLop.TabStop = true;
            this.radioMaLop.Text = "Tìm Kiếm Theo Mã Lớp";
            this.radioMaLop.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(71, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 31);
            this.label8.TabIndex = 34;
            this.label8.Text = "TÌM KIẾM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Tìm Kiếm";
            // 
            // txtTimKiemDiem
            // 
            this.txtTimKiemDiem.Location = new System.Drawing.Point(113, 444);
            this.txtTimKiemDiem.Name = "txtTimKiemDiem";
            this.txtTimKiemDiem.Size = new System.Drawing.Size(131, 20);
            this.txtTimKiemDiem.TabIndex = 36;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(169, 600);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 35;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tvDSSV
            // 
            this.tvDSSV.Location = new System.Drawing.Point(59, 179);
            this.tvDSSV.Name = "tvDSSV";
            this.tvDSSV.Size = new System.Drawing.Size(220, 172);
            this.tvDSSV.TabIndex = 16;
            this.tvDSSV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDSSV_AfterSelect);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 646);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSinhVien";
            this.Text = "Danh sách Sinh viên";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.TreeView tvDSSV;
        private System.Windows.Forms.RadioButton radioTenSV;
        private System.Windows.Forms.RadioButton radioTatCa;
        private System.Windows.Forms.RadioButton radioMaSV;
        private System.Windows.Forms.RadioButton radioMaLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiemDiem;
        private System.Windows.Forms.Button btnTimKiem;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
    }
}