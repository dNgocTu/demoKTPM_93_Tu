using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_93_Tu;
namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation_93_Tu c;

        public TestContext TestContext { get; set; }
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            c = new Calculation_93_Tu(10, 5);
        }
      [TestMethod] //TC1: a =10, b = 5, kq= 15
        public void Test_Cong()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        // sv thực hiện tiếp cho các TC tiếp theo……
        [TestMethod]//TC2: a =10, b = 5, kq= 5
        public void Test_Tru()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//TC3: a =10, b = 5, kq= 50
        public void Test_Nhan()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//TC4: a =10, b = 5, kq=2 
        public void Test_Chia()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//TC2: a =10, b = 5, kq= 5
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c = new Calculation_93_Tu(10, 0);
            c.Execute("/");
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            @".\Data\TestData_93_Tu.csv", "TestData_93_Tu#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource_ReadOperator()
        {
            int a, b, expected, actual;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            
            c = new Calculation_93_Tu(a, b);
            actual = c.Execute(operation);
            Assert.AreEqual(expected, actual);
        }

    }
}