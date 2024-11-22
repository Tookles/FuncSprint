using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncSprint
{
    internal class Exercise001
    {
        public static Func<int, int> AddOne = num => num + 1;

        public static Func<int, int> Square = num => num * num;

        public static Func<int, int> AddTen = num => num + 10;

        public static Predicate<string> GrammarCheck = str => str[0] == 'A' && str[^1] == '!'; 
    }
}
