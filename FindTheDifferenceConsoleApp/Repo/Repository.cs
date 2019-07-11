using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDifferenceConsoleApp.Repo
{
    class Repository
    {
        public int FindDifference(int totalNumber, int firstNumber)
        {
            int difNumber = totalNumber - firstNumber;

            return difNumber;
        }
    }
}
