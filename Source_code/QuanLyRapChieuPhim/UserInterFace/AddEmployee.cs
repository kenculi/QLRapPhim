using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyRapChieuPhim.Model;

namespace QuanLyRapChieuPhim.UserInterFace
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            string userName = this.txtUsername.Text;
            string passwd = this.txtPasswd.Text;
            string fullName = this.txtFullname.Text;
            DateTime birthDay = DateTime.Parse(this.slbBirthday.Text);
            string gender = this.slbGender.Text;
            string address = this.txtAddress.Text;
            string email = this.txtEmail.Text;
            string level = this.slbLevel.Text;
            string empty = "";
            if (userName.Equals(empty) || passwd.Equals(empty) || fullName.Equals(empty) || address.Equals(empty) || email.Equals(empty))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet1.chucvu' table. You can move, or remove it, as needed.
            this.chucvuTableAdapter.Fill(this.dataDataSet1.chucvu);

        }
    }
}
