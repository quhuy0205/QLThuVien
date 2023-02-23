namespace QLThuVien
{
    public partial class FormHoaDon : Form
    {
        HoaDon hd = new HoaDon();
        public FormHoaDon()
        {
            InitializeComponent();
            cbthue.Items.Add(5);
            cbthue.Items.Add(10);
            cbthue.Items.Add(15);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string tenhoadon = txttenhoadon.Text;
            int sotien = Int32.Parse(txtsotien.Text);
            int thue = Convert.ToInt32(cbthue.SelectedItem);
            int tong = (sotien * thue) / 100;
            txttongcong.Text = tong.ToString();
            hd.THEMHOADON(tenhoadon, thue, Int32.Parse(txttongcong.Text), sotien);
            MessageBox.Show("Them Thanh Cong");
        }
    }
}

