using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyRapChieuPhim
{
	/* ==========================================================
	 *	Class name: 
	 *		Program
	 *	Description:
	 *		Lớp xử lý chính của chương trình
	 *	Note:
	 *		None.
	 *	History:
	 *		2016/05/21	SonDTT		Khởi tạo
	 * ========================================================== */
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			/* Gọi hàm điều kiển chính */
			CMainController pMainController = new CMainController();

			/* Khởi động chương trình */
			pMainController.StartProgram();
		}
	}
}