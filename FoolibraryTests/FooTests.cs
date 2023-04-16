using FooClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace FoolibraryTests
{
    [TestClass]
    public class FooTests
    {
        [TestMethod]
        public void Newinstanceoftheclasstest()
        {
            Foo foo = new Foo();
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Nameisnulltest()
        { 
            Foo foo = new Foo();

            foo.Name = null;
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Nameonlyhaschartest()
        {
            Foo foo = new Foo();
            string answer = foo.Name = "Cat++";

        }
        [TestMethod]
        public void Nametestsetvalue()
        {
            Foo foo = new Foo();

            string answer = foo.Name = "Cat";
            Assert.AreEqual("Cat", answer);
        }
        [TestMethod]
        public void GetNametest()
        {
            Foo foo = new Foo();

            string name = foo.Name;
        }
        [TestMethod]
        public void GetValuetest()
        {
            Foo foo = new Foo();

            int value = foo.Value;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetValuetest()
        {
            Foo foo = new Foo();

            int answer = foo.Value = -1;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetValuetest2()
        {
            Foo foo = new Foo();

            int answer = foo.Value = 200;
        }
        [TestMethod]
        public void SetValuetest3()
        {
            Foo foo = new Foo();

            int answer = foo.Value = 0;
            Assert.AreEqual(0, answer);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Foomethodtest1()
        {
            Foo foo = new Foo(null,0);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Foomethodtest2()
        {
            Foo foo = new Foo("cat#", 0);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Foomethodtest3()
        {
            Foo foo = new Foo("cat", -1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Foomethodtest4()
        {
            Foo foo = new Foo("cat", 200);
        }
        [TestMethod]
        public void Foomethodtest5()
        {
            Foo foo = new Foo("cat", 2);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Foofootest()
        {
            Foo foo = new Foo(null);
        }
        [TestMethod]
        public void Foofootest2()
        {
            Foo foo = new Foo("Kira",2);
            Foo foo1 = new Foo(foo);
            Assert.AreEqual("Kira", foo1.Name);
            Assert.AreEqual(2, foo1.Value);
        }
        [TestMethod]
        public void Parsetest1()
        {
            string nameValueString = "sam,99";
            Foo foo = new Foo("sam",99);
            Foo foo1 = Foo.Parse(nameValueString);
            Assert.AreEqual(foo.Name,foo1.Name);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Parsetest2()
        {
            string nameValueString = "sa";
            Foo foo = new Foo("sa", 99);
            Foo foo1 = Foo.Parse(nameValueString);
            
        }
        [TestMethod]
        public void Assigntest1()
        {
            Foo foo = new Foo();
            foo.AssignTrimmedValue(-1);
            
        }
        [TestMethod]
        public void Assigntest2()
        {
            Foo foo = new Foo();
           foo.AssignTrimmedValue(101);
        }
        [TestMethod]
        public void Assigntest3()
        {
            Foo foo = new Foo();
            foo.AssignTrimmedValue(100);
        }


    }
}
