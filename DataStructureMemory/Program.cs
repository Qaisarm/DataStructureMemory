﻿using System;
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
                    case '5':
                        TestQueue();
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

