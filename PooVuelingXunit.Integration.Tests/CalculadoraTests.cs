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

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(2, iCalculadora.Division(4, 2));            
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
