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

namespace WpfApp1
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

        //Количество символов от 7 до 10 +
        //Должна быть хотя бы одна цифра +
        //Должен быть хотя бы один символ верхнего регистра +
        //Должен быть хотя бы один символ нижнего регистра +
        //Должен быть хотя бы один из спецсимволов @#$%^& -


        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            //считываение пароля с окна из поля для ввода пароля
            string password = PasswordTextBox.Text;
            //объявляем объект класса Auth
            Auth auth = new Auth();
            //выводим сообщение с результатом из метода TestPassword с паролем переданным в качестве параметра
            MessageBox.Show(auth.TestPassword(password));
            
        }
    }
}
