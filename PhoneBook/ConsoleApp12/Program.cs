using System;


class Zadanie 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj x");
        int X = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj y");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Czy x jest liczbą pierwszą?");

        if (X % 2 != 0 )
        {
            Console.WriteLine("Tak");


        }
        else
        {
            Console.WriteLine("Nie");
        }
        Console.WriteLine("Czy y jest liczbą pierwszą?");
        if (y % 2 != 0 )
        {
            Console.WriteLine("Tak");
            
        }
        else
        {

            Console.WriteLine("Nie");
           
        }
        Console.ReadKey();
    }



    
}
