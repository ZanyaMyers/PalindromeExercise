using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("level", true)]
        [InlineData("noon", true)]
        public void Test1(string response, bool expected)
        {
            //Arrange
            var smith = new WordSmith(); 
            
            //Act
            var actual = smith.IsAPalindrome(response);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
