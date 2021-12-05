namespace Lab1
{
    public class FizzBuzz
    {

        public void Start()
        {
            string welcomeText = "This is a FizzBuzz generator. To generate a FizzBuzz text up to a certain number, please enter the number (between 1 and 100)!";
            string resultError = "You haven't entered a correct number! Please enter a correct number!";
            string resultTextLow = "You have entered a number less than 1. Please enter a number between 1 and 100 instead!";
            string resultTextHigh = "You have entered a number higher than 100. Please enter a number between 1 and 100 instead!";

            int? userInput = PromptUserAndGetNumber(welcomeText, resultError, resultTextLow, resultTextHigh);

            if (!userInput.HasValue)
            {
                Console.WriteLine("An unexpected error occured in the program!");
                Console.ReadLine();
                return;
            }

            var outputText = GenerateResult(userInput.Value);

            PrintOutputToUser(outputText);
        }

        public int? PromptUserAndGetNumber(string welcomeText, string resultError, string errorTextLow, string errorTextHigh)
        {
            Console.WriteLine($"{welcomeText}");
            string result = Console.ReadLine();
            bool correctNumberHaveNotBeenEntered = true; // Note! Value does actually never change.

            while (correctNumberHaveNotBeenEntered)
            {
                if (int.TryParse(result, out int endNumber))
                {
                    switch (endNumber)
                    {
                        case < 1:
                            Console.WriteLine(errorTextLow);
                            break;
                        case > 100:
                            Console.WriteLine(errorTextHigh);
                            break;
                        case > 0 and < 101:
                            return endNumber;
                    }
                }
                else Console.WriteLine(resultError);

                result = Console.ReadLine();
            }

            return null;
        }

        public List<string> GenerateResult(int endNumber)
        {
            List<string> output = new List<string>();

            for (int i = 1; i < endNumber + 1; i++)
            {
                if (IsThisFizzBuzz(i)) output.Add("FizzBuzz");
                else if (IsThisBuzz(i)) output.Add("Buzz");
                else if (IsThisFizz(i)) output.Add("Fizz");
                else output.Add(i.ToString());
            }

            return output;
        }

        public bool IsThisFizzBuzz(int number)
        {
            return number % 15 == 0;
        }

        public bool IsThisBuzz(int number)
        {
            return number % 5 == 0;
        }

        public bool IsThisFizz(int number)
        {
            return number % 3 == 0;
        }

        private void PrintOutputToUser(List<string> outputText)
        {
            Console.WriteLine("Thanks for the number! Your FizzBuzz is:");

            Console.WriteLine(string.Join(", ", outputText));
        }
    }
}
