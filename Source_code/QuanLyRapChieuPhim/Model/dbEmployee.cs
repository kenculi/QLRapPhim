using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyRapChieuPhim.Model
{
	/* ==========================================================
	 *	Class name: 
	 *		CdbEmployee
	 *	Description:
	 *		Lớp quản lý thông tin của nhân viên
	 *	Note:
	 *		None.
	 *	History:
	 *		2016/05/21	SonDTT		Khởi tạo
	 * ========================================================== */
	class CdbEmployee: CdbQuery
	{
		/* ==========================================================
		 *	Function name: 
		 *		CdbEmployee
		 *	Description:
		 *		Hàm khởi tạo của lớp CdbEmployee
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
		public CdbEmployee()
		{
			/* Kết nối vào cơ sử dữ liệu */
			dbConnection(strAccessConn);
		}

		/* ==========================================================
		 *	Function name: 
		 *		getEmployeeName
		 *	Description:
		 *		Lấy thông tin tên nhân viên
		 *	Parameter:
		 *		[Input]
		 *			string strID: Mã nhân viên
		 *		[Output]
		 *			string strName: Tên nhân viên
		 *	Note:
		 *		None.
		 *	History:
		 *		2016/05/21	SonDTT		Khởi tạo
		 * ========================================================== */
		public void getEmployeeName(string strID, out string strName)
		{
			/* Truy cập database */
			dbAccessConn.Open();

			/* Tạo câu truy vấn */
			string strQuery = "Select * from table name";

			/* Tạo data lưu thông tin sau khi truy vấn */
			DataSet dbDataSet = new DataSet();

			/* Thực hiện truy vấn */
			dbAccess(strQuery, "table name", out dbDataSet);

			/* Xử lý thông tin lấy từ database */
			/* Lấy thông tin tên của nhân viên */
			strName = null;
		}

		/* ==========================================================
		 *	Function name: 
		 *		setEmployeeName
		 *	Description:
		 *		Sửa thông tin tên nhân viên
		 *	Parameter:
		 *		[Input]
		 *			string strID: Mã nhân viên
		 *			string strName: Tên nhân viên
		 *		[Output]
		 *			None.
		 *	Note:
		 *		None.
		 *	History:
		 *		2016/05/21	SonDTT		Khởi tạo
		 * ========================================================== */
		public void setEmployeeName(string strID, string strName)
		{
			strName = null;
		}
	}
}
