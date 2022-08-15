using NUnit.Framework;
using CodingTaskLibrary;

namespace CodingTaskTest
{
    public class ValidatorTest
    {
        

        [Test]
        public void WhenBracketsIsBalance_ReturnTrue()
        {
            // Arrange
            string myInput = "1{2asd(asd[asd]123m)asd}";

            // Act
            bool result = Validator.IsBalance(myInput);
            
            // Assert

            Assert.AreEqual(true, result);
        }

        [Test]
        public void WhenBracketIsNotBalance_ReturnFalse() {
            string myInput = "}123{123213[123adda(asdad)q123]}";
            
            bool result = Validator.IsBalance(myInput);
            
            Assert.AreEqual(false, result);
        }

        [Test]
        public void WhenNotBracketsInString_ReturnFalse()
        {
            string myInput = "MyInputDoesHaveString";

            bool result = Validator.ContainBrakets(myInput);

            Assert.AreEqual(result, false);
        }

        [Test]
        public void WhenBracketsInString_ReturnTrue()
        {
            string myInput = "MyInput{DoesHaveString";

            bool result = Validator.ContainBrakets(myInput);

            Assert.AreEqual(result, true);
        }
    }
}