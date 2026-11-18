using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class ComparingServices : IComparingServices
    {

        public string Comparison(int numOne, int numTwo)
        {
            string comparison = "";
            if (numOne > numTwo)
            {
                comparison = $"{numOne} is greater than {numTwo}";
            }
            else if (numOne < numTwo)
            {
                comparison = $"{numOne} is lesser than {numTwo}";
            }
            else
            {
                comparison = $"{numOne} is equal to {numTwo}";
            }
            return comparison;
        }
    }
}