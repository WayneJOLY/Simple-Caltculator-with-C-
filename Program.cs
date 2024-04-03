// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer Numero");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ingrese el operator");
        string op = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo Numero");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (op == "+")
        {
            Console.WriteLine(num1 + num2);
        }
        else if (op == "-")
        {
            Console.WriteLine(num1 - num2);
        }
        else if (op == "*")
        {
            Console.WriteLine(num1 * num2);
        }
        else if (op == "/")
        {
            Console.WriteLine(num1 / num2);
        }
        else
        {
            Console.WriteLine("Ingresaste un operator no matematico");
        }

    }
}