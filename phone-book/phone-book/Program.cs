using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace phone_book
{
    internal class Program
    {
        static void Main()
        {
            Book book = new Book();
            bool loop = true;
            while (loop == true)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("What do you want to me?\n1. Add person\n2. Write list\n3. Search someone\n4. Delete someone\n5. Edit someone's number\n6. Exit (enter 0)");
                int answer = Convert.ToInt32(Console.ReadLine());
                Console.BackgroundColor = ConsoleColor.Black;
                switch (answer)
                {
                    case 1:
                        Console.Write("How many people do you want to add to your phonebook--> ");
                        int j = Convert.ToInt32(Console.ReadLine());
                        book.AddInfo(j);
                        Console.WriteLine("Added succesfully!");
                        break;
                    case 2:
                        book.WriteList();
                        Console.WriteLine("That's all you've got");
                        break;
                    case 3:
                        Console.Write("Write the name of the person you're looking for --> ");
                        string wantedName = Console.ReadLine();
                        Console.Write("and surname too --> ");
                        string wantedSurname = Console.ReadLine();
                        book.SeachPerson(wantedName, wantedSurname);
                        break;
                    case 4:
                        Console.Write("Write the name you want to delete --> ");
                        string name = Console.ReadLine();
                        Console.Write("and surname too -->");
                        string surname = Console.ReadLine();
                        book.DeletePerson(name, surname);
                        Console.WriteLine("Deleted Successfully!");
                        break;
                    case 5:
                        Console.Write("Write the name that you want to change it's number -->");
                        string Name = Console.ReadLine();
                        Console.Write("and surname too -->");
                        string Surname = Console.ReadLine();
                        book.EditPerson(Name, Surname);
                        Console.WriteLine("Edited successfully!");
                        break;
                    case 0:
                        loop = false;
                        Console.Write("Goodbye <3");
                        break;
                }
                Thread.Sleep(5000);
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}