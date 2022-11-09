using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerProjects
{
    public class mathsTable
    {
        public void myTable()
        {
            int a = 2;
            for (int i=1; i<=20; i++)
            {
                Console.WriteLine($"{a} x {i} = {a * i}");
            }
        }
    }
}
