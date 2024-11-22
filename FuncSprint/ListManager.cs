using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncSprint
{
    internal class ListManager
    {
        public List<string> InputList;

        public Predicate<string> HasLength = str => str.Length > 4; 

        public ListManager(List<string> inputList) {
            InputList = inputList;
        }

        public List<string> FilterMethod()
        {
            List<string> Filtered = InputList.Where(str => HasLength(str)).ToList();
            return Filtered; 
        }
    }
}
