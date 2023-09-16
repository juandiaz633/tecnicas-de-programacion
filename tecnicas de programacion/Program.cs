using System;
// ejercicio #26
double a, b, c;

Console.WriteLine("Ingrese el valor de a: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de b: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de c: ");
c = double.Parse(Console.ReadLine());

double discriminante = b = 2 * 2 + 2 - 4 * a * c;

if (discriminante > 0)
{
    double x1, x2;
    x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
    x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
    Console.WriteLine("La solución 1 es: {0}", x1);
    Console.WriteLine("La solución 2 es: {0}", x2);
}
else if (discriminante == 0)
{
    double x;
    x = -b / (2 * a);
    Console.WriteLine("La solución es: {0}", x);
}
else
{
    Console.WriteLine("La ecuación no tiene soluciones reales");
}




// ejercicio #25
int numero25, reverso;

Console.WriteLine("Ingrese un número de 5 dígitos: ");
numero25 = int.Parse(Console.ReadLine());

reverso = 0;
for (int i = numero25; i > 0; i /= 10)
{
    reverso = reverso * 10 + i % 10;
}

if (numero25 == reverso)
{
    Console.WriteLine("Es capicúa");
}
else
{
    Console.WriteLine("No es capicúa");
}



// ejercicio #24

int numero24;

numero24 = Random.Range(1, 1000);

Console.WriteLine("El número es: {0}", numero24);

if (numero24 % 5 == 0)
{
    if (numero24 <= 25)
    {
        Console.WriteLine("Correcto");
    }
}




// ejercicio #23
int numero23;

int digitoActual2;

int indiceDigitoActual2;

int sumaDigitos = 0;

Console.WriteLine("Ingrese un número: ");
numero23 = int.Parse(Console.ReadLine());

indiceDigitoActual2 = 0;

while (numero23 > 0)
{
    digitoActual2 = numero23 % 10;

    sumaDigitos += digitoActual2;

    Console.WriteLine("d{0} = {1}", indiceDigitoActual2, digitoActual2);

    indiceDigitoActual2++;

    numero23 /= 10;
}

Console.WriteLine("La suma de los dígitos es: {0}", sumaDigitos);





// ejercicio #22
int numero22;

int digitoActual;

int indiceDigitoActual;

Console.WriteLine("Ingrese un número: ");
numero22 = int.Parse(Console.ReadLine());

indiceDigitoActual = 0;

while (numero22 > 0)
{
    digitoActual = numero22 % 10;

    Console.WriteLine("d{0} = {1}", indiceDigitoActual, digitoActual);

    indiceDigitoActual++;

    numero22 /= 10;
}




// ejercicio #21
int numero21;

int digitos = 0;

Console.WriteLine("Ingrese un número: ");
numero21 = int.Parse(Console.ReadLine());

while (numero21 > 0)
{
    digitos++;
    numero21 /= 10;
}

Console.WriteLine("La cantidad de dígitos es: {0}", digitos);




// ejercicio #20
int resultado;

Console.WriteLine("Ingrese el resultado de la jugada: ");
resultado = int.Parse(Console.ReadLine());

if (resultado >= 1 && resultado <= 12)
{
    Console.WriteLine("Docena: Primera");
}

else if (resultado >= 13 && resultado <= 24)
{
    Console.WriteLine("Docena: Segunda");
}

else if (resultado >= 25 && resultado <= 36)
{
    Console.WriteLine("Docena: Tercera");
}

else
{
    Console.WriteLine("Error: El resultado no es válido");
}



// ejercicio #19

int lado1, lado2, lado3;

Console.WriteLine("Ingrese el primer lado: ");
lado1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo lado: ");
lado2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer lado: ");
lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("El triángulo es equilátero");
}

else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine("El triángulo es isósceles");
}

else
{
    Console.WriteLine("El triángulo es escaleno");
}



// ejercicio #18

int nu1, nu2, nu3;

Console.WriteLine("Ingrese el primer número: ");
nu1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
nu2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer número: ");
nu3 = int.Parse(Console.ReadLine());

int mayor = nu1;

if (nu2 > mayor)
{
    mayor = nu2;
}

if (nu3 > mayor)
{
    mayor = nu3;
}

Console.WriteLine("El mayor número es: {0}", mayor);



// ejercicio #17

int numero;

Console.WriteLine("Ingrese un número: ");
numero = int.Parse(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine("El número es negativo");
}

else if (numero > 0)
{
    Console.WriteLine("El número es positivo");
}

else
{
    Console.WriteLine("El número es nulo");
}



// ejercicio #16
int hombres, mujeres;

Console.WriteLine("Ingrese el total de hombres: ");
hombres = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el total de mujeres: ");
mujeres = int.Parse(Console.ReadLine());

int total = hombres + mujeres;

double porcentajeHombres = (double)hombres / total * 100;

double porcentajeMujeres = (double)mujeres / total * 100;

Console.WriteLine("El porcentaje de hombres es: {0}%", porcentajeHombres);
Console.WriteLine("El porcentaje de mujeres es: {0}%", porcentajeMujeres);





// ejercicio #15
int n1, n2;

