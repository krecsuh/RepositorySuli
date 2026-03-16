using System.Linq;


namespace Functions.Tests
{
    public class WordConversionTest
    {
        [Fact]
        public void VowelsReplacedCorrectly()
        {
            // Arrange
            var service = new FunctionService();

            // Act
            var result = service.WordConversion("alma");

            // Assert
            Assert.Equal(".lm.", result);
            Assert.Equal("h.ll.", service.WordConversion("hello"));
            Assert.Equal("T.k.rf.r.g.p", service.WordConversion("Tükörfúrógép"));
        }

    }   
}