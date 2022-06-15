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
using Modelos;
using Controladores;

namespace ProyectoProgra3.Ventanas
{
    /// <summary>
    /// Lógica de interacción para Registrarse.xaml
    /// </summary>
    public partial class Registrarse : Window
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (pwb_contrasenia.Password == txt_repassword.Password)
                {
                    Persona persona = new Persona(txt_Nombre.Text, txt_Apellido.Text, txt_usuario.Text, pwb_contrasenia.Password);
                    ControladorPersona conPersona = new ControladorPersona();
                    conPersona.CrearUsuario(persona);
                    MessageBox.Show("Usuario Creado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coninciden");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
