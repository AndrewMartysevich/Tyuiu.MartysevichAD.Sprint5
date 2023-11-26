using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MartysevichAD.Sprint5.Task6.V15.Lib;

namespace Tyuiu.MartysevichAD.Sprint5.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V15.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V15.txt";
            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
