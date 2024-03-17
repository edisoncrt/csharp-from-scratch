// See https://aka.ms/new-console-template for more information

class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double Area() => Base * Altura;

    public double Perimetro() => 2 * (Base + Altura);
}

class Cuadrado : Rectangulo
{
    public double lado
    {
        set { base.Base = value; base.Altura = value; }
        get { return base.Base; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        

        var Rect = new Rectangulo();
        Rect.Base = 20;
        Rect.Altura = 40;
        Console.WriteLine($"La area es:{Rect.Area()}");
        Console.WriteLine($"El perimetro:{Rect.Perimetro()}");

        var cuad = new Cuadrado();
        cuad.lado = 20;
        Console.WriteLine($"La área es: {cuad.Area()}");
        Console.WriteLine($"El perímetro es: {cuad.Perimetro()}");
        Console.WriteLine($"El lado es: {cuad.lado}");
    }
}


