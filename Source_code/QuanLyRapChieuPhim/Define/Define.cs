namespace QuanLyRapChieuPhim
{
	enum AccessRight
	{
		eVisitor = 1,
		eAdministrators,
		eCashier,
		eSupervisor,
	};

	struct NhanVien
	{
		public string strID;
		public string strName;
		public string strAdress;
		/* ... */
	};
}