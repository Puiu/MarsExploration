using Infrastructure.Environment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infrastructure.Tests
{
    [TestClass]
    public class SettingsReaderTests
    {
        [TestMethod]
        public void LogFilePathAndName_ExpectedFolderAndFile()
        {
            var settingsReader = new SettingsReader();

            var logFilePathAndName = settingsReader.LogFilePathAndName;

            //example  \Logs\mars-exploration-20170925.log"

            var firstChar = logFilePathAndName.Substring(0, 1);
            var lastBackSlash = logFilePathAndName.LastIndexOf('\\');

            Assert.AreEqual(firstChar, @"\");
            Assert.IsTrue(lastBackSlash > 1);
        }
    }
}
