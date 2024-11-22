using FluentAssertions;
using FuncSprint;

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
    }
}