using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_book
{
    internal class Book
    {
        public Person[] myPeople = new Person[50];
        int personNum = 0;

        public void AddInfo(int j)
        {
            for (int i = 0; i < j; i++)
            {
                myPeople[i] = new Person();
                Console.Write("Name --> ");
                myPeople[i].name = Console.ReadLine();
                Console.Write("Surname --> ");
                myPeople[i].surname = Console.ReadLine();
                Console.Write("Number --> ");
                myPeople[i].no = Console.ReadLine();
                personNum++;
                Console.Write("\n");
            }
        }
        public void WriteList()
        {
            Console.WriteLine("\n");

            for (int i = 0; i < personNum; i++)
            {
                Console.WriteLine($"{i + 1}. person's name:{myPeople[i].name}\tsurname:{myPeople[i].surname}\tno:{myPeople[i].no}");
            }
        }
        public void SeachPerson(string wantedName, string wantedSurname)
        {
            bool w = false;
            int i;
            for (i = 0; i < personNum; i++)
            {
                if (myPeople[i].name == wantedName && myPeople[i].surname == wantedSurname)
                {
                    w = true;
                    if (w == true)
                    {
                        Console.WriteLine($"I know this person already! Here's the number {myPeople[i].no}");
                    }
                }
            }
            if (w == false)
                Console.WriteLine("I don't know this person...");
        }
        public void DeletePerson(string name, string surname)
        {
            for (int i = 0; i < personNum; i++)
            {
                if (myPeople[i].name == name && myPeople[i].surname == surname)
                {
                    myPeople = myPeople.Where(x => x != myPeople[i]).ToArray();
                    personNum--;
                }
            }
        }
        public void EditPerson(string name, string surname)
        {
            Console.Write("Write the NEW number --> ");
            string No = Console.ReadLine();
            for (int i = 0; i < personNum; i++)
            {
                if (myPeople[i].name == name && myPeople[i].surname == surname)
                {
                    myPeople[i].no = No;
                }
            }
        }
    }
}