using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Effects;
using System.Windows.Navigation;

namespace TheFirstStepToJapan.Pages
{
    /// <summary>
    /// Логика взаимодействия для KarHirMenu.xaml
    /// </summary>
    public partial class KarHirMenu : Page
    {
        BlurEffect effect;

        public Button[] Abc_Buttons = new Button[15];

        public static bool first_start = true;

        public static string temp_info { get; set; }

        public KarHirMenu()
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

            temp_info = "";

            All.Content = "Катакана и\r\nХирагана";

            effect = new BlurEffect();
            effect.Radius = 0;

            Abc_Buttons[0] = aiueo;
            Abc_Buttons[1] = k;
            Abc_Buttons[2] = g;
            Abc_Buttons[3] = s;
            Abc_Buttons[4] = z;
            Abc_Buttons[5] = t;
            Abc_Buttons[6] = d;
            Abc_Buttons[7] = n;
            Abc_Buttons[8] = h;
            Abc_Buttons[9] = b;
            Abc_Buttons[10] = p;
            Abc_Buttons[11] = m;
            Abc_Buttons[12] = y;
            Abc_Buttons[13] = r;
            Abc_Buttons[14] = w;

            for (int i = 0; i < 15; i++)
            {
                Abc_Buttons[i].Tag = "0";
                Abc_Buttons[i].Click += new RoutedEventHandler(abc_Click);
                Abc_Buttons[i].KeyDown += abc_KeyDown;
                Abc_Buttons[i].MouseMove += abc_MouseMove;
            }

            if (first_start)
                show_help(true);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu1());
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            temp_info = info_But();
            NavigationService.Navigate(new Test());
        }

        private void learn_Click(object sender, RoutedEventArgs e)
        {
            temp_info = info_But();
            NavigationService.Navigate(new Learn());
        }

        public string info_But()
        {
            string str = "";

            for (int i = 0; i < 15; i++)
                str += Abc_Buttons[i].Tag;

            return str;
        }

        public void checkEnable()
        {
            test.IsEnabled = info_But().CompareTo("000000000000000") != 0;
            learn.IsEnabled = info_But().CompareTo("000000000000000") != 0;
        }

        private void abc_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).Focus();
            if (Keyboard.IsKeyDown(Key.D1))
            {
                select_Kat((Button)sender);
            }
            else
            if (Keyboard.IsKeyDown(Key.D2))
            {
                select_Hir((Button)sender);
            }
            else
            if (Keyboard.IsKeyDown(Key.D3))
            {
                select_All((Button)sender);
            }
            else
            if (Keyboard.IsKeyDown(Key.D4))
            {
                select_Reset((Button)sender);
            }
        }

        private void abc_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Background == Kat.Background)
                select_Hir((Button)sender);
            else
            if (((Button)sender).Background == Hir.Background)
                select_All((Button)sender);
            else
            if (((Button)sender).Background == All.Background)
                select_Reset((Button)sender);
            else
                select_Kat((Button)sender);
        }

        private void abc_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.D1))
            {
                select_Kat((Button)sender);
            }
            else
            if (Keyboard.IsKeyDown(Key.D2))
            {
                select_Hir((Button)sender);
            }
            else
            if (Keyboard.IsKeyDown(Key.D3))
            {
                select_All((Button)sender);
            }
            else
            if (Keyboard.IsKeyDown(Key.D4))
            {
                select_Reset((Button)sender);
            }

            if (Keyboard.IsKeyDown(Key.Escape))
            {
                back_Click(null, null);
            }
        }

        public void select_Kat(Button b)
        {
            b.Tag = "2";
            b.Background = Kat.Background;
            checkEnable();
        }

        public void select_Hir(Button b)
        {
            b.Tag = "1";
            b.Background = Hir.Background;
            checkEnable();
        }

        public void select_All(Button b)
        {
            b.Tag = "3";
            b.Background = All.Background;
            checkEnable();
        }

        public void select_Reset(Button b)
        {
            b.Tag = "0";
            b.Background = Reset.Background;
            checkEnable();
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
                if (fon_black.Height == 0)
                    back_Click(null, null);
                else
                    show_help(false);
            }           
        }

        private void Kat_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 15; i++)
                select_Kat(Abc_Buttons[i]);
        }

        private void Hir_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 15; i++)
                select_Hir(Abc_Buttons[i]);
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 15; i++)
                select_All(Abc_Buttons[i]);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 15; i++)
                select_Reset(Abc_Buttons[i]);
        }
        private void grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon_black.Height != 0)
                show_help(false);
        }

        public void show_help(bool f)
        {
            if (f)
            {
                text.Margin = new Thickness(100, 100, 100, 100);
                fon_black.Height = grid.Height + 10;
                fon_black.Width = grid.Width + 10;
                fon_black_copy.Height = grid.Height + 10;
                fon_black_copy.Width = grid.Width + 10;
                effect.Radius = 10;

                first_start = false;
            }
            else
            {
                text.Margin = new Thickness(8000, 8000, 8000, 8000);
                fon_black.Height = 0;
                fon_black.Width = 0;
                fon_black_copy.Height = 0;
                fon_black_copy.Width = 0;

                effect.Radius = 0;
            }

            try
            {
                fon.Focus();
            }
            catch { }

            Back.Effect = effect;

            test.Effect = effect;
            learn.Effect = effect;

            Kat.Effect = effect;
            Hir.Effect = effect;
            All.Effect = effect;
            Reset.Effect = effect;
            help.Effect = effect;
            Text_but.Effect = effect;

            for (int i = 0; i < 15; i++)
            {
                Abc_Buttons[i].Effect = effect;
            }
        }

        private void grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            try
            {
                double newSize = 10 + e.NewSize.Width / 80;

                Back.FontSize = newSize;

                test.FontSize = newSize;
                learn.FontSize = newSize;

                Kat.FontSize = newSize;
                Hir.FontSize = newSize;
                All.FontSize = newSize;
                Reset.FontSize = newSize;
                help.FontSize = newSize;
                text.FontSize = newSize;
                Text_but.FontSize = newSize;

                for (int i = 0; i < 15; i++)
                {
                    Abc_Buttons[i].FontSize = newSize;
                }
            }
            catch
            { 
            
            }
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Help());
        }
    }
}
