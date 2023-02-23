using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmDMNhanVien : Form
    {
        public bool themmoi=false;
        Nhanvien nv = new Nhanvien();
        public frmDMNhanVien()
        {
            InitializeComponent();
        }
        void HienthiNhanVien()
        {
            DataTable dt = nv.layDSNhanVien();
            lsvNhanVien.Items.Clear();
            lsvNhanVien.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNhanVien.Items.Add(dt.Rows[i]["MaNhanVien"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["HoTenNhanVien"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

        void setNull()
        {
            txthoten.Text = "";
            txtdienthoai.Text = "";
            txtdiachi.Text = "";
        }

        void setButton(bool val)
        {
            btnthem.Enabled = val;
            btnxoa.Enabled = val;
            btnsua.Enabled = val;
            btnthoat.Enabled = val;
            btnluu.Enabled = !val;
            btnhuy.Enabled = !val;
        }

        void HienThiBangCap()
        {
            DataTable dt = nv.LayBangCap();
            cbbangcap.DataSource = dt;
            cbbangcap.DisplayMember = "TenBangCap";
            cbbangcap.ValueMember = "MaBangCap";
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            HienthiNhanVien();
            HienThiBangCap();
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                txthoten.Text =
               lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dtngaysinh.Value =
               DateTime.Parse(lsvNhanVien.SelectedItems[0].SubItems[2].Text);
                txtdiachi.Text =
               lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                txtdienthoai.Text =
               lsvNhanVien.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox
                cbbangcap.SelectedIndex =
               cbbangcap.FindString(lsvNhanVien.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txthoten.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count>0)
            {
                themmoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(lsvNhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text);
                    lsvNhanVien.Items.RemoveAt(lsvNhanVien.SelectedIndices[0]);
                    setNull();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            string ngay = String.Format("{0:MM/dd/yyyy}", dtngaysinh.Value);
            if(themmoi)
            {
                nv.ThemNhanVien(txthoten.Text, ngay, txtdiachi.Text, txtdienthoai.Text, cbbangcap.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                nv.CapNhatNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text, txthoten.Text, ngay, txtdiachi.Text, txtdienthoai.Text,
 cbbangcap.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            HienthiNhanVien();
            setNull();
        }

        
    }
}
