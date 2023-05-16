using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GooseExpress.Wind
{
    /// <summary>
    /// Логика взаимодействия для MainWind.xaml
    /// </summary>
    public partial class MainWind : Window
    {
        public MainWind()
        {
            InitializeComponent();
            Main.TextDecorations = TextDecorations.Underline;

        }
        Point scrollMousePoint = new Point();
        double hOff = 1;
        private void scrollViewer_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            scrollMousePoint = e.GetPosition(scrollViewer);
            hOff = scrollViewer.HorizontalOffset;
            scrollViewer.CaptureMouse();
        }

        private void scrollViewer_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (scrollViewer.IsMouseCaptured)
            {
                scrollViewer.ScrollToHorizontalOffset(hOff + (scrollMousePoint.X - e.GetPosition(scrollViewer).X));
            }
        }

        private void scrollViewer_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            scrollViewer.ReleaseMouseCapture();
        }

        private void scrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + e.Delta);
        }

        private void btnreturn_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            SettingWind settingWind = new SettingWind();
            settingWind.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SenderWind senderWind = new SenderWind();
            senderWind.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            HistoryOrderWind historyOrderWind = new HistoryOrderWind();
            historyOrderWind.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AboutCompanyWind aboutCompanyWind = new AboutCompanyWind();
            aboutCompanyWind.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OrderStatus orderStatus = new OrderStatus();
            orderStatus.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FeedBackWind feedBackWind = new FeedBackWind();
            feedBackWind.Show();
            this.Close();
        }

    }
}
