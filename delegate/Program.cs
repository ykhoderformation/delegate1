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
            //exemple d'action

            Action<string, double, double, double> uneaction = (a, b, c, d) => Console.WriteLine("a: " + a + " b: " + b + " c: " + c + " d: " + d);
            uneaction("toto", 5, 5, 2);
            uneaction("tata", 15, 3, 2);
            uneaction("titi", -1, 5, -2);


            //exepmle de predicat 

            Predicate<double> HasMoyenne = note =>
            {
                return note > 18;
                //if (note > 18)
                //{
                //    Console.WriteLine("J'ai resussi");
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            };
                double maNote = 19;

                bool rslt = HasMoyenne(maNote);

            Console.WriteLine(rslt);
            

            Console.Read();
        }

       
    }
}
