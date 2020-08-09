using System;
using System.Collections.Generic;
using Analogy.Interfaces;
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
            logParserSettings.IsConfigured = true;
            logParserSettings.DeleteMap(AnalogyLogMessagePropertyName.Category, "Category");
            Assert.IsTrue(logParserSettings.Maps[AnalogyLogMessagePropertyName.Category].Count == 0);
        }
    }
}
