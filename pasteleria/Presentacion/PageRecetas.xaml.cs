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
    /// Lógica de interacción para PageRecetas.xaml
    /// </summary>
    public partial class PageRecetas : Page
    {

        N_Recetas n_recetas = new N_Recetas();

        public PageRecetas()
        {
            InitializeComponent();
            tablaRecetas.ItemsSource = n_recetas.ListaRecetas().DefaultView;
        }

    }
}
