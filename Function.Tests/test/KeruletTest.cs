using System;
using Xunit;             
using Functions;          

namespace Functions.Tests
{
    public class LongerTest
    {
        [Fact]
        public void IsValidGrade_WithValidGrade_ReturnsTrue()
        {
            var service = new FunctionService();
            var result = service.IsValidGrade(3);

            Assert.True(result);
        }


        [Fact]
        public void IsValidGrade_WithGradeAboveFive_ReturnsFalse()
        {
            var service = new FunctionService();
            var result = service.IsValidGrade(6);

            Assert.False(result);
        }
    }
}
