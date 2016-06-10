using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;

namespace QuanLyRapChieuPhim.Model
{
	/* ==========================================================
	 *	Class name: 
	 *		CdbQuery
	 *	Description:
	 *		Lớp cơ sở chứa các phương thức truy cập database
	 *	Note:
	 *		None.
	 *	History:
	 *		2016/05/21	SonDTT		Khởi tạo
	 * ========================================================== */
	class CdbQuery
	{
		protected OleDbConnection dbAccessConn;
		protected string strAccessConn;

		/* ==========================================================
		 *	Function name: 
		 *		CdbQuery
		 *	Description:
		 *		Hàm khởi tạo của lớp CdbQuery
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
		public CdbQuery()
		{
			strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\Data\\data.mdb";
			dbAccessConn = null;
		}

		/* ==========================================================
		 *	Function name: 
		 *		dbConnection
		 *	Description:
		 *		Hàm kết nối database
		 *	Parameter:
		 *		[Input]
		 *			string strAccessConn: Thông tin database sẽ connect
		 *		[Output]
		 *			None.
		 *	Note:
		 *		None.
		 *	History:
		 *		2016/05/21	SonDTT		Khởi tạo
		 * ========================================================== */
		protected void dbConnection(string strAccessConn)
		{
			try
			{
				/* Kết nối đến cơ sở dữ liệu */
				dbAccessConn = new OleDbConnection(strAccessConn);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
				return;
			}
		}

		/* ==========================================================
		 *	Function name: 
		 *		dbAccess
		 *	Description:
		 *		Hàm truy vấn thông tin từ database
		 *	Parameter:
		 *		[Input]
		 *			string strQuery: Nội dung câu truy vấn
		 *			string strTableName: Tên bảng chứa nội dung trả về sau khi truy vấn
		 *		[Output]
		 *			DataSet dbDataSet: Dữ liệu trả về sau khi truy vấn
		 *	Note:
		 *		None.
		 *	History:
		 *		2016/05/21	SonDTT		Khởi tạo
		 * ========================================================== */
		protected void dbAccess(string strQuery, string strTableName, out DataSet dbDataSet)
		{
			/* Initial */
			dbDataSet = new DataSet();

			/* Create the dataset and add the Categories table to it: */
			OleDbCommand dbAccessCommand = new OleDbCommand(strQuery, dbAccessConn);
			OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(dbAccessCommand);

			/* Mở database */
			dbAccessConn.Open();

			/* Lấy thông tin */
			dbDataAdapter.Fill(dbDataSet, strTableName);

			/* Đóng database */
			dbAccessConn.Close();
		}

        protected void dbInsert(string strQuery, NhanVien nhanvien)
        {
            /* Mở database */
            dbAccessConn.Open();
            OleDbCommand dbAccessCommand = new OleDbCommand(strQuery, dbAccessConn);
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(dbAccessCommand);

            //OleDbCommand cmd = new OleDbCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = strQuery;
            ////cmd.CommandText = "INSERT INTO nhanvien (UserName, Password, Hoten, NgaySinh, DiaChi, Email, GioiTinh, MaChucVu) VALUES (@UserName,@Password,@Hoten,@NgaySinh,@DiaChi,@Email,@GioiTinh,@MaChucVu)";
            ////cmd.Parameters.AddWithValue("@Username", nhanvien.username);
            ////cmd.Parameters.AddWithValue("@Password", nhanvien.passwd);
            ////cmd.Parameters.AddWithValue("@Hoten", nhanvien.fullname);
            ////cmd.Parameters.AddWithValue("@NgaySinh", nhanvien.birthday);
            ////cmd.Parameters.AddWithValue("@DiaChi", nhanvien.address);
            ////cmd.Parameters.AddWithValue("@Email", nhanvien.email);
            ////cmd.Parameters.AddWithValue("@GioiTinh", nhanvien.gender);
            ////cmd.Parameters.AddWithValue("@MaChucVu", nhanvien.positionID);
            //cmd.Connection = dbAccessConn;
            ////dbAccessConn.Open();
            //cmd.ExecuteNonQuery();
            /* Đóng database */
            dbAccessConn.Close();
        }
	}
}
