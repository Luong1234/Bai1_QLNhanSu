using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNhanSu_1
{
    public partial class frmTrangchu : Form
    {
        public frmTrangchu()
        {
            InitializeComponent();
        }
        NhanSu nv = new NhanSu();
        public void HienThi(bool b)
        {
            txtChucVu.Visible = txtDiaChi.Visible = txtGioitinh.Visible = txtHoDem.Visible = txtLuong.Visible = txtmaDV.Visible = txtMaNQL.Visible = txtNgaySinh.Visible = txtSDT.Visible = txtten.Visible = b;
            lblChucvu.Visible = lblDiaChi.Visible = lblGT.Visible = lblHoDem.Visible = lblLuong.Visible = lblMaDV.Visible = lblMaNQL.Visible = lblNamSinh.Visible = lblSDT.Visible = lblTen.Visible = btnLuu.Visible = b;
        }
        public void KhoiTao(string b)
        {
            txtChucVu.Text = txtDiaChi.Text = txtGioitinh.Text = txtHoDem.Text = txtLuong.Text= txtmaDV.Text = txtMaNQL.Text = txtNgaySinh.Text = txtSDT.Text = txtten.Text = txtMaNV.Text = b;
        }
        private void frmTrangchu_Load(object sender, EventArgs e)
        {
            panelHead.Size = new System.Drawing.Size(984, 139);
            panelFooter.Size = new System.Drawing.Size(984, 222);
            pictrangchu.Visible = true;
            HienThi(false);
            dataGridViewDS.DataSource = nv.Show();
        }


        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHead.Size = new System.Drawing.Size(984, 139);
            panelFooter.Size = new System.Drawing.Size(984, 222);
            pictrangchu.Visible = true;
            HienThi(false);
            dataGridViewDS.DataSource = nv.Show();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHead.Size = new System.Drawing.Size(984, 275);
            panelFooter.Size = new System.Drawing.Size(984, 88);
            pictrangchu.Visible = false;
            HienThi(true);

        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dataGridViewDS.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHoDem.Text = dataGridViewDS.Rows[e.RowIndex].Cells[2].Value.ToString();
                //MessageBox.Show(dataGridViewDS.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtten.Text = dataGridViewDS.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNgaySinh.Text = dataGridViewDS.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtGioitinh.Text = dataGridViewDS.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLuong.Text = dataGridViewDS.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDiaChi.Text = dataGridViewDS.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtmaDV.Text = dataGridViewDS.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtChucVu.Text = dataGridViewDS.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtSDT.Text = dataGridViewDS.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtMaNQL.Text = dataGridViewDS.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dataGridViewDS.DataSource = nv.Update(txtMaNV.Text, txtHoDem.Text, txtten.Text, DateTime.Parse(txtNgaySinh.Text), txtGioitinh.Text, int.Parse(txtLuong.Text), txtDiaChi.Text, txtMaNQL.Text, txtmaDV.Text, txtChucVu.Text, int.Parse(txtSDT.Text));
            KhoiTao("");
        }
    }
}
