using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic ;

namespace jsonBank
{
    class Program
    {
        static String file = "../../../../../../data/account.json";
        static void Main(string[] args)
        {
            Boolean isRunning = true;
            
            Console.WriteLine("--- WELCOME TO ACCOUNTING ---");

            while (isRunning)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. View Accounts");
                Console.WriteLine("2. View Account by ID");
                Console.WriteLine("3. EXIT");
                Console.Write(">> ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        var accounts = ReadAccounts();
                            int id = 0;
                        foreach (var account in accounts)
                        {
                            Console.WriteLine("ID[" + id + "]: \n" + account);
                            id++;
                        }

                        Console.WriteLine();
                        break;
                    
                    case 2:
                        Console.WriteLine("Choose an index of the account: ");
                        Console.Write(">> ");
                        int index = Convert.ToInt32(Console.ReadLine());

                        ReadIndexOfAccounts(index);

                        Console.WriteLine();
                        break;
                    
                    case 3:
                        Console.WriteLine("GOOD BYE");
                        isRunning = false;
                        break;
                    
                    default:
                        Console.WriteLine("INVALID INPUT! TRY AGAIN!");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static IEnumerable<Account> ReadAccounts()
        {

            using (StreamReader r = new StreamReader(file))
            {
                string data = r.ReadToEnd();

                var json = JsonSerializer.Deserialize<Account[]>(
                    data,
                    new JsonSerializerOptions {
                        PropertyNameCaseInsensitive = true
                    }
                );

                return json;
            }
        }
        
        static IEnumerable<Account> ReadIndexOfAccounts(int index)
        {

            using (StreamReader r = new StreamReader(file))
            {
                string data = r.ReadToEnd();

                var json = JsonSerializer.Deserialize<Account[]>(
                    data,
                    new JsonSerializerOptions {
                        PropertyNameCaseInsensitive = true
                    }
                );

                 Console.WriteLine(json[index]);
                return json;
            }
        }
    }

    public class Account
    {
        public int Number { get; set; }
        public int Balance { get; set; }
        public string Label { get; set; }
        public int Owner { get; set; }
        
        public override string ToString()
        {
            return "+--------+---------+-----------+-------+\n" +
                   "| " + Number + " | " +  Balance + " |   " + Label  +" | " + Owner + " |\n" +
                   "+--------+---------+-----------+-------+\n";
        }
    }
}