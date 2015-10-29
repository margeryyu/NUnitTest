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
          // bug for demo purposes
          return a + b;
       }
    }
}
