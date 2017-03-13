using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai4___Tab_Control
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        string conmstring = "Data Source=NHIHO-PC;Initial Catalog=K48;Integrated Security=True";
        string SQL;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Tab Khoa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void LoadDLKhoa()
        {
            cn = new SqlConnection(conmstring);
            SQL = "SELECT * FROM Khoa";
            da = new SqlDataAdapter(SQL, cn);
            ds = new DataSet("Khoa");
            da.Fill(ds, "Khoa");
            dgvKhoa.DataSource = ds;
            dgvKhoa.DataMember = "Khoa";
            cn.Close();
            cn.Dispose();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKhoa.Enabled = false;
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells[0].Value.ToString();
                txtTenKhoa.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void btnTaoMoiKhoa_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtMaKhoa.Focus();
            txtTenKhoa.Clear();
            txtSDT.Clear();
            txtMaKhoa.Enabled = true;
            btnCapNhatKhoa.Enabled = true;
            btnLuuKhoa.Enabled = true;
            btnXoaKhoa.Enabled = false;
        }

        private void btnHienThiKhoa_Click(object sender, EventArgs e)
        {
            LoadDLKhoa();
        }

        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            SQL = "INSERT INTO Khoa VALUES (N'" + txtMaKhoa.Text.ToString() + "',N'" + txtTenKhoa.Text.ToString() + "',N'" + txtSDT.Text.ToString() + "')";
            cn = new SqlConnection(conmstring);
            SqlCommand cmd = new SqlCommand(SQL, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            LoadDLKhoa();
            cn.Close();
            cn.Dispose();
        }

        private void btnCapNhatKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                SQL = "UPDATE Khoa SET TenKhoa = N'" + txtTenKhoa.Text.ToString() + ", SDT = N'" + txtSDT.Text.ToString() + "' WHERE MaKhoa = N'" + txtMaKhoa.Text.ToString() + "')";
                cn = new SqlConnection(conmstring);
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                LoadDLKhoa();
                cn.Close();
                cn.Dispose();
            }
            catch
            {
                MessageBox.Show("Có lỗi", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (k == DialogResult.OK)
            {
                SQL = "DELETE FROM Khoa WHERE MaKhoa = N'" + txtTenKhoa.Text + "'";
                cn = new SqlConnection(conmstring);
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                LoadDLKhoa();
                cn.Close();
                cn.Dispose();
            }
        }

        /// <summary>
        /// Tab Lop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void LoadDLLop()
        {
 
        }
        private void btnHienThiLop_Click(object sender, EventArgs e)
        {
            SQL = "SELECT * FROM Lop";
            dgvLop.DataSource = ds;
            dgvLop.DataMember = "Khoa";
            LoadDLLop();
        }

        private void btnTaoMoiLop_Click(object sender, EventArgs e)
        {
            
            txtKhoa.Clear();
            txtTenLop.Clear();
            btnCapNhatLop.Enabled = true;
            btnLuuLop.Enabled = true;
            btnXoaLop.Enabled = false;
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection(conmstring);
            SQL = "SELECT * FROM Khoa";
            da = new SqlDataAdapter(SQL, cn); //lấy dữ liệu về
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboKhoa.DataSource = dt;//gán dữ liệu nguồn
            cboKhoa.ValueMember = "MaKhoa";//dùng để lọc dữ liệu
            cboKhoa.DisplayMember = "TenKhoa";//gán trường hiển thị trên combobox
            cn.Close();
            cn.Dispose();
        }

        

        






    }
}
