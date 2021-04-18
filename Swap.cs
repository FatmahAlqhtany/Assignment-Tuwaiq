
using System;
class Swap
{

    static void Main(string[] args)
    {
        swap("Iam fatimah Abdulaziz Alqhtany");
        
    }
    public static void swap(string value)
    {
        string[] array = value.Split(' ');

        for (int x = 0; x < array.Length; x += 2)
        {
            string temp = array[x];
            array[x] = array[x + 1];
            array[x + 1] = temp;
        }
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write("{0} ", array[j]);

        }
    }
}
