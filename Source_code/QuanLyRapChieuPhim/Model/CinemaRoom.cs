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
     *		CdbCinemaRoom
     *	Description:
     *		Lớp quản lý thông tin của phòng chiếu
     *	Note:
     *		None.
     *	History:
     *		2016/05/21	[canh]		Khởi tạo
     * ========================================================== */
    class CdbCinemaRoom : CdbQuery
    {
        /* ==========================================================
         *	Function name: 
         *		CdbCinemaRoom
         *	Description:
         *		Hàm khởi tạo của lớp CdbCinemaRoom
         *	Parameter:
         *		[Input]
         *			None.
         *		[Output]
         *			None.
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public CdbCinemaRoom()
        {
            /* Kết nối vào cơ sử dữ liệu */
            dbConnection(strAccessConn);
        }

        /* ==========================================================
         *	Function name: 
         *		getallCinemaRoom
         *	Description:
         *		Lấy toàn bộ thông tin phòng chiếu
         *	Parameter:
         *		[Input]
         *			string condition : Mệnh đề where
         *		[Output]
         *		PhongChieu[] tPhongChieu: Thông tin toàn bộ phòng chiếu
         *	    i : Số lượng phòng chiếu
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public void getallCinemaRoom(string condition, out PhongChieu[] tPhongChieu, int i)
        {
            /* Tạo câu truy vấn */
            string strQuery = "Select * from phong " + condition;

            /* Tạo data lưu thông tin sau khi truy vấn */
            DataSet dbDataSet;

            /* Thực hiện truy vấn */
            dbAccess(strQuery, "phong", out dbDataSet);

            /* Xử lý thông tin lấy từ database */
            tPhongChieu = new PhongChieu[100];
            i = 0;
            DataRowCollection dra = dbDataSet.Tables["phong"].Rows;
            foreach (DataRow dr in dra)
            {
                tPhongChieu[i].CinemaRoomID = (int)dr[0];
                tPhongChieu[i].CinemaRoomName = (int)dr[1];
                tPhongChieu[i].CinemaRoomStt = (int)dr[2];
                tPhongChieu[i].SLDayGhe = (int)dr[3];
                tPhongChieu[i].SLGheMoiDay = (int)dr[4];
                tPhongChieu[i].Note = (string)dr[5];
                i++;
            }
        }
        /* ==========================================================
         *	Function name: 
         *		addCinemaRoom
         *	Description:
         *		Thêm thông tin một phòng chiếu mới
         *	Parameter:
         *		[Input]
         *		    PhongChieu tPhongChieu
         *		[Output]
         *			None.
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public void addCinemaRoom(PhongChieu tPhongChieu)
        {
            DataSet dbDataSet;
            string strQuery = "INSERT INTO phong VALUES(" + tPhongChieu.CinemaRoomID + "," + tPhongChieu.CinemaRoomName + "," + tPhongChieu.CinemaRoomStt + "," + tPhongChieu.SLDayGhe + "," + tPhongChieu.SLGheMoiDay + "," + tPhongChieu.Note +")";
            dbAccess(strQuery, "phong", out dbDataSet);
        }
        /* ==========================================================
         *	Function name: 
         *		updateCinemaRoom
         *	Description:
         *		Sửa thông tin một phòng chiếu
         *	Parameter:
         *		[Input]
         *		    PhongChieu tPhongChieu
         *		[Output]
         *			None.
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public void updateCinemaRoom(PhongChieu tPhongChieu)
        {
            DataSet dbDataSet;
            string strQuery = "UPDATE phong SET MaPhong=" + tPhongChieu.CinemaRoomID + ",TenPhong=" + tPhongChieu.CinemaRoomName + ",TrangThai" + tPhongChieu.CinemaRoomStt + ",SLuongDayGhe=" + tPhongChieu.SLDayGhe + ",SLuongGheMoiDay=" + tPhongChieu.SLGheMoiDay + ",GhiChu=" + tPhongChieu.Note + " WHERE MaPhong = "+ tPhongChieu.CinemaRoomID;
            dbAccess(strQuery, "phong", out dbDataSet);
        }
    }
}