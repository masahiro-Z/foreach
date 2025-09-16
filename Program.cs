using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]  DayOfWeek = { "Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
            foreach (string Day in DayOfWeek)
            {
                Console.WriteLine(Day);
            }
        }
    }
}
