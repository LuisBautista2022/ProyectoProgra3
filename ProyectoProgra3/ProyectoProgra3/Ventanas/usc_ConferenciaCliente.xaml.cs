using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para usc_ConferenciaCliente.xaml
    /// </summary>
    public partial class usc_ConferenciaCliente : UserControl
    {
        int id = 0;
        public usc_ConferenciaCliente()
        {
            InitializeComponent();
        }

        void cargarLista()
        {
            ControladorConferencia ctConf = new ControladorConferencia();
            ControladorConferenciaPersona ctConf2 = new ControladorConferenciaPersona();

            List<Conferencia> nuevaListaconfe = ctConf.GetListCliente();
            List<ConferenciaPersona> confeAgregadas = ctConf2.GetListConferenciaAgregadas();
            foreach (var confid in confeAgregadas)//lista de conferencias agregadas
            {
                foreach (var confnew in nuevaListaconfe)//lista de todas la conferencias
                {
                    if (confid.IdConferencia == confnew.IdConferencia)
                    {
                        nuevaListaconfe.Remove(confnew);
                        break;
                    }
                }
            }

            dtg_Datos.ItemsSource = null;
            dtg_Datos.ItemsSource = nuevaListaconfe;
            dtg_Datos.Columns[0].Visibility = Visibility.Hidden;//oculta el id
            
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            cargarLista();

        }

        private void btn_registrar_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_Datos.Items.Count > 0 && dtg_Datos.SelectedItem != null)
            {
                ControladorConferencia cConfer = new ControladorConferencia();
                cConfer.RegistrarseConferencia(id, Sesiones.IdPersona);
                MessageBox.Show("Te Registraste a una conferencia");
                cargarLista();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una conferencia");
            }
        }

        private void dtg_Datos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtg_Datos.Items.Count > 0 && dtg_Datos.SelectedItem != null)
            {
                try
                {
                    Conferencia dataRow = (Conferencia)dtg_Datos.SelectedItem;
                    id = dataRow.IdConferencia;
                    //MessageBox.Show("" + id);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }
    }
}
