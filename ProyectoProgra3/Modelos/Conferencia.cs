using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Conferencia
    {
        public int IdConferencia { get; set; }
        public string NombreConferencia { get; set; }
        public string Informacion { get; set; }
        public string NombreDisertante { get; set; }
        public string InformacionDisertante { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Hora { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Ubicacion { get; set; }
        public double Precio { get; set; }

        public Conferencia()
        {

        }
        

        //getlist
        public Conferencia(int idConferencia, string nombreConferencia, string informacion, string nombreDisertante, string informacionDisertante, string correo, string celular, string hora, DateTime fechaInicio, DateTime fechaFinal, string ubicacion)
        {
            IdConferencia = idConferencia;
            NombreConferencia = nombreConferencia;
            Informacion = informacion;
            NombreDisertante = nombreDisertante;
            InformacionDisertante = informacionDisertante;
            Correo = correo;
            Celular = celular;
            Hora = hora;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
            Ubicacion = ubicacion;

        }
        public Conferencia(int idConferencia, string nombreConferencia, string informacion, string nombreDisertante, string informacionDisertante, string correo, string celular, string hora, DateTime fechaInicio, DateTime fechaFinal, string ubicacion,double precio)
        {
            IdConferencia = idConferencia;
            NombreConferencia = nombreConferencia;
            Informacion = informacion;
            NombreDisertante = nombreDisertante;
            InformacionDisertante = informacionDisertante;
            Correo = correo;
            Celular = celular;
            Hora = hora;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
            Ubicacion = ubicacion;
            Precio = precio;
        }

        public Conferencia(int idConferencia, string nombreConferencia, string informacion)
        {
            IdConferencia = idConferencia;
            NombreConferencia = nombreConferencia;
            Informacion = informacion;
        }



        //insertar
        public Conferencia(string nombreConferencia, string informacion, string nombreDisertante, string informacionDisertante, string correo, string celular, string hora, DateTime fechaInicio, DateTime fechaFinal, string ubicacion, double precio)
        {
            NombreConferencia = nombreConferencia;
            Informacion = informacion;
            NombreDisertante = nombreDisertante;
            InformacionDisertante = informacionDisertante;
            Correo = correo;
            Celular = celular;
            Hora = hora;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
            Ubicacion = ubicacion;
            Precio = precio;
        }
    }
}
