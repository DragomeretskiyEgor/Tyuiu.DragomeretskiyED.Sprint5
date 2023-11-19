using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.DragomeretskiyED.Sprint5.Task0.V3.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint5.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\Gogr-PC\source\repos\Tyuiu.DragomeretskiyED.Sprint5\Tyuiu.DragomeretskiyED.Sprint5.Task0.V3\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}
