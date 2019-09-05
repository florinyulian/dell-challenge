using System.Collections.Generic;

namespace DellChallenge.C
{
    interface IMySum
    {
        int Sum(List<int> numbers);
        int SumN(int n1, int n2);
        int SumN(int n1, int n2, int n3);
    }
}