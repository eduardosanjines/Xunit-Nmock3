using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var result = fixture.MockObject.Division(4, 2);
       
  
        }

        [Fact]
        public void MultiplicacionTest()
        {
            var result = fixture.MockObject.Multiplicacion(4, 2);

        }

        [Fact]
        public void RestaTest()
        {
            var result = fixture.MockObject.Resta(4, 2);

        }

        [Fact]
        public void SumaTest()
        {
            var result = fixture.MockObject.Suma(4, 2);

        }
    }
}