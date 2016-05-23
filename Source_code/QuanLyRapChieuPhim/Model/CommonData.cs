using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyRapChieuPhim.Model
{
	/* ==========================================================
	 *	Class name: 
	 *		CCommonData
	 *	Description:
	 *		Lớp quản lý các data chung cần thiết cho chương trình
	 *	Note:
	 *		None.
	 *	History:
	 *		2016/05/21	SonDTT		Khởi tạo
	 * ========================================================== */
	public sealed class CCommonData
	{
		/* Tạo ra vùng dữ liệu chứa data */
		private static volatile CCommonData instance;
		private static object syncRoot = new Object();

		/* Thông tin người đăng nhập */
		public string strUserName;
		public int nAcessRight;

		/* ==========================================================
		 *	Function name: 
		 *		CCommonData
		 *	Description:
		 *		Hàm khởi tạo của lớp CCommonData
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
		private CCommonData()
		{
			strUserName = null;
			nAcessRight = (int) eACESS_RIGHT.eACESS_DENIED;
		}

		/* =========================================================
		 *	Function name: 
		 *		Instance
		 *	Description:
		 *		Lấy vùng chứa dữ liệu
		 *	Parameter:
		 *		[Input]
		 *			None.
		 *		[Output]
		 *			CCommonData: vùng chưa dữ liệu
		 *	Note:
		 *		None.
		 *	History:
		 *		2016/05/21	SonDTT		Khởi tạo
		 * ========================================================== */
		public static CCommonData Instance()
		{
			if (instance == null)
			{
				lock (syncRoot)
				{
					if (instance == null)
					{
						instance = new CCommonData();
					}
				}
			}
			return instance;
		}
	}
}
