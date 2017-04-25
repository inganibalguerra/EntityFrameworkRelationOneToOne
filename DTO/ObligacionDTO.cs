using System;
using System.Collections.Generic;

namespace DTO
{
    public class ObligacionDTO
    {
        public int ObligacionId { get; set; }
        public float Cuantia { get; set; }
        public int ExpedienteId { get; set; }
        public virtual ExpedienteDTO Expediente { get; set; }
    }
}
