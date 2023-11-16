using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter perimeter");
            int perimeter =Console.Read();
            int poluperimetr = perimeter / 2;
            
            Double side = (perimeter / 3);
            
            Double S = Math.Round(Math.Sqrt(poluperimetr * (poluperimetr - side) * (poluperimetr - side) * (poluperimetr - side)),2);
            Console.WriteLine("Side = "+side);
            Console.WriteLine("S = "+S);
            Console.WriteLine("Done");
        }
    }
}
