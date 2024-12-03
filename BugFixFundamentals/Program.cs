namespace BugFixFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOTE! Remove the return statement below the task once you have fixed the bug so you can proceed to the next task.

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            // Task 1: Fix the function so that it correctly prints the full name.
            PrintFullName(firstName, lastName);

            return;

            // Task 2: Fix the function for cases involving division by zero.
            // If there is an attempt to divide by zero, the function should return -1.
            double result = Divide(12, 0);

            return;

            int[] numbers = { 1, 2, 3, 4, 5 };

            // Task 3: Fix the function so that it correctly calculates the average.
            double average = CalculateAverage(numbers);

            return;

            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());

            // Task 4: Fix the function so that it prints the correct generation when the age is 59.
            DeterminiteGeneration(age);

            return;

            // Task 5: Fix the function to make it work properly.
            PrintPlanetNames();

            return;

        }

        public static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + lastName);
        }

        public static double CalculateAverage(int[] numbers)
        {
            double sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        public static double Divide(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                return -1;
            }
            else
            {
                return a / b;
            }
        }

        public static void DeterminiteGeneration(int age)
        {
            if (age >= 0 && age <= 13)
            {
                Console.WriteLine("You belong to Generation Alpha (Alpha).");
            }
            else if (age >= 14 && age <= 28)
            {
                Console.WriteLine("You belong to Generation Z.");
            }
            else if (age >= 29 && age >= 43)
            {
                Console.WriteLine("You belong to Millennials (Generation Y).");
            }
            else if (age >= 44 || age <= 58)
            {
                Console.WriteLine("You belong to Generation X.");
            }
            else if (age >= 59 && age <= 77)
            {
                Console.WriteLine("You belong to the Baby Boomer generation.");
            }
            else
            {
                Console.WriteLine("You do not belong to any of the above generations in this program.");
            }
        }

        public static void PrintPlanetNames()
        {
            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            for (int i = 0; i <= planets.Length; i++)
            {
                Console.WriteLine(planets[i]);
            }
        }

    }
}
