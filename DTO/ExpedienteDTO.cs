using System;
using System.Collections.Generic;

namespace DTO
{
    public class ExpedienteDTO
    {
        
        public int ExpedienteId { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public float Cuantia { get; set; }
        public int ObligacionId { get; set; }
        public ObligacionDTO Obligacion { get; set; }
    }
}
