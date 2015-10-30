using NUnit.Framework;
using JoinString;

namespace Calculator.Test
{
   [TestFixture]
   public class SimpleCalculatorTests
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

      [Test]
      public void JoinString_Equality()
      {
         var js = new JoinTwoString();
         var result = js.Join("Margery", "Yu");
         Assert.That(result, Is.EqualTo("Margery Yu"));
      }

      [Test]
      public void JoinString_Equality_IgnoreCaseSensitive()
      {
         var js = new JoinTwoString();
         var result = js.Join("Margery", "Yu");
         Assert.That(result, Is.EqualTo("MARGERY YU").IgnoreCase);
      }

      [Test]
      public void JoinString_NotEquality()
      {
         var js = new JoinTwoString();
         var result = js.Join("Margery", "Yu");
         Assert.That(result, Is.Not.EqualTo("MARGERY WANG").IgnoreCase);
      }
   }
}
