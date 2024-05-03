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
    public partial class QLSV : Form
    {
        string gioiTinh;
        private DataView dvsv = new DataView();
        private ErrorProvider errorProvider = new ErrorProvider();
        string connectionString = "Data Source = DESKTOP-U4OPUOM\\SQLEXPRESS;" +
                 "Initial Catalog = QuanLyDeTai;" +
                "Integrated Security = True";
        public QLSV()
        {
            InitializeComponent();
            loadDataToDataGridView();
            LoadToComboBox();
            checkButton();
        }

        private void dgv_dssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_dssv.CurrentRow.Index;
            tb_masv.Text = dvsv[index]["sMaSV"].ToString();            
            tb_tensv.Text = dvsv[index]["sTenSV"].ToString();
            tb_lophc.Text = dvsv[index]["sLopHC"].ToString();
            tb_email.Text = dvsv[index]["sEmail"].ToString();
            tb_sdt.Text = dvsv[index]["sSDT"].ToString();
            cb_manhom.Text = dgv_dssv.Rows[index].Cells["maN"].Value.ToString();
            try
            {
                if ((string)dvsv[index]["sGioiTinh"] == "Nam")
                {
                    rb_nam.Checked = true;
                }
                else
                {
                    rb_nu.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void loadDataToDataGridView(string filter = " ")
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "Select_tblSinhVien";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            using (DataTable tblSinhVien = new DataTable())
                            {
                                adapter.Fill(tblSinhVien);
                                if (tblSinhVien.Rows.Count > 0)
                                {
                                    dvsv = tblSinhVien.DefaultView;
                                    dgv_dssv.AutoGenerateColumns = false;
                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dvsv.RowFilter = filter;
                                    }
                                    dgv_dssv.DataSource = tblSinhVien;
                                }
                                else
                                {
                                    MessageBox.Show("Khong co ban ghi nao");
                                }

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
        private void LoadToComboBox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                loadDataToDataGridView();
                using (SqlCommand sqlCommand = new SqlCommand("select sMaN from tblNhom", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_manhom.ValueMember = "sMaN";
                        // cb_man.DisplayMember = "sTenSV";
                        cb_manhom.DataSource = dt;
                        cb_manhom.Text = string.Empty;
                    }

                }

            }

        }
        private void KiemTraRangBuoc_KhoaNgoai1(string manhom)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "Count_tblSinhVien";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@sMaN", manhom);
                    sqlConnection.Open();
                    int i = (int)sqlCommand.ExecuteScalar();
                    sqlConnection.Close();
                    if (i >= 2)
                    {
                        throw new Exception("Nhóm không được vượt quá 2 thành viên");
                    }
                }
            }
        }
        private void KiemTraRangBuoc_KhoaChinh(string masv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "PK_tblSinhVien";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@sMaSV", masv);
                    connection.Open();
                    int count = (int)sqlCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        throw new Exception("Mã sinh viên đã tồn tại");
                    }
                }

            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (rb_nam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (rb_nu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            try
            {
                string manhom = cb_manhom.SelectedValue.ToString();
                KiemTraRangBuoc_KhoaNgoai1(manhom);
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "Select_tblSinhVien";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            using (DataTable dt_SINHVIEN = new DataTable("tblSinhVien"))
                            {
                                adapter.Fill(dt_SINHVIEN);

                                //dtGIANGVIEN.PrimaryKey = new DataColumn[] { dtGIANGVIEN.Columns["sMaGV"] };
                                dt_SINHVIEN.PrimaryKey = new DataColumn[] { dt_SINHVIEN.Columns["sMaSV"] };
                                DataRow row = dt_SINHVIEN.Rows.Find(tb_masv.Text);
                                row["sMaSV"] = tb_masv.Text;
                                row["sTenSV"] = tb_tensv.Text;
                                row["SGioiTinh"] = gioiTinh;
                                row["sLopHC"] = tb_lophc.Text;
                                row["sEmail"] = tb_email.Text;
                                row["sSDT"] = tb_sdt.Text;
                                row["sMaN"] = cb_manhom.SelectedValue;
                                using (SqlCommandBuilder builder = new SqlCommandBuilder(adapter))
                                {
                                    int rowsAffected = adapter.Update(dt_SINHVIEN);

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Chinh sua thanh cong");
                                        loadDataToDataGridView();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Chinh sua that bai");
                                    }
                                }

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("FK_tblSinhVienVien_tblDeTai"))
                {
                    MessageBox.Show("Nhóm đã vượt quá sớ lượng thành viên");
                }//if else () { }....Nêú có nhiều lỗi
                else
                {
                    MessageBox.Show(strError);
                }
            }

        }
        private void KiemTraRangBuoc_KhoaNgoai(string manhom)
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
                        throw new Exception("Sinh viên đang tham gia nghiên cứu khoa học ");
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_dssv.CurrentRow.Index;
            string masv = dvsv[index]["sMaSV"].ToString();
            try
            {
                string manhom = cb_manhom.SelectedValue.ToString();
                KiemTraRangBuoc_KhoaNgoai(manhom);
                DialogResult dialogResult = MessageBox.Show("Có muốn xóa mã sinh viên: " + masv + " không?", " warning ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = "Select_tblSinhVien";
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                            {
                                using (DataTable tblGiangVien = new DataTable("tblSinhVien"))
                                {
                                    adapter.Fill(tblGiangVien);
                                    using (DataSet dataSet = new DataSet())
                                    {
                                        dataSet.Tables.Add(tblGiangVien);
                                        tblGiangVien.PrimaryKey = new DataColumn[] { tblGiangVien.Columns["sMaSV"] };
                                        DataRow row = tblGiangVien.Rows.Find(masv);
                                        row.Delete();
                                        sqlCommand.CommandText = "Delete_tblSinhVien";
                                        sqlCommand.CommandType = CommandType.StoredProcedure;
                                        sqlCommand.Parameters.Clear();
                                        sqlCommand.Parameters.AddWithValue("@sMaSV", tb_masv.Text);
                                        adapter.DeleteCommand = sqlCommand;
                                        int rowsAffected = adapter.Update(dataSet, "tblSinhVien");
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Xóa thành công");
                                            loadDataToDataGridView();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Xóa thất bại");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("FK_tblSinhVienVien_tblDeTai"))
                {
                    MessageBox.Show("Mã sinh viên đang tham gia nghiên cứu");
                }//if else () { }....Nêú có nhiều lỗi
                else
                {
                    MessageBox.Show(strError);
                }
            }
        }

        private void tb_masv_Validating(object sender, CancelEventArgs e)
        {
            string masv = tb_masv.Text;
            if (string.IsNullOrEmpty(masv))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_masv, "Mã sinh viên chưa được nhập");
            }
            else
            {
                string pattern = @"^\d{2}A\d{8}$"; // Biểu thức chính quy kiểm tra chuỗi nhập vào
                if (!Regex.IsMatch(masv, pattern))
                {
                    e.Cancel = true;
                    tb_masv.Focus();
                    errorProvider.SetError(tb_masv, "Mã sinh viên không hợp lệ, vui lòng nhập lại theo định dạng xxAxxxxxxxx !");

                }
                else
                {
                    /*KiemTraRangBuoc_KhoaChinh(masv);
                    e.Cancel = true;
                    errorProvider.SetError(tb_masv, "Mã sinh viên đã tồn tại");*/                   
                    e.Cancel = false;
                    errorProvider.SetError(tb_masv, null);                   
                }               
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            tb_masv.Text = "";
            tb_tensv.Text = "";
            tb_lophc.Text = "";
            tb_email.Text = "";
            tb_sdt.Text = "";
            cb_manhom.Text = "";
            rb_nam.Checked = false;
            rb_nu.Checked = false;
            loadDataToDataGridView();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaSV IS NOT NULL";
            if (!string.IsNullOrEmpty(tb_masv.Text))
            {
                filter += string.Format(" AND sMaSV LIKE '%{0}%'", tb_masv.Text);

            }
            else if (!string.IsNullOrEmpty(tb_tensv.Text))
            {
                filter += string.Format(" AND sTenSV LIKE '%{0}%'", tb_tensv.Text);

            }
            else if (!string.IsNullOrEmpty(tb_lophc.Text))
            {
                filter += string.Format(" AND sLopHC LIKE '%{0}%'", tb_lophc.Text);

            }
            else if (!string.IsNullOrEmpty(tb_email.Text))
            {
                filter += string.Format(" AND sEmail LIKE '%{0}%'", tb_email.Text);

            }
            else if (!string.IsNullOrEmpty(tb_sdt.Text))
            {
                filter += string.Format(" AND sSDT LIKE '%{0}%'", tb_sdt.Text);

            }
            else if (!string.IsNullOrEmpty(cb_manhom.Text))
            {
                filter += string.Format(" AND sMaNhom LIKE '%{0}%'", cb_manhom.SelectedValue);
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
            loadDataToDataGridView(filter);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (rb_nam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            if (rb_nu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            try
            {
                string manhom = cb_manhom.SelectedValue.ToString();
                string masv = tb_masv.ToString();
                KiemTraRangBuoc_KhoaChinh(masv);
                KiemTraRangBuoc_KhoaNgoai1(manhom);
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "Select_tblSinhVien";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            using (DataTable tblSinhVien = new DataTable("tblSinhVien"))
                            {
                                adapter.Fill(tblSinhVien);
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(tblSinhVien);
                                    DataRow row = tblSinhVien.NewRow();

                                    row["sMaSV"] = tb_masv.Text;
                                    row["sTenSV"] = tb_tensv.Text;
                                    row["sGioitinh"] = gioiTinh;
                                    row["sLopHC"] = tb_lophc.Text;
                                    row["sEmail"] = tb_email.Text;
                                    row["sSDT"] = tb_sdt.Text;
                                    row["sMaN"] = cb_manhom.SelectedValue;
                                    tblSinhVien.Rows.Add(row);

                                    sqlCommand.CommandText = "Insert_tblSinhVien";
                                    sqlCommand.CommandType = CommandType.StoredProcedure;

                                    sqlCommand.Parameters.Clear();
                                    sqlCommand.Parameters.AddWithValue("@sMaSV", tb_masv.Text);
                                    sqlCommand.Parameters.AddWithValue("@sTenSV", tb_tensv.Text);
                                    sqlCommand.Parameters.AddWithValue("@sGioitinh", gioiTinh);
                                    sqlCommand.Parameters.AddWithValue("@sLopHC", tb_lophc.Text);
                                    sqlCommand.Parameters.AddWithValue("@sEmail", tb_email.Text);
                                    sqlCommand.Parameters.AddWithValue("@sSDT", tb_sdt.Text);
                                    sqlCommand.Parameters.AddWithValue("@sMaN", cb_manhom.SelectedValue);

                                    adapter.InsertCommand = sqlCommand;
                                    int rowsAffected = adapter.Update(dataSet, "tblSinhVien");
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Thêm mới thành công");
                                        loadDataToDataGridView();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm mới không thành công");
                                    }
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("FK_tblSinhVienVien_tblDeTai"))
                {
                    MessageBox.Show("Nhóm đã vượt quá sớ lượng thành viên");
                }
                else if (strError.Contains("PK_tblSinhVien"))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại");
                }
                else
                {
                    MessageBox.Show(strError);
                }
            }
        }

        private void tb_lophc_Validating(object sender, CancelEventArgs e)
        {
            string malop = tb_lophc.Text;
            if (string.IsNullOrEmpty(malop))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_lophc, "Lớp hành chính chưa được nhập");
            }
            else
            {
                string pattern = @"^\d{4}A\d{2}$"; // Biểu thức chính quy kiểm tra chuỗi nhập vào
                if (!Regex.IsMatch(malop, pattern))
                {
                    e.Cancel = true;
                    tb_masv.Focus();
                    errorProvider.SetError(tb_masv, "Lớp hành chính không hợp lệ, vui lòng nhập lại theo định dạng xxxxAxx !");
                }
            }
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }

        private void tb_email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_email.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_email, "Chưa nhập email");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_email, null);
            }
        }

        private void tb_sdt_Validating(object sender, CancelEventArgs e)
        {
            string sdt = tb_sdt.Text;
            if (string.IsNullOrEmpty(sdt))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_sdt, "Số điện thoại chưa được nhập");
            }
            else
            {
                int num;
                bool isNum = int.TryParse(sdt, out num);
                if (sdt.Length != 10 || !isNum)
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_sdt, "Nhập sai số điện thoại ");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(tb_sdt, null);
                }
            }
        }

        private void tb_masv_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }
        private void checkButton()
        {
            if (string.IsNullOrEmpty(tb_masv.Text) || string.IsNullOrEmpty(tb_tensv.Text) ||
                string.IsNullOrEmpty(tb_lophc.Text) || string.IsNullOrEmpty(tb_sdt.Text) ||
                string.IsNullOrEmpty(tb_email.Text))
            {
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
            }
            else
            {
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
            }
        }

        private void tb_tensv_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }

        private void tb_lophc_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }

        private void tb_tensv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_tensv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_tensv, "Tên sinh viên chưa được nhập");
                tb_tensv.Focus();
            }
            else
            {
                e.Cancel= false;
                errorProvider.SetError(tb_tensv, null);
            }
        }

        private void btn_inds_Click(object sender, EventArgs e)
        {
            InBaoCao inBaoCao = new InBaoCao();
            inBaoCao.Show();
            inBaoCao.ShowBaoCao("Select_TongHop2", "QLSV");
        }
    }
}
