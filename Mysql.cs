using System;
using System.Collections;
using System.Windows;
// 引入MySQL
using MySql.Data.MySqlClient;

namespace xqf
{
    internal class Mysql
    {                                                    //数据库账户   //密码            //数据库名
        static string constring = "server = 'localhost'; uid = 'root'; pwd = 'Miss@1925'; database = 'test';";   //定义连接mysql字符串
        MySqlConnection sqlCnn = new MySqlConnection(constring);    //连接mysql
        
        public Hashtable Mysql_read()
        {
            string username;
            string password;
            string cmdstring = "select * from code";    //写入sql
            MySqlCommand sqlCmd = new MySqlCommand(cmdstring, sqlCnn);   //创建命令对象  
            Hashtable h = new Hashtable();

            try
            {
                sqlCnn.Open();  //打开数据库
                Console.WriteLine("已经建立连接");
                MySqlDataReader rec = sqlCmd.ExecuteReader();   //执行ExecuteReader()返回一个MySqlDataReader对象

                while (rec.Read())  //初始索引是-1，执行读取下一行数据，返回值是bool
                {
                    username = rec.GetString(0);
                    password = rec.GetString(1);
                    h.Add(username, password);
                }
                return h;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
                return null;
            }
            finally
            {
                sqlCnn.Close();
            }
        }

        public void Mysql_insert(string u, string p)
        {
            try
            {
                sqlCnn.Close();
                sqlCnn.Dispose();
                string insertstring = "insert into code values('" + u + "','" + p + "')";
                MySqlCommand sqlInsert = new MySqlCommand(insertstring, sqlCnn);
                sqlCnn.Open();
                sqlInsert.ExecuteNonQuery();    //插入数据
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                sqlCnn.Close();
            }

        }
    }
}
