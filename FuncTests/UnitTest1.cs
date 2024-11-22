using FluentAssertions;
using FuncSprint;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace FuncTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SquareItTest()
        {
            int input = 3;
            int expected = 9;

            int result = Exercise001.Square(input);

            result.Should().Be(expected);
        }

        [Test]
        public void AddTenTest()
        {
            int input = 10;
            int expected = 20;

            int result = Exercise001.AddTen(input);

            result.Should().Be(expected);
        }

        [Test]
        public void GrammarCheckTest()
        {
            string input = "Amazing!";
            
            bool result = Exercise001.GrammarCheck(input);
            result.Should().BeTrue();
        }

        [Test]
        public void EmailCheckTest()
        {
            string input = "nick@northcoders.co.uk";

            EmailCheck.CheckValidEmail(input).Should().Be("Email domain and user name invalid, please check your input");
        }

        [Test]
        public void GetEmailList_ShouldReturnCorrectEmails()
        {
            var input = new List<string>
            {
                "alice.yang@northcoders.com",
                "richard.neat@northcoders.com",
                "mario@plumbing.it",
                "link@hyrule.co.uk",
                "shrek@duloc.com",
                "neil.hughes@walkingoncustard.com",
                "csharp@microsoft.cs",
                "ziggy@spidersfrommars.co.uk",
                "lemmy@motorhead.co,uk",
                "me@myhouse.sleep"
            };
            Dictionary<string, List<string>> emailList = Exercise002.FilterEmails(input);

            emailList[".com"].Should().BeEquivalentTo(new List<string>
            {
                "alice.yang@northcoders.com",
                "richard.neat@northcoders.com",
                "shrek@duloc.com",
                "neil.hughes@walkingoncustard.com"
            });
        }



        [Test]
        public void SquaredNumsTest()
        {
            List<int> inputList = [1, 2, 3];

            Exercise002.SquaredNums(inputList);

            inputList.Should().BeEquivalentTo(new List<int>() { 1, 4, 9 }); 
            
        }

        [Test]
        public void IndexError() 
         {
            
            var input = new List<string>
            {
                "a.cm",
                "richard.neat@northcoders.com",
                "mario@plumbing.it",
            };

            Action testThrow = () => Exercise002.FilterEmails(input); 

            testThrow.Should().Throw<ArgumentOutOfRangeException>();


        }


    }

}