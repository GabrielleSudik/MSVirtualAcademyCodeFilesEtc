using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyCodeFilesEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string myString = "Will this work? \\ ... Yes."; //or...
            string myString2 = @"Go to your C:\ drive.";

            Console.WriteLine(myString);
            Console.WriteLine(myString2);

            string myString3 = String.Format("{0} and {0} and {1}", "first", "second");

            Console.WriteLine(myString3);

            string myString4 = String.Format("{0:C}", 123.45); //does currency
            string myString5 = String.Format($"{ 123.45:C}");

            Console.WriteLine(myString4);
            Console.WriteLine(myString5);

            double paycheck = 321.45;
            string myString6 = String.Format($"{paycheck:C}.");
            Console.WriteLine(myString6);

            //double paycheck2 = Double.Format( 432.45:C); doesn't work

            string myString7 = string.Format($"Percentage: {.123:P}.");
            Console.WriteLine(myString7);

            //a custom format:

            string phoneNumber = string.Format("Phone number: {0: (###) ###-####}.", 2169166996);
            string phoneNumber2 = string.Format($"Phone number: {2169166996: (###) ###-####}.");
            Console.WriteLine(phoneNumber);
            Console.WriteLine(phoneNumber2);

            //playing with strings:

            string myString8 = "  Gabrielle Sudik  ";

            myString8 = myString8.Substring(6);
            Console.WriteLine(myString8);
            myString8 = myString8.Replace('e', 'o');
            Console.WriteLine(myString8);

            //others: .ToUpper, .Substring(#, #), .Remove, .Trim, .Length

            //here's an exercise in adding stuff to the string.
            //we start with an empty string
            //then keep adding -- and a new integer, 100 times

            string myString9 = "";

            for (int i = 0; i < 100; i++)
            {
                myString9 += "--" + i.ToString();
            }

            Console.WriteLine(myString9);

            //stringbuilder!

            StringBuilder myString10 = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString10.Append("--");
                myString10.Append(i);
            }

            Console.WriteLine(myString10);

            //the stringbuilder did the same thing as up above, but maybe tidier.
            //it's probably good for really complicated built strings

            Console.ReadLine();
        }
    }
}
