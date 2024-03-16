/*conditionales*/
int num;
Console.WriteLine("Ingrese un numero:");
/*conditionales/*
string nameImput = Console.ReadLine();
num = int.Parse(nameImput);
if (num > 0) Console.WriteLine("El numero es positivo");
else if (num < 0) Console.WriteLine("El numero es negativo");
else Console.WriteLine("cero");

/*conditionales*/

/*Operators*/

Console.WriteLine("Ingrese el primer numero");
double a= double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
double b= double.Parse(Console.ReadLine());
 String Indeterminado="indeterminado";

Console.WriteLine($"suma: {a+b}, resta: {a-b}, multiplicacion: {a*b}, division: {(b != 0 ? (a / b).ToString() : Indeterminado)}");


