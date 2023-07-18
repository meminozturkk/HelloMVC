using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {

            return View();
           
		}
		//penultimate codes not deleted
		public ActionResult List(/*string searchToken*/)
        {
            List<Car> cars = new List<Car>();

            for (int i = 0; i < 10; i++)
            {
                Car car = new Car();
                car.Brand = "BMW";
                car.LicensePlate = $"{i}";
                cars.Add(car);
            }

			//string encoded = HttpUtility.HtmlEncode(searchToken);
   //         ViewBag.DisplayMessage = encoded;
			return View(cars);
        }
        public string ShowDetail(string id)
        {
			string encodedToken = HttpUtility.HtmlEncode(id);
			return "Record to Show:" + id;
        }

	}
}