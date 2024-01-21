namespace Week2App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            float firstNumber;
            float secondNumber;

            Console.WriteLine("Please enter first number");
            firstNumber = float.Parse(Console.ReadLine()); //stringi floata cevirdik //Console Readline metn kimi, string kimi oxuyur

            Console.WriteLine("Please enter second number");
            secondNumber = float.Parse(Console.ReadLine());

            float resultSum = firstNumber + secondNumber;
            Console.WriteLine("Addition result: " + resultSum);
            Console.WriteLine($"Addition result1: {resultSum}"); //ve ya bele yaziriq

            float resultMinus = firstNumber - secondNumber;
            Console.WriteLine("Minus result: " + resultMinus);

            float resultMultiple = firstNumber * secondNumber;
            Console.WriteLine("Multiple result: " + resultMultiple);

            float resultDivide = firstNumber / secondNumber;
            Console.WriteLine("Divide result: " + resultDivide);

        }
    }
}