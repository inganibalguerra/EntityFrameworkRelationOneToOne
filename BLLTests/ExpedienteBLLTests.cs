using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL.Tests
{
    [TestClass()]
    public class ExpedienteBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            ExpedienteBLL obj = new ExpedienteBLL();
            //ExpedienteDTO expediente = new ExpedienteDTO{
            //    Cuantia = 500,
            //    Identificacion="dd",
            //    Nombre="jj",
            //    Obligacion= new ObligacionDTO{
            //        Cuantia=500
            //    }
            //};
            ObligacionDTO obligacion = new ObligacionDTO
            {
                Cuantia = 500
            };
            ExpedienteDTO expediente = new ExpedienteDTO
            {
                Cuantia = 500,
                Identificacion = "dd",
                Nombre = "jj",
                Obligacion=obligacion
            };
            obj.Insertar(expediente);
            Assert.AreEqual("Se realizó la operación satisfactoriamente",obj.Insertar(expediente));
        }
    }
}