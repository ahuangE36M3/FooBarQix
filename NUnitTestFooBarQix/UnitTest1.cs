using NUnit.Framework;
using FooBarQix;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("1", "1")]
        [TestCase("2", "2")]
        [TestCase("3", "FooFoo")]
        [TestCase("4", "4")]
        [TestCase("5", "BarBar")]
        [TestCase("6", "Foo")]
        [TestCase("7", "QixQix")]
        [TestCase("8", "8")]
        [TestCase("9", "Foo")]
        [TestCase("10", "Bar")]
        [TestCase("13", "Foo")]
        [TestCase("15", "FooBarBar")]
        [TestCase("21", "FooQix")]
        [TestCase("33", "FooFooFoo")]
        [TestCase("51", "FooBar")]
        [TestCase("53", "BarFoo")]
        [TestCase("101", "1*1")]
        [TestCase("303", "FooFoo*Foo")]
        [TestCase("105", "FooBarQix*Bar")]
        [TestCase("10101", "FooQix**")]
        public void WhenCompute(string strIn, string strOut)
        {
            var result = Program.Compute(strIn);
            Assert.That(result, Is.EqualTo(strOut));
        }
    }
}