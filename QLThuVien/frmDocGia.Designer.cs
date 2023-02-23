namespace QLThuVien
{
    partial class frmDocGia
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
            this.txttienno = new System.Windows.Forms.TextBox();
            this.dtngayhethan = new System.Windows.Forms.DateTimePicker();
            this.dtngaylapthe = new System.Windows.Forms.DateTimePicker();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvdocgia = new System.Windows.Forms.ListView();
            this.clMaDocGia = new System.Windows.Forms.ColumnHeader();
            this.clHoTen = new System.Windows.Forms.ColumnHeader();
            this.clNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.clDiaChi = new System.Windows.Forms.ColumnHeader();
            this.clEmail = new System.Windows.Forms.ColumnHeader();
            this.clNgayLapThe = new System.Windows.Forms.ColumnHeader();
            this.clNgayHetHan = new System.Windows.Forms.ColumnHeader();
            this.clTienNo = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(462, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐỘC GIẢ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttienno);
            this.groupBox1.Controls.Add(this.dtngayhethan);
            this.groupBox1.Controls.Add(this.dtngaylapthe);
            this.groupBox1.Controls.Add(this.dtngaysinh);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(71, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1167, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Độc Giả";
            // 
            // txttienno
            // 
            this.txttienno.Location = new System.Drawing.Point(674, 137);
            this.txttienno.Name = "txttienno";
            this.txttienno.Size = new System.Drawing.Size(300, 31);
            this.txttienno.TabIndex = 15;
            // 
            // dtngayhethan
            // 
            this.dtngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayhethan.Location = new System.Drawing.Point(674, 93);
            this.dtngayhethan.Name = "dtngayhethan";
            this.dtngayhethan.Size = new System.Drawing.Size(300, 31);
            this.dtngayhethan.TabIndex = 14;
            // 
            // dtngaylapthe
            // 
            this.dtngaylapthe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaylapthe.Location = new System.Drawing.Point(674, 50);
            this.dtngaylapthe.Name = "dtngaylapthe";
            this.dtngaylapthe.Size = new System.Drawing.Size(300, 31);
            this.dtngaylapthe.TabIndex = 13;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(125, 93);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(300, 31);
            this.dtngaysinh.TabIndex = 12;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(125, 183);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(300, 31);
            this.txtemail.TabIndex = 11;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(125, 134);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(300, 31);
            this.txtdiachi.TabIndex = 10;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(125, 44);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(300, 31);
            this.txthoten.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tiền Nợ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày Hết Hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày Lập Thẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(522, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(596, 31);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 34);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(478, 31);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(112, 34);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(360, 31);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(112, 34);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(242, 31);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(112, 34);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(124, 31);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(112, 34);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(6, 30);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 34);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvdocgia);
            this.groupBox3.Location = new System.Drawing.Point(77, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1161, 298);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chung";
            // 
            // lvdocgia
            // 
            this.lvdocgia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaDocGia,
            this.clHoTen,
            this.clNgaySinh,
            this.clDiaChi,
            this.clEmail,
            this.clNgayLapThe,
            this.clNgayHetHan,
            this.clTienNo});
            this.lvdocgia.Location = new System.Drawing.Point(15, 30);
            this.lvdocgia.Name = "lvdocgia";
            this.lvdocgia.Size = new System.Drawing.Size(1138, 262);
            this.lvdocgia.TabIndex = 0;
            this.lvdocgia.UseCompatibleStateImageBehavior = false;
            this.lvdocgia.SelectedIndexChanged += new System.EventHandler(this.lvdocgia_SelectedIndexChanged);
            // 
            // clMaDocGia
            // 
            this.clMaDocGia.Text = "Mã Độc Giả";
            this.clMaDocGia.Width = 120;
            // 
            // clHoTen
            // 
            this.clHoTen.Text = "Họ Tên";
            this.clHoTen.Width = 180;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.Text = "Ngày Sinh";
            this.clNgaySinh.Width = 120;
            // 
            // clDiaChi
            // 
            this.clDiaChi.Text = "Địa Chỉ";
            this.clDiaChi.Width = 280;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email";
            this.clEmail.Width = 180;
            // 
            // clNgayLapThe
            // 
            this.clNgayLapThe.Text = "Ngày Lập Thẻ";
            this.clNgayLapThe.Width = 180;
            // 
            // clNgayHetHan
            // 
            this.clNgayHetHan.Text = "Ngày Hết Hạn";
            this.clNgayHetHan.Width = 180;
            // 
            // clTienNo
            // 
            this.clTienNo.Text = "Tiền Nợ";
            this.clTienNo.Width = 120;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 765);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDocGia";
            this.Text = "frmDocGia";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txthoten;
        private TextBox txtdiachi;
        private TextBox txtemail;
        private DateTimePicker dtngayhethan;
        private DateTimePicker dtngaylapthe;
        private DateTimePicker dtngaysinh;
        private TextBox txttienno;
        private GroupBox groupBox2;
        private Button btnthoat;
        private Button btnhuy;
        private Button btnluu;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private GroupBox groupBox3;
        private ListView lvdocgia;
        private ColumnHeader clMaDocGia;
        private ColumnHeader clHoTen;
        private ColumnHeader clNgaySinh;
        private ColumnHeader clDiaChi;
        private ColumnHeader clEmail;
        private ColumnHeader clNgayLapThe;
        private ColumnHeader clNgayHetHan;
        private ColumnHeader clTienNo;
    }
}