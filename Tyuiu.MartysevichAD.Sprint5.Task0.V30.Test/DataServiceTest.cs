using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MartysevichAD.Sprint5.Task0.V30.Lib;

namespace Tyuiu.MartysevichAD.Sprint5.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ridui\source\repos\Tyuiu.MartysevichAD.Sprint5\Tyuiu.MartysevichAD.Sprint5.Task0.V30\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists); 
        }
    }
}
