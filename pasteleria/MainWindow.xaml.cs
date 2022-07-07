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

namespace pasteleria
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

        private void IngresarLogin(object sender, RoutedEventArgs e)
        {
            string user = textBoxUser.Text;
            string pass = textBoxPass.Password;

            if (user=="asd" && pass=="asd")
            {
                Inicio inicio = new Inicio();
                this.Close();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto.");
            }

        }
            
    }
}
