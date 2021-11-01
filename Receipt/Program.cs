using System;

namespace Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Street address: ");
            string address = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();
            Console.Write("Zip code: ");
            string zipcode = Console.ReadLine();
            Console.Write("How many magic blenders do you want to order? ");
            double orderTotal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Receipt for: \n{0}\n{1}\n{2}, {3} {4}\n",
                                name, address, city, state, zipcode);

            Console.WriteLine("{0} blenders ordered @39.95 each \n", orderTotal);

            orderTotal *= 39.95;
            Console.WriteLine("Total:{0, 10}", orderTotal.ToString("F1"));
            double tax = orderTotal * .07;
            Console.WriteLine("Tax:  {0, 10}", tax.ToString("F3"));
            Console.WriteLine("----------------------------");
            double due = orderTotal + tax;
            Console.WriteLine("Due:  {0, 10}", due.ToString("F3"));
        }
    }
}