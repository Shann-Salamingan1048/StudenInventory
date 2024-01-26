using System;


namespace StudenInventory
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentInventory student_inventory = new StudentInventory();
            student_inventory.Run();
            Console.WriteLine();
            Console.Write("Press any key to exit. ");
            Console.ReadKey();
        }
    }
}
