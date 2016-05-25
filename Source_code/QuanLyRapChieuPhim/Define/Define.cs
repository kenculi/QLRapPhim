using System;
namespace QuanLyRapChieuPhim
{
    /* Quyền đăng nhập trong hệ thống */
    enum eACESS_RIGHT
    {
        eACESS_DENIED = 0,		/* Không có quyền truy cập */
        eVISITOR,				/* Người viếng thăm */
        eADMINISTRATOR,			/* Quản trị viên */
        eCASHIER,				/* ... */
        eSUPERVISOR,
    };

    /* Mã lỗi trả về khi đăng nhập */
    enum eLOGIN_ERROR
    {
        eERROR_OK = 1,			/* Đăng nhập thành công */
        eERROR_NOK,				/* Đăng không thành công */
    }

    struct NhanVien
    {
        /* Thông tin cơ bản */
        public int employeeID;
        public string username;
        public string passwd;
        public int positionID;
        public string position;

        /* Thông tin chi tiết */
        public string fullname;
        public DateTime birthday;
        public string address;
        public string email;
        public int gender;
    };
    struct Phim
    {
        public int MovieID; //Mã phim
        public string MovieName;//Tên phim
        public string MovieGenres;//Thể loại phim
        public DateTime MovieStartDay;//Ngày bắt đầu chiếu
        public DateTime MovieFinishDay;//Ngày kết thúc chiếu
        public string MovieNation;//Quốc gia
        public string Moviecontent;//Nội dung phim
        public int MovieLen;//Độ dài phim
        public string MovieAvatar;//Ảnh đại diện phim
        public string MovieActor;//Diễn viên
        public string MovieStatus;      //Trạng thái
    };
    struct LichChieu
    {
        public int MovieShowtimesID; //Mã lịch chiếu
        public int MovieID; //Mã phim
        public int CinemaRoomID;//Mã phòng chiếu
        public DateTime MovieShowtimes;//Thời gian chiếu
    };
    struct PhongChieu
    {
        public int CinemaRoomID;//Mã phòng chiếu
        public int CinemaRoomName;//Tên phòng chiếu
        public int CinemaRoomStt;//Trạng thái phòng chiếu
        public int SLDayGhe;//Số lượng dãy ghế
        public int SLGheMoiDay;//Số lượng ghế mỗi dãy
        public string Note;//Ghi chú
    };

}