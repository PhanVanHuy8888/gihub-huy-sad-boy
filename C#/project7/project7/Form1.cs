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

namespace project7
{
    public partial class Form1 : Form
    {   
        SqlConnection sqlConnection;
        DataTable dataTable;

        private void Connect()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\project7\project7\Database1.mdf;Integrated Security=True";
            sqlConnection.Open();
        }
        private void LoadData()
        {
            string sql;
            sql = "select * from KhachHang";
            SqlDataAdapter sqlDataAdapter= new SqlDataAdapter(sql, sqlConnection);
            dataTable= new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
            
        }
        public Form1()
        {
            InitializeComponent();
            Connect();
            LoadData();
        }

        private void RunSQL(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.CommandText = sql; 
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhach.Text = dgv[0,e.RowIndex].Value.ToString();
            txtTenKhach.Text = dgv[1,e.RowIndex].Value.ToString();
            txtDiaChi.Text = dgv[2,e.RowIndex].Value.ToString();
            txtDienThoai.Text = dgv[3,e.RowIndex].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhach.Text;
            string ten = txtTenKhach.Text;
            string diaChi = txtDiaChi.Text;
            string dienThoai = txtDienThoai.Text;
            string sql = "Insert into KhachHang values" + "('" + ma + "', N'" + ten + "', N'" + diaChi + "', '" + dienThoai + "')";
            RunSQL(sql);
            LoadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from KhachHang where MaKH = '" + txtMaKhach.Text + "' ";
            RunSQL(sql);
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update KhachHang set TenKH = N'" + txtTenKhach.Text + "', diaChi = N'" + txtDiaChi.Text + "', dienThoai = '" + txtDienThoai.Text + "' ";
            RunSQL(sql);
            LoadData();
        }
    }
}
