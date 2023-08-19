                                                                                 
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
            int numberp = int.Parse(Resultado);
            string Porcentaje = Console.ReadLine();
            int numberp1 = int.Parse(Porcentaje);
            Console.WriteLine(Porcentaje);
            double porcentaje = 1.3;
            double num2 = (Porcentaje * Resultado);
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


 }
    }
    

}
