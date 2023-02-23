namespace QLThuVien
{
    partial class frmSach
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
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.txttrigia = new System.Windows.Forms.TextBox();
            this.txtnhaxb = new System.Windows.Forms.TextBox();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            this.txttacgia = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lssach = new System.Windows.Forms.ListView();
            this.clMaSach = new System.Windows.Forms.ColumnHeader();
            this.clTenSach = new System.Windows.Forms.ColumnHeader();
            this.clTacGia = new System.Windows.Forms.ColumnHeader();
            this.clNamXuatBan = new System.Windows.Forms.ColumnHeader();
            this.clNhaXuatBan = new System.Windows.Forms.ColumnHeader();
            this.clTriGia = new System.Windows.Forms.ColumnHeader();
            this.clNgayNhap = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(563, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngaynhap);
            this.groupBox1.Controls.Add(this.txttrigia);
            this.groupBox1.Controls.Add(this.txtnhaxb);
            this.groupBox1.Controls.Add(this.txtnamxb);
            this.groupBox1.Controls.Add(this.txttacgia);
            this.groupBox1.Controls.Add(this.txttensach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(70, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaynhap.Location = new System.Drawing.Point(730, 102);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(300, 31);
            this.dtngaynhap.TabIndex = 12;
            // 
            // txttrigia
            // 
            this.txttrigia.Location = new System.Drawing.Point(730, 54);
            this.txttrigia.Name = "txttrigia";
            this.txttrigia.Size = new System.Drawing.Size(300, 31);
            this.txttrigia.TabIndex = 11;
            // 
            // txtnhaxb
            // 
            this.txtnhaxb.Location = new System.Drawing.Point(150, 184);
            this.txtnhaxb.Name = "txtnhaxb";
            this.txtnhaxb.Size = new System.Drawing.Size(408, 31);
            this.txtnhaxb.TabIndex = 9;
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(150, 147);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(408, 31);
            this.txtnamxb.TabIndex = 10;
            // 
            // txttacgia
            // 
            this.txttacgia.Location = new System.Drawing.Point(150, 104);
            this.txttacgia.Name = "txttacgia";
            this.txttacgia.Size = new System.Drawing.Size(408, 31);
            this.txttacgia.TabIndex = 9;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(150, 60);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(408, 31);
            this.txttensach.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trị Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "NXB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm Xuất Bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tác Giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(513, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 73);
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
            this.btnhuy.Location = new System.Drawing.Point(475, 30);
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
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(239, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(121, 27);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(112, 34);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
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
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.lssach);
            this.groupBox3.Location = new System.Drawing.Point(70, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1148, 307);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chung";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(885, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tìm Kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(976, 43);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(150, 31);
            this.txttimkiem.TabIndex = 4;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // lssach
            // 
            this.lssach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaSach,
            this.clTenSach,
            this.clTacGia,
            this.clNamXuatBan,
            this.clNhaXuatBan,
            this.clTriGia,
            this.clNgayNhap});
            this.lssach.Location = new System.Drawing.Point(28, 80);
            this.lssach.Name = "lssach";
            this.lssach.Size = new System.Drawing.Size(1098, 221);
            this.lssach.TabIndex = 0;
            this.lssach.UseCompatibleStateImageBehavior = false;
            this.lssach.SelectedIndexChanged += new System.EventHandler(this.lssach_SelectedIndexChanged);
            // 
            // clMaSach
            // 
            this.clMaSach.Text = "Mã Sách";
            this.clMaSach.Width = 150;
            // 
            // clTenSach
            // 
            this.clTenSach.Text = "Tên Sách";
            this.clTenSach.Width = 180;
            // 
            // clTacGia
            // 
            this.clTacGia.Text = "Tác Giả";
            this.clTacGia.Width = 180;
            // 
            // clNamXuatBan
            // 
            this.clNamXuatBan.Text = "Năm Xuất Bản";
            this.clNamXuatBan.Width = 180;
            // 
            // clNhaXuatBan
            // 
            this.clNhaXuatBan.Text = "Nhà Xuất Bản";
            this.clNhaXuatBan.Width = 180;
            // 
            // clTriGia
            // 
            this.clTriGia.Text = "Trị Giá";
            this.clTriGia.Width = 180;
            // 
            // clNgayNhap
            // 
            this.clNgayNhap.Text = "Ngày Nhập";
            this.clNgayNhap.Width = 180;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 714);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSach";
            this.Text = "frmSach";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtnamxb;
        private TextBox txttacgia;
        private TextBox txttensach;
        private TextBox txtnhaxb;
        private DateTimePicker dtngaynhap;
        private TextBox txttrigia;
        private GroupBox groupBox2;
        private Button btnthoat;
        private Button btnhuy;
        private Button btnluu;
        private Button btnXoa;
        private Button btnsua;
        private Button btnthem;
        private GroupBox groupBox3;
        private ListView lssach;
        private ColumnHeader clMaSach;
        private ColumnHeader clTenSach;
        private ColumnHeader clTacGia;
        private ColumnHeader clNamXuatBan;
        private ColumnHeader clNhaXuatBan;
        private ColumnHeader clTriGia;
        private ColumnHeader clNgayNhap;
        private Label label8;
        private TextBox txttimkiem;
    }
}