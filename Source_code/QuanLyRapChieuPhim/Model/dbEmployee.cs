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
			string strQuery = "Select * from NhanVien nv where nv.StringID = " + strID;
			//string strQuery = "Select * from NhanVien";

			/* Tạo data lưu thông tin sau khi truy vấn */
			DataSet dbDataSet = new DataSet();

			/* Thực hiện truy vấn */
			dbAccess(strQuery, "NhanVien", out dbDataSet);

			/* Xử lý thông tin lấy từ database */
			/* Lấy thông tin tên của nhân viên */
			//DataColumnCollection drc = dbDataSet.Tables["NhanVien"].Columns;
			//int i = 0;

			DataRowCollection dra = dbDataSet.Tables["NhanVien"].Rows;
			DataRow dr = dra[0]; /* 0 là hàng thứ nhất */
			strName = (string) dr[0]; /* Tên nhân viên là cột thứ 5 */

			/* Đóng kết nối database */
			dbAccessConn.Close();
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

		/* ==========================================================
		 *	Function name: 
		 *		getEmployee
		 *	Description:
		 *		Lấy toàn bộ thông tin tên nhân viên
		 *	Parameter:
		 *		[Input]
		 *			None.
		 *		[Output]
		 *			NhanVien[] NhanVien_t: Thông tin toàn bộ nhân viên
		 *	Note:
		 *		None.
		 *	History:
		 *		2016/05/21	SonDTT		Khởi tạo
		 * ========================================================== */
		public void getEmployee(out NhanVien []tNhanVien)
		{
			/* Truy cập database */
			dbAccessConn.Open();

			/* Tạo câu truy vấn */
			string strQuery = "Select * from NhanVien";

			/* Tạo data lưu thông tin sau khi truy vấn */
			DataSet dbDataSet = new DataSet();

			/* Thực hiện truy vấn */
			dbAccess(strQuery, "NhanVien", out dbDataSet);

			/* Xử lý thông tin lấy từ database */
			/* Lấy thông tin tên của nhân viên */
			//DataColumnCollection drc = dbDataSet.Tables["NhanVien"].Columns;
			tNhanVien = new NhanVien[100];
			int i = 0;
			DataRowCollection dra = dbDataSet.Tables["NhanVien"].Rows;
			foreach (DataRow dr in dra)
			{
				tNhanVien[i].strName = (string) dr[0];
				tNhanVien[i].strID = (string)dr[1];
				tNhanVien[i].strName = (string)dr[2];
			}


			
			
			//DataRow dr = dra[0]; /* 0 là hàng thứ nhất */
			//strName = (string)dr[0]; /* Tên nhân viên là cột thứ 5 */

			/* Đóng kết nối database */
			dbAccessConn.Close();
		}
	}
}
