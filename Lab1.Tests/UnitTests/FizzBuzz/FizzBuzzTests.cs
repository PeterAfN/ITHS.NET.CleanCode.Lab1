using NUnit.Framework;

namespace Lab1
{
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzz _fizzBuzz = new FizzBuzz();

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void GenerateResult_Given100_ReturnListWith100Items()
        {
            int endNumberToTest = 100;

            var calculatedResult = _fizzBuzz.GenerateResult(endNumberToTest);

            Assert.That(calculatedResult.Count, Is.EqualTo(endNumberToTest));
        }

        [Test]
        public void GenerateResult_Given90_Return90thItemIsFizzBuzz()
        {
            int endNumberToTest = 90;

            var calculatedResult = _fizzBuzz.GenerateResult(endNumberToTest);

            Assert.That(calculatedResult[endNumberToTest - 1], Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GenerateResult_Given98_Return98thItemIs98()
        {
            int endNumberToTest = 98;

            var calculatedResult = _fizzBuzz.GenerateResult(endNumberToTest);

            Assert.That(calculatedResult[endNumberToTest - 1], Is.EqualTo("98"));
        }

        [Test]
        public void GenerateResult_Given99_Return99thItemIsFizz()
        {
            int endNumberToTest = 99;

            var calculatedResult = _fizzBuzz.GenerateResult(endNumberToTest);

            Assert.That(calculatedResult[endNumberToTest - 1], Is.EqualTo("Fizz"));
        }

        [Test]
        public void GenerateResult_Given100_Return100thItemIsBuzz()
        {
            int endNumberToTest = 100;

            var calculatedResult = _fizzBuzz.GenerateResult(endNumberToTest);

            Assert.That(calculatedResult[endNumberToTest - 1], Is.EqualTo("Buzz"));
        }

        [TestCase(1, false)]
        [TestCase(15, true)]
        public void IsThisFizzBuzz_GivenNumber_GivesCorrectResult(int numberToCheck, bool expectedResult) //Perhaps not needed since we test this method indirectly with the test GenerateResult***()
        {
            bool calculatedResult = _fizzBuzz.IsThisFizzBuzz(numberToCheck);

            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

        [TestCase(1, false)]
        [TestCase(3, true)]
        public void IsThisFizz_GivenNumber_GivesCorrectResult(int numberToCheck, bool expectedResult)     //Perhaps not needed since we test this method indirectly with the test GenerateResult***()
        {
            bool calculatedResult = _fizzBuzz.IsThisFizz(numberToCheck);

            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

        [TestCase(1, false)]
        [TestCase(5, true)]
        public void IsThisBuzz_GivenNumber_GivesCorrectResult(int numberToCheck, bool expectedResult)     //Perhaps not needed since we test this method indirectly with the test GenerateResult***()
        {
            bool calculatedResult = _fizzBuzz.IsThisBuzz(numberToCheck);

            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

    }
}