using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Average
    {
        public delegate double average2(string bunchANumbers);

        public average2 avg;
        public Average()
        {

        }
        public double AverageMinusAFew(string bunchANumbers)
        {
            int lonelyNumber;
            double averageNumber;
            List<int> numbers = new List<int>();



            while (bunchANumbers.IndexOf(",") > 0)
            {
                lonelyNumber = int.Parse(bunchANumbers.Substring(0, bunchANumbers.IndexOf(",")));

                numbers.Add(lonelyNumber);
                bunchANumbers = bunchANumbers.Substring(bunchANumbers.IndexOf(",") + 1, (bunchANumbers.Length - (bunchANumbers.IndexOf(",") + 1)));

            }

            numbers.Sort();
            var numbersMinusThree = numbers.Skip(3);
            averageNumber = numbersMinusThree.Average();
            return averageNumber;




        }
    }
}
