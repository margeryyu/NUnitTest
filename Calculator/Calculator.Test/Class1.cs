using NUnit.Framework;

namespace Calculator.Test
{
   [TestFixture]
   public class CalculatorTests
   {
      [Test]
      public void ShouldAddTwoNumbers()
      {
         var sut = new SimpleCalculator();
         var result = sut.Add(3.5m, 2m);
         Assert.That(result, Is.EqualTo(5.5m));
      }

      [Test]
      public void ShouldMultipleTwoNumbers()
      {
         var sut = new SimpleCalculator();
         var result = sut.multiply(3.5m, 2m);
         Assert.That(result, Is.EqualTo(7m));
      }
   }
}
