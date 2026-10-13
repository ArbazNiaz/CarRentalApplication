using CarRentalApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApplication.Controllers
{
    public class CarController : Controller
    {
        public CarController() { }

        private static  List<Car> availiableCars= [new Car(1,"Alto",3000), new Car(2, "Corolla", 6000), new Car(3, "Civic", 8000)];
        private static  List<Car> bookedCars=[];
        public IActionResult Index()
        {
            return View(availiableCars);
        }
        public IActionResult Booked()
        {
            return View(bookedCars);
        }

        [HttpPost]
        public IActionResult Book(int targetId)
        {
            Car target=null;
            foreach (var car in availiableCars)
            {
                if (car.ID == targetId)
                {
                    target = car;
                    break;
                }
            }
            if (target == null)
            {
                return RedirectToAction("Index", "Home");
            }
            
            bookedCars.Add(target);
            availiableCars.Remove(target);

            return RedirectToAction("Booked","Car");
        }

    }
}