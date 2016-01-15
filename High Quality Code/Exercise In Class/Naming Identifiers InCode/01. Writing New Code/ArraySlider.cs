namespace _01.Writing_New_Code
{
    using System;
    using System.Linq;
    using System.Numerics;

    class ArraySlider
    {
        static void Main()
        {
            BigInteger[] numbers = Console.ReadLine()
                                   .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(BigInteger.Parse).ToArray();
            var currLine = Console.ReadLine();
            var currIndex = 0;
            while (currLine != "stop")
            {
                var command = currLine.Split();
                var offset = int.Parse(command[0]) % numbers.Length;
                var operation = command[1];
                var operand = int.Parse(command[2]);

                if (offset < 0)
                {
                    offset += numbers.Length;
                }

                currIndex = (currIndex + offset) % numbers.Length;
                var changedNumber = PerformOperation(operation, numbers[currIndex], operand);
                numbers[currIndex] = changedNumber;
                currLine = Console.ReadLine();
            }

            Console.Write("[");
            Console.Write(string.Join(", ", numbers));
            Console.Write("]");
        }

        static BigInteger PerformOperation(string operationType, BigInteger firstNumber, int secondNumber)
        {
            BigInteger result = 0;
            switch (operationType)
            {
                case "&":
                    result = firstNumber & secondNumber;
                    break;
                case "|":
                    result = firstNumber | secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = (firstNumber - secondNumber) < 0 ? 0 : (firstNumber - secondNumber);
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "^":
                    result = (firstNumber ^ secondNumber) < 0 ? 0 : (firstNumber ^ secondNumber); ;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
