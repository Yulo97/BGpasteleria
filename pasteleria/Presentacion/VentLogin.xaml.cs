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

namespace pasteleria.Presentacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class VentLogin : Window
    {

        N_Usuario verificacion = new N_Usuario();


        public VentLogin()
        {
            InitializeComponent();
        }
        
        private void IngresarLogin(object sender, RoutedEventArgs e)
        {
            E_Usuario.UsuarioName = textBoxUser.Text;
            E_Usuario.UsuarioPass = textBoxPass.Password;

            if (verificacion.VerificacionDeUsuario())
            {
                VentInicio inicio = new VentInicio();
                this.Close();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario Incorrecto");
            }
        }
    }
}
