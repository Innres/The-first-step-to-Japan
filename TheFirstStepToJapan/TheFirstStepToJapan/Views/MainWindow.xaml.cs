using System.Windows;
using TheFirstStepToJapan.Pages;

namespace TheFirstStepToJapan
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent();
            frm.Content = new Pages.MainMenu1();
            DataContext = new MainMenu1();
            MaxHeight = 7900;
            MaxWidth = 7900;
        }

    }
}
