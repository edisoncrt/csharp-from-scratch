
namespace  itm.sharp.basic {
// se le pide al usuario un numero y este determina si es positivo, negativo o 0

public class Challenge1
{
    public void Run()
{
    Console.Write("Por favor, ingresa un número: ");
    string input = Console.ReadLine();

    if (double.TryParse(input, out double numero))
    {
        if (numero > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }
    }
}

}


// Se solicita 2 numeros que sean mayor entre ellos 

 public class Challenge2
{
    public void Run()
    {
        Console.Write("Por favor, ingresa el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor, ingresa el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("El primer número ({0}) es mayor que el segundo número ({1}).", numero1, numero2);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("El segundo número ({0}) es mayor que el primer número ({1}).", numero2, numero1);
        }
    }
}

//se solicita un numero y que muetre el cuadrado de ese numero
public class Challenge3
{
    public void Run()
    {
        Console.Write("Por favor, ingresa un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        double cuadrado = Math.Pow(numero, 2);

        Console.WriteLine("El cuadrado de {0} es: {1}", numero, cuadrado);
    }
}
// se le solicita al usuario el radio de un circulo y este determine el area
public class Challenge4
{
    public void Run()
    {
        System.Console.Write("Por favor, ingresa el radio del círculo: ");
        double radio = System.Convert.ToDouble(System.Console.ReadLine());

        double area = System.Math.PI * System.Math.Pow(radio, 2);

        System.Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);
    }
}

// se le solicita al usuario un numero del uno al 7 y este muestre el dia de la semana
public class Challenge5
{
    public void Run()
    {
        System.Console.Write("Por favor, ingresa un número entre 1 y 7: ");
        int numero = System.Convert.ToInt32(System.Console.ReadLine());

        string diaSemana = "";

        switch (numero)
        {
            case 1:
                diaSemana = "Lunes";
                break;
            case 2:
                diaSemana = "Martes";
                break;
            case 3:
                diaSemana = "Miércoles";
                break;
            case 4:
                diaSemana = "Jueves";
                break;
            case 5:
                diaSemana = "Viernes";
                break;
            case 6:
                diaSemana = "Sábado";
                break;
            case 7:
                diaSemana = "Domingo";
                break;
            default:
                System.Console.WriteLine("Número ingresado no válido.");
                return;
        }

        System.Console.WriteLine("El día correspondiente al número {0} es: {1}", numero, diaSemana);
    }
}


// se le solicita al usuario digitar su salrio y si este excede los 1000 pagar el impuesto de 10%
public class Challenge6
{
    public void Run()
    {
        Console.Write("Por favor, ingresa tu salario: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        if (salario > 1000)
        {
            double excedente = salario - 1000;
            double impuesto = excedente * 0.10;
            Console.WriteLine("El impuesto a pagar es: {0}", impuesto);
        }
    }
}


// Se le solicita al usuario 2 numeros y que realicen la division enttre ellos 

public class Challenge7
{
 public void Run()
    {
        Console.Write("Por favor, ingresa el dividendo: ");
        double dividendo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor, ingresa el divisor: ");
        double divisor = Convert.ToDouble(Console.ReadLine());

        if (divisor != 0)
        {
            double resultado = dividendo / divisor;
            Console.WriteLine("El resultado de la división es: {0}", resultado);
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
    }
}

// calcula y suma los numeros impares entre 1 y 100

public class Challenge8
{
    public void Run()
    {
        Console.Write("Por favor, ingresa un número entero positivo: ");
        int limiteSuperior = Convert.ToInt32(Console.ReadLine());

        int sumaImpares = 0;

        for (int i = 1; i <= limiteSuperior; i += 2)
        {
            sumaImpares += i;
        }

        Console.WriteLine("La suma de los números impares entre 1 y {0} es: {1}", limiteSuperior, sumaImpares);
    }
}
// S ele solicita al usuario  2 numeros para fracionarios y luego sumarlos

public class Challenge9
{
   public void Run()
    {
        Console.WriteLine("Ingrese la primera fracción:");
        int numerador1 = PedirEntero("Numerador: ");
        int denominador1 = PedirEntero("Denominador: ");

        Console.WriteLine("Ingrese la segunda fracción:");
        int numerador2 = PedirEntero("Numerador: ");
        int denominador2 = PedirEntero("Denominador: ");

        // Suma de fracciones
        int nuevoNumerador = numerador1 * denominador2 + numerador2 * denominador1;
        int nuevoDenominador = denominador1 * denominador2;


        SimplificarFraccion(ref nuevoNumerador, ref nuevoDenominador);

        Console.WriteLine("La suma de las fracciones es: {0}/{1}", nuevoNumerador, nuevoDenominador);
    }

