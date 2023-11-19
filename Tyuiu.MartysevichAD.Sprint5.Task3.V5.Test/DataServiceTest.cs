﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint5.Task3.V5.Lib;
using System.IO;

namespace Tyuiu.MartysevichAD.Sprint5.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ridui\source\repos\Tyuiu.MartysevichAD.Sprint5\Tyuiu.MartysevichAD.Sprint5.Task3.V5\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
