
using Inder_VideoRental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inder_VideoRental.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            try {
                Form1 obj = new Form1();
                obj.empty();
            }
            catch (Exception e) {
                Assert.Fail();
            }


        }

        [TestMethod()]
        public void emptyTest()
        {
            Assert.Fail();
        }
    }
}