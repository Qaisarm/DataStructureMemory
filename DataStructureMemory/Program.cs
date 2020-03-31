using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace DataStructureMemory
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
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
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            bool exit = false;
            List<string> theList = new List<string>();

            do
            {

                Console.WriteLine("___________________________________________");
                Console.WriteLine("########### Examine List Menu #############");
                Console.WriteLine("___________________________________________\n");
                Console.WriteLine("To add item to list enter '+Item name'.");
                Console.WriteLine("To remove item from the list enter '-Item name'.");
                Console.WriteLine("To print item in the list enter 'p'.");
                Console.WriteLine("Enter 'q' to exit this menu.");
                Console.WriteLine("_________________________\n");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    case 'p':
                        foreach(var listItem in theList) {
                            Console.WriteLine(listItem);
                              }
                        Console.WriteLine( $"Item Count: {theList.Count}");
                        Console.WriteLine($"List Capacity: {theList.Capacity}");
                        break;
                    case 'q':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter in a correct format to add/remove items from the List");
                        break;
                }
            } while (!exit);
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
            bool exit = false;
            Queue qt = new Queue();
            do
            {
                Console.WriteLine("___________________________________________");
                Console.WriteLine("########### Examine Queue Menu #############");
                Console.WriteLine("___________________________________________\n");
                Console.WriteLine("To add element to queue '+name'.");
                Console.WriteLine("To remove first element from the queue enter '-'.");
                Console.WriteLine("To print elements in the queue enter 'p'.");
                Console.WriteLine("Enter 'q' to exit this menu.");
                Console.WriteLine("_________________________\n");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        qt.Enqueue(value);
                        break;
                    case '-':
                        qt.Dequeue();
                        break;
                    case 'p':
                        foreach (Object obj in qt)
                        {
                            Console.WriteLine(obj);
                        }
                        string nElement = $" Number of Elements in Queue: {qt.Count}";
                        Console.WriteLine(nElement);
                        break;
                    case 'q':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter in a correct format to enqueue or dequeue elements from Queue");
                        break;
                }
            } while (!exit);

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
           
          


            bool exit = false;

            Stack<string> myStack = new Stack<string>();

            do
            {
                Console.WriteLine("___________________________________________");
                Console.WriteLine("########### Examine Stack Menu #############");
                Console.WriteLine("___________________________________________\n");
                Console.WriteLine("To check ICA queue stack enter '1'.");
                Console.WriteLine("To add element in stack enter  'a'.");
                Console.WriteLine("To remove element from stack enter  'o'.");
                Console.WriteLine("To print elements in the stack enter 'p'.");
                Console.WriteLine("Enter 'q' to exit this menu.");
                Console.WriteLine("_________________________\n");

                string input = Console.ReadLine();
                char nav = input[0];
                switch (nav)
                {
                    
                    case '1':
                        IcaStack();

                        break;
                    case 'a':
                        CheckStack(myStack); ;
                       

                        break;
                
                    case 'p':
                        foreach (Object obj in myStack)
                        {
                            Console.WriteLine(obj);
                        }
                        string nElement = $" Number of Elements in Stack: {myStack.Count}";
                        Console.WriteLine(nElement);
                        break;
                    case 'q':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter in a correct format to push or pop elements from Stack");
                        break;
                }
            } while (!exit);
            


            static void IcaStack()
            {
                // ICA Queue
                string[] values = { "Kalle", "Greta", "Stina", "Olle", "Erik", "Sara" };


                var stack = new Stack<string>(values);

                // Display the Stack.
                Console.WriteLine("--- Stack contains ---");
                foreach (var st in stack)
                {
                    Console.WriteLine(st);
                }
            }

            static void CheckStack(Stack<string> myStack)
            {

                Console.WriteLine("Enter you input:");
                string myString = Console.ReadLine();

                for (int i = 0; i < myString.Length; i++)
                {
                    myStack.Push(myString[i].ToString());
                }

                Console.WriteLine("_____________________");
                Console.WriteLine("Pop out string");
                Console.WriteLine("_____________________");
                for (int j = 0; j < myString.Length; j++)
                {
                    Console.WriteLine(myStack.Pop());
                }
            }
        }


        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

           
            string expression;
            Console.Write("Enter an expression/Enter 0 to exit the menu:  ");
            expression = Console.ReadLine();

            
            if (AreParanthesesBalanced(expression))
            {
                Console.Write("The Parantheses are in Correct form\n");
                Console.WriteLine(expression);
            }
            else
            {
                Console.Write("The Parantheses are not in Correct form\n");
                Console.WriteLine(expression);
            }

            static bool pairedParantheses(char opening, char closing)
            {
                if (opening == '(' && closing == ')')
                {
                    return true;
                }
                else if (opening == '{' && closing == '}')
                {
                    return true;
                }
                else if (opening == '[' && closing == ']')
                {
                    return true;
                }
                return false;
            }
            static bool AreParanthesesBalanced(string exp)
            {
                Stack<char> pStack = new Stack<char>();
                for (int i = 0; i < exp.Length; i++)
                {
                    if (exp[i] == '(' || exp[i] == '{' || exp[i] == '[')
                    {
                        pStack.Push(exp[i]);
                    }
                    else if (exp[i] == ')' || exp[i] == '}' || exp[i] == ']')
                    {
                        if (pStack.Count == 0 || !pairedParantheses(pStack.Peek(), exp[i]))
                        {
                            return false;
                        }
                        else
                        {
                            pStack.Pop();
                        }
                    }
                }
                return pStack.Count == 0 ? true : false;
            }

            

        }

    }
}

