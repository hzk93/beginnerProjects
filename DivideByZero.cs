using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerProjects
{
    public class DivideByZero
    {
        public void dividebyZ()
        {
            int a = 1;
            int b = 0;
            
            try
            {
                int c = a / b;
            }

            catch (Exception e)
            {
                Console.WriteLine($"You tried to Divide by Zero {a}/{b} not allowed");
            }
        }
    }

}
