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

        /* Thông tin chi tiết */
        public string fullname;
        public string birthday;
        public string address;
        public string email;
        public int gender;
	};


}