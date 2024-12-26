using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {   
        static void Main(string[] args)
        {
           int x=int.Parse(args[0]);
            int y=int.Parse(args[1]);
            string op=args[2];


            int res = 0;
            if (op == "+")
            {
                res = x + y;
            }
            else if (op == "-")
            {
                res = x - y;
            }
            else if (op == "*")
            {
                res = x * y;
            }
            else
            {
                res = x / y;
            }
            Console.WriteLine(res);
        }


        
    }
}
