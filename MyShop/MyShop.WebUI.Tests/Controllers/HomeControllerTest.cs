using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShop.WebUI;
using MyShop.WebUI.Controllers;

namespace MyShop.WebUI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
#pragma warning disable CS1705 // Assembly 'MyShop.WebUI' with identity 'MyShop.WebUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Web.Mvc, Version=5.2.7.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35' which has a higher version than referenced assembly 'System.Web.Mvc' with identity 'System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
            ViewResult result = controller.Index() as ViewResult;
#pragma warning restore CS1705 // Assembly 'MyShop.WebUI' with identity 'MyShop.WebUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Web.Mvc, Version=5.2.7.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35' which has a higher version than referenced assembly 'System.Web.Mvc' with identity 'System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
#pragma warning disable CS1705 // Assembly 'MyShop.WebUI' with identity 'MyShop.WebUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Web.Mvc, Version=5.2.7.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35' which has a higher version than referenced assembly 'System.Web.Mvc' with identity 'System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
            ViewResult result = controller.About() as ViewResult;
#pragma warning restore CS1705 // Assembly 'MyShop.WebUI' with identity 'MyShop.WebUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Web.Mvc, Version=5.2.7.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35' which has a higher version than referenced assembly 'System.Web.Mvc' with identity 'System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
#pragma warning disable CS1705 // Assembly 'MyShop.WebUI' with identity 'MyShop.WebUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Web.Mvc, Version=5.2.7.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35' which has a higher version than referenced assembly 'System.Web.Mvc' with identity 'System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
            ViewResult result = controller.Contact() as ViewResult;
#pragma warning restore CS1705 // Assembly 'MyShop.WebUI' with identity 'MyShop.WebUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Web.Mvc, Version=5.2.7.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35' which has a higher version than referenced assembly 'System.Web.Mvc' with identity 'System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
