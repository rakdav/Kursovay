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
using System.Data.Entity;

namespace Kursovay
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ModelDb db;
        public MainWindow()
        {
            
            InitializeComponent();
            clientGrid.Visibility = Visibility.Hidden;
            TovarGrid.Visibility = Visibility.Hidden;
            AddDelete.Visibility = Visibility.Hidden;
            db = new ModelDb();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (clientGrid.Visibility == Visibility.Visible)
            {
                ClientWindow window = new ClientWindow();
                if (window.ShowDialog() == true)
                {
                    Client client = new Client();
                    client.FirstName = window.getFirstName;
                    client.MiddleName = window.getMiddleName;
                    client.LastName = window.getLastName;
                    client.Firma = window.getFirma;
                    client.Town = window.getTown;
                    client.Phone = window.getPhone;
                    db.Client.Add(client);
                }
                db.SaveChanges();
            }
            if (TovarGrid.Visibility == Visibility.Visible)
            {
                TovarWindow window = new TovarWindow();
                if (window.ShowDialog() == true)
                {
                    Tovar tovar = new Tovar();
                    tovar.nameTovar = window.getName;
                    tovar.type = window.getType;
                    tovar.sort = window.getSort;
                    tovar.price = decimal.Parse(window.getPrice);
                    tovar.ostatok = int.Parse(window.getOstatok);
                    tovar.town = window.getTown;
                    db.Tovar.Add(tovar);
                }
                db.SaveChanges();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (clientGrid.Visibility == Visibility.Visible)
            {
                try
                {
                    if (clientGrid.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < clientGrid.SelectedItems.Count; i++)
                        {
                            Client phone = clientGrid.SelectedItems[i] as Client;
                            if (phone != null)
                            {
                                db.Client.Remove(phone);
                            }
                        }
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (TovarGrid.Visibility == Visibility.Visible)
            {
                try
                {
                    if (TovarGrid.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < TovarGrid.SelectedItems.Count; i++)
                        {
                            Tovar tovar = TovarGrid.SelectedItems[i] as Tovar;
                            if (tovar != null)
                            {
                                db.Tovar.Remove(tovar);
                            }
                        }
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            clientGrid.Visibility = Visibility.Visible;
            AddDelete.Visibility = Visibility.Visible;
            TovarGrid.Visibility = Visibility.Hidden;
            TovarGrid.ItemsSource = null;
            db.Client.Load();
            clientGrid.ItemsSource = db.Client.Local.ToBindingList();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            clientGrid.Visibility = Visibility.Hidden;
            clientGrid.ItemsSource = null;
            TovarGrid.Visibility = Visibility.Visible;
            AddDelete.Visibility = Visibility.Visible;
            db.Tovar.Load();
            TovarGrid.ItemsSource = db.Tovar.Local.ToBindingList();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
