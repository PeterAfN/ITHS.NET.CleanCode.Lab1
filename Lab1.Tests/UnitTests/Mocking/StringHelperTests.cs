using Lab1b;
using NUnit.Framework;

namespace Lab1.Tests.UnitTests.Mocking
{
    [TestFixture]
    public class StringHelperTests
    {
        private StringHelper _stringHelper = new();

        [SetUp]
        public void SetUp()
        {
            _stringHelper = new StringHelper();
        }

        [Test]
        public void Reverse_GivenString_ReturnReversedString()
        {
            string testText = "This is a sample text.";
            string expectedResult = ".txet elpmas a si sihT";

            var calculatedResult = _stringHelper.Reverse(testText);

            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Reverse_GivenEmptyString_ReturnEmptyString()
        {
            string testText = string.Empty;
            string expectedResult = string.Empty;

            var calculatedResult = _stringHelper.Reverse(testText);

            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

    }
}
