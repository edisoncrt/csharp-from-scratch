

abstract class Figura
{
    public abstract double Perimetro();
    public abstract double Area();
}

interface IExtraCalculations
{
    double Add1o();
}

class Circulo : Figura, IExtraCalculations
{
    public double Radio { get; set; }

    public override double Perimetro()
    {
        return 2 * Math.PI * Radio;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }

    public double Add1o()
    {
        return Perimetro() + Area();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo cir = new Circulo();
        bool inputValido = false;

        while (!inputValido)
        {
            try
            {
                Console.WriteLine("Ingrese el radio del círculo:");
                cir.Radio = double.Parse(Console.ReadLine());
                inputValido = true; // Si la entrada es válida, salimos del bucle
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de entrada no válido. Vuelva a ingresar el número.");
            }
        }

        double result_area = cir.Area();
        double result_perim = cir.Perimetro();
        double result_extra = cir.Add1o();

        Console.WriteLine("El área es: " + result_area);
        Console.WriteLine("El perímetro es: " + result_perim);
        Console.WriteLine("El resultado extra es: " + result_extra);

        // Ejemplo de bucle de Fibonacci
        int prev = 0, next = 1, sum;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(prev);
            sum = prev + next;
            prev = next;
            next = sum;
        }
    }
}
