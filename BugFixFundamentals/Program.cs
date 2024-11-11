namespace BugFixFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOTE! Remove the return statements below once you have fixed the bug to proceed with the next tasks.

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            // Task 1: Fix the function to correctly print the full name
            PrintFullName(firstName, lastName);

            return;

            // Task 2: Fix the function to handle division by zero.
            // If division by zero is attempted, the function should return -1
            double result = Divide(12, 0);

            return;

            int[] numbers = { 1, 2, 3, 4, 5 };

            // Task 3: Fix the function to correctly calculate the average
            double average = CalculateAverage(numbers);

            return;

            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());

            // Task 4: Fix the function to correctly identify the generation if age is 59
            DetermineGeneration(age);

            return;

            // Task 5: Fix the function to work correctly
            PrintPlanetNames();

            return;
        }

        public static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public static double CalculateAverage(int[] numbers)
        {
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++) // Changed i = 1 to i = 0
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0) // Changed condition to only check if b == 0
            {
                return -1;
            }
            else
            {
                return (double)a / b; // Casted a to double to ensure decimal division
            }
        }

        public static void DetermineGeneration(int age) // Corrected typo in method name
        {
            if (age >= 0 && age <= 13)
            {
                Console.WriteLine("You belong to Generation Alpha.");
            }
            else if (age >= 14 && age <= 28)
            {
                Console.WriteLine("You belong to Generation Z.");
            }
            else if (age >= 29 && age <= 43) // Fixed the second condition from >= to <=
            {
                Console.WriteLine("You belong to Millennials (Generation Y).");
            }
            else if (age >= 44 && age <= 58) // Fixed condition to use && instead of ||
            {
                Console.WriteLine("You belong to Generation X.");
            }
            else if (age >= 59 && age <= 77)
            {
                Console.WriteLine("You belong to the Baby Boomers generation.");
            }
            else
            {
                Console.WriteLine("You do not belong to any of the above generations in this program.");
            }
        }

        public static void PrintPlanetNames()
        {
            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            for (int i = 0; i < planets.Length; i++) // Changed i <= planets.Length to i < planets.Length to avoid out-of-bounds error
            {
                Console.WriteLine(planets[i]);
            }
        }
    }

}
