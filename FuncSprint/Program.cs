namespace FuncSprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };

            //List<int> returnList = numbers.Select(x => Exercise001.AddTen(x)).ToList();

            //returnList.ForEach(Console.WriteLine);

            //numbers.Select(x => Exercise001.AddTen(x)).ToList().ForEach(Console.WriteLine);

            //List<string> words = new List<string>
            //{
            //    "Amazing!",
            //    "apple!",
            //    "Awesome!",
            //    "Artichoke"
            //}; 

            //words.Select(x => Exercise001.GrammarCheck(x)).ToList().ForEach(Console.WriteLine);

            //Console.WriteLine(Exercise001.SumIndices("start", "pale"));

            //Console.WriteLine(EmailCheck.CheckValidEmail("rachel@northcoders.co.uk"));

            //List<string> testList = Exercise002.GetCoolPeople(); 

            //Exercise002.PrintCoolPeoeple(testList);

            List<int> myInts = new List<int>() { 1, 2, 3 };

            //Exercise002.PrintSquareNums(myInts);

            Exercise002.PrintSquareNums2(myInts);

            //foreach (int i in myInts)
            //{
            //    Console.WriteLine(i);
            //} 

        }
    }
}
