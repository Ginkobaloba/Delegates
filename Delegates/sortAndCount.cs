using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class sortAndCount
    { 
            public delegate string sortAndCount2(string TobeSorted);
    
            public sortAndCount2 SNC;
            public sortAndCount()
            {

            }
        public string Sort(string toBeSorted)
        {
            string finished = "";
            var chararray = toBeSorted.ToLower().OrderBy(c => c).GroupBy(c => c).Select(g => new { Letter = g.Key, Count = g.Count() });
            foreach (var item in chararray)
            {
                finished = finished + item.Letter.ToString() + item.Count;

            }
            return finished;
        }
        }
    }



