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

namespace Kursovay
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;//
        }
        public string getFirstName
        {
            get { return FirstName.Text; }
        }
        public string getMiddleName
        {
            get { return MiddleName.Text; }
        }
        public string getLastName
        {
            get { return LastName.Text; }
        }
        public string getFirma
        {
            get { return Firma.Text; }
        }
        public string getTown
        {
            get { return Town.Text; }
        }
        public string getPhone
        {
            get { return Phone.Text; }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
