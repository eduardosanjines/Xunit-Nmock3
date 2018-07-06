using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PooVuelingXunit.Nmock3.Unit.Tests
{
    public class CalculadoraTests: IClassFixture<CalculadoraFixture>
    {
        CalculadoraFixture fixture;

        public CalculadoraTests(CalculadoraFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(2, fixture.MockObject.Division(4, 2));

        }

        [Fact]
        public void MultiplicacionTest()
        {

            Assert.Equal(4, fixture.MockObject.Multiplicacion(2, 2));
        }

        [Fact]
        public void RestaTest()
        {
           Assert.Equal(0, fixture.MockObject.Resta(4, 4));
        }

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(4, fixture.MockObject.Suma(2, 2));
        }
    }
}