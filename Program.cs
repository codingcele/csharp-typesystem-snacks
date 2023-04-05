// See https://aka.ms/new-console-template for more information


//Snack 1:

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inserisci il primo numero:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il secondo numero:");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 == numero2)
            Console.WriteLine("I due numeri sono uguali.");
        else
        {
            if (numero1 > numero2)
                Console.WriteLine("Il numero più grande è: " + numero1);
            else
                Console.WriteLine("Il numero più grande è: " + numero2);
        }
    }
}

//Snack 2:

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inserisci la prima parola:");
        string parola1 = Console.ReadLine();

        Console.WriteLine("Inserisci la seconda parola:");
        string parola2 = Console.ReadLine();

        if (parola1.Length > parola2.Length)
        {
            Console.WriteLine(parola1);
            Console.WriteLine(parola2);
        }
        else if (parola1.Length < parola2.Length)
        {
            Console.WriteLine(parola2);
            Console.WriteLine(parola1);
        }
        else
        {
            Console.WriteLine($"{parola1} e {parola2} hanno la stessa lunghezza.");
        }


    }
}

//Snack 3:

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Inserisci il {i + 1}° numero: ");
            int numero = int.Parse(Console.ReadLine());
            sum += numero;
        }
        Console.WriteLine($"La somma dei 10 numeri che hai inserito è: " + sum);
    }
}

//Snack 4:

class Program
{
    static void Main(string[] args)
    {
        int min = 2;
        int max = 10;
        int sum = 0;
        for (int i = min; i <= max; i++)
        {
            sum += i;
        }
        int average = sum / (max - min + 1);
        Console.WriteLine($"La somma dei numeri è: " + sum);
        Console.WriteLine($"La media dei numeri è: " + average);
    }
}

//Snack 5:

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inserisci un numero:");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
            Console.WriteLine(numero);
        else
            Console.WriteLine(numero + 1);
    }
}