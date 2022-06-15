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
using Controladores;
using Modelos;

namespace ProyectoProgra3.Ventanas
{
    /// <summary>
    /// Lógica de interacción para usc_ConferenciasAgregadasCliente.xaml
    /// </summary>
    public partial class usc_ConferenciasAgregadasCliente : UserControl
    {
        public usc_ConferenciasAgregadasCliente()
        {
            InitializeComponent();
        }

        private void dtg_Datos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ControladorConferenciaPersona conferenciaPersona = new ControladorConferenciaPersona();

            dtg_Datos.ItemsSource = null;
            dtg_Datos.ItemsSource = conferenciaPersona.MisConferencias();
            dtg_Datos.Columns[0].Visibility = Visibility.Hidden;//oculta el id
            dtg_Datos.Columns[5].Visibility = Visibility.Collapsed;//oculta la foto
        }
    }
}
