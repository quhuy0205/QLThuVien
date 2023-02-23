using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QLThuVien
{
    class Nhanvien
    {
        Database db;
        public Nhanvien()
        {
            db = new Database();
        }
        public DataTable layDSNhanVien()
        {
            string strSQL = "SELECT MaNhanVien, HoTenNhanVien, " +
                "NgaySinh, DiaChi, DienThoai, TenBangCap " +
                "FROM NHANVIEN N, BANGCAP B Where N.MaBangCap = B.MaBangCap";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public DataTable LayBangCap()
        {
            string strSQL = "SELECT * FROM BANGCAP";
            DataTable dt = db.Execute(strSQL); 
            return dt;
        }

        //Them Nhan Vien
        public void ThemNhanVien(string ten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
            string sql = string.Format("Insert Into NhanVien Values(N'{0}','{1}',N'{2}','{3}',{4})",
           ten, ngaysinh, diachi, dienthoai, index_bc);
            db.ExecuteNonQuery(sql);
        }

        //Xoa nhan vien
        public void XoaNhanVien(string index_nv)
        {
            string sql = "DELETE FROM NHANVIEN WHERE MaNhanVien =" + index_nv;
            db.ExecuteNonQuery(sql);
        }

        //Cap Nhat Nhan Vien
        public void CapNhatNhanVien(string index_nv, string ten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
            string sql = string.Format("UPDATE NHANVIEN SET HoTenNhanVien = N'{0}', NgaySinh = '{1}',DiaChi=N'{2}'," +
                "DienThoai='{3}', MaBangCap='{4}' WHERE MaNhanVien ='{5}'",ten,ngaysinh,diachi,dienthoai,index_bc,index_nv);
            db.ExecuteNonQuery(sql);
        }
    }
}
