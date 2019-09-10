using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void emptyTest()
        {
            try {
                Form1 obj = new Form1();
                obj.empty();

            }
            catch (Exception e) {
                Assert.Fail();
            }
            
        }




    }
}