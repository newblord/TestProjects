using NUnit.Framework;
using Infrastructure.Model;
using System.Reflection.Metadata.Ecma335;
using System;
using NUnit.Framework.Internal;
using NUnit.Framework.Interfaces;

namespace Infrastructure.UnitTest
{
    enum TestEnum
    {
        None = 0,
        One = 1
    }

    class TestClass : BaseModel
    {
        private int id;
        private bool areYouSure;
        private string name;
        private DateTime date;
        private TestEnum testEnum;
        private ChildClass child;

        public int ID { get => id; set { id = value; OnPropertyChange(value);  } }

        public bool AreYouSure { get => areYouSure; set { areYouSure = value; OnPropertyChange(value); } }

        public string Name { get => name; set { name = value; OnPropertyChange(value); } }

        public DateTime Date { get => date; set { date = value; OnPropertyChange(value); } }

        public TestEnum TestEnum  { get => testEnum; set { testEnum = value; OnPropertyChange(value); } }

        public ChildClass Child { get => child; set { child = value; OnPropertyChange(value); } }
    }

    class ChildClass : BaseModel
    {
        private string name;

        public string Name { get => name; set { name = value; OnPropertyChange(value); } }
    }

    public class BaseModelTest
    {
        private TestClass TestClass = new TestClass();

        [SetUp]
        public void Setup()
        {
            TestClass.ID = 1;
            TestClass.AreYouSure = false;
            TestClass.Name = "TestClass";
            TestClass.Date = DateTime.Now;
            TestClass.TestEnum = TestEnum.None;
            TestClass.Child = new ChildClass();
        }

        [Test]
        public void TestOriginalValues()
        {
            TestClass.AcceptChanges();

            Assert.AreEqual(5, TestClass.OriginalValues.Keys.Count);
        }

        [Test]
        public void TestModifiedValues()
        {
            TestClass.Date = DateTime.Now;

            TestClass.Child.Name = "Test";

            TestClass.Child.Name = "Test1";

            TestClass.RejectChanges();

            Assert.AreEqual(1, TestClass.ModifiedValues.Keys.Count);
        }
    }
}