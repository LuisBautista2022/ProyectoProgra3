using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class ControladorConferencia
    {
        public IEnumerable<Modelos.Conferencia> GetList()
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                IEnumerable<Modelos.Conferencia> lst = (from d in db.Conferencia
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
                                                        }).
                                                    ToList();

                return lst;
            }
        }
        public List<Conferencia> ComboboxConferencias()
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                List<Conferencia> lst = (from d in db.Conferencia
                                         select new Modelos.Conferencia
                                         {
                                             IdConferencia = d.idConferencia,
                                             NombreConferencia = d.nombreConferencia
                                         }).ToList();

                return lst;
            }
        }
        public List<Conferencia> GetListCliente()
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                List<Conferencia> lst = (from d in db.Conferencia
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


        public void CrearConferencia(Conferencia conf)
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                Modelos.EF.Conferencia conferencia = new Modelos.EF.Conferencia();
                conferencia.nombreConferencia = conf.NombreConferencia;
                conferencia.informacion = conf.Informacion;
                conferencia.nombreDisertante = conf.NombreDisertante;
                conferencia.informacionDisertante = conf.InformacionDisertante;
                conferencia.correo = conf.Correo;
                conferencia.celular = conf.Celular;
                conferencia.hora = conf.Hora;
                conferencia.precio = Convert.ToDecimal(conf.Precio);
                conferencia.ubicacion = conf.Ubicacion;
                conferencia.fechaInicio = conf.FechaInicio;
                conferencia.fechaFin = conf.FechaFinal;

                db.Conferencia.Add(conferencia);
                db.SaveChanges();
            }
        }
        //el cliente se registra a una conferencia
        public void RegistrarseConferencia(int conferencia, int cliente)
        {
            using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
            {
                Modelos.EF.ConferenciaPersona conferenciPer = new Modelos.EF.ConferenciaPersona();
                conferenciPer.idConferencia = conferencia;
                conferenciPer.idPersona = cliente;


                db.ConferenciaPersona.Add(conferenciPer);
                db.SaveChanges();
            }
        }


        #region a
        //public DataTable GetList3()
        //{
        //    using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
        //    {
        //        DataTable dt = new DataTable();
        //        IEnumerable<Modelos.Conferencia> lst = (from d in db.Conferencia
        //                                                select new Modelos.Conferencia
        //                                                {
        //                                                    IdConferencia = d.idConferencia,
        //                                                    NombreConferencia = d.nombreConferencia,
        //                                                    Informacion = d.informacion,
        //                                                    NombreDisertante = d.nombreDisertante,
        //                                                    InformacionDisertante = d.informacionDisertante,
        //                                                    Correo = d.correo,
        //                                                    Celular = d.celular,
        //                                                    Hora = d.hora,
        //                                                    FechaInicio = d.fechaInicio,
        //                                                    FechaFinal = d.fechaFin,
        //                                                    Ubicacion = d.ubicacion,

        //                                                })
        //                                            .ToList();
        //        dt.Columns.Add("Id", typeof(int));
        //        dt.Columns.Add("Nombre_Conferencia", typeof(string));
        //        foreach (var data in lst)
        //        {
        //            DataRow dr = dt.NewRow();
        //            dr["Id"] = data.IdConferencia;
        //            dr["Nombre_Conferencia"] = data.NombreConferencia;
        //            dt.Rows.Add(dr);
        //        }

        //        return dt;
        //    }
        //}


        //public IEnumerable<Modelos.Conferencia> GetList()
        //{
        //    try
        //    {
        //        using (Modelos.EF.ConferenciasEntities db = new Modelos.EF.ConferenciasEntities())
        //        {
        //            IEnumerable<Modelos.Conferencia> lst = (from d in db.Conferencia
        //                                                    select new Modelos.Conferencia(d.idConferencia, d.nombreConferencia, d.informacion,
        //                                                    d.nombreDisertante, d.informacionDisertante, d.correo, d.celular,
        //                                                    d.hora, d.fechaInicio, d.fechaFin, d.ubicacion, Convert.ToDouble(d.precio.ToString()))
        //                                                ).ToList();
        //            return lst;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex; 
        //    }

        //}
        #endregion
    }
}
