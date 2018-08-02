using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector x, y;
            x = new Vector();
            
            
            y = x;
            Console.WriteLine(y.Value);
            x.Value = 30;
            //y.Value = 50;

           
            Console.WriteLine(y.Value);
        }
    }

    public class Vector
    {

        public int Value { get; set; }

        public Vector()
        {
            Value = 90;
        }
    }
}
