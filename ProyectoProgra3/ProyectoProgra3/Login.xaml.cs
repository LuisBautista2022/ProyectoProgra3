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
using Controladores;
using Modelos;
using System.Threading;

namespace ProyectoProgra3
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Thread carga;
        int cargado = 0;
        delegate void delegado(int valor);
        public Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_usuario.Text != "" && pwb_contrasenia.Password != "")
            {
                string usuario = txt_usuario.Text, contraseña = pwb_contrasenia.Password;

                //instanciando la clase "ControladorPersona" , para sacar al usuario valido(LinQ)
                ControladorPersona con = new ControladorPersona();
                int datos = 0;

                datos = con.Login(usuario, contraseña).Count();
                if (datos > 0)
                {
                    //MessageBox.Show("Datos validos");

                    foreach (var idintificar in con.Login(usuario, contraseña))
                    {
                        Sesiones.TipoUsuario = idintificar.TipoUsuario;
                        Sesiones.Nombre = idintificar.Nombre;
                        Sesiones.Apellido = idintificar.Apellido;
                        Sesiones.IdPersona = idintificar.IdPersona;
                    }

                    pgb_Carga.Visibility = Visibility.Visible;
                    carga = new Thread(new ThreadStart(ProcesoCarga));
                    carga.Start();

                }
                else
                {
                    //MessageBox.Show("Datos incorrectos");
                    Error er = new Error();
                    er.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Llena los compos vacios");
            }
        }

        public void ProcesoCarga()
        {
            for (int i = 0; i < 101; i++)
            {
                delegado hacer = new delegado(Actualizar);
                pgb_Carga.Dispatcher.Invoke(hacer, new object[] { i });
                Thread.Sleep(10);

            }

        }
        public void Actualizar(int valor)
        {
            pgb_Carga.Value = valor;
            if (valor > 99)
            {
                cargado = 1;
            }
            if (cargado == 1)
            {
                this.Visibility = Visibility.Hidden;//se esconde la ventana login
                MainWindow main = new MainWindow();
                main.ShowDialog();//Se abre el menu
            }
        }

        private void btn_Registrarse_Click(object sender, RoutedEventArgs e)
        {
            Ventanas.Registrarse registrarse = new Ventanas.Registrarse();
            registrarse.ShowDialog();
        }
    }
}
