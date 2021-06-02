using Microsoft.VisualStudio.TestTools.UnitTesting;
using my_Dog_Race_assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Dog_Race_assignment.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            RunnerDog runner = new RunnerDog();
            if (runner.move_Dog() > 10)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            RunnerDog runner = new RunnerDog();
            if (runner.resultSetup("Parvesh selected 1 with the amount 20",1,100)==120)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}