using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using FindAndReplace.Models;
using FindAndReplace.Controllers;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnCorrectView_True()
    {
      //arrange
      HomeController controller = new HomeController();
      //act
      IActionResult indexView = controller.Index();
      ViewResult result = indexView as ViewResult;
      //assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
    [TestMethod]
    public void Index_ReturnsString_True()
    {
      //arrange
     ViewResult indexView = new HomeController().Index() as ViewResult;
      //act
      var result = indexView.ViewData.Model;
      //assert
      Assert.IsInstanceOfType(result, typeof(string));
    }
  }
}
