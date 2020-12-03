using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Effects;
using System.Windows.Navigation;

namespace TheFirstStepToJapan.Pages
{
    /// <summary>
    /// Логика взаимодействия для Learn.xaml
    /// </summary>
    public partial class Learn : Page
    {
        BlurEffect effect;
        string[] allword;
        string[] answer;
        int size = 0;
        int size_n = 1;
        int n = 0;
        int[] my_random;
        int attempt = 0;
        bool flag_pic = false;

        Image im_temp;

        public Learn()
        {
            InitializeComponent();

            answer = new string[5];
            add_Word.Content = "Следующий\r\nзвук";

            string temp = KarHirMenu.temp_info;

            for (int i = 0; i < temp.Length; i++)
                if (temp[i] == '1' || temp[i] == '2')
                    size += ((i != 12) && (i != 14)) ? 5 : 3;
                else
                    if (temp[i] == '3')
                    size += ((i != 12) && (i != 14)) ? 10 : 6;
            allword = new string[size];

            my_random = new int[size];
            for (int i = 0; i < size; i++)
                my_random[i] = 3;

            effect = new BlurEffect();
            effect.Radius = 0;

            update_proportion();
            update_word_stat();

            //------------

            if ((temp[0] == '1') || (temp[0] == '3'))
            {
                allword[n++] = "0aあ";
                allword[n++] = "0iい";
                allword[n++] = "0uう";
                allword[n++] = "0eえ";
                allword[n++] = "0oお";
            }
            if ((temp[0] == '2') || (temp[0] == '3'))
            {
                allword[n++] = "1aア";
                allword[n++] = "1iイ";
                allword[n++] = "1uウ";
                allword[n++] = "1e工";
                allword[n++] = "1oオ";
            }

            //------------

            if ((temp[1] == '1') || (temp[1] == '3'))
            {
                allword[n++] = "0kaか";
                allword[n++] = "0kiき";
                allword[n++] = "0kuく";
                allword[n++] = "0keけ";
                allword[n++] = "0koこ";
            }
            if ((temp[1] == '2') || (temp[1] == '3'))
            {
                allword[n++] = "1kaカ";
                allword[n++] = "1kiキ";
                allword[n++] = "1kuク";
                allword[n++] = "1keケ";
                allword[n++] = "1koコ";
            }

            //------------

            if ((temp[2] == '1') || (temp[2] == '3'))
            {
                allword[n++] = "0gaが";
                allword[n++] = "0giぎ";
                allword[n++] = "0guぐ";
                allword[n++] = "0geげ";
                allword[n++] = "0goご";
            }
            if ((temp[2] == '2') || (temp[2] == '3'))
            {
                allword[n++] = "1gaガ";
                allword[n++] = "1giギ";
                allword[n++] = "1guグ";
                allword[n++] = "1geゲ";
                allword[n++] = "1goゴ";
            }

            //------------

            if ((temp[3] == '1') || (temp[3] == '3'))
            {
                allword[n++] = "0saさ";
                allword[n++] = "0shiし";
                allword[n++] = "0suす";
                allword[n++] = "0seせ";
                allword[n++] = "0soそ";
            }
            if ((temp[3] == '2') || (temp[3] == '3'))
            {
                allword[n++] = "1saサ";
                allword[n++] = "1shiシ";
                allword[n++] = "1suス";
                allword[n++] = "1seセ";
                allword[n++] = "1soソ";
            }

            //------------

            if ((temp[4] == '1') || (temp[4] == '3'))
            {
                allword[n++] = "0zaざ";
                allword[n++] = "0jiじ";
                allword[n++] = "0zu(z)ず";
                allword[n++] = "0zeぜ";
                allword[n++] = "0zoぞ";
            }
            if ((temp[4] == '2') || (temp[4] == '3'))
            {
                allword[n++] = "1zaザ";
                allword[n++] = "1jiジ";
                allword[n++] = "1zu(z)ズ";
                allword[n++] = "1zeゼ";
                allword[n++] = "1zoゾ";
            }

            //------------

            if ((temp[5] == '1') || (temp[5] == '3'))
            {
                allword[n++] = "0taた";
                allword[n++] = "0chiち";
                allword[n++] = "0tsuつ";
                allword[n++] = "0teて";
                allword[n++] = "0toと";
            }
            if ((temp[5] == '2') || (temp[5] == '3'))
            {
                allword[n++] = "1taタ";
                allword[n++] = "1chiチ";
                allword[n++] = "1tsuツ";
                allword[n++] = "1teテ";
                allword[n++] = "1toト";
            }

            //------------

            if ((temp[6] == '1') || (temp[6] == '3'))
            {
                allword[n++] = "0daだ";
                allword[n++] = "0jiぢ";
                allword[n++] = "0zu(d)づ";
                allword[n++] = "0deで";
                allword[n++] = "0doど";
            }
            if ((temp[6] == '2') || (temp[6] == '3'))
            {
                allword[n++] = "1daダ";
                allword[n++] = "1diヂ";
                allword[n++] = "1duジ";
                allword[n++] = "1deデ";
                allword[n++] = "1doド";
            }

            //------------

            if ((temp[7] == '1') || (temp[7] == '3'))
            {
                allword[n++] = "0naな";
                allword[n++] = "0niに";
                allword[n++] = "0nuぬ";
                allword[n++] = "0neね";
                allword[n++] = "0noの";
            }
            if ((temp[7] == '2') || (temp[7] == '3'))
            {
                allword[n++] = "1naナ";
                allword[n++] = "1niニ";
                allword[n++] = "1nuヌ";
                allword[n++] = "1neネ";
                allword[n++] = "1noノ";
            }

            //------------

            if ((temp[8] == '1') || (temp[8] == '3'))
            {
                allword[n++] = "0haは";
                allword[n++] = "0hiひ";
                allword[n++] = "0fuふ";
                allword[n++] = "0heへ";
                allword[n++] = "0hoほ";
            }
            if ((temp[8] == '2') || (temp[8] == '3'))
            {
                allword[n++] = "1haハ";
                allword[n++] = "1hiヒ";
                allword[n++] = "1fuフ";
                allword[n++] = "1heへ";
                allword[n++] = "1hoホ";
            }

            //------------

            if ((temp[9] == '1') || (temp[9] == '3'))
            {
                allword[n++] = "0baば";
                allword[n++] = "0biび";
                allword[n++] = "0buぶ";
                allword[n++] = "0beべ";
                allword[n++] = "0boぼ";
            }
            if ((temp[9] == '2') || (temp[9] == '3'))
            {
                allword[n++] = "1baバ";
                allword[n++] = "1biビ";
                allword[n++] = "1buブ";
                allword[n++] = "1beべ";
                allword[n++] = "1boボ";
            }

            //------------

            if ((temp[10] == '1') || (temp[10] == '3'))
            {
                allword[n++] = "0paぱ";
                allword[n++] = "0piぴ";
                allword[n++] = "0puぷ";
                allword[n++] = "0peぺ";
                allword[n++] = "0poぽ";
            }
            if ((temp[10] == '2') || (temp[10] == '3'))
            {
                allword[n++] = "1paパ";
                allword[n++] = "1piピ";
                allword[n++] = "1puプ";
                allword[n++] = "1peぺ";
                allword[n++] = "1poポ";
            }

            //------------
            if ((temp[11] == '1') || (temp[11] == '3'))
            {
                allword[n++] = "0maま";
                allword[n++] = "0miみ";
                allword[n++] = "0muむ";
                allword[n++] = "0meめ";
                allword[n++] = "0moも";
            }
            if ((temp[11] == '2') || (temp[11] == '3'))
            {
                allword[n++] = "1maマ";
                allword[n++] = "1miミ";
                allword[n++] = "1muム";
                allword[n++] = "1meメ";
                allword[n++] = "1moモ";
            }

            //------------

            if ((temp[12] == '1') || (temp[12] == '3'))
            {
                allword[n++] = "0yaや";
                allword[n++] = "0yuゆ";
                allword[n++] = "0yoよ";
            }
            if ((temp[12] == '2') || (temp[12] == '3'))
            {
                allword[n++] = "1yaヤ";
                allword[n++] = "1yuユ";
                allword[n++] = "1yoヨ";
            }

            //------------

            if ((temp[13] == '1') || (temp[13] == '3'))
            {
                allword[n++] = "0raら";
                allword[n++] = "0riり";
                allword[n++] = "0ruる";
                allword[n++] = "0reれ";
                allword[n++] = "0roろ";
            }
            if ((temp[13] == '2') || (temp[13] == '3'))
            {
                allword[n++] = "1raラ";
                allword[n++] = "1riリ";
                allword[n++] = "1ruル";
                allword[n++] = "1reレ";
                allword[n++] = "1roロ";
            }

            //------------

            if ((temp[14] == '1') || (temp[14] == '3'))
            {
                allword[n++] = "0waわ";
                allword[n++] = "0nん";
                allword[n++] = "0woを";
            }
            if ((temp[14] == '2') || (temp[14] == '3'))
            {
                allword[n++] = "1waワ";
                allword[n++] = "1nン";
                allword[n++] = "1woヲ";
            }

            //------------

            Random rnd = new Random();
            int value = rnd.Next(0, 10);

            for (int i = 1; i < 5; i++)
                answer[i] = "";

            answer[0] = allword[rnd.Next(0, size_n)];

            answer[rnd.Next(1, 5)] = answer[0];

            for (int i = 1; i < 5; i++)
                if (answer[i].Length == 0)
                    answer[i] = allword[rnd.Next(0, size_n)];


            text.Text = answer[0].Substring(1, answer[0].Length - 2);
            text.Foreground = (answer[0][0] == '0') ? hir.Foreground : kat.Foreground;

            b1.Content = answer[1].Substring(answer[1].Length - 1);
            b1.Foreground = Back.Foreground;
            b2.Content = answer[2].Substring(answer[2].Length - 1);
            b2.Foreground = Back.Foreground;
            b3.Content = answer[3].Substring(answer[3].Length - 1);
            b3.Foreground = Back.Foreground;
            b4.Content = answer[4].Substring(answer[4].Length - 1);
            b4.Foreground = Back.Foreground;

        }

