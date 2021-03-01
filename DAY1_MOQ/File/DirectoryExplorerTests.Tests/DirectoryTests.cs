using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using MagicFilesLi;

namespace DirectoryExplorerTests.Tests
{
   
    [TestFixture]
    public class DirectoryTests
    {
        Mock<IDirectoryExplorer> mockDirectoryExplorer = new Mock<IDirectoryExplorer>();
  

        private readonly string _file1 = "file.txt";

        private readonly string _file2 = "file2.txt";

        [SetUp]
        public void init()
        {
            string[] files = { _file1, _file2 };
            mockDirectoryExplorer.Setup(m => m.GetFiles(It.IsAny<string>())).Returns( files );
        }

        [TestCase("foo")]
        [TestCase("bar")]
        public void tests(string path)
        {
            var files = mockDirectoryExplorer.Object.GetFiles(path);
            Assert.IsNotNull(files);
            Assert.AreEqual(2,files.Count);
            Assert.AreEqual(true, files.Contains(_file2));
        }



    }
}
