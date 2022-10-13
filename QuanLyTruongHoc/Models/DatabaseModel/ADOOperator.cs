using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADOOperator
    {
        private SqlConnection connection;
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private string sql;


        public ADOOperator(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error ! " + ex.Message, "Information");
                    return false;
                }
            }
            return true;
        }

        private bool CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error! " + ex.Message, "Information");
                    return false;
                }
            }
            return true;
        }

        public bool ExecuteNonQuery(string sql, SqlParameter[] sqlParameter = null)
        {
            try
            {
                if (OpenConnection())
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    if (sqlParameter != null)
                    {
                        command.Parameters.AddRange(sqlParameter);
                    }
                    return command.ExecuteNonQuery() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ExecuteNonQuery Error ! " + ex.Message, "Information");
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable ExecuteQuery(string sql, SqlParameter[] sqlParameters = null)
        {
            try
            {
                if (OpenConnection())
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    if (sqlParameters != null)
                    {
                        command.Parameters.AddRange(sqlParameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    CloseConnection();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ExecuteQuery Error ! " + ex.Message, "Information");
            }
            return null;
        }
        public DataTable SelectData(string sql, List<CustomParameter> lstPara = null)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);//nội dung sql đc truyền vào
                cmd.CommandType = CommandType.StoredProcedure;//set command type cho cmd
                foreach (var para in lstPara)//gán các tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();//mở kết nối
                cmd = new SqlCommand(sql, conn);//truyền giá trị vào cmd
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());//thực thi câu lệnh
                return dt.Rows[0];//trả về kết quả
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();//cuối cùng đóng kết nối
            }
        }
        public DataTable SelectTable(string sql)
        {
            try
            {
                conn.Open();//mở kết nối
                cmd = new SqlCommand(sql, conn);//truyền giá trị vào cmd
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());//thực thi câu lệnh
                return dt;//trả về kết quả
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();//cuối cùng đóng kết nối
            }
        }

        public int ExeCute(string sql, List<CustomParameter> lstPara = null)
        {
            try
            {
                //cần sửa lại hàm execute như sau
                //string sql,List<CustomParameter> lstPara là tham số truyền vào 
                conn.Open();//mở kết nối
                cmd = new SqlCommand(sql, conn);//thực thi câu lệnh sql
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)//gán các tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();//lấy kết quả thực thi truy vấn
                return (int)rs;//trả về kết quả
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();//cuối cùng đóng kết nối
            }
        }

    }
}

