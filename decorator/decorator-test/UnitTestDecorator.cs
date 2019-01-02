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
        public void TestDecafCost3()
        {
            Beverage coffee = new Decaf();

            // add soy and caramel to Decaf coffee object
            coffee = new SoyBeverageDecorator(coffee);
            coffee = new CaramelBeverageDecorator(coffee);

            Assert.Equal(2, coffee.getCost());
        }

        [Fact]
        public void TestEspresso1()
        {
            Beverage coffee = new Espresso();
            Assert.Equal(3.15, coffee.getCost());
        }

        [Fact]
        public void TestEspresso2()
        {
            Beverage coffee = new Espresso();

            // add caramel to Espresso
            coffee = new CaramelBeverageDecorator(coffee);

            Assert.Equal(3.65, coffee.getCost());
        }

    }
}
