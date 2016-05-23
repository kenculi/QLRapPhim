using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyRapChieuPhim;
using QuanLyRapChieuPhim.Controller;
using QuanLyRapChieuPhim.Class;
using QuanLyRapChieuPhim.Model;
using System.Security.Cryptography;

namespace QuanLyRapChieuPhim.Controller
{
	/* ==========================================================
	 *	Class name: 
	 *		loginController
	 *	Description:
	 *		Lớp xử lý cho màn hình đăng nhập
	 *	Note:
	 *		None.
	 *	History:
	 *		2016/05/23	SonDTT		Khởi tạo
	 * ========================================================== */
	class loginController
	{
		/* ==========================================================
		 *	Function name: 
		 *		Login
		 *	Description:
		 *		Hàm đăng nhập
		 *	Parameter:
		 *		[Input]
		 *			string strUserName: tên đăng nhập.
		 *			string strPassword: mật khẩu.
		 *		[Output]
		 *			None.
		 *	Return:
		 *		int: mã lổi đăng nhập thành công hoặc không
		 *	Note:
		 *		None.
		 *	History:
		 *		2016/05/23	SonDTT		Khởi tạo
		 * ========================================================== */
		public int Login(string strUserName, string strPassword)
		{
			/* Tạo mã lổi */
			int nError = (int)eLOGIN_ERROR.eERROR_NOK;
			int nAccessRight = (int)eACESS_RIGHT.eACESS_DENIED;

			/* Tạo controller của database */
			CdbController dbController = new CdbController();

			/* Tạo phương thức mã hóa MD5 */
			MD5 md5Hash = MD5.Create();

			/* Mã hóa password */
			string strPasswordHash = GetMd5Hash(md5Hash, strPassword);

			/* Kiểm tra tên đăng nhập và mật khẩu */
			//dbController.dbEmployee.CheckUserLogin(strUserName, strPasswordHash, out nAccessRight)

			/* Nếu có quyền đăng nhập */
			if (nAccessRight != (int)eACESS_RIGHT.eACESS_DENIED)
			{
				/* Đăng nhập thành công */
				nError = (int)eLOGIN_ERROR.eERROR_OK;

				/* Lấy vùng dữ liệu common data */
				CCommonData CommonData = CCommonData.Instance();

				/* Lưu thông tin người đăng nhập vào Common data */
				CommonData.strUserName = strUserName;
				CommonData.nAcessRight = nAccessRight;
			}

			/* Trả về mã lỗi */
			return nError;
		}

		/* ==========================================================
		 *	Function name: 
		 *		GetMd5Hash
		 *	Description:
		 *		Hàm mã hóa MD5
		 *	Parameter:
		 *		[Input]
		 *			MD5 md5Hash: phương thức mã hóa.
		 *			string input: chuỗi cần mã hóa.
		 *		[Output]
		 *			None.
		 *	Return:
		 *		string: chuỗi đã mã hóa
		 *	Note:
		 *		None.
		 *	History:
		 *		2016/05/23	SonDTT		Khởi tạo
		 * ========================================================== */
		string GetMd5Hash(MD5 md5Hash, string input)
		{

			// Convert the input string to a byte array and compute the hash.
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

			// Create a new Stringbuilder to collect the bytes
			// and create a string.
			StringBuilder sBuilder = new StringBuilder();

			// Loop through each byte of the hashed data 
			// and format each one as a hexadecimal string.
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			// Return the hexadecimal string.
			return sBuilder.ToString();
		}
	}
}
