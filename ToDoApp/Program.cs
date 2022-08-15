using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime;
//sortowanie obiektów na podstawie numerów
//wyciągnąć wybór aktywnego zadania i dopiero potem  używać funkcji , ma byc w osobnej klasie
//klasa musi zawierac schowaną liste oraz liste akcji które bede w niej wykonywane
//interfejsy w osobnym pliku 
//wybór też ma być w funkcji
namespace ToDoApp
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Witaj w swojej liscie zadan");
            Console.WriteLine("Co zamierzasz zrobic?");
            Console.WriteLine("Kliknij 1 jeśli chcesz zobaczyć liste zadań.");
            Console.WriteLine("Kliknij 2 jeśli chcesz dodać zadanie do listy.");
            Console.WriteLine("Kliknij 3 jeśli chcesz usunąć zadanie z listy.");
            Console.WriteLine("Kliknij 4 jeśli ustawić status zadania");
            Console.WriteLine("Kliknij 5 jeśli ustawić date zadania");
            Console.WriteLine("Kliknij 6 chcesz wyjść z aplikacji");
            string msg = "Proszę podać liczbe od 1 do 6";
            string msg2 = "By wrócić kliknij ponownie liczbe od 1 do 6 by wybrać funkcje";
            int UserInput = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Wybrałeś {UserInput}");
            int i = 0;
            List<Zadanie> ListaZadań = new List<Zadanie>() { };
            //Zadanie zad1 = null;
            //ZaInicjujListe(ListaZadań);

            while (true)
            {
                if (UserInput > 6 || UserInput == 0)
                {
                    Console.WriteLine(msg);
                }
                else
                {
                    switch (UserInput)
                    {
                        case 1:
                            PokazywanieZadań(ListaZadań);
                            break;
                        case 2:
                            DodawanieZadań(ListaZadań);
                            i++;
                            Console.WriteLine(msg2);
                            UserInput = int.Parse(Console.ReadLine());
                            break;
                        case 3:
                            UsuwanieZadań(ListaZadań);
                            Console.WriteLine(msg2);
                            UserInput = int.Parse(Console.ReadLine());
                            break;
                        case 4:
                            UstawianieStatusu(ListaZadań);
                            Console.WriteLine(msg2);
                            UserInput = int.Parse(Console.ReadLine());
                            break;
                        case 5:
                            ZmianaDaty(ListaZadań);
                            Console.WriteLine(msg2);
                            UserInput = int.Parse(Console.ReadLine());
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;

                    }

                }


            }
            void PokazywanieZadań(List<Zadanie> listaZadań)
            {
                if (listaZadań == null)
                {
                    Console.WriteLine("Brak Zadań.");
                    Console.WriteLine(msg2);
                    UserInput = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("*****Lista twoich Zadań*****");
                    foreach (Zadanie element in listaZadań)
                    {
                        Console.WriteLine($"Nr.{element.Numer} Nazwa: {element.Nazwa} Status:'{element.Status}' Data Utworzenia : {element.DataUtworzenia}");

                    }
                    Console.WriteLine("*****Koniec Listy Zadań*****");
                    Console.WriteLine(msg2);
                    UserInput = int.Parse(Console.ReadLine());



                }

            }

            void DodawanieZadań(List<Zadanie> listaZadań)
            {
                Console.WriteLine("Podaj nazwe Zadania");
                string Input = Console.ReadLine();
                DateTime data = DateTime.Now;
                Zadanie zad2 = new Zadanie(Input, "Rozpoczęte", data, i);
                ListaZadań.Add(zad2);
                
            }

            void UsuwanieZadań(List<Zadanie> listaZadań)
            {
                Console.WriteLine("Podaj nr zadania które chcesz usunąć");
                int Input2 = int.Parse(Console.ReadLine());
                var e = listaZadań.Where(m => m.Numer == Input2).FirstOrDefault(); // w tym przypadku jak nie znajdzie zwróci nulla

                if (e == null)
                {
                    Console.WriteLine("Nie znaleziono zadania");
                    return;
                }
                ListaZadań.Remove(e);
               
            }

            void UstawianieStatusu(List<Zadanie> listaZadań)

            {
                Console.WriteLine("Podaj nr zadania któremu chcesz zmienic status");
                int Input2 = int.Parse(Console.ReadLine());
                var e = listaZadań.Where(m => m.Numer == Input2).FirstOrDefault();

                if (e == null)
                {
                    Console.WriteLine("Nie znaleziono zadania");                   
                    return;
                }
                Console.WriteLine("Czy chcesz zmienic status zadania?");
                Console.WriteLine("Jesli tak wpisz 'Y' jesli nie wpisz'N' ");
                string Input3 = Console.ReadLine();
                


                    if (Input3 == "Y")
                    {
                        Console.WriteLine("Jaki status chcesz ustawic 1.Rozpoczęte 2.W toku 3.Zakończone");
                        Console.WriteLine("Podaj nr od 1 do 3");
                        int Input4 = int.Parse(Console.ReadLine());
                        switch (Input4)
                        {
                            case 1:
                                e.Status = "Rozpoczęte";
                                Console.WriteLine("Zmieniono Status");
                                Console.WriteLine(msg2);
                                UserInput = int.Parse(Console.ReadLine());
                                break;
                            case 2:
                                e.Status = "W toku";
                                Console.WriteLine("Zmieniono Status");
                                Console.WriteLine(msg2);
                                UserInput = int.Parse(Console.ReadLine());
                                break;
                            case 3:
                                e.Status = "Zakończone";
                                Console.WriteLine("Zmieniono Status");
                                Console.WriteLine(msg2);
                                UserInput = int.Parse(Console.ReadLine());
                                break;
                        }
                    }

                    else if(Input3 == "N") 
                    {
                    Console.WriteLine(msg2);
                    UserInput = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                    Console.WriteLine("Podano zły znak ");
                    Console.WriteLine("Podaj ponownie 'Y' jeśli chcesz zmienic lub 'N' jeśli nie ");
                    Input3 = Console.ReadLine();
                    }
                

            }
            void ZmianaDaty(List<Zadanie> listaZadań)
            {
                Console.WriteLine("Podaj nr zadania które chcesz usunąć");
                int Input2 = int.Parse(Console.ReadLine());
                var e = listaZadań.Where(m => m.Numer == Input2).FirstOrDefault(); // w tym przypadku jak nie znajdzie zwróci nulla

                if (e == null)
                {
                    Console.WriteLine("Nie znaleziono zadania");
                    return;
                }
                Console.WriteLine("Czy chcesz zmienic date zadania?");
                Console.WriteLine("Jesli tak wpisz 'Y' jesli nie wpisz'N' ");
                string Input5 = Console.ReadLine();
                while (Input5 != "Y" || Input5 != "N")
                {
                    Console.WriteLine("Podano zły znak ");
                    Console.WriteLine("Podaj ponownie 'Y' jeśli chcesz zmienic lub 'N' jeśli nie ");
                    Input5 = Console.ReadLine();

                    if (Input5 == "Y")
                    {
                        Console.WriteLine("Podaj rok");
                        int Input6 = int.Parse(Console.ReadLine());
                        while (Input6 > 2022)
                        {
                            Console.WriteLine("Podano błędny rok");
                            Console.WriteLine("Podaj rok Ponownie");
                            Input6 = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Podaj Miesiąc");
                        int Input7 = int.Parse(Console.ReadLine());
                        while (Input7 > 12)
                        {
                            Console.WriteLine("Podano błędny Miesiac");
                            Console.WriteLine("Podaj Miesiąc Ponownie");
                            Input7 = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Podaj dzień");
                        int Input8 = int.Parse(Console.ReadLine());
                        while (Input8 > 31)
                        {
                            Console.WriteLine("Podano błędny Dzień");
                            Console.WriteLine("Podaj Dzień Ponownie");
                            Input8 = int.Parse(Console.ReadLine());
                        }
                        e.DataUtworzenia = new DateTime(Input6, Input7, Input8);
                        Console.WriteLine("Zmieniono Date");
                        Console.WriteLine(msg2);
                        UserInput = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine(msg2);
                        UserInput = int.Parse(Console.ReadLine());
                    }
                }
            }
        }

        private static void  ZaInicjujListe(List<Zadanie> ListaZadań)
        {
            Zadanie zad1 = new Zadanie("Golenie", "Rozpoczęte", new DateTime(2013, 1, 23), 99);              
            Zadanie zad3 = new Zadanie("xd", "Rozpoczęte", new DateTime(2013, 1, 23), 98);
            Zadanie zad4 = new Zadanie("xa", "Rozpoczęte", new DateTime(2013, 1, 23), 97);
            ListaZadań.Add(zad1);            
            ListaZadań.Add(zad3);            
            ListaZadań.Add(zad4);            
        }
    }
}
