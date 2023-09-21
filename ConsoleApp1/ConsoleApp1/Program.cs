using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1{
    class Program

    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Bienvenido usuario!");
            //Console.WriteLine("Que deseas hacer?");
            //Console.WriteLine("NIVEL 1");
            //Console.WriteLine("NIVEL 2");
            //Console.WriteLine("NIVEL 3");
            //int opcion = int.Parse(Console.ReadLine());
            //Console.WriteLine(opcion);

            Ejercicio19();
            Console.ReadKey();
        }

        public static T Sumar<T>(T numero1, T numero2)
        {
            dynamic num1 = numero1;
            dynamic num2 = numero2;

            return num1 + num2;
        }

        public static T Restar<T>(T numero1, T numero2)
        {
            dynamic num1 = numero1;
            dynamic num2 = numero2;

            return num1 - num2;
        }

        public static T Multiplicacion<T>(T numero1, T numero2)
        {
            dynamic num1 = numero1;
            dynamic num2 = numero2;

            return num1 * num2;
        }

        public static T Division<T>(T numero1, T numero2)
        {
            dynamic num1 = numero1;
            dynamic num2 = numero2;

            return num1 / num2;
        }

        public static T Modulo<T>(T numero1, T numero2)
        {
            dynamic num1 = numero1;
            dynamic num2 = numero2;

            return num1 % num2;
        }



        static void Ejercicio1()
    {
        Console.WriteLine("introduce un numero:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("introduce otro numero:");
        int num2 = int.Parse(Console.ReadLine());
        int resultado = Sumar(num1, num2);

        Console.WriteLine($"La suma de estos dos numeros es: {resultado};");

            Console.ReadKey();
            Console.Clear();


        Console.WriteLine("introduce un numero:");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("introduce otro numero:");
        int num4 = int.Parse(Console.ReadLine());
        int resultado1 = Restar(num3, num4);

        Console.WriteLine($"La resta de estos dos numeros es: {resultado1}");

            Console.ReadKey();
            Console.Clear();


        Console.WriteLine("introduce un numero:");
        int num5 = int.Parse(Console.ReadLine());
        Console.WriteLine("introduce otro numero:");
        int num6 = int.Parse(Console.ReadLine());
        int resultado3 = Multiplicacion(num5, num6);

        Console.WriteLine($"La multiplicacion de estos dos numeros es: {resultado3}");

            Console.ReadKey();
            Console.Clear();


        Console.WriteLine("introduce un numero:");
        int num7 = int.Parse(Console.ReadLine());
        Console.WriteLine("introduce otro numero:");
        int num8 = int.Parse(Console.ReadLine());
        int resultado4 = Division(num7, num8);

        Console.WriteLine($"La division de estos dos numeros es: {resultado4}");

            Console.ReadKey();
            Console.Clear();

        Console.WriteLine("introduce un numero:");
        int num9 = int.Parse(Console.ReadLine());
        Console.WriteLine("introduce otro numero:");
        int num10 = int.Parse(Console.ReadLine());
        int resultado5 = Modulo(num9, num10);

            Console.WriteLine($"El modulo de estos dos numeros es: {resultado5}");
        }

        static void Ejercicio2()
        {
            int N = 4;
            double A = 4.45;
            char C = 'a';
            double suma1 = N + A;
            double resta1 = A - N;
            double valorNumerico = char.GetNumericValue(C);

            Console.WriteLine($"El valor de N es : {N}");
            Console.WriteLine($"El valor de A es : {A}");
            Console.WriteLine($"El valor de C es : {C}");

            Console.WriteLine($"La suma de N y A da como resultado: {suma1}");
            Console.WriteLine($"La diferencia de A menos N da como resultado: {resta1}");
            Console.WriteLine($"El valor numerico de la variable C es: {valorNumerico}");
        }


        static void Ejercicio3()
        {
            int X = 4;
            int Y = 5;
            double N = 20.15;
            double M = 30.20;

            Console.WriteLine($"El valor de X es : {X}");
            Console.WriteLine($"El valor de Y es : {Y}");
            Console.WriteLine($"El valor de N es : {N}");
            Console.WriteLine($"El valor de M es : {M}");

            double suma = Sumar(X, Y);
            double resta = Restar(X, Y);    
            double producto = Multiplicacion( X,Y);
            double cociente = Division(X,Y);
            double resto = Modulo(X,Y);

            Console.WriteLine($"La suma entre X y Y es : {suma}");
            Console.WriteLine($"La diferencia de X menos Y da como resultado: {resta}");
            Console.WriteLine($"El producto de X por Y da como resultado: {producto}");
            Console.WriteLine($"El cociente de X sobre Y da como resultado: {cociente}");
            Console.WriteLine($"El resto de X sobre Y da como resultado: {resto}");

            double suma2 = Sumar(N,M);
            double resta2 = Restar(N,M);
            double producto2 = Multiplicacion(N,M);
            double cociente2 = Division(N,M);
            double resto2 = Modulo(N,M);

            Console.WriteLine($"La suma entre N y M es : {suma2}");
            Console.WriteLine($"La diferencia de N menos M da como resultado: {resta2}");
            Console.WriteLine($"El producto de N por M da como resultado: {producto2}");
            Console.WriteLine($"El cociente de N sobre M da como resultado: {cociente2}");
            Console.WriteLine($"El resto de N sobre M da como resultado: {resto2}");

            double suma3 = Sumar(X, N);
            double cociente3 = Division( Y,M );
            double resto3 = Modulo (Y, M);

            Console.WriteLine($"La suma entre N y M es : {suma3}");
            Console.WriteLine($"El cociente de N sobre M da como resultado: {cociente3}");
            Console.WriteLine($"El resto de N sobre M da como resultado: {resto3}");

            Console.WriteLine($"El doble de cada X sera:{X * 2}");
            Console.WriteLine($"El doble de cada Y sera:{Y * 2}");
            Console.WriteLine($"El doble de cada N sera:{N * 2}");
            Console.WriteLine($"El doble de cada M sera:{M * 2}");

            Console.WriteLine($"La suma de todas las variables da como resultado: {X + Y + N + M}");
            Console.WriteLine($"El producto de todas las variables da como resultado: {X * Y * N * M}");

        }

        static void Ejercicio4()
        {

            int N = 3;

            Console.WriteLine("El valor de N inicial es: " + N);
            N += 77 ;
            
            Console.WriteLine("El valor de N es: " + N);

            N = Restar(N, 3);
            Console.WriteLine("El valor de N ahora es: " + N);

            N = N * 2;
            Console.WriteLine("El valor de N duplico a: " + N);

        }

        static void Ejercicio5()
        {
            Console.WriteLine("introduce un numero:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("introduce otro numero:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("introduce un numero:");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("introduce otro numero:");
            int D = int.Parse(Console.ReadLine());

            B = C;
            C = A;
            A = D;
            D = B;

            Console.WriteLine("Ahora B vale: " + B);
            Console.WriteLine("Ahora C vale: " + C);
            Console.WriteLine("Ahora A vale: " + A);
            Console.WriteLine("Ahora D vale: " + D);

        }

        //-------------- Nivel 2 ------------
        static void Ejercicio6()
        {
            int A = 1;
            int B = 2;
            int C = 3;

            Console.WriteLine("El valor de A es : " + A);
            Console.WriteLine("El valor de B es : " + B);
            Console.WriteLine("El valor de C es : " + C);

            int suma = A+B+C;
            Console.WriteLine("La suma de todos ellos da como resultado: " + suma);
            


        }

        static void Ejercicio7()
        {
            Console.WriteLine("Hola usuario, digame su nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Okay, digame su ciudad ahora: ");
            string Ciudad = Console.ReadLine();

            Console.WriteLine($"Hola {Nombre}, bienvenido a {Ciudad}");
        }

        static void Ejercicio8()
        {
            Console.WriteLine("Hola usuario, digame su nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Okay, digame su edad ahora: ");
            string Edad = Console.ReadLine();

            Console.WriteLine($"Hola tu te llamas {Nombre} y tienes {Edad} años");
        }

        static void Ejercicio9()
        {
            Console.WriteLine("Introduzca un numero por favor : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Okay, deme otro numero por favor: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2) 
            {
                Console.WriteLine($"Ambos numeros son iguales.");
            } 
            else if (num1 < num2) 
            { Console.WriteLine($"El valor mayor es: {num2}");
            }
            else
            { Console.WriteLine($"El valor mayor es: {num1}"); 
            }
        }


        static void Ejercicio10()
        {
            Console.Write("Ingresa el nombre de un día de la semana: ");
            string nombreDia = Console.ReadLine();

            nombreDia = nombreDia.ToLower();

            if (nombreDia == "sabado" || nombreDia == "domingo")
            {
                Console.WriteLine("Es un fin de semana.");
            }
            else if (nombreDia == "lunes" || nombreDia == "martes" || nombreDia == "miércoles" || nombreDia == "miercoles" || nombreDia == "jueves" || nombreDia == "viernes")
            {
                Console.WriteLine("No es un fin de semana.");
            }
            else
            {
                Console.WriteLine("El día ingresado no es válido.");
            }

            Console.ReadLine();
        }

        static void Ejercicio11()
        {   
            Console.WriteLine("Introduce un valor del producto: ");
            int precioProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Como vas a pagar: efectivo o tarjeta ?");
            string formaPago = Console.ReadLine();

            if (formaPago == "tarjeta")
            {
                Console.WriteLine("Entonces pasame tu numero de tarjeta: ");
                string numeroTarjeta = Console.ReadLine();
            }
            else {
                Console.WriteLine("Perfecto, tambien aceptamos efectivo!");
             }
        }

        static void Ejercicio12()
        {
           for(int contador = 0; contador <= 100 ; contador++) 
            { Console.WriteLine($"El valor de i es : "+ contador);
            }
        }

        static void Ejercicio13()
        {
            int contador = 0;
            while (contador <= 100)
            {
               Console.WriteLine($"El valor de contador es : " + contador);
               contador++;
            } 

        }

        static void Ejercicio14()
        {
            for (int contador = 0; contador <= 100; contador++)
            {
                if (contador % 2 == 0) Console.WriteLine($"Numero par: " + contador);
               
            }


        }
        static void Ejercicio15()
        {
            for (int contador = 0; contador <= 100; contador++)
            {
                if (contador % 2 == 0) Console.WriteLine($"Numero par : " + contador);
                if (contador % 3 == 0) Console.WriteLine($"Numero divisible entre 3: " + contador);

            }



        }


        static void Ejercicio16(int num1,int num2)
        {
            if(num1 == num2)
            { Console.WriteLine("Ambos numeros son iguales.");
            }
            else if(num1 > num2) 
            {
                Console.WriteLine($"El {num1} es mayor a {num2}.");
            }
            else { Console.WriteLine($"El {num2} es mayor a {num1}."); }

        }

        static void Ejercicio17(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("El numero es divisible entre dos.");
            }
            else { Console.WriteLine("El numero no es divisible entre dos."); }

        }

        static void Ejercicio18()
        {
            Console.WriteLine("Bienvenido, introduzca el precio de su producto: ");
            double precioProducto = double.Parse(Console.ReadLine());

            double precioIva = (precioProducto * 21) / 100 ;
            double precioFinal = precioIva + precioProducto;

            Console.WriteLine("El precio final de su producto es: " + precioFinal);
        }

        static void Ejercicio19()
        {
            Console.WriteLine("Bienvenido vendedor, introduzca la cantidad de sus ventas: ");
            int cantVentas = int.Parse(Console.ReadLine());
            double precioVenta = 0;
            double montoVenta;

            Console.WriteLine("Genial, ahora escriba el monto por venta: ");

            for(int i = 0; i < cantVentas ; i++)
            {
                Console.WriteLine("Monto por venta: ");
                montoVenta = double.Parse(Console.ReadLine());

                precioVenta = precioVenta + montoVenta;
            }

            Console.WriteLine("El precio final de todas sus ventas es: " + precioVenta);
        }



    }


}

   