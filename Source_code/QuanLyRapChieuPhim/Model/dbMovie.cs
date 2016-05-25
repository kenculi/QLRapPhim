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
     *		CdbMovie
     *	Description:
     *		Lớp quản lý thông tin của phim
     *	Note:
     *		None.
     *	History:
     *		2016/05/21	[canh]		Khởi tạo
     * ========================================================== */
    class CdbMovie : CdbQuery
    {
        /* ==========================================================
         *	Function name: 
         *		CdbMovie
         *	Description:
         *		Hàm khởi tạo của lớp CdbMovie
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
        public CdbMovie()
        {
            /* Kết nối vào cơ sử dữ liệu */
            dbConnection(strAccessConn);
        }

        /* ==========================================================
         *	Function name: 
         *		getallMovie
         *	Description:
         *		Lấy toàn bộ thông tin phim
         *	Parameter:
         *		[Input]
         *			string condition : Mệnh đề where
         *		[Output]
         *			Phim[] tPhim: Thông tin toàn bộ phim
         *			i : Số lượng phim
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public void getallMovie(string condition, out Phim[] tPhim, int i)
        {
            /* Tạo câu truy vấn */
            string strQuery = "Select * from phim p,theloaiphim t,quocgia q where p.MaTheLoai=t.MaTheLoai AND p.MaQuocGia=q.MaQuocGia" + condition;

            /* Tạo data lưu thông tin sau khi truy vấn */
            DataSet dbDataSet;

            /* Thực hiện truy vấn */
            dbAccess(strQuery, "phim", out dbDataSet);

            /* Xử lý thông tin lấy từ database */
            tPhim = new Phim[100];
            i = 0;
            DataRowCollection dra = dbDataSet.Tables["phim"].Rows;
            foreach (DataRow dr in dra)
            {
                tPhim[i].MovieID = (int)dr[0];
                tPhim[i].MovieName = (string)dr[1];
                tPhim[i].MovieGenres = (string)dr[12]; //cột 13 là cột thể loại phim sau khi kết bảng
                tPhim[i].MovieLen = (int)dr[3];
                tPhim[i].MovieNation = (string)dr[14];//cột 15 là cột quốc gia sau khi kết bảng
                tPhim[i].MovieStartDay = (DateTime)dr[5];
                tPhim[i].MovieFinishDay = (DateTime)dr[6];
                tPhim[i].MovieAvatar = (string)dr[7];
                tPhim[i].MovieActor = (string)dr[8];
                tPhim[i].Moviecontent = (string)dr[9];
                tPhim[i].MovieStatus = (string)dr[10];
                i++;
            }
        }
        /* ==========================================================
         *	Function name: 
         *		addMovie
         *	Description:
         *		Thêm thông tin một phim mới
         *	Parameter:
         *		[Input]
         *		    Phim tPhim
         *		[Output]
         *			None.
         *	Note:
         *		None.
         *	History:
         *		2016/05/21	[canh]		Khởi tạo
         * ========================================================== */
        public void addMovie(Phim tPhim)
        {
            DataSet dbDataSet;
            string strQuery = "INSERT INTO phim VALUES("+tPhim.MovieID+","+tPhim.MovieName+","+tPhim.MovieGenres+","+tPhim.MovieLen+","+tPhim.MovieNation+","+tPhim.MovieStartDay+","+tPhim.MovieFinishDay+","+tPhim.MovieAvatar+","+tPhim.MovieActor+","+tPhim.Moviecontent+","+tPhim.MovieStatus+")";
            dbAccess(strQuery, "phim",out dbDataSet);
        }
    }
}