using System;
using System.Collections.Generic;
namespace Week4
{
    class Pharmacy
    {
        static void Main(string[] args)
        {
            double price = 0;
            int item;
            List<string> lists = new List<string>();
            Console.WriteLine("Welcome to our Pharmacy ");
        ask:
            do
            {
                Console.WriteLine("Please chose your Pharmacy: \n" +
                    "1- Medicine price: 200 SR \n" +
                    "2- Shampoo price: 50SR \n" +
                    "3- Careem price: 50SR \n" +
                    "4-Toothbrush price: 20SR\n"+
                    "5- Return to basket\n");
                item = int.Parse(Console.ReadLine());
                while (item >=6 )
                {
                    Console.WriteLine("please enter the Range between [1-5]");
                    item = int.Parse(Console.ReadLine());
                }
                switch (item)
                {
                    case 1:
                        lists.Add("Medicine price: 200 SR ");
                        price += 200;
                        break;
                    case 2:
                        lists.Add("Shampoo price: 50SR");
                        price += 50;
                        break;
                    case 3:
                        lists.Add("Careem price: 50SR");
                        price += 50;
                        break;

                    case 4:
                        lists.Add("Careem price: 50SR");
                        price += 50;
                        break;

                }

            } while (!item.Equals(5));
            basket(lists, price);
            Console.WriteLine("Do you want aother item 'yes' or 'no'");
            string  chose = Console.ReadLine();
            if (chose == "yes")
            {
                goto ask;
            }
            else if (chose == "no")
            {
                Console.WriteLine("Thank you For your Shoping ");
            }
            else
            {
                Console.WriteLine("Plese enter ethir 'yes' or 'no '");
                goto ask;
            }
       
      
        }
        public static void basket(List<string> list, double price)
        {
            Console.WriteLine("your items is :");
            foreach (string index in list)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine("Totel: "+ price);
            if (price >= 1000)
            {
                Console.WriteLine("Totel without dicount : "+ price);
                double price2 = price * 0.10;
                price -= price2;
                Console.WriteLine("Totel with dicount 10%: "+ price);
            }
        }

    }
}
