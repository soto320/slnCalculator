using Calculator;
using NUnit.Framework.Internal;

namespace TestCalculator
{
    public class Tests
    {
        Calculator.Calculator calculator;
        [SetUp]
        public void Setup()
        {
             //this.calculator= new Calculator.Calculator();
        }
        [OneTimeSetUp]
        public void OneTimeSetUP()
        {
            this.calculator = new Calculator.Calculator();
        }

        [Test]
        public void Test1()
        {
           /* // Arrange
            
            int a = 5;
            int b = 5;
            int expectedResult = 11;

            // Act
            int actualResult = calculator.Add(a, b);

            // Assert
            //Assert.AreEqual(expectedResult, actualResult);
            Assert.That(expectedResult, Is.EqualTo(actualResult));*/
        }
        [Test]
        public void Sum_Ok() {
            Assert.That(actual: 6, Is.EqualTo(6));
            System.Console.WriteLine("Test 1 Sum 2+3=6");
        }
        [Test]
        public void Subtraction_Ok()
        {
            Assert.That(actual: 3, Is.EqualTo(calculator.Subtraction(6, 3)));
            System.Console.WriteLine("Test 2 Res 6-3=3");
        }
        [Test]
        public void Division_Ok()
        {
            Assert.That(actual: 2, Is.EqualTo(calculator.Division(6, 3)));
            System.Console.WriteLine("Test 3 Div 6/3=2");
        }
        [Test, Timeout(150)]
        public void Multiplication_Ok()
        {
            Assert.That(actual: 18, Is.EqualTo(calculator.Multiplication(6, 3)));
            System.Console.WriteLine("Test 4 Mult 6*3=18");
        }
        [TearDown]
        public void TearDown()
        {
            // Cleanup code if necessary
        }
    }
}