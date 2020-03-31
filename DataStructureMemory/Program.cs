using System;
using System.Collections.Generic;
using System.Collections;

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
        /// 1-
        /// Stack is a static memory allocation and the valiables are 
        /// directly stored to thememory. It is a Last-in, First-out (LIFO) data structure.
        /// Data can be added to stack and deleted only from the top of stack to add Push is used
        /// while to delete Pop is used.
        /// On the other hand Heap is a Dynamic memory allocation, i.e.,
        /// the valiables get their memory allocation on the runtime and the valiavles can be resized
        /// Heap contains actual objects and heap memory is used by all parts of application.
        /// 
        /// as an example to add two integers we have a method
        /// int add(int a, int b){
        /// return a+b;
        /// }
        /// when we call this method as
        /// int a =3;
        /// int b =5;
        /// int result = add(a,b)
        /// The integers 3 and 5 are copied into the add() stack and the result is 
        /// allocated on the add’s stack and then copied back to the result.
        /// 
        /// an other way to implement the above example is 
        /// int add()
        /// {
        /// return this.a+this.b;
        /// }
        /// this.a= 3;
        /// this.b= 5;
        /// int result = add();
        /// here a and b are stored in heap
        /// This method has no arguments but a and b are copied from heap to 
        /// the program stack before being operated in add().
        /// 
        /// 2-
        /// Value type is a data type that holds a data value within its own memory space
        /// and they contain their values directly e.g, int i = 5;
        /// In this case the system stores the value of 5 in the memory space allocated to 'i'
        /// 
        /// on the other hand Reference type doest not stores the value directly and instead it stores the 
        /// address where the value is being stored, i.e., it contains a pointer to another memory location
        /// that holds the data.
        /// 3-
        /// in the first method the data is of value type, 
        /// first we allocate 3 to x, then we state y=x and then 4 to y,
        /// the value of x is not changed so when we return x it returns 3.
        /// but in the second method the data is refference type when we change the value of 
        /// y to x and assign a new value to y, then the value of x is also changed
        /// as we have same pointer to x and y.
        /// 
        /// </summary>


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
        /// Examines the datastructure List
        /// 
        /// 2- The capacity of list is increased when the current capacity is exceeded
        /// 3- The capacity is doubbled
        /// 4- When the capacity of the list expands a new list is created and all the elements 
        /// are inserted in the new list which is not memory efficeient as if its capacity is
        /// not increased then every time a new list has to be created and the data has to be inserted 
        /// in the new list. To avoid this the the capacity is doubbled every time it exceeds the limits.
        /// 5- The capacity is not decreased when we remove the element from list
        /// 6- Instead of list the advantage of self-defined array is when we know the number of the elements
        /// a list should have.
        /// </summary>


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
            /// <summary>
            /// Examines the datastructure Stack
            /// 
            /// It is not so smart to use stack in ICA queue example as stack operates
            /// on First in Last out method, so when Kalle enters the queue he will exit from the queue 
            /// the last
            /// </summary>
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

            Console.WriteLine("___________________________________________");
            Console.WriteLine("########### Examine Paranthesis #############");
            Console.WriteLine("___________________________________________\n");
            string expression;
            Console.Write("Enter an expression with Paranthesis:  ");
            expression = Console.ReadLine();

            
            if (AreParanthesesBalanced(expression))
            {

                Console.WriteLine("___________________________________________\n");
                Console.Write("The Parantheses are in Correct form\n");

                Console.WriteLine("___________________________________________\n");
                Console.WriteLine(expression);

                Console.WriteLine("___________________________________________\n");
            }
            else
            {

                Console.WriteLine("___________________________________________\n");
                Console.Write("The Parantheses are not in Correct form\n");

                Console.WriteLine("___________________________________________\n");
                Console.WriteLine(expression);

                Console.WriteLine("___________________________________________\n");
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

