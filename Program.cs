// See https://aka.ms/new-console-template for more information

//Ex 1

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
