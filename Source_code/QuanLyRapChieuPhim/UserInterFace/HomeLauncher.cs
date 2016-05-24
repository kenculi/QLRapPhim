using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
	/* ==========================================================
	 *	Class name: 
	 *		CHomeLauncher
	 *	Description:
	 *		Lớp xử lý giao diện màn hình chính
	 *	Note:
	 *		None.
	 *	History:
	 *		2016/05/21	SonDTT		Khởi tạo
	 * ========================================================== */
	public partial class CHomeLauncher : Form
	{
		/* ==========================================================
		 *	Function name: 
		 *		CHomeLauncher
		 *	Description:
		 *		Hàm khởi tạo của lớp CHomeLauncher
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
		public CHomeLauncher()
		{
			InitializeComponent();
            CUserAuthentication frmUserAuth = new CUserAuthentication();
            frmUserAuth.Close();
			/* Canh vị trí vào giữa màn hình */
			this.CenterToScreen();
            //this.WindowState = FormWindowState.Maximized;
		}

        private void CHomeLauncher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.lichchieu' table. You can move, or remove it, as needed.
            this.lichchieuTableAdapter.Fill(this.dataDataSet.lichchieu);
            // TODO: This line of code loads data into the 'dataDataSet.phim' table. You can move, or remove it, as needed.
            this.phimTableAdapter.Fill(this.dataDataSet.phim);
            // TODO: This line of code loads data into the 'dataDataSet.phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dataDataSet.phong);
            // TODO: This line of code loads data into the 'dataDataSet.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.dataDataSet.nhanvien);

        }
	}
}
