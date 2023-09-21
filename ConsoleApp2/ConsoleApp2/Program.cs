using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            mostrarMenu();

            Console.ReadKey();
        }

        public static void mostrarMenu()
        {
            Console.WriteLine("Bienvenido usuario!");
            Console.WriteLine("Seleccione la opcion que desea: ");
 
            Console.WriteLine("1. Potenciar");
            Console.WriteLine("2. Dividir");
            Console.WriteLine("3. Comparar fechas");
            Console.WriteLine("4. Comparar texto");
            Console.WriteLine("5. Inversion de texto");
            Console.WriteLine("6. Palindromo");
            Console.WriteLine("7. Numeros Pares");
            Console.WriteLine("8. Invertir un numero");

            int opcion = int.Parse(Console.ReadLine());

            while (opcion != 0) {

                switch (opcion)
                {
                    case 1: Potencia(9, 0); break;
                    case 2: Division(50, 5); break;
                    case 3: CompararDates(); break;
                    case 4: CompararTexto("alberto", "mabel"); break;
                    case 5: InversionTexto("anilina"); break;
                    case 6: Palindromo("anilina"); break;
                    case 7: NumerosPares(); break;
                    case 8: InvertirNumero(412); break;
                    case 0: return;
                    default: break;
                }
            }

        }

        public static int Potencia(int numero,int potencia)
        {
            int contador = 1;
            int resultado = 1;

            while(contador <= potencia)
            {
                resultado = resultado * numero;
                contador++;
            }

            Console.WriteLine(resultado);
            return resultado;
        }

        public static int Division(int numero, int divisor)
        {
            int contador = 0;
            int sobrante = numero;

            while( divisor <= sobrante ) 
            { sobrante = sobrante - divisor;
                contador++; 
            }

            Console.WriteLine(contador);
            return contador;
        }

        public static bool CompararTexto(string frase,string frase1)
        {
            bool resultado = true;

            frase = frase.ToLower();
            frase1 = frase1.ToLower();

            char primeraLetra = frase[0];
            char primeraLetra1 = frase1[0];

            if(primeraLetra == primeraLetra1 ) 
            {
                Console.WriteLine("Son iguales alfabeticamente.");
            }
            else if( primeraLetra < primeraLetra1 )
            {
                resultado = true;
                Console.WriteLine("La frase alfabeticamente es: " + frase);
            }
            else
            { 
                resultado = false;
                Console.WriteLine("La frase alfabeticamente es: "+ frase1); 
            }

            return resultado;

        }

        public static void CompararDates()
        {

            //Realizar un método que aceptará dos fechas en formato string. Dependiendo de si una fecha es anterior,
            // igual o posterior a la otra fecha, devolverá true, null o false, respectivamente.

            string fecha = "22/10/2022";
            int mesFecha = 0;
            int añoFecha = 0;
            int diaFecha = 0;
            int dayfecha = 0;

            string fecha1 = "20/09/2021";
            int mesFecha1 = 0;
            int añoFecha1 = 0;
            int diaFecha1 = 0;
            int dayfecha1 = 0;

            añoFecha = int.Parse(fecha.Substring(6, 4));
            añoFecha1 = int.Parse(fecha1.Substring(6, 4));

            mesFecha = int.Parse(fecha.Substring(3, 2));
            mesFecha1 = int.Parse(fecha1.Substring(3, 2));

            diaFecha = int.Parse(fecha.Substring(0, 2));
            diaFecha1 = int.Parse(fecha1.Substring(0, 2));


            dayfecha = diaFecha + (mesFecha * 100) + (añoFecha * 1000);
            dayfecha1 = diaFecha1 + (mesFecha1 * 100) + (añoFecha1 * 1000);


            if (dayfecha == dayfecha1)
            {
                Console.WriteLine("Ambas fechas llegaran iguales.");
            }
            else if (dayfecha > dayfecha1)
            {
                Console.WriteLine("La fecha " + fecha1 + " llegara antes que la fecha " + fecha);
            }
            else
            {
                Console.WriteLine("La fecha " + fecha1 + " llegara antes que la fecha " + fecha);
            }



        }

        public static string InversionTexto(string palabra)
        {
            string palabra1 = "";
            char letra;

            for(int i = palabra.Length ; i > 0 ; i--)
            {   
                letra = palabra[i-1];
                palabra1 = palabra1 + letra;
            }
            Console.WriteLine(palabra1);
            return palabra1;
        }

        public static bool Palindromo(string texto)
        {
            string texto1 = InversionTexto(texto);
            bool palindromo = false;

            if(texto1 == texto)
            {
                palindromo = true;
                Console.WriteLine("El texto o palabra es palindromo.");
            }
            else
            {
                Console.WriteLine("No son palindromo.");
            }
            return palindromo;
        }

        public static void Adivinanza()
        {
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(0, 21);
            int numeroElegido = 0;

            Console.WriteLine("Hola bienvenido al juego de las adivinanzas: ");

            do
            {
                Console.WriteLine("Introduzca un numero: ");
                numeroElegido = int.Parse(Console.ReadLine());

                if(numeroElegido > numeroAleatorio)
                { Console.WriteLine("Cerca, elegiste uno mas grande.");}
                else { Console.WriteLine("Cerca, elegiste uno mas pequeño."); }

            } while (numeroAleatorio != numeroElegido);

            Console.WriteLine("Has acertado el numero, felicitaciones!");

            Console.WriteLine("El numero aleatorio es "+numeroAleatorio+
            " y el numero elegido ha sido "+numeroElegido);
        }

        public static void NumerosPares()
        {
            int contador = 0;
            int contadorW = 0;
            int contadorD = 0;

            for(int i = 0; i <= 20; i++) 
            { 
                if(i % 2 == 0) 
                { contador++; }
            }

            int iterador = 0;

            while (iterador != 21 )
            {
                if (iterador % 2 == 0) { contadorW++; }
                iterador++;
            };

            int iterator = 0;
            do
            {
                if (iterator % 2 == 0) { contadorD++; }
                iterator++;
            } while (21 > iterator);


            Console.WriteLine($"El contador del bucle for arroja :" + contador);
            Console.WriteLine($"El contador del bucle while arroja :" + contadorW);
            Console.WriteLine($"El contador del bucle do while arroja :" + contadorD);

        }

        public static int InvertirNumero(int numero)
        {

            int numeroInvertido = 0;

            while (numero != 0)
            {
                int ultimoNumero = numero % 10;

                numeroInvertido = numeroInvertido * 10 + ultimoNumero;

                numero = numero / 10;
            }

            Console.WriteLine(numeroInvertido);
            return numeroInvertido;
        }




    }
}
