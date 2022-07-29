using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime;


class Program
{
    public static void Main(string[] args)
    {
s        Console.WriteLine("Witam w książce Telefonicznej");
        Console.WriteLine("Co zamierzasz zrobić:");
        Console.WriteLine("Dodać nr. Kliknij 1");
        Console.WriteLine("Wyświetlic kontakt na podstawie nr. Kliknij 2 ");
        Console.WriteLine("Wyświetlić Wszystkie kontakty. Kliknij 3");
        Console.WriteLine("Wyszukać kontakt dla danej nazwy. Kliknij 4 ");
        Console.WriteLine("Żeby opuscic program . Kliknij 5 ");
        Kontakt Osoba1 = new Kontakt("Czarek", "123456789");
        List<Kontakt> ListaKontaktow = new List<Kontakt>() { };
        int UserInput = int.Parse(Console.ReadLine());
        string msg = "Proszę podać liczbe od 1 do 4";
        string msg2 = "By wrócić kliknij ponownie liczbe od 1 do 4 by wybrać funkcje";
        while (true)
        {
            if (UserInput > 5 || UserInput == 0)
            {
                Console.WriteLine(msg);
            }
            else
            {
                switch (UserInput)
                {
                    case 1:
                        DodawanieKontakow(ListaKontaktow);
                        break;

                    case 2:
                        WyszukiwanieNr(ListaKontaktow);
                        break;

                    case 3:
                        PokazywanieKontaktow(ListaKontaktow);
                        break;

                    case 4:
                        WyszukiwanienNazwy(ListaKontaktow);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                }

            }


        }

        void PokazywanieKontaktow(List<Kontakt> listaKontaktow)
        {
            if (listaKontaktow == null)
            {
                Console.WriteLine("Brak Kontaktów.");
                Console.WriteLine(msg2);
                UserInput = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("*****Lista twoich Kontaktów*****");
                foreach (Kontakt element in listaKontaktow)
                {
                    Console.WriteLine($"Imie: {element.Name}, Numer: {element.Nr}");

                }
                Console.WriteLine("*****Koniec Listy Kontaktów*****");
                Console.WriteLine(msg2);
                UserInput = int.Parse(Console.ReadLine());


            }

        }
        void DodawanieKontakow(List<Kontakt> listaKontaktow)
        {
            Console.WriteLine("Podaj Imię");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj 9 cyfrowy numer");
            string Numer = Console.ReadLine();

            while (Numer.Length != 9)
            {
                Console.WriteLine("Podano nie poprawny numer");
                Console.WriteLine("Podaj 9 cyfrowy numer");
                Numer = Console.ReadLine();
            }


            Kontakt Osoba2 = new Kontakt(name, Numer);
            ListaKontaktow.Add(Osoba2);
            Console.WriteLine("Dodano Kontakt");
            Console.WriteLine(msg2);
            UserInput = int.Parse(Console.ReadLine());
        }

        void WyszukiwanienNazwy(List<Kontakt> listaKontaktow)
        {
            Console.WriteLine("Podaj imie Kontaktu");
            string ImieInput = Console.ReadLine();
            foreach (Kontakt element in listaKontaktow)
            {
                if (element.Name == ImieInput)
                {
                    Console.WriteLine($"Imie: {element.Name}, Numer: {element.Nr}");
                    Console.WriteLine(msg2);
                    UserInput = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Podano błędne imie");
                }
            }
        }

        void WyszukiwanieNr(List<Kontakt> listaKontaktow)
        {
            Console.WriteLine("Podaj numer Kontaktu");
            string NumerInput = Console.ReadLine();

            foreach (Kontakt element in listaKontaktow)
            {
                if (element.Nr == NumerInput)
                {
                    Console.WriteLine($"Imie: {element.Name}, Numer: {element.Nr}");
                    Console.WriteLine(msg2);
                    UserInput = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Podano błędny numer");
                }
            }


        }
        Console.ReadKey();
    }


}


