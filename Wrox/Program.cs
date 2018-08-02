using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Wrox
{
    class Program
    {
        static void Main(string[] args)
        {

            //long l = 1234L;
            var name = "Bugs Bunny";
            var age = 25;
            var isRabbit = true;
            //var s = age.ToString();
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();
            WriteLine($"name is type {nameType}");
            WriteLine($"age is type {ageType}");
            WriteLine($"isRabbit is type {isRabbitType}");


            WriteLine(@"Twas brilling and the slithy toves
Did gyre aand gimble in the wabe.");
        }
    }
}
