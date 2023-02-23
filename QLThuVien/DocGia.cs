using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace QLThuVien
{
    
    class DocGia
    {
        Database db;
        public DocGia()
        {
         db = new Database();
        }
      public DataTable DSDOCGIA()
        {
            string sql = "SELECT * FROM DOCGIA";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        //Them Doc Gia
        public void THEMDOCGIA(string hoten, string ngaysinh, string diachi, string email, string ngaylapthe, string ngayhethan, float tienno )
        {
            string sql = string.Format("INSERT INTO DOCGIA VALUES(N'{0}','{1}',N'{2}','{3}','{4}','{5}','{6}')",
                hoten,ngaysinh,diachi,email,ngaylapthe,ngayhethan,tienno );
            db.ExecuteNonQuery(sql);
        }

        //Xoa Doc Gia

        public void XOADOCGIA(string madocgia)
        {
            string sql = "DELETE FROM DOCGIA WHERE MaDocGia =" + madocgia;
            db.ExecuteNonQuery(sql);
        }

        //Cap Nhat Doc Gia
        public void SUADOCGIA(string madocgia, string hoten, string ngaysinh, string diachi, string email, string ngaylapthe, string ngayhethan, string tienno)
        {
            string sql = string.Format("UPDATE DOCGIA SET HoTenDocGia=N'{0}',NgaySinh='{1}',DiaChi=N'{2}',Email='{3}'," +
                "NgayLapThe='{4}',NgayHetHan='{5}',TienNo='{6}' WHERE MaDocGia = '{7}'",hoten,ngaysinh,diachi,email,ngaylapthe,ngayhethan,tienno,madocgia);
            db.ExecuteNonQuery(sql);
                
        }



    }
}
