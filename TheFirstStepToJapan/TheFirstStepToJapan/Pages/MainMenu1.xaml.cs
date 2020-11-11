using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TheFirstStepToJapan.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu1.xaml
    /// </summary>
    public partial class MainMenu1 : Page
    {
        public MainMenu1()
        {     
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KarHirMenu());
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            try
            {
                double newSize = 10 + e.NewSize.Width / 80;

                katHir.FontSize = newSize;
                word.FontSize = newSize;
            }
            catch
            {

            }
        }
    }
}
