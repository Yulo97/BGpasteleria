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

namespace pasteleria
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class VentInicio : Window
    {
        public VentInicio()
        {
            InitializeComponent();

        }

        private void OpenTabla(object sender, MouseButtonEventArgs e)
        {
            var pagina = ((Grid)sender).Name;

            switch(pagina)
            {
                case "Ingredientes":

                    FrameTablas.Navigate(new PageIngredientes());
                    break;

                case "Recetas":

                    FrameTablas.Navigate(new PageRecetas());
                    break;

            }
        }
    }
}
