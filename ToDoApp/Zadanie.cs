using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class Zadanie
    {
       public string Nazwa;
       public  string Status;
       public DateTime DataUtworzenia;
        public int Numer;

        public Zadanie(string name, string status, DateTime date, int Nr) 
        {
            Nazwa = name;
            Status = status;
            DataUtworzenia = date;
            Numer = Nr;
            
            

            Console.WriteLine("Utworzono zadanie");
        }

        
    }
}
