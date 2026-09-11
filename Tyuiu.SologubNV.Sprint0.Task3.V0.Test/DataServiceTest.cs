using Tyuiu.SologubNV.Sprint0.Task3.V0.Lib;

namespace Tyuiu.SologubNV.Sprint0.Task3.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckedValid()
        {
            Assert.Equal(10, DataService.Sum(5, 5));
        }
    }
}