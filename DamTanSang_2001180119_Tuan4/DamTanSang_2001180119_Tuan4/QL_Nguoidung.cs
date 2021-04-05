using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
namespace DamTanSang_2001180119_Tuan4
{
    public class QL_Nguoidung
    {
        public int Check_Config()
        {
            if(Properties.Settings.Default.ChuoiKetNoi==string.Empty)
                return 1;//chuổi cấu hình không tồn tại
            SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.ChuoiKetNoi);
            try
            {
                if(sqlcon.State==System.Data.ConnectionState.Closed)
                    sqlcon.Open();
                    return 0;//kết nối thành công chuổi cấu hình hợp lệ
            }
            catch 
            {
                return 2;//chuổi cấu hình không phù hợp
            }
        }
        public int Check_User(string user,string pass)
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from QL_NguoiDung where TenDangNhap='" + user + "'and MatKhau='" + pass + "'", Properties.Settings.Default.ChuoiKetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
                return 10;//user không tồn tại
            else if(dt.Rows[0][2]==null ||dt.Rows[0][2].ToString()=="False")
            {
                return 20;//không thành công
            }
            return 30;//đăng nhập thành công
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable GetDBName(string pServer,String user,string pass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source= " + pServer + ";Initial Catalog=master;User ID=" + user + ";pwd=" + pass + "");
            da.Fill(dt);
            return dt;
        }
    }
}
