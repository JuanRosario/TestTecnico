using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write(UpperCase("pepe pepe "));
            Console.Write("\n");
            Console.Write(LowerCase("PEPE PEPE"));


            
            Console.ReadKey();
        }

        public static string UpperCase(string phrase)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char p in phrase)
                builder.Append(Convert.ToChar(((int)p) - 32));
            return builder.ToString();
        }

        public static string LowerCase(string phrase)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char p in phrase)
                builder.Append(Convert.ToChar((((int)p) + 32)));
            return builder.ToString().Replace('@', ' ');
        }

        public string SnakeCase(string phrase)
        {
            var lowers = LowerCase(phrase).Split(" ");
            var w = string.Join('_', lowers);
            return w.Substring(0, w.Length - 1);
        }
       
        // 
        public string PascalCase(string phrase)
        {
            StringBuilder str = new StringBuilder();
            var lowers = LowerCase(phrase).Split(" ");
            foreach (var lower in lowers)
            {
                if (lower.Length != 0)
                {
                    int d = (int)lower[0];
                    char p = Convert.ToChar((d) - 32);
                    str.Append(p + lower.Substring(1));
                }
            }

            return str.ToString();
        }
    }

}
