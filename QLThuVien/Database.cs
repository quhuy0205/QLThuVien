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
    class Database
    {
        SqlConnection sqlConn; //Doi tuong ket noi csdl
        SqlDataAdapter da; //Bo dieu phoi csdl
        DataSet ds; //Doi tuong chua CSDL khi giao tiep
    public Database()
    {
            string strCnn = "Data Source=DESKTOP-2HTK7U0\\SQLEXPRESS; Database=QLthuvien; Integrated Security = True";
        sqlConn = new SqlConnection(strCnn);
    }
        //Phuong thuc thuc hien cau lenh truy van du lieu
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        //Phuong thuc thuc hien cau lenh them xoa sua
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();// Mo ket noi
            sqlcmd.ExecuteNonQuery(); //Lenh thuc hien them xoa sua
            sqlConn.Close(); //Dong ket noi
        }
    }
}
