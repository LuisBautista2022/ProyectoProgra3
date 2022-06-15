using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class ControladorPersona
    {
        public IEnumerable<Modelos.Persona> GetList()
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                IEnumerable<Modelos.Persona> lst = (from d in db.Persona
                                                    select new Modelos.Persona
                                                    {
                                                        IdPersona = d.idPersona,
                                                        Usuario = d.usuario,
                                                        Contrasenia = d.password
                                                    }).ToList();
                return lst;
            }
        }
        public IEnumerable<Modelos.Persona> ListaClientesRegistrados(int idconferencia)
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                IEnumerable<Modelos.Persona> lst = (from d in db.Persona
                                                    join c in db.ConferenciaPersona
                                                    on d.idPersona equals c.idPersona
                                                    where c.idConferencia.ToString().Contains(idconferencia.ToString())
                                                    select new Modelos.Persona
                                                    {
                                                        IdPersona = d.idPersona,
                                                        Nombre = d.nombre,
                                                        Apellido = d.apellido
                                                    }).ToList();
                return lst;
            }
        }
        //Metodo Para Validar un Usuario en el login
        public IEnumerable<Modelos.Persona> Login(string usuario, string password)
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                IEnumerable<Modelos.Persona> lst = (from d in db.Persona
                                                    where d.usuario.Contains(usuario) && d.password.Contains(password)
                                                    select new Modelos.Persona
                                                    {
                                                        IdPersona = d.idPersona,
                                                        Usuario = d.usuario,
                                                        Contrasenia = d.password,
                                                        TipoUsuario = d.tipoUsuario
                                                    }).ToList();
                return lst;
            }
        }
        //Crear Cliente
        public void CrearUsuario(Persona persona)
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                Modelos.EF.Persona cper = new Modelos.EF.Persona();
                cper.nombre = persona.Nombre;
                cper.apellido = persona.Apellido;
                cper.usuario = persona.Usuario;
                cper.password = persona.Contrasenia;
                cper.tipoUsuario = "Cliente";
                db.Persona.Add(cper);
                db.SaveChanges();
            }
        }
    }
}
