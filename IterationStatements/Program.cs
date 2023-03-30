namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        static void List1000() {
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void List999By3()
        {
            for (int i = 3; i <= 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static void CheckEquality(int num1, int num2) {
            var equal = num1 == num2;
            var response = (equal) ? "The two provided numbers are equal" : "The 2 provided numbers are not equal";
            Console.WriteLine(response);
        }
        //Write a method to check whether a given number is even or odd

        static void IsNumEvenOrOdd(int num) {
            var response = num % 2 == 0 ? "number is even" : "number is odd";
            Console.WriteLine(response);
        }

        //Write a method to check whether a given number is positive or negative
        static void IsNumPosOrNeg (int num)
        {
            var response = num > 0 ? "number is positive" : "number is negative";
            Console.WriteLine(response);
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        static void CheckVotingAge() {
            Console.WriteLine("Using numbers only (not words), please enter your age");
            var age = int.Parse(Console.ReadLine());
            var response = age >= 18 ? "You're old enough to vote" : "You're not old enough to vote yet";
            Console.WriteLine(response);
        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void InRange() { 
            Console.WriteLine("Is your number between -10 and 10? (inclusive)");
            int num = int.Parse(Console.ReadLine());
            var response = (num >= -10 && num <= 10) ? "Your number is between -10 and 10" : "Your number is not in the range";
            Console.WriteLine(response);
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void ShowMultiplyTable(int num) { 
            Console.WriteLine($"Multiplication table of {num} from 1 - 12");
            for (int i = 1; i <= 12; i++) {
                Console.WriteLine($"{i} X {num} equals {i * num}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //   List1000();
            // List999By3();
            // CheckEquality(1000, 1000);
            // IsNumEvenOrOdd(100);
            // IsNumPosOrNeg(-1001);
            // CheckVotingAge();
            // InRange();
            ShowMultiplyTable(12);
        }
    }
}
