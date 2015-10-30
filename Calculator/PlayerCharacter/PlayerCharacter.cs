using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCharacter
{
   public class PlayerCharacters
    {
       public int Health { get; set; }
       public string Name { get; private set; }
       public string NickName { get; set; }
       public bool IsNoob { get; set; }
       public List<string> Weapons { get; set; }

       public void Player()
       {
          Name = GenerateName();
          IsNoob = true;
       }

       public void Sleep()
       {
          var rnd = new Random();
          var healthIncrease = rnd.Next(1, 101);
          Health += healthIncrease;
       }

       public void TakeDamage(int damage)
       {
          Health = Math.Max(1, Health -= damage);
       }

       private string GenerateName()
       {
          var names = new[] { "Allen", "Robert", "Simon", "Sinny", "Lene" };
          var rnd = new Random();
          return names[rnd.Next(0, 4)];
       }
    }
}
