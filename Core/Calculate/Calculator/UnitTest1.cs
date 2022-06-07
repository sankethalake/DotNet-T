using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}

        //[Test]
        //public void ShouldAddTwoNumber()
        //{
        //    Calculate.ICalculator sut = new Calculate.Calculator();
        //    Assert.That(sut.Add(7, 8), Is.EqualTo(15));

        //}
        //[Test]
        //public void ShouldMulTwoNumber()
        //{
        //    Calculate.ICalculator sut = new Calculate.Calculator();
        //    Assert.That(sut.Mul(7, 8), Is.EqualTo(15));

        //}

        Calculate.ICalculator sut;
        
        [SetUp]
        public void TestSetUp()
        {
            sut = new Calculate.Calculator();
        }

        [Test]
        public void ShouldAddTwoNumber()
        {
            Assert.That(sut.Add(7, 8), Is.EqualTo(15));
        }

        [Test]
        public void ShouldMulTwoNumber()
        {
            Assert.That(sut.Mul(1, 8), Is.EqualTo(8));
        }

        [TearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    }
}