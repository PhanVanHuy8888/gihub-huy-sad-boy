using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtNN.Text;
            lsbNN.Items.Add(ten);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            lsbNN.Items.RemoveAt(lsbNN.SelectedIndex);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // result = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo thoát",MessageBoxButtons.YesNo);
            //if(result == messageBoxResult.yes)
            //{
            //    Application.CurrentCulture.Shutdown();
            //}
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s = txtNN.Text;
            int n = lsbNN.Items.Count;
            int check = 0;
            for(int i = 0; i < n; i++)
            {
                if (String.Compare((string)lsbNN.Items[i], s)==0)
                {
                    check = 1;
                }
            }
                if (check == 0)
                    MessageBox.Show("Không có");
                else
                    MessageBox.Show("Có");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int vt = lsbNN.SelectedIndex;
            lsbNN.Items[vt] = txtNN.Text;
        }

        private void lsbNN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = (string)lsbNN.SelectedItem;
            txtNN.Text = s;
        }
    }
}
