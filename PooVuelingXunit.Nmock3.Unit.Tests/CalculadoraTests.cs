using PooVuelingXunit;
using System;
using NMock;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooVuelingXunit.Nmock3.Unit.Tests;
using Xunit;

namespace PooVuelingXunit.Tests
{
    //[TestClass()]
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
            Assert.Equal(2, fixture.MockObject.Resta(4, 2));

        }

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(6, fixture.MockObject.Suma(4, 2));

        }
    }
}