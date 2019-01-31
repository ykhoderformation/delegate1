using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
   public class Init
{

        public delegate string Calculer(int a, int b);
        public Calculer operation;
        public int a { get; set; }
        public int b { get; set; }

        public void Run()
        {
            var rslt = operation(a,b);
            Console.WriteLine(rslt);
           
        }
        // pas de besoin de declarer de fonction avec les expressions lamda

        //public static int Addition(int a, int b)
        //{

        //    return a + b;
        //}
        //public static int Soustraire(int a, int b)
        //{

        //    return a - b;
        //}
    }
}
