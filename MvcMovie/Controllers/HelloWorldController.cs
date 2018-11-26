using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "Hello world!";
        //}

        //public string Welcome()
        //{
        //    return "Chào mừng...";
        //}

        ///// <summary>
        ///// /HelloWorld/Welcome?name=Rick&numtimes=4
        ///// </summary>
        ///// <param name="name">Rick</param>
        ///// <param name="numTimes">4</param>
        ///// <returns></returns>
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        ///// <summary>
        ///// /HelloWorld/Welcome/3?name=Rick
        ///// </summary>
        ///// <param name="name"></param>
        ///// <param name="ID"></param>
        ///// <returns></returns>
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

        /// <summary>
        /// /HelloWorld/Welcome?name=Rick&numtimes=4
        /// </summary>
        /// <param name="name">Rick</param>
        /// <param name="numTimes">4</param>
        /// <returns></returns>
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
