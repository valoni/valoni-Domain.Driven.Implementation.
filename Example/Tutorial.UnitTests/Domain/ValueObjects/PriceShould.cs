using Example.Core.Domain.Enums;
using Example.Core.Domain.ValueObjects;
using NUnit.Framework;

namespace Example.UnitTests.Domain.ValueObjects
{
    public class PriceShould
    {
        [Test]
        public void Test_ToString_For_SpecifiedUnitType()
        {
            // arrange
            var price = new Price(14, MoneyUnit.Dollar);

            // act
            var actualResult = price.ToString();
            
            // assert
            Assert.That(actualResult.Equals("14 $"));
        }
    }
}
