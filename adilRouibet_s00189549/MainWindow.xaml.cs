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

namespace adilRouibet_s00189549
{  
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhonesDataBase db = new PhonesDataBase();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender , RoutedEventArgs e)
        {
            var query = from p in db.phones
                        select p;

            listBox.ItemsSource = query.ToList();
            listBox.SelectedItem = 0;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selectedPhone = listBox.SelectedItem as Phone;

            textBlock.Text = string.Format("{0:c}", selectedPhone.Price);
            image.Source = new BitmapImage(new Uri(selectedPhone.Phone_Image, UriKind.Relative));
        }
    }
}
