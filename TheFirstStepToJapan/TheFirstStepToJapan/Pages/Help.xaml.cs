using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Effects;
using System.Windows.Navigation;

namespace TheFirstStepToJapan.Pages
{
    /// <summary>
    /// Логика взаимодействия для Help.xaml
    /// </summary>
    public partial class Help : Page
    {
        BlurEffect effect;
        bool flag_pic = false;
        Image im_temp;

        public Help()
        {
            InitializeComponent();

            text.Text =
                "Чтобы быстро выбрать символы вы можете:\r\n" +
                "Зажать одну из клавиш и провести мышкой по символам.\r\n" +
                "Клавиши:\r\n" +
                "1 - \"Катакана\"\r\n" +
                "2 - \"Хирагана\"\r\n" +
                "3 - \"Перемешать\"\r\n" +
                "4 - \"Сброс\".";

            kat.Content = "Показать\r\nкатакану";
            hir.Content = "Показать\r\nхирагану";

            effect = new BlurEffect();
            effect.Radius = 0;
        }

        private void fon_MouseMove(object sender, MouseEventArgs e)
        {
            try { ((Button)sender).Focus(); }
            catch { }
        }
        
        private void fon_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Escape))
            {
                if (!flag_pic)
                    back_Click(null, null);
                else
                    hiddenAll(false, im_temp);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KarHirMenu());
        }

        private void kat_Click(object sender, RoutedEventArgs e)
        {
            im_temp = Abc;
            hiddenAll(true, im_temp);
        }

        private void hir_Click(object sender, RoutedEventArgs e)
        {
            im_temp = Abc2;
            hiddenAll(true, im_temp);
        }

        public void hiddenAll(bool flag, Image im = null)
        {
            if (flag)
            {
                flag_pic = true;
                effect.Radius = 10;
                im.Margin = new Thickness(100, 100, 100, 100);
                im.Opacity = 1;
                fon_black.Height = grid.Height + 10;
                fon_black.Width = grid.Width + 10;
            }
            else
            {

                flag_pic = false;
                effect.Radius = 0;
                im.Margin = new Thickness(8000, 8000, 8000, 8000);
                im.Opacity = 0;

                fon_black.Height = 0;
                fon_black.Width = 0;
            }

            try
            {
                fon.Focus();
            }
            catch { }

            text.Effect = effect;
            Back.Effect = effect;
            kat.Effect = effect;
            hir.Effect = effect;
        }



        private void grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            try
            {
                double newSize = 10 + e.NewSize.Width / 80;

                Back.FontSize = newSize;
                text.FontSize = newSize;
                kat.FontSize = newSize;
                hir.FontSize = newSize;
            }
            catch
            {

            }
        }

        private void grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            if (flag_pic)
            {
                hiddenAll(false, im_temp);
            }
            
        }

        private void fon_Click(object sender, RoutedEventArgs e)
        {
            
            if (flag_pic)
            {
                hiddenAll(false, im_temp);
            }
            
        }
    }
}
