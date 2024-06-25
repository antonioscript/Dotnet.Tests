namespace Calculations.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();

            Assert.Equal(4, calc.Add(2,2));

        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();

            Assert.Equal(7.5, calc.AddDouble(2.5, 5));
        }
    }
}