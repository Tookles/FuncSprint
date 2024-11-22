using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncSprint
{
    internal class Exercise002
    {
        public static Func<List<string>> GetCoolPeople = () => new List<string> {"rich.neat@boardgamer.com",
            "poppy.mcdonnell@irishdancer.com",
            "neil.hughes@walkingoncustard.com",
            "alice.yang@midfielder.com",
            "pippa.austin@musician.com"};

        public static Action<string> GetUsernames = str => Console.WriteLine(str.Substring(0, str.IndexOf('@')));

        public static Action<List<string>> PrintCoolPeoeple = li => li.ForEach(Console.WriteLine);

        public static Action<List<int>> SquaredNums = intList => intList.ForEach(x => x = x * x);
    
        public static Func<List<int>, List<int>> SquaredNumsReturn = intList => intList.Select(x => x = x * x).ToList();

        public static Action<List<int>> PrintNums = intList => intList.ForEach(Console.WriteLine);

        // with Function chained to action 
        public static Action<List<int>> PrintSquareNums = intList => PrintNums(SquaredNumsReturn(intList));

        // with action chained to action?? but does not change the intList?  
        public static Action<List<int>> PrintSquareNums2 = intList =>
        {
            SquaredNums(intList);
            PrintNums(intList);
        };
        


    }
}
