using DTO;

namespace DAL
{
    public partial class Obligacion
    {
        /// <summary>
        /// Este metodo convierte un DTO a DAL
        /// </summary>
        /// <param name="DTO">Parametro DTO</param>
        /// <returns>Objeto tipo DAL</returns>
        public static Obligacion MapeoDTOToDAL(ObligacionDTO DTO)
        {
            Obligacion obligacion = new Obligacion();
            obligacion.ObligacionId = DTO.ObligacionId;
            obligacion.Cuantia = DTO.Cuantia;
            if (DTO.Expediente != null)
            {
                obligacion.Expediente = Expediente.MapeoDTOToDAL(DTO.Expediente);
            }
            obligacion.ExpedienteId = DTO.ExpedienteId;
            return obligacion;
        }

        /// <summary>
        /// Este metodo convierte un DTO a DAL
        /// </summary>
        /// <param name="DAL">Parametro DAL</param>
        /// <returns>Objeto tipo DAL</returns>
        public static ObligacionDTO MapeoDALToDTO(Obligacion DAL)
        {
            ObligacionDTO obligacion = new ObligacionDTO();
            obligacion.ObligacionId = DAL.ObligacionId;
            obligacion.Cuantia = DAL.Cuantia;
            if (DAL.Expediente != null)
            {
                obligacion.Expediente = Expediente.MapeoDALToDTO(DAL.Expediente);
            }
            obligacion.ExpedienteId = DAL.ExpedienteId;
            return obligacion;
        }
        public int ObligacionId { get; set; }
        public float Cuantia { get; set; }
        public int ExpedienteId { get; set; }
        public virtual Expediente Expediente { get; set; }
    }
}
