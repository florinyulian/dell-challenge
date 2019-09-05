using System.Collections.Generic;
using System.Linq;

namespace DellChallenge.C
{
    class MySum : IMySum
    {
        public int Sum(List<int> numbers)
        {
            return numbers.AsQueryable().Sum();
        }

        public int SumN(int n1, int n2)
        {
            return Sum(new List<int>() { n1, n2 });
        }
        public int SumN(int n1, int n2, int n3)
        {
            return Sum(new List<int>() { n1, n2, n3 });
        }
    }
}
