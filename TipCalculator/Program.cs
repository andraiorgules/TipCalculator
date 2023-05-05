/* Andrada Iorgulescu
 * Tip Calculator with Casting and Exception Handling
 * October 4, 2021
 */

using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double billTotal = 0;

            double tipPercentage = 0;

            //TO DO: Add an explicit conversion to your tip calculator.
            int a;
            a = (int)tipPercentage;

            double tip = 0;


            GetBill();

            GetTip();

            //TO DO: Add exception handling to your tip calculator.
            try
            {
                tip = (billTotal / 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero not possible.");
            }
            finally
            {
                tip = billTotal * tipPercentage;
            }

            GetTotal();

            void GetBill()
            {
                Console.WriteLine("Please enter the cost of the bill:");

                billTotal = Convert.ToDouble(Console.ReadLine());
            }

            void GetTip()
            {
                Console.WriteLine("Please enter the tip percentage as a decimal (for example, 10% would be entered as .10):");

                tipPercentage = Convert.ToDouble(Console.ReadLine());

                
            }

            void GetTotal()
            {
                Console.WriteLine($"The {tipPercentage} tip for a {billTotal} bill is {tip}.");

                Console.ReadKey();
            }

        }
    }
}