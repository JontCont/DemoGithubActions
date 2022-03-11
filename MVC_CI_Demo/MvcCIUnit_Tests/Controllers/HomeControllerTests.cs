using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_CI_Demo.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CI_Demo.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        private readonly ILogger<HomeController> _logger;

        [TestMethod()]
        public void Get_DataTableAtTest()
        {
            HomeController home = new(_logger) ;
            Assert.AreNotEqual(home.Get_DataTableAt(), null);
        }
    }
}