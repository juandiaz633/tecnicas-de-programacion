                                                                                 
namespace tecnicas_de_programacion
{
    internal class Program
    {
        static void Main(string[] args) {

            //Ejercicio 3

            Console.WriteLine("genera un numero aleatorio del 0 al 200");

            Random rnd = new Random();
            Console.WriteLine(rnd.Next(0, 200));
            string Resultado = Console.ReadLine();
            int numberp2 = int.Parse(Resultado);
            string Porcentaje = Console.ReadLine();
            int number3 = int.Parse(Porcentaje);    
            Console.WriteLine(Porcentaje);
            double porcentaje = 1.3;
            double num2 = (numberp2 * number3);
            Console.WriteLine("numero aleatorio" + porcentaje);


            // ejercicio #2

            Console.WriteLine("El numero generado aleatoriamente es:");
            string Porcentaje1 = Console.ReadLine();
            int numberp = int.Parse(Porcentaje1);
            double porcentaje1 = numberp * 1.3;
            Console.WriteLine("El numero generado aleatoriamente y aumentado un 30% es:" + porcentaje1);
            

            // ejercicio #1
            Console.WriteLine("escribe el numero que quiere imprimir");
            string numero = Console.ReadLine();
            int number = int.Parse(numero);
            Console.WriteLine("El numero ingresado anteriormente es:" + (number + 1));



            //Ejercicio 14-----------------------------------------------------------------------------------------------------
using System;

Console.WriteLine("Algoritmo para calcular el volumen del cilindro y saber si es positivo");
Console.Write("Añade los valores del radio");

Console.WriteLine("Algoritmo para calcular el volumen del cilindro");
Console.Write("Añade los valores del radio");
double radio = Convert.ToDouble(Console.ReadLine());


    Console.Write("Añade los valores de la altura");
double altura = Convert.ToDouble(Console.ReadLine());
double pi = Math.PI;

double volumen = Convert.ToDouble(radio * altura * pi);

if (true)
{

}
else {

    volumen > = 12;

}


Console.WriteLine("El volumen es:" + Math.Round(volumen, 3));




//Ejercicio 13------------------------------------------------------------------------------------------------

Console.WriteLine("Algoritmo para transformar temperatura Fahrenheit a Celsuius");
Console.Write("Añade la temperatura Fahrenheit");

double fh = Convert.ToDouble(Console.ReadLine());

double conversionfh = Convert.ToDouble((fh - 32) * 5 / 9);

Console.WriteLine("El grado Fahrenheit convertido a grados Celsuius es: " + conversionfh);


//Ejercicio #12------------------------------------------------------------------------------------------------

Console.WriteLine("Algoritmo para transformar centimentros a yardas, metros, pies y pulgadas");
Console.Write("añade los centimetros que quieres convertir");

double cm = Convert.ToDouble(Console.ReadLine());

double conversionyd = Convert.ToDouble(cm / 91.44);

double conversionmt = Convert.ToDouble(cm / 100);

double conversionps = Convert.ToDouble(cm / 30.48);

double conversionpg = Convert.ToDouble(cm / 2.54);

Console.WriteLine("El centimetro convertido es " +  conversionyd,conversionmt,conversionps, conversionpg );

Console.WriteLine("Yardas: " + conversionyd);

Console.WriteLine("Metros: " + conversionmt);

Console.WriteLine("Pies: " + conversionps);

Console.WriteLine("Pulgadas: " + conversionpg);

//Ejercicio #11--------------------------------------------------------------------------------------------------------------------------

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo para calcular el volumen del cilindro");
            Console.Write("Añade los valores del radio");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Añade los valores de la altura");
            double altura = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;

            double volumen = Convert.ToDouble(radio * altura * pi);


            Console.WriteLine ("El volumen es:" + Math.Round(volumen, 3));

            









        }
    }
}
 }
    }
    

}
