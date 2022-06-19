using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;
using System.Windows.Input;
using Window = System.Windows.Window;

namespace xqf
{
    /// <summary>
    /// Registered.xaml 的交互逻辑
    /// </summary>
    public partial class Registered : Window
    {
        public static Hashtable userall;
        public Registered()
        {
            InitializeComponent();
        }
        private void MoveWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)     //主页面
        {
            DragMove();
        }

        private void ReClose_Click(object sender, RoutedEventArgs e)      //关闭窗口
        {
            this.Close();
        }

        private void Register_Button(object sender, RoutedEventArgs e)   //注册点击事件
        {
            string u = Re_Account.Text.ToString();           //账户
            string p = Re_Password.Password.ToString();        //密码
            string rp = Re_PasswordAgain.Password.ToString();   //确认密码
            Mysql mysql = new Mysql();            //数据库


            if (String.IsNullOrEmpty(u))            //判读是否有账户
            {
                MessageBox.Show("不能为空 user is not null");
                return;
            }
            if (String.IsNullOrEmpty(p))
            {
                MessageBox.Show("password is not null");
                return;
            }
            if (String.IsNullOrEmpty(rp))
            {
                MessageBox.Show("Repassword is not null");
                return;
            }
            if (!p.Equals(rp))
            {
                MessageBox.Show("password is not equals repassword");
                return;
            }

            userall = mysql.Mysql_read();
            if (userall == null)
            {
                userall = new Hashtable();
                userall.Add(u, p);
            }
            else
            {
                bool isexist = userall.ContainsKey(u);  //判断用户是否存在
                if (isexist)
                {
                    MessageBox.Show("user is exist!");
                    return;
                }
                else
                {
                    userall.Add(u, p);
                    Console.WriteLine(userall.Count);
                }
            }

            System.Windows.Application.Current.Properties["users"] = userall;   //类似于Session的功能,用户登录后，可以将用户的信息保存在Properties中。
            mysql.Mysql_insert(u, p);
            MessageBox.Show("regist success!");


            MainWindow main = new MainWindow();
            main.WindowStartupLocation = WindowStartupLocation.Manual;   //使新窗口位置在原来的位置上
            main.Left = this.Left;  //使新窗口位置在原来的位置上
            main.Top = this.Top;  //使新窗口位置在原来的位置上
            this.Close();
            main.ShowDialog();  //打开新窗口         
        }
    }
}
