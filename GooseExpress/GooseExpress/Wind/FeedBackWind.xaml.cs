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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace GooseExpress.Wind
{
    /// <summary>
    /// Логика взаимодействия для FeedBackWind.xaml
    /// </summary>
    public partial class FeedBackWind : Window
    {
        public FeedBackWind()
        {
            InitializeComponent();
            Feedback.TextDecorations = TextDecorations.Underline;
        }

        Point scrollMousePoint = new Point();
        double hOff = 1;
        private void scrollViewer_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            scrollMousePoint = e.GetPosition(scrollViewer);
            hOff = scrollViewer.VerticalOffset;
            scrollViewer.CaptureMouse();
        }

        private void scrollViewer_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (scrollViewer.IsMouseCaptured)
            {
                scrollViewer.ScrollToVerticalOffset(hOff + (scrollMousePoint.Y - e.GetPosition(scrollViewer).Y));
            }
        }

        private void scrollViewer_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            scrollViewer.ReleaseMouseCapture();
        }

        private void scrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + e.Delta);
        }
        Point scrollMousePoint2 = new Point();
        double hOff2 = 1;
        private void scrollViewer2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            scrollMousePoint2 = e.GetPosition(scrollViewer2);
            hOff2 = scrollViewer2.VerticalOffset;
            scrollViewer2.CaptureMouse();
        }

        private void scrollViewer2_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (scrollViewer2.IsMouseCaptured)
            {
                scrollViewer2.ScrollToVerticalOffset(hOff2 + (scrollMousePoint2.Y - e.GetPosition(scrollViewer2).Y));
            }
        }

        private void scrollViewer2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            scrollViewer2.ReleaseMouseCapture();
        }

        private void scrollViewer2_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            scrollViewer2.ScrollToVerticalOffset(scrollViewer2.VerticalOffset + e.Delta);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AboutCompanyWind aboutCompanyWind = new AboutCompanyWind();
            aboutCompanyWind.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainWind mainWind = new MainWind();
            mainWind.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            OrderStatus orderStatus = new OrderStatus();
            orderStatus.Show();
            this.Close();
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
    }
}
