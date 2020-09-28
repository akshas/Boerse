using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Collections.ObjectModel;
using System.Data;

namespace Boerse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AktienTable.ItemsSource = Aktie.getAktien();

            
            Task.Run(Aktie.changePrice);
        }

        private void OnVerkaufenBtnClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Grid Parent = (Grid)btn.Parent;

            string KaufenTextboxAngaben = Parent.Children.OfType<TextBox>().First().Text;

            Aktie obj = ((FrameworkElement)sender).DataContext as Aktie;
            MessageBox.Show(obj.Name.ToString());

            Int32.TryParse(KaufenTextboxAngaben, out int AnzahlAktien);
            Trader.Verkaufen(AnzahlAktien, obj);

        }

        private void OnKaufenBtnClick(object sender, RoutedEventArgs e)
        {
            Aktie obj = ((FrameworkElement)sender).DataContext as Aktie;

            Button btn = (Button)sender;
            Grid Parent = (Grid)btn.Parent;

            string KaufenTextboxAngaben = Parent.Children.OfType<TextBox>().First().Text;

            Int32.TryParse(KaufenTextboxAngaben, out int AnzahlAktien);

            Trader.Kaufen(AnzahlAktien, obj);
            MeineAktienList.ItemsSource = Trader.getMeineAktien();
        }
    }
}
