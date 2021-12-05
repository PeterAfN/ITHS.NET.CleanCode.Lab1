using Lab1b;
using Moq;
using NUnit.Framework;


namespace Lab1.Tests.UnitTests.Mocking
{
    public class ReadFileReverseItTests
    {
        private Mock<IGetStringReader> _GetStringReaderMock = new();

        [SetUp]
        public void SetUp()
        {
            _GetStringReaderMock = new Mock<IGetStringReader>();
        }

        [Test]
        public void Start_GivenMockTextFileWithTextContent_ReturnFileContentReversed()
        {
            // Act
            string fileContentText = "This is a sample text.";
            string expectedResult = ".txet elpmas a si sihT";

            _GetStringReaderMock.Setup(g => g.GetString(string.Empty)).Returns(fileContentText);
            ReadFileReverseIt readFileReverseIt = new(_GetStringReaderMock.Object);

            // Arrange
            string calculatedResult = readFileReverseIt.Start();

            // Assert
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

    }
}
