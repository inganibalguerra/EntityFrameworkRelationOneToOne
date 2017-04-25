using DTO;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Expediente
    {
        /// <summary>
        /// Este metodo convierte un DTO a DAL
        /// </summary>
        /// <param name="DTO">Parametro DTO</param>
        /// <returns>Objeto tipo DAL</returns>
        public static Expediente MapeoDTOToDAL(ExpedienteDTO DTO)
        {
            Expediente expediente = new Expediente();
            expediente.ExpedienteId = DTO.ExpedienteId;
            expediente.Cuantia = DTO.Cuantia;
            expediente.Identificacion = DTO.Identificacion;
            expediente.Nombre = DTO.Nombre;
            expediente.ObligacionId = DTO.ObligacionId;
            return expediente;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DAL"></param>
        /// <returns></returns>
        public static ExpedienteDTO MapeoDALToDTO(Expediente DAL)
        {
            ExpedienteDTO expediente = new ExpedienteDTO();
            expediente.ExpedienteId = DAL.ExpedienteId;
            expediente.Cuantia = DAL.Cuantia;
            expediente.Identificacion = DAL.Identificacion;
            expediente.Nombre = DAL.Nombre;
            expediente.Obligacion = Obligacion.MapeoDALToDTO(DAL.Obligacion);
            expediente.ObligacionId = DAL.ObligacionId;
            return expediente;
        }
        public int ExpedienteId { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public float Cuantia { get; set; }
        public int ObligacionId { get; set; }
        [Required]
        public Obligacion Obligacion { get; set; }
    }
}
