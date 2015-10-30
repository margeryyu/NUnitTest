using NUnit.Framework;
using PlayerCharacter;

namespace PlayerCharacterTests
{
   [TestFixture]
   public class PlayerCharacterTests
   {
      [Test]
      public void ShouldIncreaseHealthInExpectedRangeAfterSleeping()
      {
         var sut = new PlayerCharacters { Health = 100 };
         sut.Sleep();
         Assert.That(sut.Health, Is.InRange(101, 200));
      }

      [Test]
      public void ShouldIncreaseHealthAfterSleeping()
      {
         var sut = new PlayerCharacters { Health = 100 };
         sut.Sleep();
         Assert.That(sut.Health, Is.GreaterThan(100));
      }
   }
}
