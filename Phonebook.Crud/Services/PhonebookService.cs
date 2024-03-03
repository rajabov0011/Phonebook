using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Crud.Models;

namespace Phonebook.Crud.Services
{
    internal class PhonebookService
    {
        public PhoneBook[] PhoneBooks { get; set; } = new PhoneBook[3];

        public PhonebookService() 
        {
            PhoneBooks[0] = new PhoneBook
            {
                Id = 1,
                Name = "Asadbek",
                Phone = "+998900116677"
            };
            PhoneBooks[1] = new PhoneBook
            {
                Id = 2,
                Name = "Oltin",
                Phone = "+998958598855"
            };
            PhoneBooks[2] = new PhoneBook
            {
                Id = 3,
                Name = "Shaxzod",
                Phone = "+998914074477"
            };
        }

        public void ReadAllPhoneBooks()
        {
            Console.Clear();
            for (int iteration = 0; iteration < PhoneBooks.Length; iteration++)
            {
                PhoneBook phoneBook = PhoneBooks[iteration];
                if (phoneBook is not null)
                {
                    Console.WriteLine($"{phoneBook.Id}  - {phoneBook.Name}       {phoneBook.Phone}");
                }
                else
                { 
                    Console.WriteLine("null");
                }
            }
        }

        public void DeletePhoneBookById(int id)
        {
            id = id - 1;
            if (id >= 0 && id < PhoneBooks.Length && PhoneBooks[id] != null) 
            {
                PhoneBooks[id] = null;
                Console.WriteLine("Deleted!");
                Console.Write("Want to see the result? [Yes/No] >>> ");
                string answer = Console.ReadLine();
                if (answer == "Yes" | answer == "yes" )
                {
                    ReadAllPhoneBooks();
                }
            }
            else
            {
                Console.WriteLine("There is no data with this Id");
            }
        }

        public void ReadById(int id)
        { 
            id = id - 1;
            if (id >= 0 && id < PhoneBooks.Length && PhoneBooks[id] != null)
            {
                for (int iteration = 0; iteration < PhoneBooks.Length;iteration++)
                {
                    if (PhoneBooks[iteration] is not null && iteration == id)
                    {
                        PhoneBook phoneBook = PhoneBooks[iteration];
                        Console.WriteLine($"{phoneBook.Id} - {phoneBook.Name} {phoneBook.Phone}");
                    }
                }
            }
            else
            {
                Console.WriteLine("There is no data with this Id");
            }
        }

        public void Update(int id)
        {
            id = id - 1;
            if (id >= 0 && id < PhoneBooks.Length && PhoneBooks[id] != null)
            {
                home:
                PhoneBook phoneBook = PhoneBooks[id];
                Console.Clear();
                ReadAllPhoneBooks();
                Console.WriteLine("What information do you want to update?\n1. ID\n2. Name\n3. Phone");
                Console.Write("Choose >>> ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Cannot change ID!");
                            Console.Write("Do you want to change other information? [Yes/No] >>> ");
                            string answer = Console.ReadLine();
                            if (answer == "Yes" | answer == "yes")
                            {
                                goto home;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter new Name >>> ");
                            string name = Console.ReadLine();
                            phoneBook.Name = name;
                            Console.WriteLine("Information changed!");
                            Console.Write("Want to see the result? [Yes/No] >>> ");
                            string answer = Console.ReadLine();
                            if (answer == "Yes" | answer == "yes")
                            {
                                Console.Clear();
                                Console.WriteLine($"{phoneBook.Id} - {phoneBook.Name}  {phoneBook.Phone}");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter new Phone >>> ");
                            string phone = Console.ReadLine();
                            phoneBook.Phone = phone;
                            Console.WriteLine("Information changed!");
                            Console.Write("Want to see the result? [Yes/No] >>> ");
                            string answer = Console.ReadLine();
                            if (answer == "Yes" | answer == "yes")
                            {
                                Console.Clear();
                                Console.WriteLine($"{phoneBook.Id} - {phoneBook.Name}  {phoneBook.Phone}");
                            }
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("There is no data with this Id");
            }
        }
    }
}
