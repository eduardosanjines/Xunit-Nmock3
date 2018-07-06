using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVuelingXunit.Integration.Tests
{
  
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(2, iCalculadora.Division(4, 2));
            log.Info("Se ha iniciado el metodo Division");
            
        }

        [Fact]
        public void MultiplicacionTest()
        {
            Assert.Equal(4, iCalculadora.Multiplicacion(2, 2));
        }

        [Fact]
        public void RestaTest()
        {
            Assert.Equal(2, iCalculadora.Resta(4, 2));
        }

        [Fact]
        public void Suma()
        {
            Assert.Equal(4, iCalculadora.Suma(2, 2));
        }

    }
}
