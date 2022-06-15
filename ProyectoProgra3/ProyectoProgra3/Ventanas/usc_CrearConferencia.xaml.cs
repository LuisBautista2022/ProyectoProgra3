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
using Controladores;

namespace ProyectoProgra3.Ventanas
{
    /// <summary>
    /// Lógica de interacción para usc_CrearConferencia.xaml
    /// </summary>
    public partial class usc_CrearConferencia : UserControl
    {
        public usc_CrearConferencia()
        {
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, RoutedEventArgs e)
        {
            Conferencia con;
            try
            {
                if (txt_NombreConferencia.Text != "" && txb_InfoConferen.Text != "" && txt_NombreDisertante.Text != "" && txt_InfoDisertante.Text != "" &&
                    txt_Correo.Text != "" && txt_Celular.Text != "" && PresetTimePicker.Text != "" && dp_FechaInicio.Text != "" &&
                    dp_FechaFin.Text != "" && txt_Ubicacion.Text != "" && txt_Precio.Text != "")
                {
                    int celular = Convert.ToInt32(txt_Celular.Text);
                    int precio = Convert.ToInt32(txt_Precio.Text);
                    con = new Conferencia(txt_NombreConferencia.Text, txb_InfoConferen.Text, txt_NombreDisertante.Text, txt_InfoDisertante.Text, txt_Correo.Text, txt_Celular.Text, PresetTimePicker.Text, dp_FechaInicio.SelectedDate.Value, dp_FechaFin.SelectedDate.Value, txt_Ubicacion.Text, Convert.ToDouble(txt_Precio.Text));
                    ControladorConferencia cont = new ControladorConferencia();
                    cont.CrearConferencia(con);
                    MessageBox.Show("Registro completado");
                    txt_NombreConferencia.Text = "";
                    txb_InfoConferen.Text = "";
                    txt_NombreDisertante.Text = "";
                    txt_InfoDisertante.Text = "";
                    txt_Correo.Text = "";
                    txt_Celular.Text = "";
                    PresetTimePicker.Text = "";
                    dp_FechaInicio.Text = "";
                    dp_FechaFin.Text = "";
                    txt_Ubicacion.Text = "";
                    txt_Precio.Text = "";
                }
                else
                {
                    MessageBox.Show("Completa los espaciol vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese solo numeros");
            }

        }
    }
}
