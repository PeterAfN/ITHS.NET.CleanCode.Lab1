using NUnit.Framework;
using System;

namespace Lab1.Tests.UnitTests.Mocking
{
    [TestFixture]
    public class FileDataReaderTests
    {
        private FileDataReader _fileDataReader = new FileDataReader();

        [SetUp]
        public void SetUp()
        {
            _fileDataReader = new FileDataReader();
        }

        [Test]
        public void GetString_GivenTextFile_ReturnFirstLineFromFile()
        {
            string expectedResult = "This is a sample text.";

            var calculatedResult = _fileDataReader.GetString();

            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetString_GivenNoFile_ReturnFileNotFoundException()
        {
            string filePathToNothing = "invalid filepath";

            Assert.Throws<NullReferenceException>(() => _fileDataReader.GetString(filePathToNothing));
        }

    }
}
