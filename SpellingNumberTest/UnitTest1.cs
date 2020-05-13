using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpellingNumber;

namespace SpellingNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Millions()
        {
            //Arrange 
            int number = 1345678;

            //Act
            String NumberString = Program.NumberToWords(number);

            //Assert
            Assert.AreEqual("one million three hundred and forty-five thousand six hundred and seventy-eight", "one million three hundred and forty-five thousand six hundred and seventy-eight");

        }

        [TestMethod]
        public void Thousands()
        {
            //Arrange 
            int number = 13678;

            //Act
            String NumberString = Program.NumberToWords(number);

            //Assert
            Assert.AreEqual("thirteen thousand six hundred and seventy-eight", "thirteen thousand six hundred and seventy-eight");

        }

        [TestMethod]
        public void Hundreds()
        {
            //Arrange 
            int number = 136;

            //Act
            String NumberString = Program.NumberToWords(number);

            //Assert
            Assert.AreEqual("one hundred and thirty-six", "one hundred and thirty-six");

        }

        [TestMethod]
        public void Tens()
        {
            //Arrange 
            int number = 13;

            //Act
            String NumberString = Program.NumberToWords(number);

            //Assert
            Assert.AreEqual("thirteen", "thirteen");

        }

        [TestMethod]
        public void Singles()
        {
            //Arrange 
            int number = 3;

            //Act
            String NumberString = Program.NumberToWords(number);

            //Assert
            Assert.AreEqual("three", "three");

        }

        [TestMethod]
        public void Zero()
        {
            //Arrange 
            int number = 0;

            //Act
            String NumberString = Program.NumberToWords(number);

            //Assert
            Assert.AreEqual("zero", "zero");

        }
    }
}
