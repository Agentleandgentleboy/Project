using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace xqf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public int play_state = 1;
        public MainWindow()
        {
            InitializeComponent();

            #region 登录界面加载及验证
            //显示登陆界面，验证后返回。
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            if (loginWindow.DialogResult != Convert.ToBoolean(1))
            {
                this.Close();
            }
            //显示登陆界面 结束
            #endregion
        }
        //窗口设置自由移动
        private void MoveWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        #region 窗体放大、还原、缩小、关闭功能实现
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaxOrNormal_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                // 如果窗口已经最大化，则恢恢复为正常大小
                this.WindowState = WindowState.Normal;

                //更改按钮样式
                btnmax.Content = "☐";
            }
            else
            {
                // 否则，窗口为正常时，将其最大化
                this.WindowState = WindowState.Maximized;

                //更改按钮样式
                btnmax.Content = "[-]";
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        # region 音乐播放设置
        //音乐播放、暂停功能实现
        private void Music_Play(object sender, RoutedEventArgs e)
        {
            mediaElement1.Source = new Uri("D:\\1.mp3");

            if (play_state == 1)
            {
                mediaElement1.Play();
                play_state = 2;

            }
            else
            {
                mediaElement1.Pause();
                play_state = 1;
            }
        }

        //设置音频播放进度、音量调节显示
        DispatcherTimer timer = null;
        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            sliderPosition.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalSeconds;
            //媒体文件打开成功
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
        }
        private void timer_tick(object sender, EventArgs e)
        {
            sliderPosition.Value = mediaElement1.Position.TotalSeconds; //歌曲播放时长对应的滑块位置
        }
        //控制视频的位置
        private void sliderPosition_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //mediaElement.Stop();
            mediaElement1.Position = TimeSpan.FromSeconds(sliderPosition.Value);
            //mediaElement.Play();
        }
        #endregion
    }
}