        public bool check_answer(string tag)
        {
            return (answer[0].Substring(1).CompareTo(answer[Int32.Parse(tag)].Substring(1)) == 0);
        }

        public bool check_rand(int n)
        {
            int sum = 0;

            for (int i = 0; i < size_n; i++)
                sum += my_random[i];

            if (sum <= 0)
                for (int i = 0; i < size; i++)
                    my_random[i] = 3;

            return my_random[n] == 0;
        }

        public void update_Buttons()
        {
            b1.IsEnabled = true;
            b1.Background = Back.Background;
            f1.Margin = new Thickness(8000, 8000, 8000, 8000);
            b2.IsEnabled = true;
            b2.Background = Back.Background;
            f2.Margin = new Thickness(8000, 8000, 8000, 8000);
            b3.IsEnabled = true;
            b3.Background = Back.Background;
            f3.Margin = new Thickness(8000, 8000, 8000, 8000);
            b4.IsEnabled = true;
            b4.Background = Back.Background;
            f4.Margin = new Thickness(8000, 8000, 8000, 8000);

            Random rnd = new Random();
            int value = rnd.Next(0, 10);

            for (int i = 1; i < 5; i++)
                answer[i] = "";

            int num_str = rnd.Next(0, size_n);
            while (check_rand(num_str))
                num_str = rnd.Next(0, size_n);
            answer[0] = allword[num_str];
            my_random[num_str]--;


            answer[rnd.Next(1, 5)] = answer[0];

            //убрать повторение в кнопках
            if (size_n > 3)
            {
                for (int i = 1; i < 5; i++)
                    if (answer[i].Length == 0)
                    {
                        string tempstr = allword[rnd.Next(0, size_n)];
                        while
                            (
                            (tempstr.CompareTo(answer[1]) == 0) ||
                            (tempstr.CompareTo(answer[2]) == 0) ||
                            (tempstr.CompareTo(answer[3]) == 0) ||
                            (tempstr.CompareTo(answer[4]) == 0)
                            )
                            tempstr = allword[rnd.Next(0, size_n)];

                        answer[i] = tempstr;
                    }
            }
            else
            for (int i = 1; i < 5; i++)
                if (answer[i].Length == 0)
                    answer[i] = allword[rnd.Next(0, size_n)];

            if (rnd.Next(0, 2) == 0)
            {
                //a
                text.Text = answer[0].Substring(answer[0].Length - 1);
                text.Foreground = Back.Foreground;

                //あ
                b1.Content = answer[1].Substring(1, answer[1].Length - 2);
                b1.Foreground = (answer[1][0] == '0') ? hir.Foreground : kat.Foreground;
                b2.Content = answer[2].Substring(1, answer[2].Length - 2);
                b2.Foreground = (answer[2][0] == '0') ? hir.Foreground : kat.Foreground;
                b3.Content = answer[3].Substring(1, answer[3].Length - 2);
                b3.Foreground = (answer[3][0] == '0') ? hir.Foreground : kat.Foreground;
                b4.Content = answer[4].Substring(1, answer[4].Length - 2);
                b4.Foreground = (answer[4][0] == '0') ? hir.Foreground : kat.Foreground;
            }
            else
            {
                //あ
                text.Text = answer[0].Substring(1, answer[0].Length - 2);
                text.Foreground = (answer[0][0] == '0') ? hir.Foreground : kat.Foreground;

                //a
                b1.Content = answer[1].Substring(answer[1].Length - 1);
                b1.Foreground = Back.Foreground;
                b2.Content = answer[2].Substring(answer[2].Length - 1);
                b2.Foreground = Back.Foreground;
                b3.Content = answer[3].Substring(answer[3].Length - 1);
                b3.Foreground = Back.Foreground;
                b4.Content = answer[4].Substring(answer[4].Length - 1);
                b4.Foreground = Back.Foreground;
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KarHirMenu());
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            attempt++;
            if (check_answer(((Button)sender).Tag + ""))
                update_Buttons();
            else
            {
                int number = int.Parse(((Button)sender).Tag + "");

                //при неверном выборе в кнопке будет такой формат "あ - a"
                ((Button)sender).Content = answer[number].Substring(answer[number].Length - 1)  + " - " 
                    + answer[number].Substring(1, answer[number].Length - 2);

                ((Button)sender).IsEnabled = false;
                attempt = 0;

                if (((Button)sender).Tag + "" == "1")
                    f1.Margin = new Thickness(60, 20, 20, 20);
                else
                if (((Button)sender).Tag + "" == "2")
                    f2.Margin = new Thickness(20, 20, 60, 20);
                else
                if (((Button)sender).Tag + "" == "3")
                    f3.Margin = new Thickness(60, 20, 20, 20);
                else
                if (((Button)sender).Tag + "" == "4")
                    f4.Margin = new Thickness(20, 20, 60, 20);
            }

            update_proportion();
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

            b1.Effect = effect;
            b2.Effect = effect;
            b3.Effect = effect;
            b4.Effect = effect;
            text.Effect = effect;
            Back.Effect = effect;
            kat.Effect = effect;
            hir.Effect = effect;
            proportion.Effect = effect;
            word_stat.Effect = effect;
            add_Word.Effect = effect;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (flag_pic)
            {
                hiddenAll(false, im_temp);
            }
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

        private void fon_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                ((Button)sender).Focus();
            }
            catch
            {

            }
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

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            try
            {
                //double newSize = 10 + e.NewSize.Width / 80;
                double newSize = e.NewSize.Width / 40;
                if(newSize>20)
                    newSize = 10 + e.NewSize.Width / 90;

                Back.FontSize = newSize;
                text.FontSize = newSize + 10;
                b1.FontSize = newSize + 10;
                b2.FontSize = newSize + 10;
                b3.FontSize = newSize + 10;
                b4.FontSize = newSize + 10;
                kat.FontSize = newSize;
                hir.FontSize = newSize;
                proportion.FontSize = newSize;
                word_stat.FontSize = newSize;
                add_Word.FontSize = newSize;
            }
            catch
            {

            }
        }

