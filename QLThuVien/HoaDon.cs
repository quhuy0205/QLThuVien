using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    class HoaDon
    {
        Database db;
        public HoaDon()
        {
            db = new Database();
        }
        public void THEMHOADON(string tenhoadon, int thue, int tongcong, int sotien)
        {
            string sql = String.Format("INSERT INTO HOADON VALUES('{0}','{1}','{2}','{3}')",tenhoadon, thue, tongcong,sotien);   
            db.ExecuteNonQuery(sql);
        }
    }
}
