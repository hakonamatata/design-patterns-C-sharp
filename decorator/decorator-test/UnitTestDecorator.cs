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
            Assert.Equal(1.25, coffee.getCost());
        }

        [Fact]
        public void TestDecafCost2()
        {
            Beverage coffee = new Decaf();

            // add soy to Decaf coffee
            coffee = new SoyBeverageDecorator(coffee);

            Assert.Equal(1.50, coffee.getCost());
        }

        [Fact]
        public void TestEspresso1()
        {
            Beverage coffee = new Espresso();
            Assert.Equal(3.15, coffee.getCost());
        }
    }
}
