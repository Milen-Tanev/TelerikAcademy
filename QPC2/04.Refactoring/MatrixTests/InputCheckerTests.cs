namespace MatrixTests
{
    using System;
    using NUnit.Framework;
    using RotatingWalkInMatrix;

    [TestFixture]
    class InputCheckerTests
    {
        InputChecker checker = new InputChecker();

        [TestCase("1")]
        [TestCase("50")]
        [TestCase("100")]
        public void CheckIfNumberTestShouldBeEqual(string input)
        {
            var checkedInput = checker.CheckInput(input);

            Assert.AreEqual(int.Parse(input), checkedInput);
        }

        [Test]
        public void CheckIfNumberTestNotNumberGivenShouldThrowArgumentExceptionWithSpecificMessage()
        {
            Assert.That(() => checker.CheckInput("t"),
                Throws.TypeOf<ArgumentException>()
                 .With.Message.EqualTo("You haven't entered a positive number!"));
        }

        [TestCase("-1")]
        [TestCase("111")]
        public void CheckIfNumberTestUnexpectedNumberGivenShouldThrowArgumentOutOfRangeException(string input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => checker.CheckInput(input));
        }
    }
}
