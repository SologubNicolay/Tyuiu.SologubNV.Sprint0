
using Tyuiu.SologubNV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.SologubNV.Sprint0.Task4.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckedAdditionValid()
        {
            Assert.Equal(10, DataService.Addition(5, 5));
        }
        [Fact]
        public void CheckedSubtractionValid()
        {
            Assert.Equal(5, DataService.Subtraction(10, 5));
        }
        [Fact]
        public void CheckedMultiplicationValid()
        {
            Assert.Equal(50, DataService.Multiplication(10, 5));
        }
        [Fact]
        public void CheckedDivisionValid()
        {
            Assert.Equal(3, DataService.Division(9, 3));
        }
    }
}