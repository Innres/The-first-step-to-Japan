using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace TheFirstStepToJapan.Pages
{
    /// <summary>
    /// Логика взаимодействия для KarHirMenu.xaml
    /// </summary>
    public partial class KarHirMenu : Page
    {
        public Button[] Abc_Buttons = new Button[15];
        public KarHirMenu()
        {
            InitializeComponent();

            All.Content = "Катакана и\r\nХирагана";

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
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu1());
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText("fisrtStepTemp.txt", info_But());
            NavigationService.Navigate(new Test());
        }

        private void learn_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText("fisrtStepTemp.txt", info_But());
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
                back_Click(null, null);
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
