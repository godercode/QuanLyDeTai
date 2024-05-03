using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai
{
    public partial class InBaoCao : Form
    {
        string connectionString = "Data Source = DESKTOP-U4OPUOM\\SQLEXPRESS;" +
                "Initial Catalog = QuanLyDeTai;" +
               "Integrated Security = True";
        public InBaoCao()
        {
            InitializeComponent();
        }
        public void ShowBaoCao(string tableName, string fileName)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = tableName;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            ReportDocument reportDocument = new ReportDocument();
                            string path = string.Format("{0}\\BaoCao\\{1}.rpt", Application.StartupPath,fileName);
                            reportDocument.Load(path);
                            reportDocument.Database.Tables[tableName].SetDataSource(dt);
                            reportDocument.SetParameterValue("NguoiLapPhieu", "Phạm Đình Tân");
                            reportDocument.SetParameterValue("Ten", "Tan"); 
                            crystalReportViewer1.ReportSource = reportDocument;
                        }
                    }
                }
            }
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
