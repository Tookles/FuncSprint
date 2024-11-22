using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncSprint
{
    internal class ListSumCalculator<T>
    {
        public List<T> ListToSum { get; set; }
        public ListSumCalculator(List<T> list)
        {
            ListToSum = list;
        }

        public int SumBy(Func<T, int> func)
        {
            return ListToSum.Sum(func);
        }
    }
}
