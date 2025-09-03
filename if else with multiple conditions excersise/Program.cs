namespace if_else_with_multiple_conditions_excersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18 && age <= 80)
            {
                Console.WriteLine("you are allowed to drive!");
            }
            else
            {
                Console.WriteLine("you must be 18-80 to drive");
            }
            Console.WriteLine("Please enter the day of the week:");
            string day = Console.ReadLine();

            if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine("It is the weekend yayy");
            }
            else
            {
                Console.WriteLine("It is a weekday :(");
            }
            Console.WriteLine("Do you want cheese? (yes/no)");
            string cheeseChoice = Console.ReadLine().ToLower();

            Console.WriteLine("Do you want pepperoni? (yes/no)");
            string pepperoniChoice = Console.ReadLine().ToLower();

            if (cheeseChoice == "yes" && pepperoniChoice == "yes")
            {
                Console.WriteLine("Cheese & pepperoni pizza coming uppp!!");
            }
            else if (cheeseChoice == "yes" && pepperoniChoice == "no")
            {
                Console.WriteLine("Marghareta pizza coming up, no topping pizza");
            }
            else if (cheeseChoice == "no" && pepperoniChoice == "no")
            {
                Console.WriteLine("Boneless pizza");
            }
            Console.WriteLine("Are you a student? (yes/no)");
            string studentStatus = Console.ReadLine().ToLower();

            Console.WriteLine("Do you have a student card? (yes/no)");
            string studentCardStatus = Console.ReadLine().ToLower();

            if (studentStatus == "yes" && studentCardStatus == "yes")
            {
                Console.WriteLine("Access granted.");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }
            Console.WriteLine("Is it raining? (yes/no)");
            string weatherStatus = Console.ReadLine().ToLower();

            if (weatherStatus == "no")
            {
                Console.WriteLine("You dont need an umbrella");
            }
            else if (weatherStatus == "yes")
            {
                Console.WriteLine("Take an umbrella!");
            }

        }
    }
}
