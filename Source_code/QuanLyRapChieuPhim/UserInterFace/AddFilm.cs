using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UserInterFace
{
    /* ==========================================================
	 *	Class name: 
	 *		AddFilm
	 *	Description:
	 *		Lớp xử lý giao diện thêm phim
	 *	Note:
	 *		None.
	 *	History:
	 *		Vuong		Khởi tạo
	 * ========================================================== */
    public partial class AddFilm : Form
    {
        public AddFilm()
        {
            InitializeComponent();
        }

        private void AddFilm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet1.quocgia' table. You can move, or remove it, as needed.
            this.quocgiaTableAdapter1.Fill(this.dataDataSet1.quocgia);
            // TODO: This line of code loads data into the 'dataDataSet1.theloaiphim' table. You can move, or remove it, as needed.
            this.theloaiphimTableAdapter1.Fill(this.dataDataSet1.theloaiphim);
            // TODO: This line of code loads data into the 'dataDataSet.quocgia' table. You can move, or remove it, as needed.
            this.quocgiaTableAdapter.Fill(this.dataDataSet.quocgia);
            // TODO: This line of code loads data into the 'dataDataSet.theloaiphim' table. You can move, or remove it, as needed.
            this.theloaiphimTableAdapter.Fill(this.dataDataSet.theloaiphim);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.theloaiphimTableAdapter.FillBy(this.dataDataSet.theloaiphim);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
