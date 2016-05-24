using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
	/* ==========================================================
	 *	Class name: 
	 *		CMainController
	 *	Description:
	 *		Lớp xử lý chính của trương trình
	 *	Note:
	 *		None.
	 *	History:
	 *		2016/05/21	SonDTT		Khởi tạo
	 * ========================================================== */
	class CMainController
	{
		private CHomeLauncher frmHomeLauncher;
		private CUserAuthentication frmUserAuthentication;

		/* ==========================================================
		 *	Function name: 
		 *		CMainController
		 *	Description:
		 *		Hàm khởi tạo của lớp CMainController
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
		public CMainController()
		{
			frmHomeLauncher = new CHomeLauncher();
			frmUserAuthentication = new CUserAuthentication();
		}

		/* ==========================================================
		 *	Function name: 
		 *		StartProgram
		 *	Description:
		 *		Hàm khởi khởi động chương trình
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
		public void StartProgram()
		{
			/* Hiển thị màn hình đăng nhập */
			frmUserAuthentication.ShowDialog();

			while (true)
			{
				/* Khi màn hình đăng nhập đóng thì hiển thị màn hình chính */
				if (frmUserAuthentication.Visible == false)
				{
					break;
				}
			}

			/* Hiển thị màn hình chính */
			frmHomeLauncher.ShowDialog();
		}
	}
}
