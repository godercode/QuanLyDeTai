using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyDeTai
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void quảnLýSinhViênThamGiaNghiênCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSV qlsv = new QLSV();
            qlsv.Show();
            this.Hide();
        }

        private void quảnLýGiảngViênHướngDấnNghiênCứuKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 QLGV = new Form1();
            QLGV.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNhómSinhViênThamGiaNghiênCứuKhoaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNHOM qLNHOM = new QLNHOM();
            qLNHOM.Show();
            this.Hide();
        }

        private void quảnLýĐềTàiNCKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDT qLDT = new QLDT();
            qLDT.Show();
            this.Hide();
        }

        private void quảnLýLĩnhVựcNghiênCứuKhoaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLLV qLLV = new QLLV();
            qLLV.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TrangChu tc = new TrangChu();
            tc.TopLevel = false;
            panel1.Controls.Add(tc);
            tc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tc.Dock = DockStyle.Fill;
            tc.Show();
        }
    }
}

