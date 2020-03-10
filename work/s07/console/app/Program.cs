using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic ;
using System.Linq;

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
                        var accountId = ReadAccounts();
                        Console.WriteLine("Choose an index of the account: ");
                        Console.Write(">> ");
                        int index = Convert.ToInt32(Console.ReadLine());

                        var exists = accountId.FirstOrDefault(account => account.Number == index);
                        if (exists == null)
                        {
                            Console.WriteLine("This account does not exists");
                            break;
                        }
                        PrintArray(new []{exists});
                        break;

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

        private static void PrintArray(IEnumerable<Account> accounts)
        {
            var accountList = accounts.ToList();
            if (!accountList.Any())
            {
                return;
            }

            const string lineBreak = "+--------+---------+-----------+-------+";
            Console.WriteLine(lineBreak);
            Console.WriteLine("| Number | Balance |   Label   | Owner |");
            Console.WriteLine(lineBreak);
            foreach (var account in accountList)
            {
                Console.WriteLine($"|{account.Number,8}|{account.Balance,9}|{account.Label,11}|{account.Owner,7}|");
                Console.WriteLine(lineBreak);
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