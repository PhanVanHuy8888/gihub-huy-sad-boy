using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }    

        private void btnYes_Click(object sender, EventArgs e)
        {
            

        }

        private void lsbMH_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lsbHDM_DoubleClick(object sender, EventArgs e)
        {
            string s = (string)lsbHDM.SelectedItem;
            //int c
        }

        private void btnYes_Click_1(object sender, EventArgs e)
        {
            string hoTen, DT;
            hoTen = txtHoTen.Text;
            DT = txtDT.Text;
            if (hoTen.Length == 0)
            {
                MessageBox.Show("Bạn chưa điền họ tên");
            }
            else if (DT.Length == 0)
            {
                MessageBox.Show("Bạn chưa điền số điện thoại");
            }
            else if (hoTen.Length == 0 || DT.Length == 0)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
            }
        }

        private void lsbListMH_DoubleClick(object sender, EventArgs e)
        {
            string s = (string)lsbListMH.SelectedItem;
            int check = 0;
            for (int i = 0; i < lsbHDM.Items.Count; i++)
            {
                if (String.Compare((string)lsbHDM.Items[i], s) == 0)
                {
                    check = 1;
                }
            }
            if (check == 0)
            {
                lsbHDM.Items.Add(s);
            }
            else
            {
                MessageBox.Show("Môn học đã được đăng ký");
            }
            lsbListMH.Items.Add(s);
        }
    }
}
