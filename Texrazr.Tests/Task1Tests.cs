using Microsoft.VisualStudio.TestTools.UnitTesting; // импортируем методы для тестирования
using FirstApp; // импортируем код нашей программы
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests 
    {
        [TestMethod()]
        public void Max_432_Test()
        {
            var num = 432;
            var result = Logic.Max(num);
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void Max_199_Test()
        {
            var num = 199;
            var result = Logic.Max(num);
            Assert.AreEqual(9, result);
        }

        [TestMethod()]
        public void Max_100_Test()
        {
            var num = 100;
            var result = Logic.Max(num);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void Max_999_Test()
        {
            var num = 999;
            var result = Logic.Max(num);
            Assert.AreEqual(9, result);
        }

        [TestMethod()]
        public void Max_478_Test()
        {
            var num = 478;
            var result = Logic.Max(num);
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void Max_711_Test()
        {
            var num = 711;
            var result = Logic.Max(num);
            Assert.AreEqual(7, result);
        }

        [TestMethod()]
        public void Max_505_Test()
        {
            var num = 505;
            var result = Logic.Max(num);
            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void Max_111_Test()
        {
            var num = 111;
            var result = Logic.Max(num);
            Assert.AreEqual(1, result);
        }
    }
}
