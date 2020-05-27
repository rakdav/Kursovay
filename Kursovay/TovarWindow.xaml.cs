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
    /// Логика взаимодействия для TovarWindow.xaml
    /// </summary>
    public partial class TovarWindow : Window
    {
        public TovarWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public string getName
        {
            get { return NameTovar.Text; }
        }

        public string getType
        {
            get { return typeTovar.Text; }
        }

        public string getSort
        {
            get { return sortTovar.Text; }
        }
        public string getPrice
        {
            get { return priceTovar.Text; }
        }

        public string getOstatok
        {
            get { return ostatokTovar.Text; }
        }
        public string getTown
        {
            get { return towmTovar.Text; }
        }
    }
}
