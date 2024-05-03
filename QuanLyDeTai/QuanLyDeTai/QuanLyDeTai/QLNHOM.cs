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
    public partial class QLNHOM : Form
    {
        string connectionString = "Data Source = DESKTOP-U4OPUOM\\SQLEXPRESS;" +
                "Initial Catalog = QuanLyDeTai;" +
               "Integrated Security = True";

        DataView dtv = new DataView();
        public QLNHOM()
        {
            InitializeComponent();
            LoadDatatoConboBox();
        }
        private void CheckButton()
        {
            if (string.IsNullOrEmpty(cb_maNhom.Text) || string.IsNullOrEmpty(tb_soSV.Text))
            {
                btn_them.Enabled = false;
                btn_tim.Enabled = false;
            }
            else
            {
                btn_them.Enabled = true;
                btn_tim.Enabled = true;
            }
        }
        private void dgv_nhomSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_nhomSV.CurrentRow.Index;
            cb_maNhom.Text = dgv_nhomSV.Rows[index].Cells["sMaN"].Value.ToString();
            tb_soSV.Text = dgv_nhomSV.Rows[index].Cells["iSoSV"].Value.ToString();
        }
        private void KiemTraRangBuoc_KhoaChinh(string manhom)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "PK_tblNhom";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@sMaN", manhom);
                    connection.Open();
                    int count = (int)sqlCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        throw new Exception("Mã Nhóm đã tồn tại");
                    }
                }

            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string manhom = cb_maNhom.SelectedValue.ToString();
                KiemTraRangBuoc_KhoaChinh(manhom);
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "Insert_tblNhom";
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.AddWithValue("@sMaN", cb_maNhom.Text);
                        sqlCommand.Parameters.AddWithValue("@iSoSV", tb_soSV.Text);

                        sqlConnection.Open();
                        int row_af = sqlCommand.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Thêm thành công!");
                        }
                    }
                    LoadToDataGridView();
                }
            }catch(Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("PK_tblNhom"))
                {
                    MessageBox.Show("Mã nhóm đã tồn tại");
                }//if else () { }....Nêú có nhiều lỗi
                else
                {
                    MessageBox.Show(strError);
                }
            }
        }
        private void LoadDatatoConboBox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadToDataGridView();
                using (SqlCommand sqlCommand = new SqlCommand("select sMaN from tblNhom", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cb_maNhom.ValueMember = "sMaN";
                        cb_maNhom.DisplayMember = "sMaN";
                        cb_maNhom.DataSource = dt;
                        cb_maNhom.Text = string.Empty;
                    }

                }
            }
        }
        private void LoadToDataGridView(string filter = "")
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string querySelect1 = "Select_tblNhom";
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
        private void KiemTraRangBuoc_KhoaNgoai(string manhom)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "FK_tblNHOM";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@sMaN", manhom);
                    sqlConnection.Open();
                    bool existed = (sqlCommand.ExecuteScalar() != null);
                    sqlConnection.Close();
                    if (existed)
                    {
                        throw new Exception("Nhóm đang tham gia nghiên cứu khoa học ");
                    }
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string manhom = cb_maNhom.SelectedValue.ToString();
                KiemTraRangBuoc_KhoaNgoai(manhom);
                if (MessageBox.Show("Bạn muốn xóa chứ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(
                            "Delete from tblNhom where sMaN = @sMaN"
                            , con))
                        {

                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@sMaN", cb_maNhom.Text);

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
            }catch(Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("FK_tblNhom_tblDeTai"))
                {
                    MessageBox.Show("Nhóm đang tham gia nghiên cứu");
                }//if else () { }....Nêú có nhiều lỗi
                else
                {
                    MessageBox.Show(strError);
                }
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            cb_maNhom.Text = "";
            tb_soSV.Text = "";

            cb_maNhom.Focus();
            LoadToDataGridView();
        }

        private void cb_maNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CheckButton();
        }

        private void tb_soSV_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
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

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string filter = "sMaN IS NOT NULL";
            if (!string.IsNullOrEmpty(cb_maNhom.Text))
            {
                filter += string.Format(" AND sMaN LIKE '%{0}%'", cb_maNhom.Text);
            }
            else if (!string.IsNullOrEmpty(tb_soSV.Text))
            {
                int soSV = Convert.ToInt32(tb_soSV.Text);
                filter += string.Format(" AND iSoSV = {0}", soSV);
            }
            else
            {
                MessageBox.Show("Không tìm thấy !");
            }
            MessageBox.Show("Đã tìm thấy <3");
            LoadToDataGridView(filter);
        }

        private void tb_soSV_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            string soSV = tb_soSV.Text;
            if (!string.IsNullOrEmpty(soSV))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_soSV, "Số sinh viên chưa được nhập");
            }
            else
            {
                string pattern = @"^\d{2}$"; // Biểu thức chính quy kiểm tra chuỗi nhập vào
                if (!Regex.IsMatch(soSV, pattern))
                {
                    e.Cancel = true;
                    //tb_magv.Focus();
                    errorProvider.SetError(tb_soSV, "Số sinh viên nhập vào phải là số có 2 chữ số");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(tb_soSV, null);
                }
            }
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            InBaoCao inBaoCao = new InBaoCao();
            inBaoCao.Show();
            inBaoCao.ShowBaoCao("Select_TongHop3", "QLN");
        }
    }
}
