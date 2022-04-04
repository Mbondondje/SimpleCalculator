using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float nombre1, nombre2, choix;

            Console.WriteLine("--------------------------");
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\n\n");


            Console.WriteLine("Entrez le premier nombre :");
            nombre1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le second nombre :");
            nombre2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Opérations : \n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Soustraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Retour");
            Console.Write("Faire votre choix :");
            choix = Convert.ToInt32(Console.ReadLine());

            switch(choix)
            {
                case 1:
                    Console.WriteLine("L'addition de {0} et {1} est: {2}\n", nombre1, nombre2, nombre1 + nombre2);
                    break;

                case 2:
                    Console.WriteLine("La soustraction de {0} et {1} est: {2}\n", nombre1, nombre2, nombre1 - nombre2);
                    break;

                case 3:
                    Console.WriteLine("La multiplication de {0} et {1} est: {2}\n", nombre1, nombre2, nombre1 * nombre2);
                    break;

                case 4:
                    if(nombre2 == 0)
                    {
                        Console.WriteLine("Opération impossible");
                    }else
                    {
                        Console.WriteLine("La division de {0} et {1} est: {2}\n", nombre1, nombre2, nombre1 / nombre2);
                    }
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("Vous n'avez pas fait le bon choix");
                    break;
            }
        }
    }
}
