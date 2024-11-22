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

        public static Action<List<int>> SquaredNums = intList =>
        {
            for (int i = 0; i < intList.Count; i++)
            {
                intList[i] = intList[i] * intList[i];
            }
        };
    
        public static Func<List<int>, List<int>> SquaredNumsReturn = intList => intList.Select(x => x = x * x).ToList();

        public static Action<List<int>> PrintNums = intList => intList.ForEach(x => Console.WriteLine(x));

        // with Function chained to action 
        public static Action<List<int>> PrintSquareNums = intList => PrintNums(SquaredNumsReturn(intList));

        // with action chained to action?? but does not change the intList?  
        public static Action<List<int>> PrintSquareNums2 = (list) => { SquaredNums(list); PrintNums(list); };

        public static Dictionary<string, List<string>> FilterEmails(List<string> emails)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            List<string> list1 = emails.Where(x => x.Substring(x.Length - 6) == ".co.uk").ToList();
            result.Add(".co.uk", list1);

            List<string> list2 = emails.Where(x => x.Substring(x.Length - 4) == ".com").ToList();
            result.Add(".com", list2);

            List<string> list3 = emails.Where(x => x.Substring(x.Length - 4) != ".com" && x.Substring(x.Length - 6) != ".co.uk").ToList();
            result.Add("invalid", list3);

            return result;
        }


    }
}
