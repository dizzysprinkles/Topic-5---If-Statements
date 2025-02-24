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
            while (!Int32.TryParse(Console.ReadLine(), out personOne))
            {
                Console.WriteLine("That's not a number, try again.");
            }
            Console.WriteLine();

            Console.WriteLine("The second person's age is...");
            while (!Int32.TryParse(Console.ReadLine(), out personTwo))
            {
                Console.WriteLine("That's not a number, try again.");
            }
            Console.WriteLine();

            Console.WriteLine("The third person's age is...");
            while (!Int32.TryParse(Console.ReadLine(), out personThree))
            {
                Console.WriteLine("That's not a number, try again.");
            }
            Console.WriteLine();

            Console.WriteLine("Awesome, thanks! From what I can tell..");

            //Print messages for when...

            // 1 > 2
            if (personOne > personTwo)
            {
                Console.WriteLine("Person 1 is older than person 2.");
            }

            // 3 < 1
            if (personThree < personOne)
            {
                Console.WriteLine("Person 3 is younger than person 1.");
            }
           
            // 2 == 3
            if (personThree == personTwo)
            {
                Console.WriteLine("Person 2 and person 3 are the same age.");
            }

            // 2 < 3 , 1
            if (personTwo < personThree && personTwo < personOne)
            {
                Console.WriteLine("Person 2 is the youngest.");
            }

            // 1 > 2,3
            if (personOne > personTwo && personOne > personThree)
            {
                Console.WriteLine("Person 1 is the oldest.");
            }
            // 2 == 1 or 2 == 3  but not both
            if (personTwo == personOne && personTwo != personThree || personTwo == personThree && personTwo != personOne)
            {
                Console.WriteLine("Person 2 is the same age as one other person.");
            }
          
            // 1 != 2 or 3 No one is the same age as person one
            if (personOne != personTwo && personOne != personThree)
            {
                Console.WriteLine("No one is the same age as person 1.");
            }

            // 1=2=3 Everyone is the same age
            if (personOne == personTwo && personTwo == personThree)
            {
                Console.WriteLine("Everyone is the same age!");
            }

            //No one is the same --  Everyone is a different age
            if (personOne != personTwo && personTwo != personThree && personThree !=personOne)
            {
                Console.WriteLine("Everyone is a diiferent age!");
            }
            // Two people are but not all three -- Exactly 2 people are the same age, but not everyone
            if (personOne == personTwo && personOne !=personThree || personTwo == personThree && personTwo !=personOne || personThree == personOne && personOne != personTwo)
            {
                Console.WriteLine("Exactly 2 people are the same age, but not everyone.");
            }
            
            
        }
    }
}
