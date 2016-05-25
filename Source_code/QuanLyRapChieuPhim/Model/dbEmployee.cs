using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyRapChieuPhim;

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
    class CdbEmployee : CdbQuery
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
         *		addEmployee
         *	Description:
         *		Thêm thông tin một nhân viên
         *	Parameter:
         *		[Input]
         *		    NhanVien tNhanVien
         *		[Output]
         *			None.
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public void addEmployee(NhanVien tNhanVien)
        {
            DataSet dbDataSet;
            string strQuery = "INSERT INTO nhanvien VALUES("+tNhanVien.employeeID+","+tNhanVien.username+","+tNhanVien.passwd+","+tNhanVien.fullname+","+tNhanVien.birthday+","+tNhanVien.address+","+tNhanVien.email+","+tNhanVien.gender+","+tNhanVien.positionID+")";
            dbAccess(strQuery, "nhanvien",out dbDataSet);
        }

        /* ==========================================================
         *	Function name: 
         *		getallEmployee
         *	Description:
         *		Lấy toàn bộ thông tin nhân viên
         *	Parameter:
         *		[Input]
         *			string condition : Mệnh đề where
         *		[Output]
         *			NhanVien[] tNhanVien: Thông tin toàn bộ nhân viên
         *			i : Số lượng nhân viên
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	SonDTT		Khởi tạo
         * ========================================================== */
        public void getallEmployee(string condition, out NhanVien[] tNhanVien, int i)
        {
            /* Tạo câu truy vấn */
            string strQuery = "Select * from nhanvien l,chucvu c where l.MaChucVu = c.MaChucVu" + condition;

            /* Tạo data lưu thông tin sau khi truy vấn */
            DataSet dbDataSet;

            /* Thực hiện truy vấn */
            dbAccess(strQuery, "nhanvien", out dbDataSet);

            /* Xử lý thông tin lấy từ database */
            tNhanVien = new NhanVien[100];
            i = 0;
            DataRowCollection dra = dbDataSet.Tables["nhanvien"].Rows;
            foreach (DataRow dr in dra)
            {
                tNhanVien[i].employeeID = (int)dr[0];
                tNhanVien[i].username = (string)dr[1];
                tNhanVien[i].passwd = (string)dr[2];
                tNhanVien[i].fullname = (string)dr[3];
				tNhanVien[i].birthday = (DateTime)dr[4];
                tNhanVien[i].address = (string)dr[5];
                tNhanVien[i].email = (string)dr[6];
                tNhanVien[i].gender = (int)dr[7];
                tNhanVien[i].positionID = (int)dr[8];//cột 9 là cột ma~ chức vụ sau khi kết bảng
                tNhanVien[i].position = (string)dr[10];//cột 11 là cột chức vụ sau khi kết bảng
                i++;
            }
        }

        public void checkUserLogin(string strUserName, string strPasswordHash, out int nError, out int nAccessRight)
        {
            nError = (int)eLOGIN_ERROR.eERROR_NOK;
            nAccessRight = (int)eACESS_RIGHT.eACESS_DENIED;
            NhanVien[] tNhanVien;
            int i = 0;
            string condition = "";
            this.getallEmployee(condition, out tNhanVien, i);
            string passInDB = tNhanVien[0].passwd;
            if (passInDB == strPasswordHash)
            {
                nError = (int)eLOGIN_ERROR.eERROR_OK;
                nAccessRight = (int)tNhanVien[0].positionID;
            }
            else
            {
                nError = (int)eLOGIN_ERROR.eERROR_NOK;
            }
        }
    }
}