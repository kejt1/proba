using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void partitionTest()
        {
            int[] t = { 5, 10, 4 };
            Program.partition(t, 0, 2);
            Assert.AreEqual(t[0],4);
        }
        [TestMethod()]
        public void sortTest()
        {
            int[] t = { 5, 10, 4, 2, 15, 11};
            Program.sort(t, 0, 5);
            int[] wlasciwa = { 2, 4, 5, 10, 11, 15 };
            for(int i = 0; i < 6; i++)
            {
                Assert.AreEqual(t[0], wlasciwa[0]);
            }
            
        }
    }
}