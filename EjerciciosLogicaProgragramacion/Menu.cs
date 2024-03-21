
public static class Menu
{
    public static void MostrarMenu()
    {
         
            Console.WriteLine("=== Menú ===");
            Console.WriteLine("1. Determinar si un número es positivo, negativo o cero");
            Console.WriteLine("2. Solicitar 2 números y mostrar el mayor entre ellos");
            Console.WriteLine("3. Solicitar un número y mostrar su cuadrado");
            Console.WriteLine("4. Solicitar el radio de un círculo y mostrar el área");
            Console.WriteLine("5. Solicitar un número del 1 al 7 y mostrar el día de la semana");
            Console.WriteLine("6. Solicitar el salario del usuario y calcular el impuesto (10% si excede los 1000)");
            Console.WriteLine("7. Solicitar 2 números y realizar la división entre ellos");
            Console.WriteLine("8. Calcular y mostrar la suma de los números impares entre 1 y 100");
            Console.WriteLine("9. Solicitar 2 números fraccionarios y luego sumarlos");
            Console.WriteLine("10. Solicitar una palabra y mostrarla en orden inverso");
            Console.WriteLine("11. Mostrar el mayor de 5 números ingresados por el usuario");
            Console.WriteLine("12. Determinar si una palabra ingresada por el usuario es un palíndromo");
            Console.WriteLine("13. Determinar si un número ingresado por el usuario es par o impar");
            Console.WriteLine("14. Ingresar un número entre 0 y 100 y determinar si está en el rango");
            Console.WriteLine("15. Salir");

            Console.Write("Por favor, elige una opción: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Has seleccionado la opción 1.");
                    break;
                case "2":
                    Console.WriteLine("Has seleccionado la opción 2.");
                    break;
                case "3":
                    Console.WriteLine("Has seleccionado la opción 3.");
                    break;
                case "4":
                    Console.WriteLine("Has seleccionado la opción 4.");
                    break;
                case "5":
                    Console.WriteLine("Has seleccionado la opción 5.");
                    break;
                case "6":
                    Console.WriteLine("Has seleccionado la opción 6.");
                    break;
                case "7":
                    Console.WriteLine("Has seleccionado la opción 7.");
                    break;
                case "8":
                    Console.WriteLine("Has seleccionado la opción 8.");
                    break;
                case "9":
                    Console.WriteLine("Has seleccionado la opción 9.");
                    break;
                case "10":
                    Console.WriteLine("Has seleccionado la opción 10.");
                    break;
                case "11":
                    Console.WriteLine("Has seleccionado la opción 11.");
                    break;
                case "12":
                    Console.WriteLine("Has seleccionado la opción 12.");
                    break;
                case "13":
                    Console.WriteLine("Has seleccionado la opción 13.");
                    break;
                case "14":
                    Console.WriteLine("Has seleccionado la opción 14.");
                    break;
                case "15":
                    
                    Console.WriteLine("¡Hasta luego!");
                    break;
                
            }

            Console.WriteLine();
        }

    }

