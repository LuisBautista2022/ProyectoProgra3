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
using Modelos;

namespace ProyectoProgra3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lvMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            grd_main.Children.Clear();
            switch (((ListViewItem)(((ListView)sender).SelectedItem)).Name)
            {
                case "itemConferencia":
                    MessageBox.Show("tipo usuario "+Sesiones.TipoUsuario);
                    break;
                case "lv_CrearConferencia":
                    usc = new Ventanas.usc_CrearConferencia();
                    break;
                case "lv_ConferenciaOrganizador":
                    usc = new Ventanas.usc_ConferenciaOrganizador();
                    break;
                case "lv_ConferenciaCliente":
                    usc = new Ventanas.usc_ConferenciaCliente();
                    break;
                case "lv_MisConferencias":
                    usc = new Ventanas.usc_ConferenciasAgregadasCliente();
                    break;
                case "lv_ListaClientesAgregadas":
                    usc = new Ventanas.usc_ClientesRegistrados();
                    break;
            }
            if (usc!=null)
            {
                grd_main.Children.Add(usc);
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();//se llama a la ventana login
            login.Visibility = Visibility.Visible;//se cambias el estado de oculto a visible
            this.Close();//se cierra el menu

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            switch (Sesiones.TipoUsuario)
            {
                case "Organizador":
                    lv_ConferenciaCliente.Visibility = Visibility.Collapsed;
                    lv_MisConferencias.Visibility = Visibility.Collapsed;
                    break;
                case "Cliente":
                    lv_ConferenciaOrganizador.Visibility = Visibility.Collapsed;
                    lv_CrearConferencia.Visibility = Visibility.Collapsed;
                    lv_ListaClientesAgregadas.Visibility = Visibility.Collapsed;
                    break;
            }
        }
    }
}
