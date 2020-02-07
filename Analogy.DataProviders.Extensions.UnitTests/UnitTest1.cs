using System;
using System.Collections.Generic;
using Analogy.Interfaces.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Analogy.DataProviders.Extensions.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var logParserSettings = new LogParserSettings();
            logParserSettings.Splitter = " ";
            logParserSettings.IsConfigured = true;
            logParserSettings.SupportedFilesExtensions = new List<string> { "u_ex*.log" };
            GeneralFileParser p = new GeneralFileParser(logParserSettings); 
            Assert.IsTrue(p.splitters.Length==1);
        }
    }
}
