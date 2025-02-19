namespace Topic_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personOne, personTwo, personThree;

            // Read in the three ages
            Console.WriteLine("Hey there! Please give me three people's ages and I will tell you some facts about them!");
            Console.WriteLine("The first person's age is...");
            Int32.TryParse(Console.ReadLine(), out personOne);
            Console.WriteLine();
            Console.WriteLine("The second person's age is...");
            Int32.TryParse(Console.ReadLine(), out personTwo);
            Console.WriteLine();
            Console.WriteLine("The third person's age is...");
            Int32.TryParse(Console.ReadLine(), out personThree);
            Console.WriteLine();
            Console.WriteLine("Awesome, thanks! From what I can tell..");

            //Print messages for when...

            // 1 > 2
            // 3 < 1
            // 2 == 3
            // 2 < 3 , 1
            // 1 > 2,3
            // 2 == 1 or 2 == 3  but not both
            // 1 != 2 or 3
            // 1=2=3
            //No one is the same
            // Two people are but not all three
            
            
        }
    }
}
