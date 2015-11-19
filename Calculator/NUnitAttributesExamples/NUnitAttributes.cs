using Calculator;
using NUnit.Framework;
using System;

//TestFixture: Simple NUnit test examples
//1. Running code before and after each test
//2. Running code before and after a Fixture
//3. Running code before and after a namespace or assambly
namespace NUnitAttributesExamples
{
   [TestFixture]
   public class MemoryCalculatorTests
   {
      MemoryCalculator sut;

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

      [SetUp]
      public void BeforeEachTest()
      {
         //Running code before and after each test
         Console.WriteLine("Before {0}", TestContext.CurrentContext.Test.Name);
         sut = new MemoryCalculator();
      }

      [TearDown]
      public void AfterEachTest()
      {
         //Running code before and after each test
         Console.WriteLine("After {0}", TestContext.CurrentContext.Test.Name);
         sut = null;
      }

      [TestFixtureSetUp]
      public void BeforeAnyTestStarted()
      {
         Console.WriteLine("***Before PlayerCharacterTests***");
      }

      [TestFixtureTearDown]
      public void AfterAnyTestStarted()
      {
         Console.WriteLine("***After PlayerCharacterTests***");
      }
   }
}
