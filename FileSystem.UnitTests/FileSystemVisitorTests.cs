using FileSystem.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.IO;

namespace FileSystem.UnitTests
{
    [TestClass]
    public class FileSystemVisitorTests
    {
        [TestMethod]
        public void DirectoryFindedEvent_Executed_Tree_Times()
        {
            //Arrange 
            var testPath = @"C:\Users\George_Kaladze\Desktop\Task1-master";
            var mockDirectories = new string[]
                {
                       "testfolder", "testFolder1", "testfie.png"
                };
            var mockFileProvider = Substitute.For<IFileProvider>();
            mockFileProvider.GetFiles(Arg.Any<string>()).Returns(mockDirectories);
            mockFileProvider.DirectoryExists(Arg.Any<string>()).Returns(true);
            var sut = new FileSystemVisitor(mockFileProvider, testPath, (file) => file.Contains("t"));
            var fileCount = 0;
            sut.DirectoryFinded += (s, e) =>
            {
                fileCount++;
            };

            //Act
            sut.FindFiles();

            //
            Assert.AreEqual(mockDirectories.Length, fileCount);
        }

        [TestMethod]
        public void FileFindedEvent_Executed_Tree_Times()
        {
            //Arrange 
            var testPath = @"C:\Users\George_Kaladze\Desktop\Task1-master";
            var mockDirectories = new string[]
                {
                       "testfolder", "testFolder1", "testfie.png"
                };
            var mockFileProvider = Substitute.For<IFileProvider>();
            mockFileProvider.GetFiles(Arg.Any<string>()).Returns(mockDirectories);
            mockFileProvider.DirectoryExists(Arg.Any<string>()).Returns(false);
            var sut = new FileSystemVisitor(mockFileProvider, testPath, (file) => file.Contains("t"));
            var fileCount = 0;
            sut.FileFinded += (s, e) =>
            {
                fileCount++;
            };

            //Act
            sut.FindFiles();

            //
            Assert.AreEqual(mockDirectories.Length, fileCount);
        }


        [TestMethod]
        public void Check_Start_Event()
        {
            //Arrange 
            var testPath = @"C:\Users\George_Kaladze\Desktop\Task1-master";
            var mockDirectories = new string[]
                {
                       "testfolder", "testFolder1", "testfie.png"
                };
            var mockFileProvider = Substitute.For<IFileProvider>(); 
            var sut = new FileSystemVisitor(mockFileProvider, testPath, (file) => file.Contains("t"));

            bool started = false;
            sut.Start += (s, o) =>
            {
                started = true;
            }; 

             //Act
            sut.FindFiles();

            //
            Assert.IsTrue(started);
        }
    }
}