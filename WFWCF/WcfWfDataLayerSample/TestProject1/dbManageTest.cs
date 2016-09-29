using WcfWfDataLayerSample.DB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for dbManageTest and is intended
    ///to contain all dbManageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class dbManageTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for checkIDinTabA
        ///</summary>
        [TestMethod()]
        public void checkIDinTabATest()
        {
            {
                string ID = "wxd"; //
                bool expected = true;
                bool actual;
                actual = dbManage.checkIDinTabA(ID);
                Assert.AreEqual(expected, actual);
            }

            {
                string ID = "lzm"; //
                bool expected = false;
                bool actual;
                actual = dbManage.checkIDinTabA(ID);
                Assert.AreEqual(expected, actual);
            }

        }

        /// <summary>
        ///A test for checkRowIDinTabB
        ///</summary>
        [TestMethod()]
        public void checkRowIDinTabBTest()
        {
            {
                string RowID = "1";
                bool expected = true;
                bool actual;
                actual = dbManage.checkRowIDinTabB(RowID);
                Assert.AreEqual(expected, actual);
            }

            {
                string RowID = "2";
                bool expected = false;
                bool actual;
                actual = dbManage.checkRowIDinTabB(RowID);
                Assert.AreEqual(expected, actual);
            }

        }

        /// <summary>
        ///A test for insertTabB
        ///</summary>
        [TestMethod()]
        public void insertTabBTest()
        {
            var RowID = System.Guid.NewGuid().ToString();
            TableB row = new TableB() { ID = "wxd", Value = System.Guid.NewGuid().ToString(), RowID = RowID };
            dbManage.insertTabB(row);
            bool actual;
            actual = dbManage.checkRowIDinTabB(RowID);
            Assert.AreEqual(true, actual);
        }
    }
}
