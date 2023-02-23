using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    class Sach
    {
        Database db;
        public Sach()
            {
            db = new Database();
            }
        public DataTable LaySach()
        {
            string sql = "SELECT * FROM SACH";
            DataTable dt = db.Execute(sql);
            return dt;
        }

        public DataTable TimSach(string tensach)
        {
            string sql = "SELECT * FROM SACH WHERE TenSach LIKE'%" + tensach+ "%'";
            DataTable dt = db.Execute(sql);
            return dt;
        }

        public void ThemSach(string tensach, string tacgia, string namxuatban, string nhaxuatban, float trigia, string ngaynhap)
        {
            string sql = String.Format("INSERT INTO SACH VALUES(N'{0}',N'{1}','{2}',N'{3}','{4}','{5}')",tensach,tacgia,namxuatban,nhaxuatban,trigia,ngaynhap);
            db.ExecuteNonQuery(sql);
        }

        public void XoaSach(string masach)
        {
            string sql = "DELETE FROM SACH WHERE MaSach=" + masach;
            db.ExecuteNonQuery(sql);
        }

        public void CapNhatSach(string masach, string tensach, string tacgia, string namxuatban, string nhaxuatban, float trigia, string ngaynhap) 
        {
            string sql = String.Format("UPDATE SACH SET TenSach='N{0}', TacGia=N'{1}', NamXuatBan='{2}'," +
                "NhaXuatBan = N'{3}',TriGia='{4}',NgayNhap='{5}' WHERE MaSach='{6}'", tensach, tacgia,namxuatban,nhaxuatban,trigia,ngaynhap,masach);
            db.ExecuteNonQuery(sql);
        }
    }
}
