using System;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();           
        }
        static void MyMethod()
        {
            Console.WriteLine("Measurment type:");
            string type = Console.ReadLine();
            Console.WriteLine("amount:");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (type == "inch")
            {
                Console.WriteLine(amount * 3.5 + " fidget spinners");
                replay();
            } else if (type == "foot")
            {
                Console.WriteLine(amount * 5 + " memes");
                replay();
            } else if (type == "fidget spinners")
            {
                Console.WriteLine(amount / 3.5 + " inch");
                replay();
            } else if (type == "memes")
            {
                Console.WriteLine(amount / 5 + " foot");
                replay();
            }
        }
        static void replay()
        {
            Console.WriteLine("would you like another?");
            string another = Console.ReadLine();
            if (another == "yes")
            {
                MyMethod();
            } else
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
        
}
