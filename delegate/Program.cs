using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class Program
    {
        

        static void Main(string[] args)
        {


            Init opr = new Init();
            opr.a = 100;
            opr.b = 14;

            //opr.operation =Init.Addition;
            opr.operation = (a, b) => $"Somme: {a + b}";
            opr.Run();

            //opr.operation = Init.Soustraire;
            opr.operation = (a, b) => $"Soustraction: {a - b}";

            opr.Run();

            //avec expression lamda ou on n a pas besoin de definir une fonction 

            opr.operation = (a, b) => $"Multiplication: {a * b}";
            opr.Run();
            Console.Read();
        }

       
    }
}
