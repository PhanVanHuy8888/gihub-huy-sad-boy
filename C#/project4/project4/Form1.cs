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
using System.Data;


namespace project4
{
    public partial class Form1 : Form
    {

        SqlConnection sqlConnection;
        DataTable dataTable;


        private void connection()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=HUY\SQLEXPRESS;Initial Catalog=thongTinKhachHang;Integrated Security=True";
            sqlConnection.Open();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
