using System;
using System.Collections;
namespace Builder
{
    class MatchNumber
    { 
        static bool checkOrder(string source)
        {
            Stack startStack = new Stack();
            int number = 0;
            char temp;
            while (number < source.Length)
            {
                if (startStack.Count == 0)
                {
                    startStack.Push(source[number]);
                    number++;
                    continue;
                }

                temp = (char)startStack.Peek();

                if (source[number] == temp)
                {
                    startStack.Pop();
                }
                else if (source[number] != temp)
                {
                    startStack.Push(source[number]);
                }
                number++;
            }
            return startStack.Count == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(checkOrder("998899"));
            Console.WriteLine(checkOrder("12344321"));
            Console.WriteLine(checkOrder("1234321"));
            Console.WriteLine(checkOrder("7655544367"));
        }
    }
}
