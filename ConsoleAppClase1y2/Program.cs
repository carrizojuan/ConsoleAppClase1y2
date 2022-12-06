using System;

namespace ConsoleAppClase1y2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio2();
            
        }

        static void Ejercicio1() 
        { 
            Console.Write("Ingresar valor: ");
            int numero = Int32.Parse(Console.ReadLine());
            if (numero>100)
            {
                Console.WriteLine("El valor es mayor a 100");
            }
        }

        static void Ejercicio2()
        {
            Console.Write("Ingresar valor: ");
            int numero = Int32.Parse(Console.ReadLine());
            if (numero%2 == 0)
            {
                Console.WriteLine("El valor es par");
            }
            else
            {
                Console.WriteLine("El valor es impar");
            }
        }

        static void Ejercicio3() 
        {

        }
    }
}
