using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;
using System.Xml.Serialization;

namespace PracticeExerciseWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chooseExerciseNo = 0;
            Console.Write("Please enter a valid exercise number (1 -26 ): ");
            chooseExerciseNo = Convert.ToInt32(Console.ReadLine());

            switch (chooseExerciseNo)
            {
                case 1:
                    RunExerciseOne();
                    break;

                case 2:
                    RunExerciseTwo();
                    break;

                case 3:
                    RunExerciseThree();
                    break;

                case 4:
                    RunExerciseFour();
                    break;

                case 5:
                    RunExerciseFive();
                    break;

                case 6:
                    RunExerciseSix();
                    break;

                case 7:
                    RunExerciseSeven();
                    break;

                case 8:
                    RunExerciseEight();
                    break;


                case 9:
                    RunExerciseNine();
                    break;

                case 10:
                    RunExerciseTen();
                    break;

                case 11:
                    RunExerciseEleven();
                    break;

                case 12:
                    RunExerciseTwelve();
                    break;

                case 13:
                    RunExerciseThirteen();
                    break;

                case 14:
                    RunExerciseFourteen();
                    break;

                case 15:
                    RunExerciseFifteen();
                    break;

                case 16:
                    RunExerciseSixteen();
                    break;

                case 17:
                    RunExerciseSeventeen();
                    break;
            }



        }

        static void RunExerciseOne()
        {

            Console.Write("Please enter First Name:");
            String firstName = Console.ReadLine();
            Console.Write("Please enter Last Name:");
            String lastName = Console.ReadLine();
            Console.Write("Hello " + firstName + " " + lastName + "! I'm glad to inform you that you are the test subject of my first assignment ");

        }


        static void RunExerciseTwo()
        {

            DateTime today = DateTime.Today;
            Console.WriteLine("Today's date is " + today);

            DateTime tomorrow = DateTime.Today.AddDays(+1);
            Console.WriteLine("Tomorrow's date is " + tomorrow);

            DateTime yesterday = DateTime.Today.AddDays(-1);
            Console.WriteLine("Yesterday's date was " + yesterday);

        }

        static void RunExerciseThree()
        {
            String firstName = "Shreya";
            String lastName = "Sai";

            Console.Write("Please Enter your First Name:");
            firstName = Console.ReadLine();
            Console.Write("Please Enter your Last Name:");
            lastName = Console.ReadLine();

            Console.Write(firstName + " " + lastName);


        }

        static void RunExerciseFour()
        {
            /*string engText = "I am Arijeet";
            string result = "";

            result = engText.Substring(5);
            Console.WriteLine("Original String:"+ engText);
            Console.WriteLine("Sub String:" + result);

             result = engText.Remove(5);
             Console.WriteLine("Remove String:" + result);

             int index = 0;

             index = engText.IndexOf("Arijeet");
             Console.WriteLine("IndexOf String:" + index);

             string replace = engText.Replace("am", "Called");
             Console.WriteLine("ReplaceString: " + replace);

             string insert = engText.Insert(5, "Ghosh ");
             Console.WriteLine("InsertString: " + insert);
            */

            string str = "The quick fox jumped Over the DOG";

            // The brown fox jumped over the lazy dog
            /*Console.WriteLine("Original String: " + str);
            result = str.Substring(4);
            Console.WriteLine("SubString" + result);
           */

            Console.WriteLine("Original String: " + str);
            string replace = str.Replace("quick", "brown");
            Console.WriteLine("ReplaceString: " + replace);

            string insert = replace.Insert(30, "lazy ");
            Console.WriteLine("InsertString: " + insert);

            string fox = insert.Replace("Over", "over");
            Console.WriteLine("ReplaceString: " + fox);

            string dog = fox.Replace("DOG", "dog");
            Console.WriteLine("ReplaceString: " + dog);
        }


        static void RunExerciseFive()
        {
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            int index = str.IndexOf("2");
            Console.WriteLine("IndexString: " + index);

            //int num = str.IndexOf("3");
            //Console.WriteLine("IndexString: " + num);

            str = str.Replace("2,3,", "");
            Console.WriteLine("ReplaceString:" + str);


            int num = str.Length;
            //str = str.Insert(71, ",6,7,8,9,10");
            Console.WriteLine("Lenght: " + num);
            str = str.Insert(num - 1, ",6,7,8,9,10");
            Console.WriteLine("InsertString: " + str);


        }


        static void RunExerciseSix()
        {
            int num1 = 5;
            int num2 = 8;

            Console.WriteLine("Please Enter a Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter a Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add Two Numbers");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("Subtract Two Numbers");
            Console.WriteLine(num1 - num2);


            if (num1 > num2)
            {
                Console.WriteLine("This number is biggest" + num1);
            }

            else
            {
                Console.WriteLine("This number is smallest" + num2);
            }

            Console.WriteLine("Multiply Two Numbers");
            Console.WriteLine(num1 * num2);

            Console.WriteLine("Divide Two Numbers");
            if (num2 == 0)
            {
                Console.WriteLine("Denominator is 0");
            }
            else
            {
                Console.WriteLine(num1 / num2);
            }


        }
        static void RunExerciseSeven()
        {
            double area = 0;
            double radius = 0;
            double pi = 3.14;
            double volume = 0;

            Console.Write("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = 2 * pi * radius * radius;
            volume = (4 * pi * radius * radius * radius) / 3;
            Console.WriteLine("Area= " + area);
            Console.WriteLine("Volume= " + volume);

        }
        static void RunExerciseEight()
        {
            double num = 0;
            double result = 0;

            Console.Write("Please Enter a Number: ");
            num = Convert.ToDouble(Console.ReadLine());

            result = Math.Pow(num, 2);
            Console.WriteLine("Square of " + num + "=" + result);

            result = Math.Pow(num, 10);
            Console.WriteLine("Power of Ten of " + num + "= " + result);

            result = Math.Pow(num, 0.5);
            Console.Write("Square root of " + num + "=" + result);



        }
        static void RunExerciseNine()

        {
            String userName = "Shreya";
            int birthYear = 0;
            int age = 0;

            Console.WriteLine("Please Enter Your Name:");
            Console.Write("Name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + " Welcome! and Now Please Enter Your Birth Year: ");
            birthYear = Convert.ToInt32(Console.ReadLine());
            age = DateTime.Now.Year - birthYear;
            Console.WriteLine(age);


            if (age >= 18)
            {
                String ifYes = "Your Order Has Been Done";
                String ifNo = "You Can Order a Coke";
                String usrChoice = "";
                Console.Write("Want To Order a Beer? (y/n):");
                usrChoice = Console.ReadLine();
                if (usrChoice == "y")
                {
                    Console.WriteLine(ifYes);
                }
                else
                {
                    Console.WriteLine(ifNo);

                }


            }


            else
            {
                String ifYes = "The Coke Has Been Served";
                String ifNo = "No Order Options Are Available";
                String usrChoice = "";
                Console.WriteLine("You Can Order a Coke");
                usrChoice = Console.ReadLine();

                if (usrChoice == "y")
                {
                    Console.WriteLine(ifYes);
                }

                else
                {
                    Console.WriteLine(ifNo);
                }



            }




        }

        static void RunExerciseTen()
        {
            int chooseAnOption = 0;
            Console.Write("Please Enter An Option: ");
            chooseAnOption = Convert.ToInt32(Console.ReadLine());

            switch (chooseAnOption)
            {
                case 1:
                    RunFirstOption();
                    break;

                case 2:
                    RunSecondOption();
                    break;

                    /*case 3:
                        RunThirdOption();
                            break;*/
            }

        }

        static void RunFirstOption()
        {

            int a = 0;
            int b = 0;
            int result = 0;
            Console.Write("Please Enter a Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter a Number: ");
            b = Convert.ToInt32(Console.ReadLine());


            if (b != 0)
            {
                result = a / b;
                Console.WriteLine(result);
            }

            else
            {
                Console.WriteLine("It Is An Error");
            }

        }

        static void RunSecondOption()
        {
            RunExerciseFour();
        }

        static void RunExerciseEleven()
        {
            int i = 1;
            int n = 10;
            Console.Write("Enter Number Comes After Zero: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(i);

            }
            Console.WriteLine("-------------------------------------");
            for (i = n; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(i);
            }

            Console.ForegroundColor = ConsoleColor.White;

        }

        static void RunExerciseTwelve()
        {
            int i = 0;
            int j = 0;

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");

                }
                Console.WriteLine();
            }
        }

        static void RunExerciseThirteen()
        {
            int randomNumber = 0;
            int usrNumber = 0;
            int counter = 1;

            randomNumber = RandomNumberGenerator.GetInt32(501);

            Console.Write("Guess a number between 1 and 500:");
            usrNumber = Convert.ToInt32(Console.ReadLine());

            while (usrNumber != randomNumber && usrNumber != -1)
            {
                if (usrNumber > randomNumber)
                {
                    Console.WriteLine("Your guess was too big");
                }
                else
                {
                    Console.WriteLine("Your guess was too small");
                }
                Console.Write("Guess a number again (Enter -1 to quit):");
                usrNumber = Convert.ToInt32(Console.ReadLine());
                counter++;

            }
            if (usrNumber != -1)
            {
                Console.WriteLine("It's a rigth guess. You made " + counter + " attempts");
            }
            else
            {
                Console.WriteLine("You Quit.LOOSER!. You made " + counter + " attempts");
            }

        }
        static void RunExerciseFourteen()
        {
            int usrInput = 0;
            int sum = 0;
            int counter = 1;
            int average = 0;

            Console.Write("Please Enter a Number : ");
            usrInput = Convert.ToInt32(Console.ReadLine());

            while (usrInput != -1)
            {
                sum = sum + usrInput;
                Console.Write("Please Enter a Number again (-1 to quit) : ");
                usrInput = Convert.ToInt32(Console.ReadLine());
                counter++;
            }

            Console.WriteLine("Sum= " + sum);
            average = sum / (counter - 1);
            Console.WriteLine("Average= " + average);

        }

        static void RunExerciseFifteen()
        {
            int i = 0;
            int n = 0;
            int sum = 0;
            Console.Write("Please Enter a Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = n - 1; i >= 1; i--)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;

                }

            }
            if (sum == n)
            {
                Console.WriteLine("This Number Is a Perfect Number");
            }
            else
            {
                Console.WriteLine("This Number Is Not a Perfect Number");
            }
        }

        static void RunExerciseSixteen()
        {
            int a = 0;
            int b = 1;
            int c = 0;

            int n = 0;
            int i = 0;

            Console.Write("Please enter the lenght of the Fibonacci series:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(a + "\t");
            Console.Write(b + "\t");
            for (i = 3; i <= n; i++)
            {
                c = a + b;
                Console.Write(c + "\t");
                a = b;
                b = c;
            }
        }

        static void RunExerciseSeventeen()
        {
            String usrText = "";
            String revText = "";
            int strLen = 0;
            int i = 0;

            Console.WriteLine("Please enter a String:");
            usrText = Console.ReadLine();

            usrText = usrText.Replace(" ", "");

            strLen = usrText.Length;

            for (i = strLen - 1; i >= 0; i--)
            {
                revText = revText + usrText[i];
            }


            //Console.WriteLine(usrText);
            //Console.WriteLine(revText);

            if (revText.CompareTo(usrText) == 0)
            {
                Console.WriteLine("This String is a PALINDROME!");
            }
            else
            {
                Console.WriteLine("This String is not a PALINDROME!");
            }

        }


    } //Program class ends here

}  //Namespace ends here  
