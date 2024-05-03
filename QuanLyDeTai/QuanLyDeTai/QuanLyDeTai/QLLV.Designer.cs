namespace QuanLyDeTai
{
    partial class QLLV
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
            this.dgv_nhomSV = new System.Windows.Forms.DataGridView();
            this.sMaLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_malv = new System.Windows.Forms.TextBox();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.tb_tenlv = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhomSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_nhomSV);
            this.groupBox2.Location = new System.Drawing.Point(563, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(448, 402);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhóm ";
            // 
            // dgv_nhomSV
            // 
            this.dgv_nhomSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhomSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhomSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaLV,
            this.sTenLV});
            this.dgv_nhomSV.Location = new System.Drawing.Point(24, 23);
            this.dgv_nhomSV.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_nhomSV.Name = "dgv_nhomSV";
            this.dgv_nhomSV.RowHeadersWidth = 51;
            this.dgv_nhomSV.Size = new System.Drawing.Size(397, 372);
            this.dgv_nhomSV.TabIndex = 0;
            this.dgv_nhomSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhomSV_CellContentClick);
            // 
            // sMaLV
            // 
            this.sMaLV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sMaLV.DataPropertyName = "sMaLV";
            this.sMaLV.HeaderText = "Mã lĩnh vực";
            this.sMaLV.MinimumWidth = 6;
            this.sMaLV.Name = "sMaLV";
            this.sMaLV.ReadOnly = true;
            this.sMaLV.Width = 104;
            // 
            // sTenLV
            // 
            this.sTenLV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTenLV.DataPropertyName = "sTenLV";
            this.sTenLV.HeaderText = "Tên lĩnh vực";
            this.sTenLV.MinimumWidth = 6;
            this.sTenLV.Name = "sTenLV";
            this.sTenLV.ReadOnly = true;
            this.sTenLV.Width = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_malv);
            this.groupBox1.Controls.Add(this.btn_baocao);
            this.groupBox1.Controls.Add(this.tb_tenlv);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.btn_boqua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(56, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 402);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lĩnh vực nghiên cứu";
            // 
            // tb_malv
            // 
            this.tb_malv.Location = new System.Drawing.Point(177, 46);
            this.tb_malv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_malv.Name = "tb_malv";
            this.tb_malv.Size = new System.Drawing.Size(151, 22);
            this.tb_malv.TabIndex = 12;
            this.tb_malv.TextChanged += new System.EventHandler(this.tb_malv_TextChanged);
            this.tb_malv.Validating += new System.ComponentModel.CancelEventHandler(this.tb_malv_Validating);
            // 
            // btn_baocao
            // 
            this.btn_baocao.Location = new System.Drawing.Point(82, 309);
            this.btn_baocao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(100, 28);
            this.btn_baocao.TabIndex = 11;
            this.btn_baocao.Text = "Báo cáo";
            this.btn_baocao.UseVisualStyleBackColor = true;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // tb_tenlv
            // 
            this.tb_tenlv.Location = new System.Drawing.Point(177, 106);
            this.tb_tenlv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tenlv.Name = "tb_tenlv";
            this.tb_tenlv.Size = new System.Drawing.Size(151, 22);
            this.tb_tenlv.TabIndex = 10;
            this.tb_tenlv.TextChanged += new System.EventHandler(this.tb_tenlv_TextChanged);
            this.tb_tenlv.Validating += new System.ComponentModel.CancelEventHandler(this.tb_tenlv_Validating);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(284, 309);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(284, 174);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(100, 28);
            this.btn_tim.TabIndex = 7;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(284, 241);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(100, 28);
            this.btn_boqua.TabIndex = 6;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(82, 241);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(82, 174);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên lĩnh vực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lĩnh vực";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ LĨNH VỰC NGHIÊN CỨU KHOA HỌC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QLLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QLLV";
            this.Text = "QLLVcs";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhomSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_nhomSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.TextBox tb_tenlv;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_malv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenLV;
    }
}