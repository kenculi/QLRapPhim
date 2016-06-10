namespace QuanLyRapChieuPhim.UserInterFace
{
    partial class AddFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.slbGenre = new System.Windows.Forms.ComboBox();
            this.theloaiphimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new QuanLyRapChieuPhim.dataDataSet();
            this.theloaiphimBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.slbNation = new System.Windows.Forms.ComboBox();
            this.quocgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.theloaiphimTableAdapter = new QuanLyRapChieuPhim.dataDataSetTableAdapters.theloaiphimTableAdapter();
            this.quocgiaTableAdapter = new QuanLyRapChieuPhim.dataDataSetTableAdapters.quocgiaTableAdapter();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataDataSet1 = new QuanLyRapChieuPhim.dataDataSet1();
            this.theloaiphimBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.theloaiphimTableAdapter1 = new QuanLyRapChieuPhim.dataDataSet1TableAdapters.theloaiphimTableAdapter();
            this.dataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quocgiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quocgiaTableAdapter1 = new QuanLyRapChieuPhim.dataDataSet1TableAdapters.quocgiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiphimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiphimBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quocgiaBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiphimBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quocgiaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(208, 217);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(150, 20);
            this.txtTime.TabIndex = 22;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(208, 119);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(150, 20);
            this.txtMovieName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(73, 261);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quốc gia";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(73, 163);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(73, 212);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Độ dài (phút)";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(73, 114);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên phim";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(73, 355);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(73, 404);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ảnh đại diện";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(73, 306);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(208, 505);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(150, 20);
            this.txtDesc.TabIndex = 33;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(208, 456);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(150, 20);
            this.txtActor.TabIndex = 32;
            this.txtActor.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(73, 451);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Diễn viên";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(73, 500);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Mô tả";
            // 
            // slbGenre
            // 
            this.slbGenre.DataSource = this.theloaiphimBindingSource2;
            this.slbGenre.DisplayMember = "TenTheLoai";
            this.slbGenre.FormattingEnabled = true;
            this.slbGenre.Location = new System.Drawing.Point(208, 167);
            this.slbGenre.Name = "slbGenre";
            this.slbGenre.Size = new System.Drawing.Size(150, 21);
            this.slbGenre.TabIndex = 34;
            this.slbGenre.ValueMember = "MaTheLoai";
            // 
            // theloaiphimBindingSource
            // 
            this.theloaiphimBindingSource.DataMember = "theloaiphim";
            this.theloaiphimBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theloaiphimBindingSource1
            // 
            this.theloaiphimBindingSource1.DataMember = "theloaiphim";
            this.theloaiphimBindingSource1.DataSource = this.dataDataSet;
            // 
            // slbNation
            // 
            this.slbNation.DataSource = this.quocgiaBindingSource1;
            this.slbNation.DisplayMember = "TenQuocGia";
            this.slbNation.FormattingEnabled = true;
            this.slbNation.Location = new System.Drawing.Point(208, 265);
            this.slbNation.Name = "slbNation";
            this.slbNation.Size = new System.Drawing.Size(150, 21);
            this.slbNation.TabIndex = 35;
            this.slbNation.ValueMember = "MaQuocGia";
            // 
            // quocgiaBindingSource
            // 
            this.quocgiaBindingSource.DataMember = "quocgia";
            this.quocgiaBindingSource.DataSource = this.dataDataSet;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(208, 311);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(150, 20);
            this.startDate.TabIndex = 36;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(208, 360);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(150, 20);
            this.endDate.TabIndex = 37;
            // 
            // theloaiphimTableAdapter
            // 
            this.theloaiphimTableAdapter.ClearBeforeFill = true;
            // 
            // quocgiaTableAdapter
            // 
            this.quocgiaTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddGenre.Location = new System.Drawing.Point(172, 550);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(87, 31);
            this.btnAddGenre.TabIndex = 38;
            this.btnAddGenre.Text = "Thêm";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(430, 25);
            this.fillByToolStrip.TabIndex = 39;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "dataDataSet1";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theloaiphimBindingSource2
            // 
            this.theloaiphimBindingSource2.DataMember = "theloaiphim";
            this.theloaiphimBindingSource2.DataSource = this.dataDataSet1;
            // 
            // theloaiphimTableAdapter1
            // 
            this.theloaiphimTableAdapter1.ClearBeforeFill = true;
            // 
            // dataDataSet1BindingSource
            // 
            this.dataDataSet1BindingSource.DataSource = this.dataDataSet1;
            this.dataDataSet1BindingSource.Position = 0;
            // 
            // quocgiaBindingSource1
            // 
            this.quocgiaBindingSource1.DataMember = "quocgia";
            this.quocgiaBindingSource1.DataSource = this.dataDataSet1BindingSource;
            // 
            // quocgiaTableAdapter1
            // 
            this.quocgiaTableAdapter1.ClearBeforeFill = true;
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 610);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.slbNation);
            this.Controls.Add(this.slbGenre);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm phim mới";
            this.Load += new System.EventHandler(this.AddFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiphimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiphimBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quocgiaBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiphimBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quocgiaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox slbGenre;
        private System.Windows.Forms.ComboBox slbNation;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource theloaiphimBindingSource;
        private dataDataSetTableAdapters.theloaiphimTableAdapter theloaiphimTableAdapter;
        private System.Windows.Forms.BindingSource quocgiaBindingSource;
        private dataDataSetTableAdapters.quocgiaTableAdapter quocgiaTableAdapter;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.BindingSource theloaiphimBindingSource1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private dataDataSet1 dataDataSet1;
        private System.Windows.Forms.BindingSource theloaiphimBindingSource2;
        private dataDataSet1TableAdapters.theloaiphimTableAdapter theloaiphimTableAdapter1;
        private System.Windows.Forms.BindingSource dataDataSet1BindingSource;
        private System.Windows.Forms.BindingSource quocgiaBindingSource1;
        private dataDataSet1TableAdapters.quocgiaTableAdapter quocgiaTableAdapter1;
    }
}