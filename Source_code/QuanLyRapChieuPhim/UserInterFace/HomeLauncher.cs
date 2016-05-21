using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
	/* ==========================================================
	 *	Class name: 
	 *		CHomeLauncher
	 *	Description:
	 *		Lớp xử lý giao diện màn hình chính
	 *	Note:
	 *		None.
	 *	History:
	 *		2016/05/21	SonDTT		Khởi tạo
	 * ========================================================== */
	public partial class CHomeLauncher : Form
	{
		/* ==========================================================
		 *	Function name: 
		 *		CHomeLauncher
		 *	Description:
		 *		Hàm khởi tạo của lớp CHomeLauncher
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
		public CHomeLauncher()
		{
			InitializeComponent();

			/* Canh vị trí vào giữa màn hình */
			this.CenterToScreen();
		}
	}
}
