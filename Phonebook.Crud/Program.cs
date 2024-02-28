using Phonebook.Crud.Services;
using Phonebook.Crud.Models;

namespace Phonebook.Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t-= Welcome to my project! =-\n");
            PhonebookService phoneBookService = new PhonebookService();
            while (true)
            {
                Console.WriteLine("1. Read All Phone Books");
                Console.WriteLine("2. Delete Phone Book By Id");
                Console.WriteLine("3. Read By Id");
                Console.WriteLine("4. Update PhoneBook");
                Console.Write("Choose >>>  ");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            phoneBookService.ReadAllPhoneBooks();
                            break;
                        }
                    case 2:
                        {
                            phoneBookService.ReadAllPhoneBooks();
                            Console.Write("Enter ID: ");
                            int IdNumber = Convert.ToInt32(Console.ReadLine());
                            phoneBookService.DeletePhoneBookById(IdNumber);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter ID: ");
                            int IdNumber = Convert.ToInt32(Console.ReadLine());
                            phoneBookService.ReadById(IdNumber);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            phoneBookService.ReadAllPhoneBooks();
                            Console.WriteLine("\nWhich Id do you want to update ?");
                            Console.Write("Enter ID: ");
                            int IdNumber = Convert.ToInt32(Console.ReadLine());
                            phoneBookService.Update(IdNumber);
                            break;
                        }
                }
                Console.Write("Do you want to use it again? [Yes/No] >>> ");
                string useAgain = Console.ReadLine();
                if (useAgain == "no" | useAgain == "No")  
                {
                    Console.Clear();
                    Console.WriteLine("Thanks, Bye!");
                    break;
                }
                Console.Clear();
            }
        }
    }
}
