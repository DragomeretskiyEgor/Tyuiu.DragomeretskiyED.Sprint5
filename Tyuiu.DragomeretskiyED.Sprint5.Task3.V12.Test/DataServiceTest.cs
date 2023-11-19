using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.DragomeretskiyED.Sprint5.Task3.V12.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\Gogr-PC\source\repos\Tyuiu.DragomeretskiyED.Sprint5\Tyuiu.DragomeretskiyED.Sprint5.Task3.V12\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
