using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace digi_timer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 時刻表示用タイマー
        /// </summary>
        private DispatcherTimer timer_;

        public MainWindow()
        {
            InitializeComponent();

            timer_ = CreateTimer();
        }

        /// <summary>
        /// タイマーの生成処理
        /// </summary>
        /// <returns>生成したタイマー</returns>
        private DispatcherTimer CreateTimer()
        {
            var t = new DispatcherTimer(DispatcherPriority.SystemIdle);
            t.Interval = TimeSpan.FromMilliseconds(300);

            t.Tick += (sender, e) =>
            {
                textBlock.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            return t;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            timer_.Start();
        }
    }
}
