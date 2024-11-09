using blog.Factories;
using blog.Interfaces;
using blog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogService _adminBlogService;
        private readonly BlogService _userBlogService;


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _adminBlogService = new BlogService(new AdminBlogFactory());


            _userBlogService = new BlogService(new RegularUserBlogFactory());

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult CreatePost()
        {
            string title = "Sample Admin Post";
            string content = "This is a post created by an admin user.";
            string imageUrl = "admin_image.jpg"; // Example image URL
            int userStatus = 2; // Set status (0 = Student, 1 = Military, 2 = Anime)

            string result = _adminBlogService.CreatePost(title, content, imageUrl, userStatus);

            ViewBag.Result = result; // Pass the result to the view for display
            return View("Index");
        }

        [HttpPost]
        public ActionResult CreatePost0()
        {
            string title = "Sample Regular Post";
            string content = "This is a post created by an Regular user.";
            string imageUrl = "admin_image.jpg"; // Example image URL
            int userStatus =1; // Set status (0 = Student, 1 = Military, 2 = Anime)

            string result = _userBlogService.CreatePost(title, content, imageUrl, userStatus);

            ViewBag.Result = result; // Pass the result to the view for display
            return View("Index");


            IBlogFactory regularUserFactory = new RegularUserBlogFactory();
            BlogService userBlogService = new BlogService(regularUserFactory);
            string userPost = userBlogService.CreatePost("User Title", "User Content", "user_image.jpg", 0);
            Console.WriteLine(userPost);
        }
    }
}