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

namespace Coronavirus_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void show(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dane mogą różnić się od stanu faktycznego, ponieważ są pobierane ze strony WHO, gdzie aktualizacja nowych przypadków odbywa się raz dziennie!");
            string country_ = countries.SelectedValue.ToString().Split(':')[1];
            GetData.ChangeToEnglish(country_);
            GetData.GetDataApi();
            //MessageBox.Show(GetData.Confirmed);
            //MessageBox.Show(GetData.Country);
            confirm.Content = GetData.Confirmed;
            recovered.Content = GetData.recovered;
            death.Content = GetData.deaths;
        }
    }
}
