using NUnit.Framework;
using JoinString;
using System;

namespace Calculator.Test
{
   //TestFixture 1 : Simple NUnit test examples
   //Equality and inequality
   //Ranges
   //Nulls and Booleans
   //Collections
   //Reference equality
   //Exceptions
   [TestFixture]
   public class NunitTestsExamples
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

      [Test]
      public void ShouldMultipleTwoDoubles_WithTolerance()
      {
         var myObject = new SimpleCalculator();
         var result = myObject.AddDouble(1.1, 2.2);
         Assert.That(result, Is.EqualTo(3.3).Within(0.1));
      }

      [Test]
      public void ShouldMultipleTwoDoubles_WithTolerancePercent()
      {
         var myObject = new SimpleCalculator();
         var result = myObject.AddDouble(50, 50);
         Assert.That(result, Is.EqualTo(100).Within(1).Percent);
      }

      [Test]
      public void ShouldMultipleTwoDoubles_Negative()
      {
         var myObject = new SimpleCalculator();
         var result = myObject.AddDouble(50, -50);
         Assert.That(result, Is.LessThanOrEqualTo(0));
      }

      [Test]
      public void ShouldErrorWhenDivideByZero()
      {
         var myObject = new SimpleCalculator();
         Assert.That(() => myObject.Divide(200, 0), Throws.Exception);
      }

      [Test]
      public void ShouldErrorWhenDivideByZero_ExpliciteExceptionType()
      {
         var myObject = new SimpleCalculator();
         Assert.That(() => myObject.Divide(99, 0), Throws.TypeOf<DivideByZeroException>());
      }

      [Test]
      public void ShouldErrorWhenDivideByZero_ExpectedFail()
      {
         var myObject = new SimpleCalculator();
         Assert.That(() => myObject.Divide(200, 0), Throws.TypeOf<DivideByZeroException>());
      }

      [Test]
      public void ShouldErrorWhenNumberTooBig()
      {
         var myObject = new SimpleCalculator();
         Assert.That(() => myObject.Divide(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>());
      }

      [Test]
      public void ShouldErrorWhenNumberTooBig_MoreExplicit()
      {
         var myObject = new SimpleCalculator();
         Assert.That(() => myObject.Divide(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Matches<ArgumentOutOfRangeException>(x => x.ParamName == "by"));
      }
   }


   //TestFixture 2 : Simple NUnit test examples
   [TestFixture]
   public class MemoryCalculatorTests
   {
      MemoryCalculator sut = new MemoryCalculator();

      [Test]
      public void ShouldAdd()
      {
         sut.Add(10);
         sut.Add(5);
         Assert.That(sut.CurrentValue, Is.EqualTo(15));
      }

      [Test]
      public void ShouldSubtract()
      {
         sut.Subtract(5);
         Assert.That(sut.CurrentValue, Is.EqualTo(-5));
      }


   }
}
