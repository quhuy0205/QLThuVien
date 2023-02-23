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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMNhanVien form = new frmDMNhanVien();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int tong = a + b;
            textBox3.Text = tong.ToString();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