    static int PedirEntero(string mensaje)
    {
        Console.Write(mensaje);
        return Convert.ToInt32(Console.ReadLine());
    }

    static int CalcularMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void SimplificarFraccion(ref int numerador, ref int denominador)
    {
        int mcd = CalcularMCD(numerador, denominador);
        numerador /= mcd;
        denominador /= mcd;
    }
}
// Se le solicita al usuario una palabra y esta la muestra en inverso

public class Challenge10
{
    public void Run()
    {
        Console.Write("Por favor, ingresa una palabra: ");
        string palabra = Console.ReadLine();

        string palabraInversa = "";


        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabraInversa += palabra[i];
        }

        Console.WriteLine("La palabra en orden inverso es: " + palabraInversa);
    }
}
// Solicitar al usuario que ingrese los tres números y este muestre el promedio 

public class Challenge11
{
    public void Run()
    {
        Console.WriteLine("Por favor, ingresa tres números:");

        // Solicitar al usuario que ingrese los tres números
        double numero1 = PedirNumero("Primer número: ");
        double numero2 = PedirNumero("Segundo número: ");
        double numero3 = PedirNumero("Tercer número: ");


        double promedio = (numero1 + numero2 + numero3) / 3;


        Console.WriteLine("El promedio de los tres números es: " + promedio);
    }

    static double PedirNumero(string mensaje)
    {
        Console.Write(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }
}

// Solicitar al usuario que ingrese los cinco números y  Mostrar el mayor número
public class Challenge12
{
   public void Run()
    {
        Console.WriteLine("Por favor, ingresa cinco números:");


        double[] numeros = new double[5];
        for (int i = 0; i < 5; i++)
        {
            numeros[i] = PedirNumero("Número " + (i + 1) + ": ");
        }


        double mayor = numeros[0];
        for (int i = 1; i < 5; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
        }


        Console.WriteLine("El mayor número ingresado es: " + mayor);
    }

    static double PedirNumero(string mensaje)
    {
        Console.Write(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }
}
// le pedimos al usuario una palabra  y determinar si es palindramo o no

public class Challenge13
{
    public void Run()
    {
        Console.Write("Por favor, ingresa una palabra: ");
        string palabra = Console.ReadLine();


        palabra = palabra.ToLower();

        bool esPalindromo = EsPalindromo(palabra);

        if (esPalindromo)
        {
            Console.WriteLine("La palabra ingresada es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra ingresada no es un palíndromo.");
        }
    }

    static bool EsPalindromo(string palabra)
    {

        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}

// Pedir al usuario un numero y determinar si es par o impar

 public class Challenge14
{
   public void Run()
    {
        Console.Write("Por favor, ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (EsPar(numero))
        {
            Console.WriteLine("El número ingresado es par.");
        }
        else
        {
            Console.WriteLine("El número ingresado es impar.");
        }
    }

    static bool EsPar(int numero)
    {

        return numero % 2 == 0;
    }
}
//  Ingresar un numero entre 0 y 100 y determinar si esta en el rango
public class Challenge15
{
   public void Run()
    {
        Console.Write("Por favor, ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 0 && numero <= 100)
        {
            Console.WriteLine("El número ingresado está dentro del rango entre 0 y 100.");
        }
        else
        {
            Console.WriteLine("El número ingresado no está dentro del rango entre 0 y 100.");
        }
    }

}
}
