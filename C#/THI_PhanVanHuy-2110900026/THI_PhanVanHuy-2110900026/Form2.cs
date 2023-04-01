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
using System.Data.SqlClient;

namespace THI_PhanVanHuy_2110900026
{
    public partial class Form2 : Form
    {
        SqlConnection sqlConnection;
        DataTable dataTable;

        private void Connect()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\THI_PhanVanHuy-2110900026\THI_PhanVanHuy-2110900026\Database1.mdf;Integrated Security=True";
            sqlConnection.Open();
        }

        private void LoadData()
        {
            string sql;
            sql = "select * from NhanVien";
            SqlDataAdapter sqlDataAdapter= new SqlDataAdapter(sql, sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
        }
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNV = tbMaNV.Text;
            string sql = "delete from NhanVien where MaNV = '" + MaNV + "'";
            RunSQL(sql);
            LoadData();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string ma = tbMaNV.Text;
            string ten = tbTenNV.Text;
            string diaChi = tbAdress.Text;
            string ngaysinh = tbDate.Text;
            string maphong = tbIdRoom.Text;
            string sql = "Insert into NhanVien values" + "('" + ma + "', N'" + ten + "', N'" + diaChi + "', '" + ngaysinh + "', '" + maphong + "' )";
            RunSQL(sql);
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tbMaNV.Text = "";
            tbTenNV.Text = "";
            tbDate.Text = "";
            tbAdress.Text = "";
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaNV.Text = dgv[0, e.RowIndex].Value.ToString();
            tbTenNV.Text = dgv[1, e.RowIndex].Value.ToString();
            tbDate.Text = dgv[2, e.RowIndex].Value.ToString();
            tbIdRoom.Text = dgv[3, e.RowIndex].Value.ToString();
            tbAdress.Text = dgv[3, e.RowIndex].Value.ToString();
        }
    }
}
