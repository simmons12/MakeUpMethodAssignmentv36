using System;

namespace MakeUpMethodAssignmentv36
{
    class Program
    {
        static void CopyCreator(string RandWord)
        {
            string UserInput;
            int Number;
            int i;
            UserInput = Console.ReadLine();
            
            
            if (!Int32.TryParse(UserInput, out Number))
            {
                Console.WriteLine(" Error: Invalid data input. Please start again.");
            }
            else if ((Number < 3) || (Number > 6))
            {
                Console.WriteLine(" Error: Number out of range: Pleast start again " +
                    "and enter a number between 3 and 6.");
            }
            else
            {
                for (i = 0; i <= Number; i++)
                {
                    Console.WriteLine(" " + RandWord);
                    
                }
                                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Jordan Simmons Version = 36");
            
            Console.WriteLine("Please type the first word that comes to mind, then hit enter");
            
            //Declare word that will be duplicated
            string RandWord;

            RandWord = Console.ReadLine();

            Console.WriteLine("Now please select an integer from 3 to 6, then hit enter");
                        
            //Call Method
            CopyCreator(RandWord);

        }
    }
}
