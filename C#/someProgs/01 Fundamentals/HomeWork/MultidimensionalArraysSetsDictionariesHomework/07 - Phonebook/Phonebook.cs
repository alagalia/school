using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Phonebook
{
    static void Main()
    {
        ///// малко разнообразих програмката :)

        Console.WriteLine("\"add\" - To ADD name and telephone in phonebook enter.");
        Console.WriteLine("\"search\" - To SEARCH someone in phonebook enter.");
        Console.WriteLine("\"exit\" - To EXIT enter.");

        SortedDictionary<string, List<string>> phonebook = new SortedDictionary<string, List<string>>();

        Console.Write("What do you want to do ? :");
        string input = Console.ReadLine();
        if (input == "add")
        {
            Console.Clear();
            Console.WriteLine("\"search\" - to search contact \n\"end\" - to exit");
            Console.Write("Enter a name and telephone number : \n\"Ivan-088888888\" - example");
            Console.WriteLine();
            input = Console.ReadLine();
            PhonebookAdd(phonebook, input);
        }
        else if (input == "search")
        {
            Console.Clear();
            Console.WriteLine("\"add\" - to add contact \n\"exit\" - to exit");
            Console.Write("Enter a name :");
            input = Console.ReadLine();
            PhonebookSearch(phonebook, input);
        }
        else if (input == "exit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
            input = Console.ReadLine();
        }


    }
    static void PhonebookAdd(SortedDictionary<string, List<string>> phonebook, string input)
    {
        while (true)
        {
            if (input == "search")
            {
                Console.Clear();
                Console.WriteLine("\"add\" - to add contact \n\"exit\" - to exit");
                Console.WriteLine("\"list\" - to see all contacts");
                Console.Write("Enter a name :");
                input = Console.ReadLine();
                PhonebookSearch(phonebook, input);
            }
            if (input == "exit")
            {
                Environment.Exit(0);
            }
            if (!input.Contains("-"))
            {
                Console.WriteLine("Invalid Input!");
                input = Console.ReadLine();
            }
            string[] nameAndnumber = input.Split('-').ToArray();

            if (!phonebook.ContainsKey(nameAndnumber[0]))
            {
                List<string> list = new List<string>();
                list.Add(nameAndnumber[1]);
                phonebook.Add(nameAndnumber[0].Trim(), list);
            }
            else
            {
                List<string> list = phonebook[nameAndnumber[0]];
                if (!list.Contains(nameAndnumber[1]))
                {
                    list.Add(nameAndnumber[1]);
                }
            }
            input = Console.ReadLine();
        }
    }
    static void PhonebookSearch(SortedDictionary<string, List<string>> phonebook, string input)
    {
        while (true)
        {
            
            if (input == "add")
            {
                Console.Clear();
                Console.WriteLine("\"search\" - to seasrch contact \n\"exit\" - to exit");
                Console.Write("Enter a name and telephone number : \n\"Ivan-088888888\" - example");
                Console.WriteLine();
                input = Console.ReadLine();
                PhonebookAdd(phonebook, input);
            }
            if (input == "list")
            {
                Console.WriteLine();
                foreach (var contacts in phonebook)
                {
                    Console.WriteLine("{0} -> {1}", contacts.Key, string.Join(", ", contacts.Value));
                }
                Console.WriteLine();
                Console.WriteLine("\"add\" - to add contact \n\"exit\" - to exit");
                Console.WriteLine("\"list\" - to see all contacts");
                Console.Write("Enter a name :");
                input = Console.ReadLine();
                PhonebookSearch(phonebook, input);
            }
            if (input == "exit")
            {
                Environment.Exit(0);
            }
            if (!input.Contains("-") )
            {

                Console.WriteLine("Invalid Input!");
                input = Console.ReadLine();
            }

            if (phonebook.ContainsKey(input))
            {
                Console.WriteLine("{0} -> {1}", input, string.Join(", ", phonebook[input]));
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", input);
            }
            
            input = Console.ReadLine();

        }
    }
}

