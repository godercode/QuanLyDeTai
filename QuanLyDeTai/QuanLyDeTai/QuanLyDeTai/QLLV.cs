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
    public partial class QLLV : Form
    {
        string connectionString = "Data Source = DESKTOP-U4OPUOM\\SQLEXPRESS;" +
                "Initial Catalog = QuanLyDeTai;" +
               "Integrated Security = True";
        DataView dtv = new DataView();
        ErrorProvider errorProvider = new ErrorProvider();
        public QLLV()
        {
            InitializeComponent();
            LoadToDataGridView();
            CheckButton();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void KiemTraRangBuoc_KhoaChinh(string malv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "PK_tblLinhVuc";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@sMaLV", malv);
                    connection.Open();
                    int count = (int)sqlCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        throw new Exception("Mã lĩnh vực đã tồn tại");
                    }
                }

            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string malv = tb_malv.Text;
                KiemTraRangBuoc_KhoaChinh(malv);
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "Insert_tblLinhVuc";
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.AddWithValue("@sMaLV", tb_malv.Text);
                        sqlCommand.Parameters.AddWithValue("@sTenLV", tb_tenlv.Text);

                        sqlConnection.Open();
                        int row_af = sqlCommand.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Thêm thành công!");
                        }
                    }
                    LoadToDataGridView();
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("PK_tblLinhVuc"))
                {
                    MessageBox.Show("Mã lĩnh vực đã tồn tại");
                }//if else () { }....Nêú có nhiều lỗi
                else
                {
                    MessageBox.Show(strError);
                }
            }
        }

        private void dgv_nhomSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_nhomSV.CurrentRow.Index;
            tb_malv.Text = dgv_nhomSV.Rows[index].Cells["sMaLV"].Value.ToString();
            tb_tenlv.Text = dgv_nhomSV.Rows[index].Cells["sTenLV"].Value.ToString();
        }
        private void LoadToDataGridView(string filter = "")
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string querySelect1 = "Select_tblLinhVuc";
                    using (SqlCommand sqlCommand = new SqlCommand(querySelect1, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = sqlCommand;
                            using (DataTable QLN = new DataTable())
                            {
                                adapter.Fill(QLN);
                                if (QLN.Rows.Count > 0)
                                {
                                    dtv = QLN.DefaultView;
                                    if (filter != null)
                                    {
                                        dtv.RowFilter = filter;
                                    }
                                    dgv_nhomSV.AutoGenerateColumns = false;
                                    dgv_nhomSV.DataSource = dtv;
                                }
                                else
                                {
                                    MessageBox.Show("Khong ton tai ban ghi nao");
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

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string filter = "sMaLV IS NOT NULL";
            if (!string.IsNullOrEmpty(tb_malv.Text))
            {
                filter += string.Format(" AND sMaLV LIKE '%{0}%'", tb_malv.Text);
            }
            else if (!string.IsNullOrEmpty(tb_tenlv.Text))
            {

                filter += string.Format(" AND STenLV = {0}", tb_tenlv.Text);
            }
            else
            {
                MessageBox.Show("Không tìm thấy !");
            }
            MessageBox.Show("Đã tìm thấy <3");
            LoadToDataGridView(filter);
        }
        private void KiemTraRangBuoc_KhoaNgoai(string malv)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "FK_tblLinhVuc";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@sMaLV", malv);
                    sqlConnection.Open();
                    bool existed = (sqlCommand.ExecuteScalar() != null);
                    sqlConnection.Close();
                    if (existed)
                    {
                        throw new Exception("Lĩnh vực đang được nghiên cứu khoa học ");
                    }
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string malv = tb_malv.Text;
                KiemTraRangBuoc_KhoaNgoai(malv);
                if (MessageBox.Show("Bạn muốn xóa chứ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(
                            "Delete from tblLinhVuc where sMaLV = @sMaLV"
                            , con))
                        {

                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@sMaLV", tb_malv.Text);

                            con.Open();
                            int row_af = command.ExecuteNonQuery();
                            if (row_af > 0)
                            {
                                MessageBox.Show("Xóa thành công!");
                            }
                        }

                    }
                    LoadToDataGridView();
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("FK_tblLinhVuc_tblDeTai"))
                {
                    MessageBox.Show("Lĩnh vực đang được nghiên cứu");
                }//if else () { }....Nêú có nhiều lỗi
                else
                {
                    MessageBox.Show(strError);
                }
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            tb_malv.Text = "";
            tb_tenlv.Text = "";

            tb_malv.Focus();
            LoadToDataGridView();
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

        private void tb_malv_Validating(object sender, CancelEventArgs e)
        {
            string malv = tb_malv.Text;
            if (string.IsNullOrEmpty(malv))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_malv, "Mã lĩnh vực chưa được nhập");
            }
            else
            {
                string pattern = @"^LV\d{3}$"; // Biểu thức chính quy kiểm tra chuỗi nhập vào
                if (!Regex.IsMatch(malv, pattern))
                {
                    e.Cancel = true;
                    //tb_magv.Focus();
                    errorProvider.SetError(tb_malv, "Mã Lĩnh vực không hợp lệ, vui lòng nhập lại theo định dạng LVxxx!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(tb_malv, null);
                }
            }
        }

        private void tb_tenlv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_tenlv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_tenlv, "Tên lĩnh vực chưa được nhập");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_tenlv, null);
            }
        }
        private void CheckButton()
        {
            if (string.IsNullOrEmpty(tb_malv.Text) || string.IsNullOrEmpty(tb_tenlv.Text))
            {
                btn_them.Enabled=false;

            }
            else
            {
                btn_them.Enabled=true;
            }
        }

        private void tb_malv_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void tb_tenlv_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {           
            InBaoCao inBaoCao = new InBaoCao();
            inBaoCao.Show();
            inBaoCao.ShowBaoCao("Select_TongHop3", "QLLV");
        }
    }
}
