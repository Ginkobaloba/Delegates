using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            Average average = new Average();
            string numberstobepassed = "5,3,2,1,41,213,54,21,31,43,77,65,42,324,6,42,3434,42342423,234";
            average.avg = (string x) => { return average.AverageMinusAFew(x); };
            Console.WriteLine(average.avg(numberstobepassed));
            Console.ReadLine();

            sortAndCount sortandcount = new sortAndCount();
            string nametobepassed = "thisisthestatmenttobedissectedcountedsortedandreturned";
            sortandcount.SNC = (string x) => { return sortandcount.Sort(x); };
            Console.WriteLine(sortandcount.SNC(nametobepassed));
            Console.ReadLine();


        }

    }
    }       
    

