using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using Window = System.Windows.Window;

namespace xqf
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public string UserName;
        public string UserPassword;
        public int border = 1;
        public static Hashtable userall_harsh;

        public LoginWindow()
        {
            InitializeComponent();
        }
        private void MoveWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #region mysql 使用账户数据
        private void Login_Button(object sender, RoutedEventArgs e)
        {
            Mysql mysql = new Mysql();
            userall_harsh = mysql.Mysql_read();

            if (userall_harsh == null)
            {
                MessageBox.Show("无此账户，请先注册!");
                return;
            }
            else
            {

                IDictionaryEnumerator myEnumerator = userall_harsh.GetEnumerator();  //读取harshtable中的key和value值
                while (myEnumerator.MoveNext()) //将枚举数推到集合的下一元素，若为空，则退出循环
                {

                    UserName = myEnumerator.Key.ToString();         //key值赋给UserName
                    UserPassword = myEnumerator.Value.ToString();    //value值赋给UserPassword

                    if (Account.Text.ToString() == UserName && Password.Password.ToString() == UserPassword)
                    {
                        this.DialogResult = Convert.ToBoolean(1);
                        this.Close();
                        break;
                    }
                    else if (border <= userall_harsh.Count - 1)      //给循环一边界，若循环到所存数据最后一个数仍然不正确，则执行else语句
                    {
                        border++;
                    }
                    else
                        MessageBox.Show("账号或密码错误，请重试！");
                }
            }

        }
        #endregion

        //“注册账户”TextBlock触发事件
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Registered register1 = new Registered();  //Login为窗口名，把要跳转的新窗口实例化
            this.Close();  //关闭当前窗口
            register1.ShowDialog();   //打开新窗口          
        }
    }
}
