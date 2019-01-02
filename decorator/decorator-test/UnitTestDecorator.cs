using decorator_console;
using System;
using Xunit;

namespace decorator_test
{
    public class UnitTestDecorator
    {
        [Fact]
        public void TestDecafCost1()
        {
            Beverage coffee = new Decaf();
            Assert.Equal(1, coffee.getCost());
        }

        [Fact]
        public void TestEspresso1()
        {
            Beverage coffee = new Espresso();
            Assert.Equal(3, coffee.getCost());
        }
    }
}
