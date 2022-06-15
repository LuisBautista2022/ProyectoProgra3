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
    /// Lógica de interacción para usc_ClientesRegistrados.xaml
    /// </summary>
    public partial class usc_ClientesRegistrados : UserControl
    {
        public usc_ClientesRegistrados()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ControladorConferencia conferencia = new ControladorConferencia();

            cbx_Conferencias.DisplayMemberPath = "NombreConferencia";
            cbx_Conferencias.SelectedValuePath = "IdConferencia";
            cbx_Conferencias.SelectedIndex = 0;
            cbx_Conferencias.ItemsSource = conferencia.ComboboxConferencias();
        }

        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            ControladorPersona conferencia = new ControladorPersona();
            dtg_Datos.ItemsSource = null;
            int combo = cbx_Conferencias.SelectedIndex;
            combo += 1;
            MessageBox.Show("" + combo);
            dtg_Datos.ItemsSource = conferencia.ListaClientesRegistrados(combo);
            dtg_Datos.Columns[0].Visibility = Visibility.Hidden;//oculta el id
            dtg_Datos.Columns[3].Visibility = Visibility.Hidden;//oculta el id
            dtg_Datos.Columns[4].Visibility = Visibility.Hidden;//oculta el id
            dtg_Datos.Columns[5].Visibility = Visibility.Hidden;//oculta el id

        }
    }
}
