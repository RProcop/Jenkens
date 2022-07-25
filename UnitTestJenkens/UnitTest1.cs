using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTestJenkens
{
    [TestClass]
    public class UnitTest1
    {
        private readonly string expected = "Hello Jenkens";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                JenkensTest.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }

    }
}
