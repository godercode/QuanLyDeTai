using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyDeTai
{
    public partial class Form1 : Form
    {
        string gioiTinh;
        private DataView dvgv = new DataView();
        private ErrorProvider errorProvider = new ErrorProvider();
        string connectionString = "Data Source = DESKTOP-U4OPUOM\\SQLEXPRESS;" +
                 "Initial Catalog = QuanLyDeTai;" +
                "Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
            loadDataToDataGridView();
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
            checkButton();
        }
        private void loadDataToDataGridView(string filter = " ")
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "Select_tblGiangVien";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            using (DataTable tblGiangVien = new DataTable())
                            {
                                adapter.Fill(tblGiangVien);
                                if (tblGiangVien.Rows.Count > 0)
                                {
                                    dvgv = tblGiangVien.DefaultView;
                                    dgv_dsgv.AutoGenerateColumns = false;
                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dvgv.RowFilter = filter;
                                    }
                                    dgv_dsgv.DataSource = tblGiangVien;
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
        private void KiemTraRangBuoc_KhoaChinh(string magv)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "PK_tblGiangVien";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@sMaGV", magv);
                    connection.Open();
                    int count = (int)sqlCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        
                        throw new Exception("Mã sinh viên đã tồn tại"); 
                    }
                }
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
                string magv = tb_magv.Text;
                KiemTraRangBuoc_KhoaChinh(magv);
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = "Select_tblGiangVien";
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                            {
                                using (DataTable tblGiangVien = new DataTable("tblGiangVien"))
                                {
                                    adapter.Fill(tblGiangVien);
                                    using (DataSet dataSet = new DataSet())
                                    {
                                        dataSet.Tables.Add(tblGiangVien);
                                        DataRow newRow = tblGiangVien.NewRow();

                                        newRow["sMaGV"] = tb_magv.Text;
                                        newRow["sTenGV"] = tb_tengv.Text;
                                        newRow["sGioiTinh"] = gioiTinh;
                                        newRow["sSDT"] = tb_sdt.Text;
                                        newRow["sEmail"] = tb_email.Text;
                                        newRow["sChucVu"] = tb_chucvu.Text;
                                        newRow["sNgaySinh"] = Convert.ToDateTime(mtb_ngaysinh.Text);
                                        tblGiangVien.Rows.Add(newRow);

                                        sqlCommand.CommandText = "Insert_tblGiangVien";
                                        sqlCommand.CommandType = CommandType.StoredProcedure;
                                        sqlCommand.Parameters.Clear();
                                        sqlCommand.Parameters.AddWithValue("@sMaGV", tb_magv.Text);
                                        sqlCommand.Parameters.AddWithValue("@sTenGV", tb_tengv.Text);
                                        sqlCommand.Parameters.AddWithValue("@sGioiTinh", gioiTinh);
                                        sqlCommand.Parameters.AddWithValue("@sSDT", tb_sdt.Text);
                                        sqlCommand.Parameters.AddWithValue("@sEmail", tb_email.Text);
                                        sqlCommand.Parameters.AddWithValue("@sChucVu", tb_chucvu.Text);
                                        sqlCommand.Parameters.AddWithValue("@sNgaySinh", Convert.ToDateTime(mtb_ngaysinh.Text));
                                        adapter.InsertCommand = sqlCommand;
                                        int rowsAffected = adapter.Update(dataSet, "tblGiangVien");

                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Them moi thanh cong");
                                            loadDataToDataGridView();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Them moi that bai");
                                        }
                                    }
                                }
                            }

                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }

            private void dgv_dsgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                int index = dgv_dsgv.CurrentRow.Index;

                tb_magv.Text = dgv_dsgv.Rows[index].Cells["sMaGV"].Value.ToString();               
                tb_tengv.Text = dvgv[index]["sTenGV"].ToString();
                tb_chucvu.Text = dvgv[index]["sChucVu"].ToString();
                tb_email.Text = dvgv[index]["sEmail"].ToString();
                tb_sdt.Text = dvgv[index]["sSDT"].ToString();
                mtb_ngaysinh.Text = dvgv[index]["sNgaySinh"].ToString();
                try
                {
                    if ((string)dvgv[index]["sGioiTinh"] == "Nam")
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

        private void btn_sua_Click(object sender, EventArgs e)
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
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "Select_tblGIANGVIEN";
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            using (DataTable tblGiangVien = new DataTable("tblGiangVien"))
                            {
                                adapter.Fill(tblGiangVien);
                                tblGiangVien.PrimaryKey = new DataColumn[] { tblGiangVien.Columns["sMaGV"] };
                                DataRow newRow = tblGiangVien.Rows.Find(tb_magv.Text);
                                newRow["sMaGV"] = tb_magv.Text;
                                newRow["sTenGV"] = tb_tengv.Text;
                                newRow["sGioiTinh"] = gioiTinh;
                                newRow["sSDT"] = tb_sdt.Text;
                                newRow["sEmail"] = tb_email.Text;
                                newRow["sChucVu"] = tb_chucvu.Text;
                                newRow["sNgaySinh"] = Convert.ToDateTime(mtb_ngaysinh.Text);
                                using (SqlCommandBuilder builder = new SqlCommandBuilder(adapter))
                                {
                                    int rowsAffected = adapter.Update(tblGiangVien);

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
                MessageBox.Show(ex.ToString());
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
                        throw new Exception("Mã giảng viên đang tồn tại trong bảng khác ");
                    }
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_dsgv.CurrentRow.Index;
            string magv = dvgv[index]["sMaGV"].ToString();        
            try
            {
                KiemTraRangBuoc_KhoaNgoai(magv);
                DialogResult dialogResult = MessageBox.Show("Có muốn xóa mã giảng viên: " + magv + " không?", " warning ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = "Select_tblGiangVien";
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                            {
                                using (DataTable tblGiangVien = new DataTable("tblGiangVien"))
                                {
                                    adapter.Fill(tblGiangVien);
                                    using (DataSet dataSet = new DataSet())
                                    {
                                        dataSet.Tables.Add(tblGiangVien);
                                        tblGiangVien.PrimaryKey = new DataColumn[] { tblGiangVien.Columns["sMaGV"] };
                                        DataRow row = tblGiangVien.Rows.Find(magv);
                                        row.Delete();
                                        sqlCommand.CommandText = "Delete_tblGiangVien";
                                        sqlCommand.CommandType = CommandType.StoredProcedure;
                                        sqlCommand.Parameters.Clear();
                                        sqlCommand.Parameters.AddWithValue("@sMaGV", tb_magv.Text);
                                        adapter.DeleteCommand = sqlCommand;
                                        int rowsAffected = adapter.Update(dataSet, "tblGiangVien");
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
            }catch(Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("FK_tblGiangVien_tblDeTai"))
                {
                    MessageBox.Show("Mã sinh viên đã có phát sinh điểm");
                }//if else () { }....Nêú có nhiều lỗi
                else
                {
                    MessageBox.Show(strError);
                }
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            tb_magv.Text = "";
            tb_tengv.Text = "";
            mtb_ngaysinh.Text = "";
            tb_chucvu.Text = "";
            tb_email.Text = "";
            tb_sdt.Text = "";
            rb_nam.Checked= false;
            rb_nu.Checked= false;
            loadDataToDataGridView();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                // Application.Exit();
                var home = new Form2();
                home.Show();
                Close();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaGV IS NOT NULL";
            try 
            {
                if (!string.IsNullOrEmpty(tb_magv.Text))
                {
                    MessageBox.Show("Tìm thấy giảng viên có mã: " +tb_magv.Text);
                    filter += string.Format(" AND sMaGV LIKE '%{0}%'", tb_magv.Text);
                }
                else if(!string.IsNullOrEmpty(tb_tengv.Text))
                {
                    MessageBox.Show("Tìm thấy giảng viên có tên: " + tb_tengv.Text);
                    filter += string.Format(" AND sTenGV LIKE '%{0}%'", tb_tengv.Text);
                }
                else if(!string.IsNullOrEmpty(tb_chucvu.Text))
                {
                    MessageBox.Show("Tìm thấy giảng viên có chức vụ: " + tb_chucvu.Text);
                    filter += string.Format(" AND sChucVu LIKE '%{0}%'", tb_chucvu.Text);
                }
                else if(!string.IsNullOrEmpty(tb_sdt.Text))
                {
                    MessageBox.Show("Tìm thấy giảng viên có số điện thoại: " + tb_sdt.Text);
                    filter += string.Format(" AND sSDT LIKE '%{0}%'", tb_sdt.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi nào ");
                }
                loadDataToDataGridView(filter);
                /*if (!string.IsNullOrEmpty(mtb_ngaysinh.Text))
                {
                    filter += string.Format("AND sNgaySinh LIKE '%{0}%'", Convert.ToDateTime(mtb_ngaysinh.Text));
                }*/               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }

        private void tb_magv_Validating(object sender, CancelEventArgs e)
        {
            string magv = tb_magv.Text;
            if (string.IsNullOrEmpty(magv))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_magv, "Mã Giảng viên không được nhập");
            }
            else
            {
                string pattern = @"^GV\d{2}$"; // Biểu thức chính quy kiểm tra chuỗi nhập vào
                if (!Regex.IsMatch(magv, pattern))
                {
                    e.Cancel = true;
                    //tb_magv.Focus();
                    errorProvider.SetError(tb_magv, "Mã giảng viên không hợp lệ, vui lòng nhập lại theo định dạng GVxx!");
                }
                else
                {  
                                e.Cancel = false;
                                errorProvider.SetError(tb_magv, null);                                                             
                }              
            }

        }
        
        private void tb_tengv_Validating(object sender, CancelEventArgs e)
        {
            string tengv = tb_tengv.Text;
            if (string.IsNullOrEmpty(tengv))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_tengv, "Tên Giảng viên chưa được nhập");
            }
            else
            {
                e.Cancel= false;
                errorProvider.SetError(tb_tengv, null);
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
                if (sdt.Length != 10 || !isNum )
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_sdt, "Nhập sai số điện thoại ");
                }
                else
                {
                    e.Cancel= false;
                    errorProvider.SetError(tb_sdt, null);
                }
            }           
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }

        private void tb_tengv_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }

        private void tb_chucvu_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }

        private void tb_email_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tb_email.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_email, "Chưa nhập email");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_email , null);
            }
        }

        private void tb_email_TextChanged_1(object sender, EventArgs e)
        {
            checkButton();
        }

        private void tb_chucvu_Validating(object sender, CancelEventArgs e)
        {
            string chucvu = tb_chucvu.Text;
            if (string.IsNullOrEmpty(chucvu))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_chucvu, "Chưa nhập chức vụ");
            }
            else 
            {
                if (chucvu == "Phó chủ nhiệm" || chucvu!="Giảng viên")
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_chucvu, "Chức vụ nhập vào không hợp lệ");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(tb_chucvu, null);
                }
            }          
        }

        private void mtb_ngaysinh_Validating(object sender, CancelEventArgs e)
        {
            string ngaysinh = mtb_ngaysinh.Text;
            if(string.IsNullOrEmpty(ngaysinh))
            {
                e.Cancel = true;
                errorProvider.SetError(mtb_ngaysinh, "Chưa nhập ngày sinh");
            }
            else
            {
                DateTime ngaySinh;
                if (!DateTime.TryParseExact(mtb_ngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                {
                    e.Cancel = true;
                    errorProvider.SetError(mtb_ngaysinh, "Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(mtb_ngaysinh, null);
                }
            }
        }

        private void tb_magv_TextChanged(object sender, EventArgs e)
        {
            checkButton();
        }
        private void checkButton()
        {
            if(string.IsNullOrEmpty(tb_magv.Text) || string.IsNullOrEmpty(tb_tengv.Text) || 
                string.IsNullOrEmpty(tb_chucvu.Text) || string.IsNullOrEmpty(tb_sdt.Text) || 
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

        private void btn_inds_Click(object sender, EventArgs e)
        {
            InBaoCao inBaoCao = new InBaoCao();
            inBaoCao.Show();
            inBaoCao.ShowBaoCao("Select_TongHop1","QLGV");
        }
    }
}

