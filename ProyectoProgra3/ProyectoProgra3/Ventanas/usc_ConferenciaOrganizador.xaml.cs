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
    /// Lógica de interacción para usc_ConferenciaOrganizador.xaml
    /// </summary>
    public partial class usc_ConferenciaOrganizador : UserControl
    {
        public usc_ConferenciaOrganizador()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ControladorConferencia ctConf = new ControladorConferencia();


            

            dtg_Datos.ItemsSource = null;
            //dtg_Datos.ItemsSource = ctConf.GetList3().DefaultView;
            dtg_Datos.ItemsSource = ctConf.GetList();
            dtg_Datos.Columns[0].Visibility = Visibility.Collapsed;//oculta el id

        }
    }
}
