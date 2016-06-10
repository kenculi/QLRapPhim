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
		}
	}
}
