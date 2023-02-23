namespace QLThuVien
{
    partial class frmDMNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbangcap = new System.Windows.Forms.ComboBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.lbbangcap = new System.Windows.Forms.Label();
            this.lbdienthoai = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsvNhanVien = new System.Windows.Forms.ListView();
            this.colMaNV = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.colDienThoai = new System.Windows.Forms.ColumnHeader();
            this.colBangCap = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(491, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbangcap);
            this.groupBox1.Controls.Add(this.dtngaysinh);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.lbbangcap);
            this.groupBox1.Controls.Add(this.lbdienthoai);
            this.groupBox1.Controls.Add(this.lbdiachi);
            this.groupBox1.Controls.Add(this.lbhoten);
            this.groupBox1.Controls.Add(this.lbngaysinh);
            this.groupBox1.Location = new System.Drawing.Point(57, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1347, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cbbangcap
            // 
            this.cbbangcap.FormattingEnabled = true;
            this.cbbangcap.Location = new System.Drawing.Point(659, 106);
            this.cbbangcap.Name = "cbbangcap";
            this.cbbangcap.Size = new System.Drawing.Size(349, 33);
            this.cbbangcap.TabIndex = 11;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Location = new System.Drawing.Point(137, 106);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(300, 31);
            this.dtngaysinh.TabIndex = 10;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(659, 55);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(349, 31);
            this.txtdienthoai.TabIndex = 9;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(137, 156);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(300, 31);
            this.txtdiachi.TabIndex = 8;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(137, 55);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(300, 31);
            this.txthoten.TabIndex = 7;
            // 
            // lbbangcap
            // 
            this.lbbangcap.AutoSize = true;
            this.lbbangcap.Location = new System.Drawing.Point(557, 106);
            this.lbbangcap.Name = "lbbangcap";
            this.lbbangcap.Size = new System.Drawing.Size(88, 25);
            this.lbbangcap.TabIndex = 6;
            this.lbbangcap.Text = "Bằng Cấp";
            // 
            // lbdienthoai
            // 
            this.lbdienthoai.AutoSize = true;
            this.lbdienthoai.Location = new System.Drawing.Point(557, 53);
            this.lbdienthoai.Name = "lbdienthoai";
            this.lbdienthoai.Size = new System.Drawing.Size(96, 25);
            this.lbdienthoai.TabIndex = 5;
            this.lbdienthoai.Text = "Điện Thoại";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(32, 162);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(68, 25);
            this.lbdiachi.TabIndex = 4;
            this.lbdiachi.Text = "Địa Chỉ";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Location = new System.Drawing.Point(32, 53);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(67, 25);
            this.lbhoten.TabIndex = 2;
            this.lbhoten.Text = "Họ Tên";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(32, 106);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(93, 25);
            this.lbngaysinh.TabIndex = 3;
            this.lbngaysinh.Text = "Ngày Sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(669, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(593, 27);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 34);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(475, 27);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(112, 34);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(357, 27);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(112, 34);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(239, 27);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(112, 34);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(121, 27);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(112, 34);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(3, 27);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 34);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsvNhanVien);
            this.groupBox3.Location = new System.Drawing.Point(57, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1347, 281);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chung";
            // 
            // lsvNhanVien
            // 
            this.lsvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colDienThoai,
            this.colBangCap});
            this.lsvNhanVien.Location = new System.Drawing.Point(20, 30);
            this.lsvNhanVien.Name = "lsvNhanVien";
            this.lsvNhanVien.Size = new System.Drawing.Size(1296, 234);
            this.lsvNhanVien.TabIndex = 0;
            this.lsvNhanVien.UseCompatibleStateImageBehavior = false;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã Nhân Viên";
            this.colMaNV.Width = 180;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 180;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày Sinh";
            this.colNgaySinh.Width = 180;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa Chỉ";
            this.colDiaChi.Width = 260;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Text = "Điện Thoại";
            this.colDienThoai.Width = 180;
            // 
            // colBangCap
            // 
            this.colBangCap.Text = "Băng Cấp";
            this.colBangCap.Width = 180;
            // 
            // frmDMNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 652);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDMNhanVien";
            this.Text = "frmDMNhanVien";
            this.Load += new System.EventHandler(this.frmDMNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txthoten;
        private Label lbbangcap;
        private Label lbdienthoai;
        private Label lbdiachi;
        private Label lbhoten;
        private Label lbngaysinh;
        private ComboBox cbbangcap;
        private DateTimePicker dtngaysinh;
        private TextBox txtdienthoai;
        private TextBox txtdiachi;
        private GroupBox groupBox2;
        private Button btnluu;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthem;
        private Button btnthoat;
        private Button btnhuy;
        private GroupBox groupBox3;
        private ListView lsvNhanVien;
        private ColumnHeader colMaNV;
        private ColumnHeader colHoTen;
        private ColumnHeader colNgaySinh;
        private ColumnHeader colDiaChi;
        private ColumnHeader colDienThoai;
        private ColumnHeader colBangCap;
    }
}