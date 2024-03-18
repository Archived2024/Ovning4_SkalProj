using System;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static List<string> theList = new List<string>();
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            while (true)
            {
                Console.WriteLine("Enter '+' to add or '-' to remove from the list (or any other key to exit):");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value); //Ö1,F2 + F3: Listans kapacitet ökar inte förrän vi överstiger kapaciteten
                                            //som redan finns inbyggd som grund i List<T>. Den ökar med 4. Alltså om vi lagt till fyra och sen
                                            //lägger till en femte så kommer kapaciteten öka från 4 till 8
                                            //Ö1,F4: Kapaciteten ökar inte på grund av att List använder en konstant tidskomplexitetsstrategi
                                            //för att lägga till element. Detta görs genom att fördubbla listans storlek när den väl överskrider nuvarande kapaciteten
                                            //vilket gör att arbetskostnaden för att lägga till element blir konstant som i sin tur bidrar till en balans mellan prestanda och minnesanvändning.
                        Console.WriteLine($"Added '{value}' to the list.");
                        break;
                    case '-':
                        if (theList.Contains(value))
                        {
                            theList.Remove(value);//Ö1,F5: Nej Kapaciteten minskar inte. Om vi tillexempel lägger till 5 st så att standard kapaciteten ökar,
                                                  //minskar inte kapaciteten om vi börjar ta bort saker i listan utan förblir den samma. 
                            Console.WriteLine($"Removed '{value}' from the list.");
                        }
                        else
                        {
                            Console.WriteLine($"'{value}' not found in the list.");
                        }
                        break;
                    default:
                        Console.WriteLine("Please use only '+' or '-' to manipulate the list.");
                        return;
                        //Ö1,F6: En egendefinierad Array kan vara bra att använda när man har en
                        //samling med fast storlek som du vet i förväg och inte kommer behöva ändra storlek på dynamiskt.
                        //Det kan då vara mer minneseffektivt.
                        //Arrayer kan i vissa användningsfall också vara snabbare iochmed att de inte har ett förutbestämd kapacitetshantering.
             
                }

                Console.WriteLine($"Current count: {theList.Count}. Capacity: {theList.Capacity}");
                //Ö1.
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

