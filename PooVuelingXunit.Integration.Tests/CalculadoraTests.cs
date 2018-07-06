using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PooVuelingXunit.Integration.Tests
{
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();
        ClassLog log = new ClassLog();

        [Fact]
        public void DivisionTest()
        {
           try {
                Assert.Equal(2, iCalculadora.Division(4, 2));
                log.LogDivi();
            }
           catch (Exception) {
                log.LogDiviError();
                throw;
            }
        }

        [Fact]
        public void MultiplicacionTest()
        {
            try
            {
                Assert.Equal(4, iCalculadora.Multiplicacion(2, 2));
                log.LogMulti();
            }
            catch (Exception)
            {
                log.LogMultiError();
                throw;
            }
            
        }

        [Fact]
        public void RestaTest()
        {
            try {
                Assert.Equal(2, iCalculadora.Resta(4, 2));
                log.LogResta();
            }
            catch (Exception) {
                log.LogRestaError();
                throw;
            }
            
        }

        [Fact]
        public void SumaTest()
        {
            try
            {
                Assert.Equal(4, iCalculadora.Suma(2, 2));
                log.LogSuma();
            }
            catch (Exception)
            {
                log.LogSumaError();
                throw;
            }
        }

        [Fact]
        public void SumaError() {
            try
            {
                Assert.Equal(34, iCalculadora.Suma(2, 2));
                log.LogSuma();
            }
            catch (Exception)
            {
                log.LogSumaError();
                throw;
            }
        }
            
        

    }
}
