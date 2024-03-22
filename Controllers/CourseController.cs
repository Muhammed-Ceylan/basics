using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        //Details içerisine gönderilen id parametresi nullable olabilir. Nullable olması durumunda bir if kontrolü yapılarak başka bir 
        //action ve/veya controller'a yönlendirilebilir.
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                //TO DO: Burada bir problem var çözülemedi!!!!

                //return Redirect("/course/list");
                return RedirectToAction("List", "Course");//birden fazla kullanım olduğu için bu burada ilk action sonrasında controller verilir.

            }
            var course = Repository.GetById(id);
            return View(course);
        }
        public IActionResult List()
        {
            return View("CourseList", Repository.Courses);
        }

    }
}