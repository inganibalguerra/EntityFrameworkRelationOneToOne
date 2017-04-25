using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ExpedienteBLL
    {
        string respuesta = "";
        Contexto db = new Contexto();

        public string Insertar(ExpedienteDTO expediente)
        {
            using (db = new Contexto())
            {
                try
                {
                    // preparar el cliente para guardar
                    Expediente c = Expediente.MapeoDTOToDAL(expediente);
                    c.Obligacion = Obligacion.MapeoDTOToDAL(expediente.Obligacion);
                    c.Obligacion.Expediente = c;
                     db.Expedientes.Add(c);
                    //db.Obligaciones.Add(c.Obligacion);
                    db.SaveChanges();
                    // preparar la respuesta
                    respuesta = "Se realizó la operación satisfactoriamente";
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    respuesta = ex.Message;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }

                return respuesta;
            }
        }

        public List<ExpedienteDTO> GetRecords()
        {
            using (Contexto db = new Contexto())
            {
                return db.Expedientes
                    .Select(t =>
                        Expediente.MapeoDALToDTO(t)
                    ).ToList();
            }
        }

        public ExpedienteDTO FindById(int ExpedienteId)
        {
            using (Contexto db = new Contexto())
            {
                var exped = db.Expedientes.Find(ExpedienteId);
                ExpedienteDTO expediente = Expediente.MapeoDALToDTO(exped); // Busca por llave primaria
                return expediente;
            }
        }
    }
}
