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
     *		CdbShowTime
     *	Description:
     *		Lớp quản lý thông tin của lịch chiếu
     *	Note:
     *		None.
     *	History:
     *		2016/05/21	[canh]		Khởi tạo
     * ========================================================== */
    class CdbShowTime : CdbQuery
    {
        /* ==========================================================
         *	Function name: 
         *		CdbShowTime
         *	Description:
         *		Hàm khởi tạo của lớp CdbShowTime
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
        public CdbShowTime()
        {
            /* Kết nối vào cơ sử dữ liệu */
            dbConnection(strAccessConn);
        }

        /* ==========================================================
         *	Function name: 
         *		getallShowTime
         *	Description:
         *		Lấy toàn bộ thông tin lịch chiếu
         *	Parameter:
         *		[Input]
         *			string condition : Mệnh đề where
         *		[Output]
         *			LichChieu[] tLichChieu : Thông tin toàn bộ lịch chiếu
         *			i : Số lượng lịch chiếu
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public void getallShowTime(string condition, out LichChieu[] tLichChieu, int i)
        {
            /* Tạo câu truy vấn */
            string strQuery = "Select * from lichchieu" + condition;

            /* Tạo data lưu thông tin sau khi truy vấn */
            DataSet dbDataSet;

            /* Thực hiện truy vấn */
            dbAccess(strQuery, "lichchieu", out dbDataSet);

            /* Xử lý thông tin lấy từ database */
            tLichChieu = new LichChieu[100];
            i = 0;
            DataRowCollection dra = dbDataSet.Tables["lichchieu"].Rows;
            foreach (DataRow dr in dra)
            {
                tLichChieu[i].MovieShowtimesID = (int)dr[0];
                tLichChieu[i].MovieID = (int)dr[1];
                tLichChieu[i].CinemaRoomID = (int)dr[2];
                tLichChieu[i].MovieShowtimes = (DateTime)dr[3];
                i++;
            }
        }
        /* ==========================================================
         *	Function name: 
         *		addShowTime
         *	Description:
         *		Thêm thông tin một lịch chiếu mới
         *	Parameter:
         *		[Input]
         *		    LichChieu tLichChieu
         *		[Output]
         *			None.
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public void addShowTime(LichChieu tLichChieu)
        {
            DataSet dbDataSet;
            string strQuery = "INSERT INTO phim VALUES(" + tLichChieu.MovieShowtimesID + "," + tLichChieu.MovieID + "," + tLichChieu.CinemaRoomID + "," + tLichChieu.MovieShowtimes +")";
            dbAccess(strQuery, "lichchieu", out dbDataSet);
        }
        /* ==========================================================
         *	Function name: 
         *		updateShowTime
         *	Description:
         *		Sửa thông tin một lịch chiếu
         *	Parameter:
         *		[Input]
         *		    LichChieu tLichChieu
         *		[Output]
         *			None.
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public void updateShowTime(LichChieu tLichChieu)
        {
            DataSet dbDataSet;
            string strQuery = "UPDATE lichchieu GET MaLichChieu=" + tLichChieu.MovieShowtimesID + ",MaPhim=" + tLichChieu.MovieID + ",MaPhong=" + tLichChieu.CinemaRoomID + ",ThoiGianChieu=" + tLichChieu.MovieShowtimes + " WHERE MaLichChieu = " + tLichChieu.MovieShowtimesID;
            dbAccess(strQuery, "lichchieu", out dbDataSet);
        }
    }
}