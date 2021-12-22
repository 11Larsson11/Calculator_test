using System;
using System.Collections.Generic;


namespace Lexicon3
{
    public class Program

    {
        static void Main()
        {
            bool running = true;
            while (running)
            {
                running = Menu(); //Making the menu run as long as the program makes the user return to the beginning each time a case is returned
            }
        }
        static bool Menu()
        {
            double valuea;
            double valueb;

            Console.Clear();
            Console.WriteLine("Choose calculation method:");
            Console.WriteLine("\n1) Regular addition, subtraction, multiplication and division" +
                "\n2) Matrix addition and subtraction");

            Console.WriteLine("\nOr 0 to close the application!");
            Console.Write(">");

            switch (Console.ReadLine()) //Using switch readline to require the correct input for respective choice
            {
                case "1":

                    Console.Clear();
                    Console.WriteLine("First enter the value for 'a'. It can be an integer or a decimal number:");
                    string inputA = Console.ReadLine();

                    while (double.TryParse(inputA, out valuea) != true)     //Looping until correct input from user

                    {
                        Console.WriteLine("Incorrect input, try entering the value for 'a' again:");
                        inputA = Console.ReadLine();
                    }

                    Console.WriteLine("\nNow enter the value for 'b':");
                    string inputB = Console.ReadLine();

                    while (double.TryParse(inputB, out valueb) != true)

                    {
                        Console.WriteLine("Incorrect input, try entering the value for 'b' again:");
                        inputB = Console.ReadLine();
                    }

                    Console.WriteLine("\nGreat! Now you can choose:" +
                        "\n1) for adding a+b" +
                        "\n2) for subtracting a-b" +
                        "\n3) for multiplying a*b" +
                        "\n4) for dividing a/b");

                    switch (Console.ReadLine())

                    {
                        case "1":
                            Console.WriteLine("\nAnswer: a + b = " + Adding(valuea, valueb) + " for a = " + valuea + " and b = " + valueb);
                            Console.WriteLine("\nPress enter to make a new calculation.");
                            Console.ReadLine();
                            return true;

                        case "2":
                            Console.WriteLine("\nAnswer: a - b = " + Subtracting(valuea, valueb) + " for a = " + valuea + " and b = " + valueb);
                            Console.WriteLine("\nPress enter to make a new calculation.");
                            Console.ReadLine();

                            return true;

                        case "3":
                            Console.WriteLine("\nAnswer: a * b = " + Multiply(valuea, valueb) + " for a = " + valuea + " and b = " + valueb);
                            Console.WriteLine("\nPress enter to make a new calculation.");
                            Console.ReadLine();

                            return true;

                        case "4":
                            
                            double zeroDetected = Divide(valuea, valueb);

                            while (zeroDetected == 0) //Running a loop until the value is correct for division

                            {
                                Console.WriteLine("When using division, the value for 'b' cannot be zero. Try entering the value for 'b' again:");
                                Console.Write(">");
                                string inputC = Console.ReadLine();

                                while (double.TryParse(inputC, out valueb) != true)

                                {
                                    Console.WriteLine("Incorrect input, try entering the value for 'a' again:");
                                    inputC = Console.ReadLine();
                                }

                                break;

                            }

                            Console.WriteLine("\nAnswer: a / b = " + Divide(valuea, valueb) + " for a = " + valuea + " and b = " + valueb);
                            Console.Write("\nPress enter to make a new calculation.");
                            Console.ReadLine();

                            return true;

                        default:

                            return true;

                    }

                case "2":

                    Console.Clear();
                    Console.WriteLine("Matrix addition addition or subtraction.");
                    Console.WriteLine("\nFirst enter the values in a matrix, as integers separated by space (for example: '1 24 4'):");
                    Console.Write(">");
                    var inputMatrix = Console.ReadLine();

                    string[] incomingValues;
                    incomingValues = inputMatrix.Split(' '); //separating the elements of the array using space
                    var numbers = new List<int>();

                    foreach (var stringNumber in incomingValues)
                    {
                        numbers.Add(int.Parse(stringNumber));  //populating the array with integers
                    }
                    int[] arrayNumbers = numbers.ToArray();


                    Console.WriteLine("\nNow enter the value for 'b':");
                    Console.Write(">");
                    string inputMatrixPlusB = Console.ReadLine();

                    while (double.TryParse(inputMatrixPlusB, out valueb) != true)

                    {
                        Console.WriteLine("Incorrect input, try entering the value for 'b' again:");
                        inputMatrixPlusB = Console.ReadLine();
                    }


                    Console.WriteLine("\nGreat! Now choose:" +
                        "\n1) for adding b to the matrix" +
                        "\n2) for subtracting b from the matrix");
                    Console.Write(">");
                    switch (Console.ReadLine())

                    {
                        case "1":

                            Console.WriteLine("\nWhen adding " + valueb + " to the matrix, the results are: ");

                            foreach (int i in arrayNumbers)     //taking each value in the array and calculating it
                            {
                                Console.Write(Adding(i, valueb) + " ");
                            }

                            Console.Write("\n" +
                            "\nPress enter to make a new calculation.");
                            Console.ReadLine();

                            return true;

                        case "2":

                            Console.WriteLine("\nWhen subtracting " + valueb + " from the above matrix, the results are: ");

                            foreach (int i in arrayNumbers)
                            {
                                Console.Write(Subtracting(i, valueb) + " ");
                            }

                            Console.Write("\n" +
                            "\nPress enter to make a new calculation.");
                            Console.ReadLine();

                            return true;

                        default:
                            return true;
                            
                    }

                case "0":
                    return false;

                default:
                    return true; //Making the user always to return to the menu, unless typing the specific numbers 0-4
            }
        }

        //Methods with the different ways of calculating
        public static double Adding(double valuea, double valueb)
        {
            return valuea + valueb;
        }
        public static double Adding(int i, double valueb)
        {
            return i + valueb;
        }
        public static double Subtracting(double valuea, double valueb)
        {
            return valuea - valueb;
        }
        public static double Subtracting(int i, double valueb)
        {
            return i - valueb;
        }
        public static double Multiply(double valuea, double valueb)
        {
            return valuea * valueb;
        }
        public static double Divide(double valuea, double valueb)
        {
            if (valueb != 0)        //A method for avoiding division with zero
                return (valuea / valueb);

            else
            {
                return 0;
            }
        }
    }
}