        public void update_proportion()
        {
           proportion.Text = "Правильных ответов подряд:\r\n" + attempt;
        }

        public void update_word_stat()
        {
            word_stat.Text = "Кол-во слов\r\nВ тесте: " + size_n + "\r\nОжидают: " + (size - size_n);
        }

        private void fon_Click(object sender, RoutedEventArgs e)
        {
            if (flag_pic)
            {
                hiddenAll(false, im_temp);
            }
        }

        private void add_Word_Click(object sender, RoutedEventArgs e)
        {
            if (size_n < size)
            {
                size_n++;

                b1.IsEnabled = true;
                b1.Background = Back.Background;
                f1.Margin = new Thickness(8000, 8000, 8000, 8000);
                b2.IsEnabled = true;
                b2.Background = Back.Background;
                f2.Margin = new Thickness(8000, 8000, 8000, 8000);
                b3.IsEnabled = true;
                b3.Background = Back.Background;
                f3.Margin = new Thickness(8000, 8000, 8000, 8000);
                b4.IsEnabled = true;
                b4.Background = Back.Background;
                f4.Margin = new Thickness(8000, 8000, 8000, 8000);

                

                answer[0] = allword[size_n-1];

                for (int i = 1; i < 5; i++)
                    answer[i] = answer[0];

                text.Text = answer[0].Substring(1, answer[0].Length - 2);
                text.Foreground = (answer[0][0] == '0') ? hir.Foreground : kat.Foreground;

                b1.Content = answer[1].Substring(answer[1].Length - 1);
                b1.Foreground = Back.Foreground;
                b2.Content = answer[2].Substring(answer[2].Length - 1);
                b2.Foreground = Back.Foreground;
                b3.Content = answer[3].Substring(answer[3].Length - 1);
                b3.Foreground = Back.Foreground;
                b4.Content = answer[4].Substring(answer[4].Length - 1);
                b4.Foreground = Back.Foreground;

                update_word_stat();

                if (size_n == size)
                {
                    add_Word.IsEnabled = false;
                    try { fon.Focus(); }
                    catch { }
                }
            }
        }
    }
}

