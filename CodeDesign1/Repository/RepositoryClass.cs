using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign1.Repository
{
    internal class RepositoryClass
    {
        public static void Run()
        {

            Console.WriteLine("Repository");

            
            Console.WriteLine("Welcome To DB");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Select ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: Get Data");
            Console.WriteLine("B: Get Customer");
            Console.WriteLine("C: Get Animal");
            Console.WriteLine("D: Save Data");
            Console.WriteLine("E: Save Customer");
            Console.WriteLine("F: Save Animal");
            Console.WriteLine("X: Exit Program");


            
            while (true)
            {
               
                char userInput = Console.ReadKey(true).KeyChar;

                var dataRepository = new DataRepository();
                string data = dataRepository.Load("Dataset A");
                string customer = "";
                string animal = "";

                switch (userInput)
                {
                    case 'a' or 'A':
                        data = dataRepository.GetData();
                        Console.WriteLine($"This is the {data}");
                        break;

                    case 'b' or 'B':
                        customer = dataRepository.GetCustomer();
                        Console.WriteLine($"Customer: {customer}");
                        break;

                    case 'c' or 'C':
                        animal = dataRepository.GetAnimal();
                        Console.WriteLine($"Animal: {animal}");
                        break;

                    case 'd' or 'D':
                        if (data != "")
                        {
                            dataRepository.Save(data);
                            Console.WriteLine($"Saved {data}");
                        }
                        else
                        {
                            Console.WriteLine("Nothing to save");
                        }
                        break;

                    case 'e' or 'E':
                        if (customer != "")
                        {
                            dataRepository.Save(customer);
                            Console.WriteLine($"Saved {customer}");
                        }
                        else
                        {
                            Console.WriteLine("Nothing to save");
                        }
                        break;

                    case 'f' or 'F':
                        if (animal != "")
                        {
                            dataRepository.Save(animal);
                            Console.WriteLine($"Saved {animal}");
                        }
                        else
                        {
                            Console.WriteLine("Nothing to save");
                        }

                        break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }
}
