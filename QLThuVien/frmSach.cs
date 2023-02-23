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
    public partial class frmSach : Form
    {
        bool themmoi = false;
        Sach sach = new Sach();
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            hienthisach();
        }
        void hienthisach()
        {
            DataTable dt = sach.LaySach();
            lssach.Items.Clear();
            lssach.View = View.Details; 

            for (int i = 0; i< dt.Rows.Count; i++)
            {
                ListViewItem lvi = lssach.Items.Add(dt.Rows[i]["MaSach"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TenSach"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = sach.TimSach(txttimkiem.Text);
            lssach.Items.Clear();
            lssach.View = View.Details;
            
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lssach.Items.Add(dt.Rows[i]["MaSach"].ToString());
                    lvi.SubItems.Add(dt.Rows[i]["TenSach"].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                    lvi.SubItems.Add(dt.Rows[i][6].ToString());
                }
            }

        void SetNull()
        {
            txttensach.Text = "";
            txttacgia.Text = "";
            txtnhaxb.Text = "";
            txtnamxb.Text = "";
            txttrigia.Text = "";
        }

        void SetButton(bool val)
        {
            btnthem.Enabled= val;
            btnsua.Enabled= val;
            btnXoa.Enabled= val;
            btnhuy.Enabled= !val;
            btnluu.Enabled= !val;
            btnthoat.Enabled= val;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            SetButton(false);
            txttensach.Focus();
        }

        private void lssach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lssach.SelectedIndices.Count>0)
            {
                txttensach.Text = lssach.SelectedItems[0].SubItems[1].Text;
                txttacgia.Text = lssach.SelectedItems[0].SubItems[2].Text;
                txtnamxb.Text = lssach.SelectedItems[0].SubItems[3].Text;
                txtnhaxb.Text = lssach.SelectedItems[0].SubItems[4].Text;
                txttrigia.Text = lssach.SelectedItems[0].SubItems[5].Text;
                dtngaynhap.Value = DateTime.Parse(lssach.SelectedItems[0].SubItems[6].Text);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(lssach.SelectedIndices.Count>0)
            {
                themmoi=true;
                SetButton(false);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lssach.SelectedIndices.Count>0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    sach.XoaSach(lssach.SelectedItems[0].SubItems[0].Text);
                    lssach.Items.RemoveAt(lssach.SelectedIndices[0]);
                    SetNull();
                    MessageBox.Show("XOA THANH CONG");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string ngaynhap = String.Format("{0:MM/dd/yyyy}", dtngaynhap.Value);
            if(themmoi)
            {
                sach.ThemSach(txttensach.Text, txttacgia.Text, txtnamxb.Text, txtnhaxb.Text, float.Parse(txttrigia.Text), ngaynhap);
                MessageBox.Show("Them Moi Thanh Cong!");
            }
            else
            {
                sach.CapNhatSach(lssach.SelectedItems[0].SubItems[0].Text, txttensach.Text, txttacgia.Text, txtnamxb.Text, txtnhaxb.Text, float.Parse(txttrigia.Text), ngaynhap);
                MessageBox.Show("Cap Nhat Thanh Cong!");
            }
            hienthisach();
            SetNull();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            SetButton(true);
        }
    }
    }

