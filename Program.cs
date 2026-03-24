using System;

namespace PeriodicTableSystem
{
    public class Program
    {
        private static PeriodicTable table;

        public static void Main()
        {
            table = new PeriodicTable();
            bool running = true;

            Console.WriteLine("========================================");
            Console.WriteLine("Hi there! Happy to help!");
            Console.WriteLine("========================================\n");

            while (running)
            {
                Console.Write("Provide atomic number of the element: ");
                string input = Console.ReadLine();
                int atomic_number;

                if (!int.TryParse(input, out atomic_number) || atomic_number < 1 || atomic_number > 30)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 30.\n");
                    continue;
                }

                if (!table.ElementExists(atomic_number))
                {
                    Console.WriteLine("Element not found in the database.\n");
                    continue;
                }

                Element elem = table.GetElement(atomic_number);
                DisplayElement(elem);

                Console.Write("\nDo you want to know more elements [y/n]? ");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "n")
                {
                    running = false;
                }
                else if (choice.ToLower() != "y")
                {
                    Console.WriteLine("Invalid choice. Please enter 'y' or 'n'.\n");
                    running = true;
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nThanks !");
        }

        private static void DisplayElement(Element elem)
        {
            Console.WriteLine("\nAtomic Number: {0}", elem.atomic_number);
            Console.WriteLine("Name: {0}", elem.name);
            Console.WriteLine("Symbol: {0}", elem.symbol);
            Console.WriteLine("Class: {0}", elem.element_class);
            Console.WriteLine("Atomic Mass: {0:F4}", elem.atomic_mass);
            Console.WriteLine("Information: {0}", elem.information);
        }
    }
}
