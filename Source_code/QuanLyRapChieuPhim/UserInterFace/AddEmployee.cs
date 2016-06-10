using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyRapChieuPhim.Model;
using QuanLyRapChieuPhim.Controller;
using System.Security.Cryptography;

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
            int gender = (int)this.slbGender.SelectedIndex;
            string address = this.txtAddress.Text;
            string email = this.txtEmail.Text;
            int level = (int)this.slbLevel.SelectedIndex;
            string empty = "";
            if (userName.Equals(empty) || passwd.Equals(empty) || fullName.Equals(empty) || address.Equals(empty) || email.Equals(empty))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loginController loginController = new loginController();
                MD5 md5Hash = MD5.Create();
                string strPasswordHash = loginController.GetMd5Hash(md5Hash, passwd);
                
                nhanvien.username = userName;
                nhanvien.passwd = strPasswordHash;
                nhanvien.fullname = fullName;
                nhanvien.positionID = level;
                nhanvien.birthday = birthDay;
                nhanvien.gender = gender;
                nhanvien.address = address;
                nhanvien.email = email;

                CdbEmployee employee = new CdbEmployee();
                string strQuery;
                employee.addEmployee(nhanvien,out strQuery);
                MessageBox.Show(strQuery, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet1.chucvu' table. You can move, or remove it, as needed.
            this.chucvuTableAdapter.Fill(this.dataDataSet1.chucvu);

        }
    }
}
