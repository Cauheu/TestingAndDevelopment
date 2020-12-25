using NUnit.Framework;
using System.IO;
using System;

namespace webApi
{
    public class Tests
    {
        /*
        [SetUp]
        public void Setup()
        {
        }
        */
        [Test]
        public void TestMethod_Upload()
        {
            DropBox_App pr = new DropBox_App(); // Creating a class Object  
            pr.UploadAFile("local_file.txt");
        }
        [Test]
        public void TestMethod_GetMetadata()
        {
            DropBox_App pr = new DropBox_App(); // Creating a class Object  
            pr.GetFileMetadata();
        }
        [Test]
        public void TestMethod_Delete()
        {
            DropBox_App pr = new DropBox_App(); // Creating a class Object  
            pr.DeleteFile();
        }
    }
}