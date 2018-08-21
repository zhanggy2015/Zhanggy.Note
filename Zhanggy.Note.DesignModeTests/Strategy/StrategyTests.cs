using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zhanggy.Note.DesignMode.Strategy.Tests
{
    [TestClass()]
    public class StrategyTests
    {
        /// <summary>
        /// 策略模式 /ˈstrætədʒɪ/ 
        /// </summary>
        [TestMethod()]
        public void mainTest()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
        }
    }
}