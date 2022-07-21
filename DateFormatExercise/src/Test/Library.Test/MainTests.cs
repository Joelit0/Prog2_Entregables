using NUnit.Framework;

namespace DateFormat.Tests
{
    [TestFixture]
    public class DateFormatTests
    {
        [Test]
        public void TestGoodDate1()
        {
            string dateInput = "17/03/2003";
            string formatedDate = Program.ChangeFormat(dateInput);
            Assert.AreEqual("2003-03-17", formatedDate);
        }

        [Test]
        public void TestGoodDate2()
        {
            string dateInput = "05/12/2001";
            string formatedDate = Program.ChangeFormat(dateInput);
            Assert.AreEqual("2001-12-05", formatedDate);
        }

        [Test]
        public void TestWrongDate1()
        {
            string dateInput = "28/01/1998";
            string formatedDate = Program.ChangeFormat(dateInput);
            Assert.AreNotEqual("XXXXXXXX", formatedDate);
        }
        
        [Test]
        public void TestWrongDate2()
        {
            string dateInput = "01/10/1420";
            string formatedDate = Program.ChangeFormat(dateInput);
            Assert.AreNotEqual("XXXXXXXX", formatedDate);
        }

        [Test]
        public void TestWrongDate3()
        {
            string dateInput = "2022-03-14";
            string formatedDate = Program.ChangeFormat(dateInput);
            Assert.AreNotEqual("14/03/2022", formatedDate);
        }

        [Test]
        public void Test2GoodDate1()
        {
            string dateInput = "17/03/2003";
            string formatedDate = Program.ChangeFormat2(dateInput);
            Assert.AreEqual("17-03-2003", formatedDate);
        }

        [Test]
        public void Test2GoodDate2()
        {
            string dateInput = "05/12/2001";
            string formatedDate = Program.ChangeFormat2(dateInput);
            Assert.AreEqual("05-12-2001", formatedDate);
        }

        [Test]
        public void Test2WrongDate1()
        {
            string dateInput = "28/01/1998";
            string formatedDate = Program.ChangeFormat2(dateInput);
            Assert.AreNotEqual("XXXXXXXX", formatedDate);
        }
        
        [Test]
        public void Test2WrongDate2()
        {
            string dateInput = "01/10/1420";
            string formatedDate = Program.ChangeFormat2(dateInput);
            Assert.AreNotEqual("XXXXXXXX", formatedDate);
        }

        [Test]
        public void Test2WrongDate3()
        {
            string dateInput = "2022-03-14";
            string formatedDate = Program.ChangeFormat2(dateInput);
            Assert.AreNotEqual("14-03-2022", formatedDate);
        }
    }
}
