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

namespace project6
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        DataTable dataTable;

        private void Connect()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\project6\project6\Database3.mdf;Integrated Security=True";
            sqlConnection.Open();
        }
        private void LoadData()
        {
            string sql;
            sql = "Select *from KhachHang";
            // lấy dữ liệu từ sql lưu vào dataadapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            dataTable = new DataTable();
            //đưa dữ liệu từ DataAdapter vào Datatable
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
            // dối tượng thực hiện lệnh
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.CommandText = sql; // câu lệnh SQL
            sqlCommand.Connection = sqlConnection; // thực hiện ở connecttion nào
            sqlCommand.ExecuteNonQuery(); // thực thi lệnh SQL
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu từ các textbox
            int ma = Convert.ToInt32(txtMaKhach.Text);
            string ten = txtTenKhach.Text;
            int soLuong = Convert.ToInt32(tbSoLuong.Text);
            string sql = "Insert into Hang values" +
                "(" + ma + ", N'" + ten + "', N'" + chatLieu + "'," + soLuong + ")";
            RunSQL(sql);
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txMaHang.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            tbTenHang.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            tbChatLieu.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            tbSoLuong.Text = dataGridView1[3, e.RowIndex].Value.ToString();
        }
    }
}
