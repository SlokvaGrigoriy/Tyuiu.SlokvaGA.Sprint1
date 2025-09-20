using Tyuiu.SlokvaGA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.SlokvaGA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double wait = 113.04;
            var res = ds.CylinderVolume(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
