using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyRapChieuPhim.Controller;

namespace QuanLyRapChieuPhim
{
    /* ==========================================================
     *	Class name: 
     *		CUserAuthentication
     *	Description:
     *		Lớp xử lý chính của chương trình
     *	Note:
     *		None.
     *	History:
     *		2016/05/21	SonDTT		Khởi tạo
     * ========================================================== */
    public partial class CUserAuthentication : Form
    {
        /* ==========================================================
         *	Function name: 
         *		CUserAuthentication
         *	Description:
         *		Hàm khởi tạo của lớp CUserAuthentication
         *	Parameter:
         *		[Input]
         *			None.
         *		[Output]
         *			None.
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	SonDTT		Khởi tạo
         * ========================================================== */
        public CUserAuthentication()
        {
            InitializeComponent();
        }

        private void CUserAuthentication_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CHomeLauncher frmHomeLauncher = new CHomeLauncher();
            loginController loginController = new loginController();
            int errCode = loginController.Login(this.txtUsername.Text, this.txtPasswd.Text);
            if (errCode == 1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thành công");
                this.Close(); this.Dispose();
                frmHomeLauncher.ShowDialog();
            }
            else
                MessageBox.Show("Sai thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.txtUsername.Focus();
        }
    }
}