using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Input;
namespace MediaPlayer
{
    /// <summary>
    /// MainWindow.xaml的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // 播放媒体
        void OnMouseDownPlayMedia(object sender, MouseButtonEventArgs args)
        {   // Play命令将播放不活动的或暂停的媒体；此命令对正在播放的媒体不起作用
            myMediaElement.Play();
            InitializePropertyValues();// 初始化MediaElement属性值
        }
        // 暂停媒体播放
        void OnMouseDownPauseMedia(object sender, MouseButtonEventArgs args)
        {
            myMediaElement.Pause();//暂停正在播放的媒体；可使用Play命令继续播放
        }
        // 停止媒体播放
        void OnMouseDownStopMedia(object sender, MouseButtonEventArgs args)
        {
            myMediaElement.Stop();  //停止媒体的播放
        }
        // 改变媒体播放的音量
        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            myMediaElement.Volume = (double)volumeSlider.Value;
        }
        // 改变媒体播放的速度
        private void ChangeMediaSpeedRatio(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            myMediaElement.SpeedRatio = (double)speedRatioSlider.Value;
        }
        // 打开媒体时，将Seek To初始化为最大值（媒体长度，ms为单位）
        private void Element_MediaOpened(object sender, EventArgs e)
        {
            timelineSlider.Maximum = myMediaElement.NaturalDuration.TimeSpan.TotalMilliseconds;
        }
        // 当媒体完成重放，使用Stop()搜索媒体的起始部分
        private void Element_MediaEnded(object sender, EventArgs e)
        {
            myMediaElement.Stop();
        }
        // 跳转到媒体的不同部分(seek to)
        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            int SliderValue = (int)timelineSlider.Value;
            // 重载构造函数，使用参数：days, hours, minutes, seconds, miniseconds
            // 创建TimeSpan对象，使之等于当前游标的值
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            myMediaElement.Position = ts;
        }
        void InitializePropertyValues()
        {   // 设置媒体的音量Volume和速率SpeedRatio等于当前游标的值
            myMediaElement.Volume = (double)volumeSlider.Value;
            myMediaElement.SpeedRatio = (double)speedRatioSlider.Value;
        }
    }
}
