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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Class1> class1s { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            //List<string> list = new List<string>() {"Стройка", "Ремонт", "Снос", "Переезд" };
            //phoneList.ItemsSource = list.ToList();
            class1s = new List<Class1>();

            Class1 class1 = new Class1();
            class1.Services = "Ремонт";
            class1.Cost = 400;

            Class1 class2 = new Class1();
            class2.Services = "Стройка";
            class2.Cost = 700;

            Class1 class3 = new Class1();
            class3.Services = "Снос";
            class3.Cost = 1300;

            class1s.Add(class1);
            class1s.Add(class2);
            class1s.Add(class3);

            DataContext=(this);
        }
       
    }
    //public class Amount
    //{
    //    public
    //    List<int> list = new List<int>() { 400, 700, 350, 120 };
    //    return list.ToList();
    //}
}
