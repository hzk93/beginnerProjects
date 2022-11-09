using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerProjects
{
    public class calcHandlExcep
    {
        public void calculator()
        {
            try
            {
                Console.WriteLine("Enter the First Number\n");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number\n");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select the Operation To Perform\n");
                Console.WriteLine("To Add '+'\nFor Subtract '-'\nFor Multiplication '*'\nFor Division '/'\n");
                string z = Console.ReadLine();
                switch (z)
                {
                    case "+":
                        Console.WriteLine($"First Number: ({x}) + Second Number: ({y}) = {x + y}");
                        break;
                    case "-":
                        Console.WriteLine($"First Number: ({x}) - Second Number: ({y}) = {x - y}");
                        break;
                    case "*":
                        Console.WriteLine($"First Number: ({x}) * Second Number: ({y}) = {x * y}");
                        break;
                    case "/":
                        Console.WriteLine($"First Number: ({x}) / Second Number: ({y}) = {x / y}");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Faced some computational error");
            }
        }
    }
}
