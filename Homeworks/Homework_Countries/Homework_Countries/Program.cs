using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            var Countries = new Dictionary<string, string>();

            Countries.Add("Macedonia", "Skopje");
            Countries.Add("Spain", "Madrid");
            Countries.Add("Portugal", "Lisbon");
            Countries.Add("France", "Paris");
            Countries.Add("Germany", "Berlin");

            while (true)
            {
                Console.WriteLine("Choose 1 in order to add a new country and a capital city");
                Console.WriteLine("Choose 2 to find the capital city of a country");

                int choice;
                bool IsChosen = int.TryParse(Console.ReadLine(), out choice);

                if (choice == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Please add the new country:");
                        string newCountry = Console.ReadLine();

                        Console.WriteLine("Please add the capital of the new country:");
                        string newCapital = Console.ReadLine();

                        Countries.Add(newCountry, newCapital);
                        

                        while (true)
                        {
                            Console.WriteLine("Do you want to add another country and its capital? Yes or No");
                            var answer = Console.ReadLine();

                            if (answer == "Yes" || answer == "yes")
                            {
                                break;
                            }
                            else if (answer == "No" || answer == "no")
                            {
                                Console.WriteLine("Here is the list of the countries");

                                foreach (var country in Countries)
                                {
                                    Console.WriteLine(country);
                                }

                                Console.ReadLine();
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Press enter to continue");
                                Console.ReadLine();
                                continue;
                            }
                        }
                    }
                }
                else if (choice == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Please enter the name of the country:");
                        var userInput = Console.ReadLine();

                        if (Countries.ContainsKey(userInput))
                        {
                            Console.WriteLine($"The capital city of {userInput} is {Countries[userInput]}.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"There is no such country in our database. Press enter to continue:");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Choose 1 in order to add a new country and a capital city");
                    Console.WriteLine("Choose 2 to find the capital city of a country");
                    continue;
                }
            }
        }
    }
}
