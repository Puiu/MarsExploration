using Infrastructure.Environment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infrastructure.Tests
{
    [TestClass]
    public class HeaderHelperTests
    {
        [TestMethod]
        public void GetAppVersion_ExpectedFourNumbersDotSeparated()
        {
            var helper = new HeaderHelper();

            var version = helper.GetAppVersion();

            Match match = Regex.Match(version, @"^([+]?\d*)\.([+]?\d*)\.([+]?\d*)\.([+]?\d*)$");
            
            Assert.IsTrue(match.Success);
        }

        [TestMethod]
        public void GetLocalIpAddress_ExpectedFourNumbersDotSeparated()
        {
            var helper = new HeaderHelper();
            var localIp = helper.TryGetLocalIPAddress();
            Match match = GetIpMatch(localIp);

            Assert.IsTrue(match.Success);
        }

       

        [TestMethod]
        public async Task GetExternalIpAddress_ExpectedFourNumbersDotSeparated()
        {
            var helper = new HeaderHelper();
            var extIp =  await helper.TryGetExternalIPAddressAsync();

            Match match = GetIpMatch(extIp);

            Assert.IsTrue(match.Success);
        }

        private static Match GetIpMatch(string localIp)
        {
            return Regex.Match(localIp, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
        }

    }
}
