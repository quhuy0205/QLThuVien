namespace QLThuVien
{
    partial class FormHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenhoadon = new System.Windows.Forms.TextBox();
            this.txttongcong = new System.Windows.Forms.TextBox();
            this.cbthue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Hoa Don";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tong Cong";
            // 
            // txttenhoadon
            // 
            this.txttenhoadon.Location = new System.Drawing.Point(201, 72);
            this.txttenhoadon.Name = "txttenhoadon";
            this.txttenhoadon.Size = new System.Drawing.Size(184, 31);
            this.txttenhoadon.TabIndex = 3;
            // 
            // txttongcong
            // 
            this.txttongcong.Location = new System.Drawing.Point(201, 204);
            this.txttongcong.Name = "txttongcong";
            this.txttongcong.ReadOnly = true;
            this.txttongcong.Size = new System.Drawing.Size(182, 31);
            this.txttongcong.TabIndex = 4;
            // 
            // cbthue
            // 
            this.cbthue.FormattingEnabled = true;
            this.cbthue.Location = new System.Drawing.Point(203, 153);
            this.cbthue.Name = "cbthue";
            this.cbthue.Size = new System.Drawing.Size(182, 33);
            this.cbthue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sotien";
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(203, 115);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(182, 31);
            this.txtsotien.TabIndex = 7;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(201, 251);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(112, 34);
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "%";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbthue);
            this.Controls.Add(this.txttongcong);
            this.Controls.Add(this.txttenhoadon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txttenhoadon;
        private TextBox txttongcong;
        private ComboBox cbthue;
        private Label label4;
        private TextBox txtsotien;
        private Button btnluu;
        private Label label5;
    }
}