using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class ControladorConferenciaPersona
    {
        public List<ConferenciaPersona> GetListConferenciaAgregadas()
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                List<ConferenciaPersona> lst = (from d in db.ConferenciaPersona
                                                where d.idPersona.ToString().Contains(Sesiones.IdPersona.ToString())

                                                select new Modelos.ConferenciaPersona
                                                {
                                                    IdConferencia = d.idConferencia,
                                                    IdPersona = d.idPersona
                                                }).ToList();

                return lst;
            }
        }
        public List<Conferencia> MisConferencias()
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                List<Conferencia> lst = (from d in db.Conferencia
                                         join mi in db.ConferenciaPersona
                                         on d.idConferencia equals mi.idConferencia
                                         where d.idConferencia.ToString().StartsWith(mi.idConferencia.ToString())
                                         where mi.idPersona.ToString().Contains(Sesiones.IdPersona.ToString())
                                         select new Modelos.Conferencia
                                         {
                                             IdConferencia = d.idConferencia,
                                             NombreConferencia = d.nombreConferencia,
                                             Informacion = d.informacion,
                                             NombreDisertante = d.nombreDisertante,
                                             InformacionDisertante = d.informacionDisertante,
                                             Correo = d.correo,
                                             Celular = d.celular,
                                             Hora = d.hora,
                                             FechaInicio = d.fechaInicio,
                                             FechaFinal = d.fechaFin,
                                             Ubicacion = d.ubicacion,
                                             Precio = (double)d.precio
                                         }).ToList();

                return lst;
            }
        }
    }
}
