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
using System.Windows.Shapes;

namespace Авторизация
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁёйцукенгшщзхъфывапролджэячсмитьбю".IndexOf(e.Text) < 0;
        }

        private void TextBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁёйцукенгшщзхъфывапролджэячсмитьбю".IndexOf(e.Text) < 0;
        }

        private void TextBox3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM".IndexOf(e.Text) < 0;
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM".IndexOf(e.Text) < 0;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
