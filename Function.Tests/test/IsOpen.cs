using System;
using Xunit;             
using Functions;          

namespace Functions.Tests
{
    public class IsOpenTests
    {
        [Fact]
        public void IsOpenReturnTrue()
        {

            // Arrange
            var service = new FunctionService();

            // Act
            Assert.True(service.IsOpen(8)); 
            Assert.True(service.IsOpen(10)); 
            Assert.True(service.IsOpen(12)); 
            Assert.True(service.IsOpen(15));          
        }

        [Fact]
        public void IsNotOpenReturnFalse()
        {

            // Arrange
            var service = new FunctionService();

            // Act
            Assert.False(service.IsOpen(7));
            Assert.False(service.IsOpen(2));
            Assert.False(service.IsOpen(16));
            Assert.False(service.IsOpen(21));
        }
        [Fact]
        public void
    }
}
