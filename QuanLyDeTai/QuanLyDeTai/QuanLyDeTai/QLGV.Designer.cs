namespace QuanLyDeTai
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_dsgv = new System.Windows.Forms.DataGridView();
            this.sMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_inds = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.mtb_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.tb_chucvu = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_tengv = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_magv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_dsgv);
            this.groupBox2.Location = new System.Drawing.Point(25, 330);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1016, 228);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách giảng viên";
            // 
            // dgv_dsgv
            // 
            this.dgv_dsgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaGV,
            this.sTenGV,
            this.sGioiTinh,
            this.sSDT,
            this.sEmail,
            this.sChucVu,
            this.sNgaySinh});
            this.dgv_dsgv.Location = new System.Drawing.Point(27, 25);
            this.dgv_dsgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_dsgv.Name = "dgv_dsgv";
            this.dgv_dsgv.RowHeadersWidth = 51;
            this.dgv_dsgv.Size = new System.Drawing.Size(981, 185);
            this.dgv_dsgv.TabIndex = 0;
            this.dgv_dsgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsgv_CellContentClick);
            // 
            // sMaGV
            // 
            this.sMaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sMaGV.DataPropertyName = "sMaGV";
            this.sMaGV.HeaderText = "Mã giáo viên";
            this.sMaGV.MinimumWidth = 6;
            this.sMaGV.Name = "sMaGV";
            this.sMaGV.Width = 113;
            // 
            // sTenGV
            // 
            this.sTenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTenGV.DataPropertyName = "sTenGV";
            this.sTenGV.HeaderText = "Tên giáo viên";
            this.sTenGV.MinimumWidth = 6;
            this.sTenGV.Name = "sTenGV";
            this.sTenGV.Width = 118;
            // 
            // sGioiTinh
            // 
            this.sGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sGioiTinh.DataPropertyName = "sGioiTinh";
            this.sGioiTinh.HeaderText = "Giới tính";
            this.sGioiTinh.MinimumWidth = 6;
            this.sGioiTinh.Name = "sGioiTinh";
            this.sGioiTinh.Width = 83;
            // 
            // sSDT
            // 
            this.sSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "Số điện thoại";
            this.sSDT.MinimumWidth = 6;
            this.sSDT.Name = "sSDT";
            this.sSDT.Width = 114;
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
            // sChucVu
            // 
            this.sChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sChucVu.DataPropertyName = "sChucVu";
            this.sChucVu.HeaderText = "Chức vụ";
            this.sChucVu.MinimumWidth = 6;
            this.sChucVu.Name = "sChucVu";
            this.sChucVu.Width = 83;
            // 
            // sNgaySinh
            // 
            this.sNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sNgaySinh.DataPropertyName = "sNgaySinh";
            this.sNgaySinh.HeaderText = "Ngày sinh";
            this.sNgaySinh.MinimumWidth = 6;
            this.sNgaySinh.Name = "sNgaySinh";
            this.sNgaySinh.Width = 96;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(236, 143);
            this.rb_nu.Margin = new System.Windows.Forms.Padding(4);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(45, 20);
            this.rb_nu.TabIndex = 21;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(107, 143);
            this.rb_nam.Margin = new System.Windows.Forms.Padding(4);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(57, 20);
            this.rb_nam.TabIndex = 20;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(887, 212);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 19;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_inds
            // 
            this.btn_inds.Location = new System.Drawing.Point(759, 212);
            this.btn_inds.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inds.Name = "btn_inds";
            this.btn_inds.Size = new System.Drawing.Size(100, 28);
            this.btn_inds.TabIndex = 18;
            this.btn_inds.Text = "Báo cáo";
            this.btn_inds.UseVisualStyleBackColor = true;
            this.btn_inds.Click += new System.EventHandler(this.btn_inds_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(615, 212);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(100, 28);
            this.btn_boqua.TabIndex = 17;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(472, 212);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 28);
            this.btn_timkiem.TabIndex = 16;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(332, 212);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(164, 212);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(27, 212);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // mtb_ngaysinh
            // 
            this.mtb_ngaysinh.Location = new System.Drawing.Point(808, 32);
            this.mtb_ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.mtb_ngaysinh.Mask = "00/00/0000";
            this.mtb_ngaysinh.Name = "mtb_ngaysinh";
            this.mtb_ngaysinh.Size = new System.Drawing.Size(183, 22);
            this.mtb_ngaysinh.TabIndex = 12;
            this.mtb_ngaysinh.ValidatingType = typeof(System.DateTime);
            this.mtb_ngaysinh.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_ngaysinh_Validating);
            // 
            // tb_chucvu
            // 
            this.tb_chucvu.Location = new System.Drawing.Point(472, 145);
            this.tb_chucvu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_chucvu.Name = "tb_chucvu";
            this.tb_chucvu.Size = new System.Drawing.Size(241, 22);
            this.tb_chucvu.TabIndex = 11;
            this.tb_chucvu.TextChanged += new System.EventHandler(this.tb_chucvu_TextChanged);
            this.tb_chucvu.Validating += new System.ComponentModel.CancelEventHandler(this.tb_chucvu_Validating);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(472, 30);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(241, 22);
            this.tb_sdt.TabIndex = 9;
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            this.tb_sdt.Validating += new System.ComponentModel.CancelEventHandler(this.tb_sdt_Validating);
            // 
            // tb_tengv
            // 
            this.tb_tengv.Location = new System.Drawing.Point(107, 86);
            this.tb_tengv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tengv.Name = "tb_tengv";
            this.tb_tengv.Size = new System.Drawing.Size(241, 22);
            this.tb_tengv.TabIndex = 8;
            this.tb_tengv.TextChanged += new System.EventHandler(this.tb_tengv_TextChanged);
            this.tb_tengv.Validating += new System.ComponentModel.CancelEventHandler(this.tb_tengv_Validating);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(472, 86);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(241, 22);
            this.tb_email.TabIndex = 10;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged_1);
            this.tb_email.Validating += new System.ComponentModel.CancelEventHandler(this.tb_email_Validating);
            // 
            // tb_magv
            // 
            this.tb_magv.Location = new System.Drawing.Point(107, 28);
            this.tb_magv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_magv.Name = "tb_magv";
            this.tb_magv.Size = new System.Drawing.Size(241, 22);
            this.tb_magv.TabIndex = 7;
            this.tb_magv.TextChanged += new System.EventHandler(this.tb_magv_TextChanged);
            this.tb_magv.Validating += new System.ComponentModel.CancelEventHandler(this.tb_magv_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "SDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(733, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUẢN LÝ GIẢNG VIÊN HƯỚNG DẪN NGHIÊN CỨU ĐỀ TÀI KHOA HỌC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên giáo viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_inds);
            this.groupBox1.Controls.Add(this.btn_boqua);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.mtb_ngaysinh);
            this.groupBox1.Controls.Add(this.tb_chucvu);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.tb_tengv);
            this.groupBox1.Controls.Add(this.tb_magv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1016, 247);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giảng viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_dsgv;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_inds;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.MaskedTextBox mtb_ngaysinh;
        private System.Windows.Forms.TextBox tb_chucvu;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_tengv;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_magv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgaySinh;
    }
}

