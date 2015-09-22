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

namespace QLNhanSu_Bai1
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            string sql = "select * from tblNhanVien";
            DataTable dt = new DataTable();
            string str = @"Data Source=PHAMVANLUONG\SQLEXPRESS; Initial Catalog=QLCT; Integrated Security=true;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            dataGridViewDS.DataSource = dt;
            con.Close();
        }
    }
}
