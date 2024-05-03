namespace QuanLyDeTai
{
    partial class QLDT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsdt = new System.Windows.Forms.DataGridView();
            this.sMaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNamTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_gvhd = new System.Windows.Forms.ComboBox();
            this.cb_namTH = new System.Windows.Forms.ComboBox();
            this.cb_maNhom = new System.Windows.Forms.ComboBox();
            this.cb_linhvuc = new System.Windows.Forms.ComboBox();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.txt_tendt = new System.Windows.Forms.TextBox();
            this.txt_madt = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.lb_namTH = new System.Windows.Forms.Label();
            this.lb_man = new System.Windows.Forms.Label();
            this.lb_gv = new System.Windows.Forms.Label();
            this.lb_diem = new System.Windows.Forms.Label();
            this.lb_linhvuc = new System.Windows.Forms.Label();
            this.lb_tendt = new System.Windows.Forms.Label();
            this.lb_madt = new System.Windows.Forms.Label();
            this.cb_gv = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdt)).BeginInit();
            this.cb_gv.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsdt);
            this.groupBox1.Location = new System.Drawing.Point(22, 399);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1020, 191);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đề tài NCKH";
            // 
            // dgv_dsdt
            // 
            this.dgv_dsdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsdt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaDT,
            this.sTenDT,
            this.sMaLV,
            this.sNamTH,
            this.sMaN,
            this.sMaGV,
            this.sDiem});
            this.dgv_dsdt.Location = new System.Drawing.Point(8, 23);
            this.dgv_dsdt.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_dsdt.Name = "dgv_dsdt";
            this.dgv_dsdt.RowHeadersWidth = 51;
            this.dgv_dsdt.Size = new System.Drawing.Size(985, 215);
            this.dgv_dsdt.TabIndex = 0;
            this.dgv_dsdt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsdt_CellContentClick);
            // 
            // sMaDT
            // 
            this.sMaDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sMaDT.DataPropertyName = "sMaDT";
            this.sMaDT.HeaderText = "Mã đề tài";
            this.sMaDT.MinimumWidth = 6;
            this.sMaDT.Name = "sMaDT";
            this.sMaDT.ReadOnly = true;
            this.sMaDT.Width = 91;
            // 
            // sTenDT
            // 
            this.sTenDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTenDT.DataPropertyName = "sTenDT";
            this.sTenDT.HeaderText = "Tên đề tài";
            this.sTenDT.MinimumWidth = 6;
            this.sTenDT.Name = "sTenDT";
            this.sTenDT.ReadOnly = true;
            this.sTenDT.Width = 96;
            // 
            // sMaLV
            // 
            this.sMaLV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sMaLV.DataPropertyName = "sMaLV";
            this.sMaLV.HeaderText = "Mã LV";
            this.sMaLV.MinimumWidth = 6;
            this.sMaLV.Name = "sMaLV";
            this.sMaLV.ReadOnly = true;
            this.sMaLV.Width = 74;
            // 
            // sNamTH
            // 
            this.sNamTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sNamTH.DataPropertyName = "sNamTH";
            this.sNamTH.HeaderText = "Năm thực hiện";
            this.sNamTH.MinimumWidth = 6;
            this.sNamTH.Name = "sNamTH";
            this.sNamTH.ReadOnly = true;
            this.sNamTH.Width = 120;
            // 
            // sMaN
            // 
            this.sMaN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sMaN.DataPropertyName = "sMaN";
            this.sMaN.HeaderText = "Mã nhóm";
            this.sMaN.MinimumWidth = 6;
            this.sMaN.Name = "sMaN";
            this.sMaN.ReadOnly = true;
            this.sMaN.Width = 91;
            // 
            // sMaGV
            // 
            this.sMaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sMaGV.DataPropertyName = "sMaGV";
            this.sMaGV.HeaderText = "Giảng viên";
            this.sMaGV.MinimumWidth = 6;
            this.sMaGV.Name = "sMaGV";
            this.sMaGV.ReadOnly = true;
            // 
            // sDiem
            // 
            this.sDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sDiem.DataPropertyName = "sDiem";
            this.sDiem.HeaderText = "Điểm";
            this.sDiem.MinimumWidth = 6;
            this.sDiem.Name = "sDiem";
            this.sDiem.ReadOnly = true;
            this.sDiem.Width = 67;
            // 
            // cb_gvhd
            // 
            this.cb_gvhd.DisplayMember = "sTenGV";
            this.cb_gvhd.FormattingEnabled = true;
            this.cb_gvhd.Location = new System.Drawing.Point(644, 39);
            this.cb_gvhd.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gvhd.Name = "cb_gvhd";
            this.cb_gvhd.Size = new System.Drawing.Size(280, 24);
            this.cb_gvhd.TabIndex = 22;
            this.cb_gvhd.ValueMember = "sTenGV";
            // 
            // cb_namTH
            // 
            this.cb_namTH.DisplayMember = "sNamTH";
            this.cb_namTH.FormattingEnabled = true;
            this.cb_namTH.Location = new System.Drawing.Point(644, 123);
            this.cb_namTH.Margin = new System.Windows.Forms.Padding(4);
            this.cb_namTH.Name = "cb_namTH";
            this.cb_namTH.Size = new System.Drawing.Size(280, 24);
            this.cb_namTH.TabIndex = 21;
            this.cb_namTH.ValueMember = "sNamTH";
            // 
            // cb_maNhom
            // 
            this.cb_maNhom.DisplayMember = "sMaN";
            this.cb_maNhom.FormattingEnabled = true;
            this.cb_maNhom.Location = new System.Drawing.Point(644, 82);
            this.cb_maNhom.Margin = new System.Windows.Forms.Padding(4);
            this.cb_maNhom.Name = "cb_maNhom";
            this.cb_maNhom.Size = new System.Drawing.Size(280, 24);
            this.cb_maNhom.TabIndex = 20;
            this.cb_maNhom.ValueMember = "sMaN";
            // 
            // cb_linhvuc
            // 
            this.cb_linhvuc.DisplayMember = "sTenLV";
            this.cb_linhvuc.FormattingEnabled = true;
            this.cb_linhvuc.Location = new System.Drawing.Point(120, 191);
            this.cb_linhvuc.Margin = new System.Windows.Forms.Padding(4);
            this.cb_linhvuc.Name = "cb_linhvuc";
            this.cb_linhvuc.Size = new System.Drawing.Size(280, 24);
            this.cb_linhvuc.TabIndex = 18;
            this.cb_linhvuc.ValueMember = "sTenLV";
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(644, 182);
            this.txt_diem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(280, 22);
            this.txt_diem.TabIndex = 17;
            this.txt_diem.TextChanged += new System.EventHandler(this.txt_diem_TextChanged);
            this.txt_diem.Validating += new System.ComponentModel.CancelEventHandler(this.txt_diem_Validating);
            // 
            // txt_tendt
            // 
            this.txt_tendt.Location = new System.Drawing.Point(120, 82);
            this.txt_tendt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tendt.Multiline = true;
            this.txt_tendt.Name = "txt_tendt";
            this.txt_tendt.Size = new System.Drawing.Size(280, 93);
            this.txt_tendt.TabIndex = 16;
            this.txt_tendt.TextChanged += new System.EventHandler(this.txt_tendt_TextChanged);
            this.txt_tendt.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tendt_Validating);
            // 
            // txt_madt
            // 
            this.txt_madt.Location = new System.Drawing.Point(120, 31);
            this.txt_madt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_madt.Name = "txt_madt";
            this.txt_madt.Size = new System.Drawing.Size(280, 22);
            this.txt_madt.TabIndex = 15;
            this.txt_madt.TextChanged += new System.EventHandler(this.txt_madt_TextChanged);
            this.txt_madt.Validating += new System.ComponentModel.CancelEventHandler(this.txt_madt_Validating);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(869, 261);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_baocao
            // 
            this.btn_baocao.Location = new System.Drawing.Point(725, 261);
            this.btn_baocao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(100, 28);
            this.btn_baocao.TabIndex = 13;
            this.btn_baocao.Text = "Báo cáo";
            this.btn_baocao.UseVisualStyleBackColor = true;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(598, 261);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(100, 28);
            this.btn_boqua.TabIndex = 11;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(453, 261);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 28);
            this.btn_timkiem.TabIndex = 10;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(312, 261);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(174, 261);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(34, 261);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lb_namTH
            // 
            this.lb_namTH.AutoSize = true;
            this.lb_namTH.Location = new System.Drawing.Point(477, 133);
            this.lb_namTH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_namTH.Name = "lb_namTH";
            this.lb_namTH.Size = new System.Drawing.Size(91, 16);
            this.lb_namTH.TabIndex = 6;
            this.lb_namTH.Text = "Năm thực hiện";
            // 
            // lb_man
            // 
            this.lb_man.AutoSize = true;
            this.lb_man.Location = new System.Drawing.Point(477, 86);
            this.lb_man.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_man.Name = "lb_man";
            this.lb_man.Size = new System.Drawing.Size(62, 16);
            this.lb_man.TabIndex = 5;
            this.lb_man.Text = "Mã nhóm";
            // 
            // lb_gv
            // 
            this.lb_gv.AutoSize = true;
            this.lb_gv.Location = new System.Drawing.Point(477, 39);
            this.lb_gv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gv.Name = "lb_gv";
            this.lb_gv.Size = new System.Drawing.Size(137, 16);
            this.lb_gv.TabIndex = 4;
            this.lb_gv.Text = "Giảng viên hướng dẫn";
            // 
            // lb_diem
            // 
            this.lb_diem.AutoSize = true;
            this.lb_diem.Location = new System.Drawing.Point(477, 186);
            this.lb_diem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_diem.Name = "lb_diem";
            this.lb_diem.Size = new System.Drawing.Size(38, 16);
            this.lb_diem.TabIndex = 3;
            this.lb_diem.Text = "Điểm";
            // 
            // lb_linhvuc
            // 
            this.lb_linhvuc.AutoSize = true;
            this.lb_linhvuc.Location = new System.Drawing.Point(31, 191);
            this.lb_linhvuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_linhvuc.Name = "lb_linhvuc";
            this.lb_linhvuc.Size = new System.Drawing.Size(57, 16);
            this.lb_linhvuc.TabIndex = 2;
            this.lb_linhvuc.Text = "Lĩnh vực";
            // 
            // lb_tendt
            // 
            this.lb_tendt.AutoSize = true;
            this.lb_tendt.Location = new System.Drawing.Point(25, 92);
            this.lb_tendt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tendt.Name = "lb_tendt";
            this.lb_tendt.Size = new System.Drawing.Size(67, 16);
            this.lb_tendt.TabIndex = 1;
            this.lb_tendt.Text = "Tên đề tài";
            // 
            // lb_madt
            // 
            this.lb_madt.AutoSize = true;
            this.lb_madt.Location = new System.Drawing.Point(31, 39);
            this.lb_madt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_madt.Name = "lb_madt";
            this.lb_madt.Size = new System.Drawing.Size(62, 16);
            this.lb_madt.TabIndex = 0;
            this.lb_madt.Text = "Mã đề tài";
            // 
            // cb_gv
            // 
            this.cb_gv.Controls.Add(this.cb_gvhd);
            this.cb_gv.Controls.Add(this.cb_namTH);
            this.cb_gv.Controls.Add(this.cb_maNhom);
            this.cb_gv.Controls.Add(this.cb_linhvuc);
            this.cb_gv.Controls.Add(this.txt_diem);
            this.cb_gv.Controls.Add(this.txt_tendt);
            this.cb_gv.Controls.Add(this.txt_madt);
            this.cb_gv.Controls.Add(this.btn_thoat);
            this.cb_gv.Controls.Add(this.btn_baocao);
            this.cb_gv.Controls.Add(this.btn_boqua);
            this.cb_gv.Controls.Add(this.btn_timkiem);
            this.cb_gv.Controls.Add(this.btn_xoa);
            this.cb_gv.Controls.Add(this.btn_sua);
            this.cb_gv.Controls.Add(this.btn_them);
            this.cb_gv.Controls.Add(this.lb_namTH);
            this.cb_gv.Controls.Add(this.lb_man);
            this.cb_gv.Controls.Add(this.lb_gv);
            this.cb_gv.Controls.Add(this.lb_diem);
            this.cb_gv.Controls.Add(this.lb_linhvuc);
            this.cb_gv.Controls.Add(this.lb_tendt);
            this.cb_gv.Controls.Add(this.lb_madt);
            this.cb_gv.Location = new System.Drawing.Point(22, 57);
            this.cb_gv.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gv.Name = "cb_gv";
            this.cb_gv.Padding = new System.Windows.Forms.Padding(4);
            this.cb_gv.Size = new System.Drawing.Size(1020, 335);
            this.cb_gv.TabIndex = 7;
            this.cb_gv.TabStop = false;
            this.cb_gv.Text = "Thông tin đề tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ ĐỀ TÀI NGHIÊN CỨU KHOA HỌC - KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // QLDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_gv);
            this.Controls.Add(this.label1);
            this.Name = "QLDT";
            this.Text = "QLDT";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdt)).EndInit();
            this.cb_gv.ResumeLayout(false);
            this.cb_gv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dsdt;
        private System.Windows.Forms.ComboBox cb_gvhd;
        private System.Windows.Forms.ComboBox cb_namTH;
        private System.Windows.Forms.ComboBox cb_maNhom;
        private System.Windows.Forms.ComboBox cb_linhvuc;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.TextBox txt_tendt;
        private System.Windows.Forms.TextBox txt_madt;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lb_namTH;
        private System.Windows.Forms.Label lb_man;
        private System.Windows.Forms.Label lb_gv;
        private System.Windows.Forms.Label lb_diem;
        private System.Windows.Forms.Label lb_linhvuc;
        private System.Windows.Forms.Label lb_tendt;
        private System.Windows.Forms.Label lb_madt;
        private System.Windows.Forms.GroupBox cb_gv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNamTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiem;
    }
}