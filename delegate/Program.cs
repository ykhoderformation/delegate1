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


            //exemple LINQ

            ICollection<string> eleves = new List<string>();
            eleves.Add("E13");
            eleves.Add("E222");
            eleves.Add("E3333333");
            eleves.Add("E4");
            eleves.Add("E5000");

            Console.WriteLine("J'ai "+ eleves.Count+"élèves");

            List<string> eleves4Caratere = eleves.Where( s => s.Count() >4).ToList();
            List<string> ELEVES4C = (from o in eleves where o.Count() > 4 select o).ToList();

            Console.WriteLine("les eleves ayant plus de 4 lettres dans leurs prenoms sont:");
            foreach (string prenom in eleves4Caratere)
            {
                Console.WriteLine(prenom);
            }

            Console.WriteLine("Entity Framework");
            foreach (string prenom in ELEVES4C)
            {
                Console.WriteLine(prenom);
            }

            Console.WriteLine("Les eleves qui contiennent 3 dans leurs noms sont:");

            bool hasFoundPerson = eleves.Where(p => p.Contains("3")).Where(p => p.Count() <= 4).Any();
            string firstPerson = eleves.Where(p => p.Contains("3")).Where(p => p.Count() <= 4).FirstOrDefault().ToString();

            Console.WriteLine(hasFoundPerson? "J'ai trouvé un ":" Personne introuvable");
            Console.WriteLine(firstPerson);


            //dictionnaire

            Dictionary<int, string> monDico = new Dictionary<int, string>();

            monDico.Add(1,"Hello0");
            monDico.Add(2, "World");
            monDico.Add(3, "Hola0");
            monDico.Add(4, "Familia");
            monDico.Add(5, "Heko0");

            if (monDico.Any(d=>d.Value.EndsWith("0")))
            {
                foreach (KeyValuePair<int, string> item in monDico.Where(d => d.Value.EndsWith("0")).ToList())
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Dico");
                foreach (KeyValuePair<int, string> item in monDico.Where(d => d.Value.EndsWith("0")))
                {
                    Console.WriteLine(item);

                }
                Console.WriteLine(monDico.Where(d => d.Value.EndsWith("0")).ElementAt(1).ToString());  //FirstOrDefault().ToString()); 
            }




            Console.Read();
        }

       
    }
}
