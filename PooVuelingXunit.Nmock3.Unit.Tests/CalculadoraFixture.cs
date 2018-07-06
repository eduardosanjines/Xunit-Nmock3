using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NMock;
using System.Threading.Tasks;

namespace PooVuelingXunit.Nmock3.Unit.Tests
{
    public class CalculadoraFixture
    {
        private MockFactory _factory = new MockFactory();

        public CalculadoraFixture() {

            var mock = _factory.CreateMock<ICalculadora>();
            mock.Expects.One.MethodWith(_ => _.Division(4, 2)).WillReturn((2));
            mock.Expects.One.MethodWith(_ => _.Multiplicacion(2, 2)).WillReturn((4));
            mock.Expects.One.MethodWith(_ => _.Resta(4, 4)).WillReturn((0));
            mock.Expects.One.MethodWith(_ => _.Suma(2, 2)).WillReturn((4));

        }
        public ICalculadora MockObject { get; private set; }
    }
}
