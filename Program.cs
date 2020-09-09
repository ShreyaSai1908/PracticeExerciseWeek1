using System;
using System.Text;
using System.Xml.Serialization;

namespace PracticeExerciseWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chooseExerciseNo = 0;
            Console.Write("Please enter a valid exercise number (1 -26 ):");
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

               
            }



        }

        static void RunExerciseOne()
        {
            String firstName = "Default First Name";
            String lastName = "Default Last Name";

            Console.Write("Please enter First Name:");
            firstName = Console.ReadLine();
            Console.Write("Please enter Last Name:");
            lastName = Console.ReadLine();

            Console.Write("Hello " + firstName + " " + lastName + "! I'm glad to inform you that you are the test subject of my first assignment ");


        }

        static void RunExerciseTwo()
        {

            DateTime today = DateTime.Today;
            Console.WriteLine("Today's date is "+ today);

            DateTime tomorrow = DateTime.Today.AddDays(-1);
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
           /* string engText = "I am Arijeet";
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
            string result = "";


            // The brown fox jumped over the lazy dog
            /*Console.WriteLine("Original String: " + str);
            result = str.Substring(4);
            Console.WriteLine("SubString" + result);
           */

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
            str = str.Insert(num-1, ",6,7,8,9,10");
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





    
    }
}    
