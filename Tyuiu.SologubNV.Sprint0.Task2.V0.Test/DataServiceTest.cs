using Tyuiu.SologubNV.Sprint0.Task2.V0.Lib; 
namespace Tyuiu.SologubNV.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMessageValid()
        {
            var name = "Николай";
            var res = DataService.GetMessage(name);
            Assert.Equal("Привет..., Николай", res);
        }
    }
}