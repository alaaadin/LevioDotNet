using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebLevio.Areas.adminstrator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WebLevio.Areas.adminstrator.Controllers.Tests
{
    [TestClass()]
    public class MandatControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            new Controllers.MandatController();
          new  Controllers.MandatController().Historique();
            Assert.Fail();
        }
    }
}