using System;

namespace GCBonusLab2
{
    class Program
    {
        //Task: ​Calculate the age of a person 

        static void Main(string[] args)
        {

            Console.WriteLine("What Is your birth year?");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What Is your birth Month?");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What Is your birth day?");
            int day = Convert.ToInt32(Console.ReadLine());

            var birthDate = new DateTime(year, month, day);
            var today = DateTime.Today;
            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (birthDate.Year * 100 + birthDate.Month) * 100 + birthDate.Day;
            int Years = new DateTime(DateTime.Now.Subtract(birthDate).Ticks).Year - 1;
            var sMonth = today.Month;
            var sDay = today.Day;
        


            DateTime PastYearDate = birthDate.AddYears(Years);
            int Months = 0;
           
            int Days = today.Subtract(PastYearDate.AddMonths(Months)).Days;
                

            while  (Days==0)
            {
                Console.WriteLine("HAPPY BIRTHDAY");
                Console.WriteLine("Age: {0} Year(s) {1} Day(s)", Years, Days);
                Console.ReadLine();
                break;

            }

            if (Days!=0)
            {
                Console.WriteLine("Age: {0} Year(s) {1} Day(s)", Years, Days);
                Console.ReadLine();
            }
        }
        }
    }
/*
 * Task: Calculate the age of a person!
What will the application do?
● Ask the user to enter their birthday. You can ask the user to enter the year,
month, then day, then store it in a DateTime variable.
● Calculate the Age of the user (Show the output in years and days).
Extra Challenges:
● If the current day is the user’s birthday, print a nice message!
*/


               



    

