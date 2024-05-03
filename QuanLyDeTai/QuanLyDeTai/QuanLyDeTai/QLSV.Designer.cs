namespace QuanLyDeTai
{
    partial class QLSV
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_dssv = new System.Windows.Forms.DataGridView();
            this.sMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLopHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_manhom = new System.Windows.Forms.ComboBox();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.tb_lophc = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_tensv = new System.Windows.Forms.TextBox();
            this.tb_masv = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_lopHC = new System.Windows.Forms.Label();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_masv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_inds = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.lb_tensv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_dssv);
            this.groupBox2.Location = new System.Drawing.Point(17, 364);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1033, 239);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sinh viên";
            // 
            // dgv_dssv
            // 
            this.dgv_dssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dssv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSV,
            this.sTenSV,
            this.sGioiTinh,
            this.sLopHC,
            this.sEmail,
            this.sSDT,
            this.maN});
            this.dgv_dssv.Location = new System.Drawing.Point(8, 23);
            this.dgv_dssv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_dssv.Name = "dgv_dssv";
            this.dgv_dssv.RowHeadersWidth = 51;
            this.dgv_dssv.Size = new System.Drawing.Size(1016, 207);
            this.dgv_dssv.TabIndex = 0;
            this.dgv_dssv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dssv_CellContentClick);
            // 
            // sMaSV
            // 
            this.sMaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sMaSV.DataPropertyName = "sMaSV";
            this.sMaSV.HeaderText = "Mã sinh viên";
            this.sMaSV.MinimumWidth = 6;
            this.sMaSV.Name = "sMaSV";
            this.sMaSV.Width = 101;
            // 
            // sTenSV
            // 
            this.sTenSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTenSV.DataPropertyName = "sTenSV";
            this.sTenSV.HeaderText = "Tên sinh viên";
            this.sTenSV.MinimumWidth = 6;
            this.sTenSV.Name = "sTenSV";
            this.sTenSV.Width = 106;
            // 
            // sGioiTinh
            // 
            this.sGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sGioiTinh.DataPropertyName = "sGioiTinh";
            this.sGioiTinh.HeaderText = "Giới tính";
            this.sGioiTinh.MinimumWidth = 6;
            this.sGioiTinh.Name = "sGioiTinh";
            this.sGioiTinh.Width = 77;
            // 
            // sLopHC
            // 
            this.sLopHC.DataPropertyName = "sLopHC";
            this.sLopHC.HeaderText = "Lớp hành chính";
            this.sLopHC.MinimumWidth = 6;
            this.sLopHC.Name = "sLopHC";
            this.sLopHC.Width = 125;
            // 
            // sEmail
            // 
            this.sEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.MinimumWidth = 6;
            this.sEmail.Name = "sEmail";
            this.sEmail.Width = 70;
            // 
            // sSDT
            // 
            this.sSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "Số điện thoại";
            this.sSDT.MinimumWidth = 6;
            this.sSDT.Name = "sSDT";
            this.sSDT.Width = 105;
            // 
            // maN
            // 
            this.maN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maN.DataPropertyName = "sMaN";
            this.maN.HeaderText = "Mã nhóm";
            this.maN.MinimumWidth = 6;
            this.maN.Name = "maN";
            this.maN.Width = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã nhóm";
            // 
            // cb_manhom
            // 
            this.cb_manhom.FormattingEnabled = true;
            this.cb_manhom.Location = new System.Drawing.Point(613, 174);
            this.cb_manhom.Margin = new System.Windows.Forms.Padding(4);
            this.cb_manhom.Name = "cb_manhom";
            this.cb_manhom.Size = new System.Drawing.Size(260, 24);
            this.cb_manhom.TabIndex = 24;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(305, 155);
            this.rb_nu.Margin = new System.Windows.Forms.Padding(4);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(45, 20);
            this.rb_nu.TabIndex = 16;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(153, 155);
            this.rb_nam.Margin = new System.Windows.Forms.Padding(4);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(57, 20);
            this.rb_nam.TabIndex = 15;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // tb_lophc
            // 
            this.tb_lophc.Location = new System.Drawing.Point(613, 23);
            this.tb_lophc.Margin = new System.Windows.Forms.Padding(4);
            this.tb_lophc.Name = "tb_lophc";
            this.tb_lophc.Size = new System.Drawing.Size(260, 22);
            this.tb_lophc.TabIndex = 12;
            this.tb_lophc.TextChanged += new System.EventHandler(this.tb_lophc_TextChanged);
            this.tb_lophc.Validating += new System.ComponentModel.CancelEventHandler(this.tb_lophc_Validating);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(613, 79);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(260, 22);
            this.tb_email.TabIndex = 10;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged);
            this.tb_email.Validating += new System.ComponentModel.CancelEventHandler(this.tb_email_Validating);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(613, 127);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(260, 22);
            this.tb_sdt.TabIndex = 11;
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            this.tb_sdt.Validating += new System.ComponentModel.CancelEventHandler(this.tb_sdt_Validating);
            // 
            // tb_tensv
            // 
            this.tb_tensv.Location = new System.Drawing.Point(153, 87);
            this.tb_tensv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tensv.Name = "tb_tensv";
            this.tb_tensv.Size = new System.Drawing.Size(260, 22);
            this.tb_tensv.TabIndex = 9;
            this.tb_tensv.TextChanged += new System.EventHandler(this.tb_tensv_TextChanged);
            this.tb_tensv.Validating += new System.ComponentModel.CancelEventHandler(this.tb_tensv_Validating);
            // 
            // tb_masv
            // 
            this.tb_masv.Location = new System.Drawing.Point(153, 27);
            this.tb_masv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_masv.Name = "tb_masv";
            this.tb_masv.Size = new System.Drawing.Size(260, 22);
            this.tb_masv.TabIndex = 8;
            this.tb_masv.TextChanged += new System.EventHandler(this.tb_masv_TextChanged);
            this.tb_masv.Validating += new System.ComponentModel.CancelEventHandler(this.tb_masv_Validating);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(540, 87);
            this.lb_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(41, 16);
            this.lb_email.TabIndex = 7;
            this.lb_email.Text = "Email";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(540, 135);
            this.lb_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(35, 16);
            this.lb_sdt.TabIndex = 6;
            this.lb_sdt.Text = "SDT";
            // 
            // lb_lopHC
            // 
            this.lb_lopHC.AutoSize = true;
            this.lb_lopHC.Location = new System.Drawing.Point(525, 31);
            this.lb_lopHC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lopHC.Name = "lb_lopHC";
            this.lb_lopHC.Size = new System.Drawing.Size(52, 16);
            this.lb_lopHC.TabIndex = 3;
            this.lb_lopHC.Text = "Lớp HC";
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Location = new System.Drawing.Point(40, 155);
            this.lb_gioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(54, 16);
            this.lb_gioitinh.TabIndex = 2;
            this.lb_gioitinh.Text = "Giới tính";
            // 
            // lb_masv
            // 
            this.lb_masv.AutoSize = true;
            this.lb_masv.Location = new System.Drawing.Point(40, 36);
            this.lb_masv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_masv.Name = "lb_masv";
            this.lb_masv.Size = new System.Drawing.Size(81, 16);
            this.lb_masv.TabIndex = 0;
            this.lb_masv.Text = "Mã sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_inds);
            this.groupBox1.Controls.Add(this.btn_boqua);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_manhom);
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Controls.Add(this.tb_lophc);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.tb_tensv);
            this.groupBox1.Controls.Add(this.tb_masv);
            this.groupBox1.Controls.Add(this.lb_email);
            this.groupBox1.Controls.Add(this.lb_sdt);
            this.groupBox1.Controls.Add(this.lb_lopHC);
            this.groupBox1.Controls.Add(this.lb_gioitinh);
            this.groupBox1.Controls.Add(this.lb_tensv);
            this.groupBox1.Controls.Add(this.lb_masv);
            this.groupBox1.Location = new System.Drawing.Point(17, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1033, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý nhóm sinh viên";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(900, 231);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 33;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_inds
            // 
            this.btn_inds.Location = new System.Drawing.Point(749, 231);
            this.btn_inds.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inds.Name = "btn_inds";
            this.btn_inds.Size = new System.Drawing.Size(100, 28);
            this.btn_inds.TabIndex = 32;
            this.btn_inds.Text = "Báo cáo";
            this.btn_inds.UseVisualStyleBackColor = true;
            this.btn_inds.Click += new System.EventHandler(this.btn_inds_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(616, 231);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(100, 28);
            this.btn_boqua.TabIndex = 31;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(472, 231);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 28);
            this.btn_timkiem.TabIndex = 30;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(323, 231);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 29;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(182, 231);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 28;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(40, 231);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 27;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lb_tensv
            // 
            this.lb_tensv.AutoSize = true;
            this.lb_tensv.Location = new System.Drawing.Point(40, 92);
            this.lb_tensv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tensv.Name = "lb_tensv";
            this.lb_tensv.Size = new System.Drawing.Size(86, 16);
            this.lb_tensv.TabIndex = 1;
            this.lb_tensv.Text = "Tên sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ SINH VIÊN THAM GIA NCKH";
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QLSV";
            this.Text = "QLSV";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_dssv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_manhom;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.TextBox tb_lophc;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_tensv;
        private System.Windows.Forms.TextBox tb_masv;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_lopHC;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.Label lb_masv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_tensv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLopHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maN;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_inds;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
    }
}