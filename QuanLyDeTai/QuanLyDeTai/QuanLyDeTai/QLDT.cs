using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai
{
    public partial class QLDT : Form
    {
        string connectionString = "Data Source = DESKTOP-U4OPUOM\\SQLEXPRESS;" +
                 "Initial Catalog = QuanLyDeTai;" +
                "Integrated Security = True";
        ErrorProvider errorProvider = new ErrorProvider();

        private DataView dt = new DataView();
        public QLDT()
        {
            InitializeComponent();                       
            LoadDatatoComboBox();
            LoadtoDataGridView();
            CheckButton();
        }       
        private void txt_madt_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void txt_tendt_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void txt_diem_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }


        private void CheckButton()
        {
            if (string.IsNullOrEmpty(txt_madt.Text)|| string.IsNullOrEmpty(txt_tendt.Text) || string.IsNullOrEmpty(txt_diem.Text)) 
            {                                  
                    btn_them.Enabled = false;
                    btn_sua.Enabled = false;
                    btn_xoa.Enabled = false;                                
            }
            else
            {
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
            }
        }

        private void LoadtoDataGridView(string filter = "")
        {
            try
            {
                string querySelect = "Select_tblDeTai";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = querySelect;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable QLDT = new DataTable();
                            adapter.Fill(QLDT);
                            if (QLDT.Rows.Count > 0)
                            {
                                dt = QLDT.DefaultView;
                                if (filter != null)
                                {
                                    dt.RowFilter = filter;
                                }
                                dgv_dsdt.AutoGenerateColumns = false;
                                dgv_dsdt.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No records existence!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadDatatoComboBox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadtoDataGridView();
                using (SqlCommand sqlCommand = new SqlCommand("select sMaLV,sTenLV from tblLinhVuc", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_linhvuc.ValueMember = "sMaLV";
                        cb_linhvuc.DisplayMember = "sTenLV";
                        cb_linhvuc.DataSource = dt;
                        cb_linhvuc.Text = string.Empty;
                    }

                }

                using (SqlCommand sqlCommand = new SqlCommand("select sMaGV, sTenGV from tblGiangVien", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cb_gvhd.ValueMember = "sMaGV";
                        cb_gvhd.DisplayMember = "sTenGV";
                        cb_gvhd.DataSource = dt;
                        cb_gvhd.Text = string.Empty;
                    }

                }

                using (SqlCommand sqlCommand = new SqlCommand("Select sMaN from tblNhom", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_maNhom.ValueMember = "sMaN";
                        cb_maNhom.DataSource = dt;
                        cb_maNhom.Text = string.Empty;
                    }

                }

                //pr_nhomchuaTH
                using (SqlCommand sqlCommand = new SqlCommand("select sNamTH from tblDeTai group by sNamTH", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_namTH.ValueMember = "sNamTH";
                        cb_namTH.DataSource = dt;
                        cb_namTH.Text = string.Empty;
                    }

                }

            }

        }

     
        private void btn_them_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    string iMaDT = txt_madt.Text;

                    {
                        sqlCommand.CommandText = "sp_tenDTtheoKhoa";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@madt", iMaDT);
                        sqlConnection.Open();
                        var tmp = sqlCommand.ExecuteScalar();
                        sqlConnection.Close();

                        if (tmp == null)
                        {
                            sqlCommand.Parameters.Clear();
                            sqlCommand.CommandText = "Insert_tblDeTai";
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            sqlCommand.Parameters.AddWithValue("@sMaDT", txt_madt.Text);
                            sqlCommand.Parameters.AddWithValue("@sTenDT", txt_tendt.Text);
                            sqlCommand.Parameters.AddWithValue("@sMaLV", cb_linhvuc.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@sMaGV", cb_gvhd.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@sNamTH", cb_namTH.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@sMaN", cb_maNhom.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@sDiem", txt_diem.Text);
                            sqlConnection.Open();
                            int row_af = sqlCommand.ExecuteNonQuery();
                            if (row_af > 0)
                            {
                                MessageBox.Show("Thêm thành công!");
                                LoadDatatoComboBox();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã đề tài " + iMaDT + " đã tồn tại!");
                        }
                    }

                    LoadDatatoComboBox();
                }
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            txt_madt.Text = "";
            txt_tendt.Text = "";
            cb_linhvuc.Text = "";
            cb_gvhd.Text = "";
            cb_maNhom.Text = "";
            cb_namTH.Text = "";
            txt_diem.Text = "";

            txt_madt.Focus();
            LoadtoDataGridView();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            {
                DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    // Application.Exit();
                    var home = new Form2();
                    home.Show();
                    Close();
                }
            
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaDT IS NOT NULL";
            if (txt_madt.Text != null)
            {
                filter += string.Format(" AND sMaDT LIKE '%{0}%'", txt_madt.Text);
            }
            else if (!string.IsNullOrEmpty(txt_tendt.Text))
            {
                filter += string.Format(" AND sTenDT LIKE '%{0}%'", txt_tendt.Text);
            }
            else if (!string.IsNullOrEmpty(cb_linhvuc.Text))
            {
                filter += string.Format(" AND sTenLV LIKE '%{0}%'", cb_linhvuc.Text);
            }
            else if (!string.IsNullOrEmpty(cb_gvhd.Text))
            {
                filter += string.Format(" AND sTenGV LIKE '%{0}%'", cb_gvhd.Text);
            }
            else if (!string.IsNullOrEmpty(cb_maNhom.Text))
            {
                filter += string.Format(" AND sMaN LIKE '%{0}%'", cb_maNhom.Text);
            }
            else if (!string.IsNullOrEmpty(cb_namTH.Text))
            {
                filter += string.Format(" AND sNamTH LIKE '%{0}%'", cb_namTH.Text);
            }
            else if (!string.IsNullOrEmpty(txt_diem.Text))
            {
                float diem = Convert.ToInt32(txt_diem.Text);
                filter += string.Format(" AND sDiem = {0}", diem);
            }
            else
            {
                MessageBox.Show("Không tìm thấy !");
            }
            MessageBox.Show("Đã tìm thấy <3");
            LoadtoDataGridView(filter);
        }
        private void KiemTraRangBuoc_KhoaNgoai1(string manhom)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "FK_tblSinhVien";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@sMaN", manhom);
                    sqlConnection.Open();
                    bool existed = (sqlCommand.ExecuteScalar() != null);
                    sqlConnection.Close();
                    if (existed)
                    {
                        throw new Exception("Đề tài đang được nghiên cứu ");
                    }
                }
            }
        }
        private void KiemTraRangBuoc_KhoaNgoai(string magv)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "FK_tblGiangVien";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@sMaGV", magv);
                    sqlConnection.Open();
                    bool existed = (sqlCommand.ExecuteScalar() != null);
                    sqlConnection.Close();
                    if (existed)
                    {
                        throw new Exception("Đề tài đang được nghiên cứu");
                    }
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string magv= cb_gvhd.SelectedValue.ToString();
                string manhom = cb_maNhom.SelectedValue.ToString();
                KiemTraRangBuoc_KhoaNgoai(magv);
                KiemTraRangBuoc_KhoaNgoai1(manhom);
                if (MessageBox.Show("Bạn muốn xóa chứ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(
                            "Delete from tblDeTai where sMaDT = @sMaDT"
                            , con))
                        {

                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@sMaDT", txt_madt.Text);

                            con.Open();
                            int row_af = command.ExecuteNonQuery();
                            if (row_af > 0)
                            {
                                MessageBox.Show("Xóa thành công!");
                            }
                        }

                    }
                    LoadtoDataGridView();
                }
            }
            catch(Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("FK_tblSinhVienVien_tblDeTai"))
                {
                    MessageBox.Show("Đề tài đâng được nghiên cứu");
                }//if else () { }....Nêú có nhiều lỗi
                else
                {
                    MessageBox.Show(strError);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_madt.Text == null)
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Update_tblDeTai", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@sMaDT", txt_madt.Text);
                        sqlCommand.Parameters.AddWithValue("@sTenDT", txt_tendt.Text);
                        sqlCommand.Parameters.AddWithValue("@sMaLV", cb_linhvuc.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@sMaGV", cb_gvhd.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@sNamTH", cb_namTH.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@sMaN", cb_maNhom.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@sDiem", float.Parse(txt_diem.Text));

                        int row = sqlCommand.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            txt_madt.Text = "";
                            txt_tendt.Text = "";
                            cb_linhvuc.Text = "";
                            cb_gvhd.Text = "";
                            cb_maNhom.Text = "";
                            cb_gv.Text = "";
                            txt_diem.Text = "";
                            LoadtoDataGridView();
                        }
                    }
                    sqlConnection.Close();
                }
            }
        }   
        private void dgv_dsdt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_dsdt.CurrentRow.Index;
            txt_madt.Text = dgv_dsdt.Rows[index].Cells["sMaDT"].Value.ToString();
            txt_tendt.Text = dgv_dsdt.Rows[index].Cells["sTenDT"].Value.ToString();
            cb_linhvuc.Text = dgv_dsdt.Rows[index].Cells["sMaLV"].Value.ToString();
            cb_gvhd.Text = dgv_dsdt.Rows[index].Cells["sMaGV"].Value.ToString();
            cb_maNhom.Text = dgv_dsdt.Rows[index].Cells["sMaN"].Value.ToString();
            cb_namTH.Text = dgv_dsdt.Rows[index].Cells["sNamTH"].Value.ToString();
            txt_diem.Text = dgv_dsdt.Rows[index].Cells["sDiem"].Value.ToString();
        }

        private void txt_madt_Validating(object sender, CancelEventArgs e)
        {
            string madt = txt_madt.Text;
            if (string.IsNullOrEmpty(madt))
            {
                e.Cancel = true;
                errorProvider.SetError(txt_madt, "Mã đề tài chưa được nhập");
            }
            else
            {
                string pattern = @"^DT\d{3}$"; // Biểu thức chính quy kiểm tra chuỗi nhập vào
                if (!Regex.IsMatch(madt, pattern))
                {
                    e.Cancel = true;
                    //tb_magv.Focus();
                    errorProvider.SetError(txt_madt, "Mã Đề tài không hợp lệ, vui lòng nhập lại theo định dạng DTxxx!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txt_madt, null);
                }
            }
        }

        private void txt_tendt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tendt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txt_tendt, "Tên đề tài chưa được nhập");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_tendt, null);
            }
        }

        private void txt_diem_Validating(object sender, CancelEventArgs e)
        {
            string diem = txt_diem.Text;
            if (string.IsNullOrEmpty(diem))
            {
                e.Cancel = true;
                errorProvider.SetError(txt_diem, "Điểm chưa được nhập");
            }
            else
            {
                string pattern = @"^\d{2}$"; // Biểu thức chính quy kiểm tra chuỗi nhập vào
                if (!Regex.IsMatch(diem, pattern))
                {
                    e.Cancel = true;
                    //tb_magv.Focus();
                    errorProvider.SetError(txt_diem, "Điểm nhập vào phải là số có 2 chữ số");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txt_diem, null);
                }
            }           
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            InBaoCao inBaoCao = new InBaoCao();
            inBaoCao.Show();
            inBaoCao.ShowBaoCao("Select_TongHop3", "QLDT");
        }
    }
}