Console.WriteLine("Ingrese el primer número: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
n2 = int.Parse(Console.ReadLine());

int residuo = n1 % n2;

if (residuo == 0)
{
    Console.WriteLine("Es divisible");
}
else
{
    Console.WriteLine("No es divisible");
}



// ejercicio #14
double radio3, altura3, volumen3;

Console.WriteLine("Ingrese el radio del cilindro: ");
radio3 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del cilindro: ");
altura3 = double.Parse(Console.ReadLine());

if (radio3 <= 0)
{
    Console.WriteLine("El radio debe ser positivo.");
    return;
}

if (altura3 <= 0)
{
    Console.WriteLine("La altura debe ser positiva.");
    return;
}

volumen3 = Math.PI * radio3 * radio3 * altura3;

Console.WriteLine("El volumen del cilindro es: {0}", volumen3);


// ejercicio #13
Console.WriteLine("Algoritmo para transformar temperatura Fahrenheit a Celsuius");
Console.Write("Añade la temperatura Fahrenheit");

double fh = Convert.ToDouble(Console.ReadLine());

double conversionfh = Convert.ToDouble((fh - 32) * 5 / 9);

Console.WriteLine("El grado Fahrenheit convertido a grados Celsuius es: " + conversionfh);

//ejercicio #12

double cm = Convert.ToDouble(Console.ReadLine());

double conversionyd = Convert.ToDouble(cm / 91.44);

double conversionmt = Convert.ToDouble(cm / 100);

double conversionps = Convert.ToDouble(cm / 30.48);

double conversionpg = Convert.ToDouble(cm / 2.54);

Console.WriteLine("El centimetro convertido es " + conversionyd, conversionmt, conversionps, conversionpg);

Console.WriteLine("Yardas: " + conversionyd);

Console.WriteLine("Metros: " + conversionmt);

Console.WriteLine("Pies: " + conversionps);

Console.WriteLine("Pulgadas: " + conversionpg);



// ejercicio #11
double radio, altura2, volumen;

Console.WriteLine("Ingrese el radio del cilindro: ");
radio = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del cilindro: ");
altura2 = double.Parse(Console.ReadLine());

volumen = Math.PI * radio * radio * altura2;

Console.WriteLine("El volumen del cilindro es: {0}", volumen);



// ejercicio #10
int base1, altura;

Console.WriteLine("Ingrese la base del rectángulo: ");
base1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del rectángulo: ");
altura = int.Parse(Console.ReadLine());

int area = base1 * altura;
int perimetro = 2 * (base1 + altura);

Console.WriteLine("El área del rectángulo es: {0}", area);
Console.WriteLine("El perímetro del rectángulo es: {0}", perimetro);


// ejercicio #9

string palabraA, palabraB, temp;


Console.WriteLine("Ingrese la primera palabra: ");
palabraA = Console.ReadLine();
Console.WriteLine("Ingrese la segunda palabra: ");
palabraB = Console.ReadLine();


temp = palabraA;


palabraA = palabraB;


palabraB = temp;


Console.WriteLine("La palabra A es ahora: {0}", palabraA);
Console.WriteLine("La palabra B es ahora: {0}", palabraB);






// ejercicio #8
double numero1_1, numero2_2, numero3_3, promedio;

Console.WriteLine("Ingrese el primer número: ");
numero1_1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
numero2_2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer número: ");
numero3_3 = double.Parse(Console.ReadLine());

promedio = (numero1_1 + numero2_2 + numero3_3) / 3;


Console.WriteLine("El promedio es: {0}", promedio);






// ejercicio #7


double numero5;

numero5 = new Random().NextDouble(.10,51.);


Console.WriteLine("El número aleatorio es: {0}", numero5);

double numeroDisminuido = numero5 * 0.85;


Console.WriteLine("El número disminuido en un 15% es: {0}", numeroDisminuido);


// ejercicio #6
int numero4;


numero4 = new Random().Next(0, 201);


Console.WriteLine("El número aleatorio es: {0}", numero4);


int numeroAumentado = (int)(numero4 * 1.3);


Console.WriteLine("El número aumentado en un 30% es: {0}", numeroAumentado);



// ejercicio #5

double numero3;


Console.WriteLine("Ingrese un número: ");
numero3 = double.Parse(Console.ReadLine());


double siguiente = numero3 + 1;


Console.WriteLine("El número siguiente es {0}", siguiente);


// ejercicio #4

int numero2, cuadrado2, cubo2;


Console.WriteLine("Ingrese un número: ");
numero2 = int.Parse(Console.ReadLine());


cuadrado2 = numero2 * numero2;
cubo2 = numero2 * numero2 * numero2;

Console.WriteLine("El cuadrado del número es {0}", cuadrado2);
Console.WriteLine("El cubo del número es {0}", cubo2);

// ejercicio #3


double numero1;

        
        Console.WriteLine("Ingrese un número: ");
        numero1 = double.Parse(Console.ReadLine());

        
        double doble = numero1 * 2;
        double triple = numero1 * 3;

        
        Console.WriteLine("El doble del número es {0}", doble);
        Console.WriteLine("El triple del número es {0}", triple);
 

//ejercicio #2

string pais, capital;


Console.WriteLine("Ingrese el país: ");
pais = Console.ReadLine();


Console.WriteLine("Ingrese la capital: ");
capital = Console.ReadLine();


Console.WriteLine("{0} es la capital de {1}", capital, pais);

// ejercicio #1



public class Tecnicas_de_programacion
{
    public static void Main(string[] args)
    {
        int n1, n2;

        Console.WriteLine("Ingrese el primer número: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        
        int suma = n1 + n2;

        Console.WriteLine("La suma de los números es {0}", suma);
    }
}
