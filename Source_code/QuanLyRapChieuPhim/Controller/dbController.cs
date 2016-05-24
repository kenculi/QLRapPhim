using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyRapChieuPhim.Model;

namespace QuanLyRapChieuPhim.Class
{
	/* ==========================================================
	 *	Class name: 
	 *		CdbController
	 *	Description:
	 *		Lớp quản lý toàn bộ dữ liệu trong chương trình
	 *	Note:
	 *		None.
	 *	History:
	 *		2016/05/21	SonDTT		Khởi tạo
	 * ========================================================== */
	class CdbController
	{
		public CdbEmployee dbEmployee;

		public CdbController()
		{
			dbEmployee = new CdbEmployee();
		}
	}
}
