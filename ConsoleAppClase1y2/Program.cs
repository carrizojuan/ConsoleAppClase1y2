using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ConsoleAppClase1y2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio2();

        }

        //EJERCICIO 1
        static string mayor100(int valor)
        {
            if (valor > 100)
            {
                return "El valor es mayor a 100";
            }
            return "El valor no es mayor a 100";
        }

        //EJERCICIO 2
        static void calcularParidad()
        {
            Console.Write("Ingresar valor: ");
            int numero = Int32.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El valor es par");
            }
            else
            {
                Console.WriteLine("El valor es impar");
            }
        }

        //EJERCICIO 3
        static bool VerificarSiEsElDobleDeUnImpar(int valor)
        {

            // Si el valor es impar, entonces no puede ser el doble de un impar
            if (valor % 2 != 0)
            {
                return false;
            }

            // Si el valor dividido entre 2 no es impar, entonces tampoco puede ser el doble de un impar
            if ((valor / 2) % 2 == 0)
            {
                return false;
            }

            // Si llegamos hasta aquí, entonces el valor es el doble de un impar
            return true;

        }

        //EJERCICIO 4
        public string ObtenerNumeroRomano(int numero)
        {
            Dictionary<int, string> valoresRomanos = new Dictionary<int, string>()
            {
                { 1, "I" },
                { 2, "II" },
                { 3, "III" },
                { 4, "IV" },
                { 5, "V" },
                { 6, "VI" },
                { 7, "VII" },
                { 8, "VIII" },
                { 9, "IX" },
                { 10, "X" }
            };
            // Comprobamos si el número está en el rango permitido (del 1 al 10)
            if (numero < 1 || numero > 10)
            {
                throw new ArgumentException("El número debe estar en el rango del 1 al 10");
            }

            // Buscamos el valor romano correspondiente al número en el diccionario
            return valoresRomanos[numero];
        }

        //EJERCICIO 5

        public (string, int) ObtenerNombreMenor(string nombrePersona1, int edadPersona1, string nombrePersona2, int edadPersona2)
        {
            string nombreMenor = "";
            int diferenciaEdad = 0;

            // Si ambas personas tienen la misma edad, se devuelve un mensaje indicándolo
            if (edadPersona1 == edadPersona2)
            {
                return ("Tienen la misma edad", 0);
            }

            // Si la edad de la primera persona es menor que la de la segunda, entonces la primera es la menor
            if (edadPersona1 < edadPersona2)
            {
                nombreMenor = nombrePersona1;
                diferenciaEdad = edadPersona2 - edadPersona1;
            }

            // Si la edad de la segunda persona es menor que la de la primera, entonces la segunda es la menor
            else
            {
                nombreMenor = nombrePersona2;
                diferenciaEdad = edadPersona1 - edadPersona2;
            }

            // Devolvemos el nombre de la persona menor y la diferencia de edad
            return (nombreMenor, diferenciaEdad);
        }

        //EJERCICIO 6
        public string ObtenerTipoTriangulo(int lado1, int lado2, int lado3)
        {
            // Si todos los lados son iguales, entonces es un triángulo equilátero
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Equilátero";
            }

            // Si solo dos lados son iguales, entonces es un triángulo isósceles
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Isósceles";
            }

            // Si ningún lado es igual a otro, entonces es un triángulo escaleno
            else
            {
                return "Escaleno";
            }
        }
        public int ObtenerPerimetroTriangulo(int lado1, int lado2, int lado3)
        {
            return lado1 + lado2 + lado3;
        }
        public double ObtenerAreaTriangulo(int lado1, int lado2, int lado3)
        {
            // Primero calculamos el semiperímetro
            double semiperimetro = (lado1 + lado2 + lado3) / 2.0;

            // Luego utilizamos la fórmula de Herón para calcular el área
            double area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

            // Devolvemos el área
            return area;
        }

        //EJERCICIO 7

        public string ObtenerDesglose(int cantidad)
        {
            // Lista que almacena el desglose de la cantidad en billetes y monedas
            List<string> desglose = new List<string>();

            // Arreglo que contiene las denominaciones de los billetes y monedas
            int[] denominaciones = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };

            // Realizamos el desglose de la cantidad en billetes y monedas
            foreach (int denominacion in denominaciones)
            {
                // Calculamos la cantidad de billetes o monedas de la denominación actual
                int cantidadDenominacion = cantidad / denominacion;

                // Si hay al menos un billete o moneda de la denominación actual, lo añadimos al desglose
                if (cantidadDenominacion > 0)
                {
                    desglose.Add($"{cantidadDenominacion} {(denominacion > 5 ? "billetes" : "monedas")} de {denominacion}");
                }

                // Actualizamos la cantidad restante
                cantidad -= cantidadDenominacion * denominacion;
            }

            // Devolvemos el desglose como una cadena de texto
            return string.Join(", ", desglose);
        }

        //EJERCICIO 8
        // Función que muestra todos los números del 1 al N
        public void MostrarNumeros(int N)
        {
            // Recorremos todos los números del 1 al N
            for (int i = 1; i <= N; i++)
            {
                // Mostramos el número actual
                Console.WriteLine(i);
            }
        }

        //EJERCICIO 9
        // Función que pide 15 números y devuelve la suma total
        public int SumarNumeros()
        {
            int suma = 0;

            // Pedimos 15 números al usuario
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                // Actualizamos la suma
                suma += numero;
            }

            // Devolvemos la suma
            return suma;
        }

        //EJERCICIO 10

        // Función que pide 5 números y devuelve si alguno es múltiplo de 3
        public bool ExisteMultiploTres()
        {
            List<int> numeros = new List<int>();
            // Pedimos 5 números al usuario
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
               
            }

            for (int i = 0; i < 5; i++)
            {
                // Si el número es múltiplo de 3, devolvemos true
                if (numeros[i] % 3 == 0)
                {
                    return true;
                }

            }

            // Si ningún número es múltiplo de 3, devolvemos false
            return false;
        }

        //EJERCICIO 11
        // Función que solicita una contraseña y la vuelve a solicitar hasta que las dos contraseñas coincidan
        public void SolicitarContrasena()
        {
            // Pedimos la contraseña al usuario
            Console.Write("Ingrese una contraseña: ");
            string contrasena1 = Console.ReadLine();

            // Pedimos la contraseña de nuevo al usuario
            Console.Write("Ingrese nuevamente la contraseña: ");
            string contrasena2 = Console.ReadLine();

            // Si las contraseñas no coinciden, volvemos a solicitar la contraseña
            while (contrasena1 != contrasena2)
            {
                Console.WriteLine("Las contraseñas no coinciden");

                Console.Write("Ingrese una contraseña: ");
                contrasena1 = Console.ReadLine();

                Console.Write("Ingrese nuevamente la contraseña: ");
                contrasena2 = Console.ReadLine();
            }
        }

        //EJERCICIO 12

        public void SolicitarContrasenaconPeticion()
        {
            // Pedimos la contraseña al usuario
            Console.Write("Ingrese una contraseña: ");
            string contrasena1 = Console.ReadLine();

            // Pedimos la contraseña de nuevo al usuario
            Console.Write("Ingrese nuevamente la contraseña: ");
            string contrasena2 = Console.ReadLine();

            int contador = 0;

            // Si las contraseñas no coinciden, volvemos a solicitar la contraseña
            while ((contrasena1 != contrasena2) || contador < 3)
            {
                contador += 1;
                Console.WriteLine("Las contraseñas no coinciden");

                Console.Write("Ingrese una contraseña: ");
                contrasena1 = Console.ReadLine();

                Console.Write("Ingrese nuevamente la contraseña: ");
                contrasena2 = Console.ReadLine();
            }

            if (contador == 3)
            {
                //Mostrar mensaje de error
                Console.WriteLine("Error: has ingresado la contraseña incorrectamente tres veces.");
            }
            else
            {
                //Mostrar mensaje de éxito
                Console.WriteLine("Las contraseñas coinciden.");
            }
        }

        //EJERCICIO 13

        public void AdivinarNumero()
        {

            //Declarar una variable para el número aleatorio
            int numeroAleatorio = new Random().Next(1, 101);

            //Declarar una variable para el número ingresado por el usuario
            int numeroIngresado = 0;

            //Mientras el usuario no haya adivinado el número
            while (numeroIngresado != numeroAleatorio)
            {
                //Solicitar al usuario que ingrese un número
                Console.WriteLine("Ingresa un número entre 1 y 100: ");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());

                //Verificar si el número ingresado es igual al número aleatorio
                if (numeroIngresado == numeroAleatorio)
                {
                    //Mostrar mensaje de felicitación
                    Console.WriteLine("¡Felicidades! Has adivinado el número.");
                }
            }
        }

        //EJERCICIO 14
        public void AdivinarNumeroConAyuda()
        {

            //Declarar una variable para el número aleatorio
            int numeroAleatorio = new Random().Next(1, 101);

            //Declarar una variable para el número ingresado por el usuario
            int numeroIngresado = 0;

            //Mientras el usuario no haya adivinado el número
            while (numeroIngresado != numeroAleatorio)
            {
                //Solicitar al usuario que ingrese un número
                Console.WriteLine("Ingresa un número entre 1 y 100: ");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());

                //Verificar si el número ingresado es igual al número aleatorio
                if (numeroIngresado == numeroAleatorio)
                {
                    //Mostrar mensaje de felicitación
                    Console.WriteLine("¡Felicidades! Has adivinado el número.");
                }
                else
                {
                    //Mostrar mensaje si el número ingresado es mayor o menor que el número aleatorio
                    if (numeroIngresado > numeroAleatorio)
                    {
                        Console.WriteLine("El número que ingresaste es mayor que el número aleatorio.");
                    }
                    else
                    {
                        Console.WriteLine("El número que ingresaste es menor que el número aleatorio.");
                    }
                }
            }
        }

        //EJERCICIO 15

        public void sumarNnumeros()
        {
            // Inicializamos la variable que almacenará la suma en cero
            int suma = 0;

            // Solicitamos al usuario que ingrese un número
            Console.WriteLine("Por favor, ingrese un número (escriba 'fin' para terminar):");

            // Leemos el número que ingresó el usuario
            string entrada = Console.ReadLine();

            // Mientras que el usuario no haya ingresado la palabra 'fin', repetimos el proceso
            while (entrada != "fin")
            {
                // Convertimos la entrada del usuario a un número entero
                int numero = Int32.Parse(entrada);

                // Agregamos el número a la suma
                suma += numero;

                // Solicitamos al usuario que ingrese otro número
                Console.WriteLine("Por favor, ingrese otro número (escriba 'fin' para terminar):");

                // Leemos el nuevo número que ingresó el usuario
                entrada = Console.ReadLine();
            }

            // Una vez que el usuario ha ingresado la palabra 'fin', mostramos la suma total
            Console.WriteLine("La suma total es: " + suma);
        }

    }
}
