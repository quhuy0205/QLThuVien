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
    public partial class frmDocGia : Form
    {
        public bool themmoi = false;
        DocGia dg = new DocGia(); 
        public frmDocGia()
        {
            InitializeComponent();
        }

        void hienthidocgia()
        {
            DataTable dt = dg.DSDOCGIA();
            lvdocgia.Items.Clear();
            lvdocgia.View = View.Details;
            for (int i = 0; i< dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvdocgia.Items.Add(dt.Rows[i]["MaDocGia"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["HoTenDocGia"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
            }
        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            hienthidocgia();
        }

        void SetNull()
        {
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            txttienno.Text = "";
        }

        void setButton(bool val)
        {
            btnthem.Enabled= val;
            btnsua.Enabled= val;
            btnxoa.Enabled= val;
            btnhuy.Enabled= !val;
            btnluu.Enabled= !val;
            btnthoat.Enabled= val;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txthoten.Focus();
        }

        private void lvdocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvdocgia.SelectedIndices.Count> 0)
            {
                txthoten.Text = lvdocgia.SelectedItems[0].SubItems[1].Text;
                dtngaysinh.Value = DateTime.Parse(lvdocgia.SelectedItems[0].SubItems[2].Text);
                txtdiachi.Text = lvdocgia.SelectedItems[0].SubItems[3].Text;
                txtemail.Text = lvdocgia.SelectedItems[0].SubItems[4].Text;
                dtngaylapthe.Value = DateTime.Parse(lvdocgia.SelectedItems[0].SubItems[5].Text);
                dtngayhethan.Value = DateTime.Parse(lvdocgia.SelectedItems[0].SubItems[6].Text);
                txttienno.Text = lvdocgia.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(lvdocgia.SelectedItems.Count> 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvdocgia.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dg.XOADOCGIA(lvdocgia.SelectedItems[0].SubItems[0].Text);
                    lvdocgia.Items.RemoveAt(lvdocgia.SelectedIndices[0]);
                    SetNull();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            string ngaysinh = String.Format("{0:MM/dd/yyyy}", dtngaysinh.Value);
            string ngaylapthe = String.Format("{0:MM/dd/yyyy}", dtngaylapthe.Value);
            string ngayhethan = String.Format("{0:MM/dd/yyyy}", dtngayhethan.Value);
          
            if (themmoi)
            {
                dg.THEMDOCGIA(txthoten.Text, ngaysinh, txtdiachi.Text, txtemail.Text, ngaylapthe, ngayhethan, float.Parse(txttienno.Text));
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                dg.SUADOCGIA(lvdocgia.SelectedItems[0].SubItems[0].Text, txthoten.Text, ngaysinh, txtdiachi.Text, txtemail.Text, ngaylapthe, ngayhethan, txttienno.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            hienthidocgia();
            SetNull();
        }
    }
}
