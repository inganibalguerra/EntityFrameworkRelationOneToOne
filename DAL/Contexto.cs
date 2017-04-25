using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Expediente> Expedientes { get; set; }
        public DbSet<Obligacion> Obligaciones { get; set; }
    }

}
