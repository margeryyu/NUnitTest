using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class SimpleCalculator
   {
      public decimal Add(decimal a, decimal b)
      {
         return a + b;
      }

      public decimal multiply(decimal a, decimal b)
      {
         return a * b;
      }

      public double AddDouble(double a, double b)
      {
         return a + b;
      }

      public double Divide(int value, int by)
      {
         if (value > 100)
         {
            throw new ArgumentOutOfRangeException("by");
         }
         return value / by;
      }

   }
   
   public class MemoryCalculator
   {
      public int CurrentValue { get; set; }

      public int Add(int a)
      {
         CurrentValue = CurrentValue + a;
         return CurrentValue;
      }

      public int Subtract(int a)
      {
         CurrentValue = CurrentValue - a;
         return CurrentValue;
      }
   }
}
