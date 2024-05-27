using AcademicAssistant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AcademicAssistant.Controllers
{
    /// <summary>
    /// Represents the controller for managing home-related actions.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        WebDbContext _webDB;

        /// <summary>
        /// Displays the page for seeing books.
        /// </summary>
        /// <param name="searchTerm">The search term for filtering books.</param>
        /// <returns>The view containing the books.</returns>
        public async Task<IActionResult> SeeBooks(string searchTerm)
        {
            var booksQuery = from book in _webDB.Books
                             join user in _webDB.Users on book.UserID equals user.ID
                             where book.Status == "Active"
                             select new _ShowBook
                             {
                                 ID = book.ID,
                                 Title = book.Title,
                                 Course = book.Course,
                                 FileUrl = book.FileUrl,
                                 DateTime = book.DateTime,
                                 UserName = user.Name,
                                 Status = book.Status,
                                 UserID = book.UserID

                             };

            if (!string.IsNullOrEmpty(searchTerm))
            {
                booksQuery = booksQuery.Where(b => b.Title.Contains(searchTerm) || b.Course.Contains(searchTerm));
            }

            var books = await booksQuery.ToListAsync();
            return View(books);
        }


        /// <summary>
        /// Displays the sign-up page.
        /// </summary>
        /// <returns>The view containing the sign-up form.</returns>
        public IActionResult SignUp()
        {
            return View();
        }

        /// <summary>
        /// Displays the log-in page.
        /// </summary>
        /// <returns>The view containing the log-in form.</returns>
        public IActionResult LogIn()
        {
            string UserID = HttpContext.Request.Cookies["UserID"];
            string AdminID = HttpContext.Request.Cookies["AdminID"];

            if (UserID != null || AdminID != null)
            {
                return RedirectToAction("Index", "Home");
            }


            return View();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="webDB">The web database context.</param>
        public HomeController(ILogger<HomeController> logger, WebDbContext webDB)
        {
            _logger = logger;
            _webDB = webDB;
        }


        /// <summary>
        /// Displays the home page with posts and comments.
        /// </summary>
        /// <returns>The view containing the home page.</returns>
        public async Task<IActionResult> Index()
        {
            var postsWithUserNames = await (from post in _webDB.Posts
                                            join user in _webDB.Users on post.UserID equals user.ID
                                            where post.Status == "Active"
                                            select new _ShowPost
                                            {
                                                ID = post.ID,
                                                Title = post.Title,
                                                Content = post.Content,
                                                ImgUrl = post.ImgUrl,
                                                DateTime = post.DateTime,
                                                UserID = post.UserID,
                                                UserName = user.Name, // Extracting the username from the Users table
                                                Status = post.Status,
                                                Comments = (from comment in _webDB.Comments
                                                            join commentUser in _webDB.Users on comment.UserID equals commentUser.ID
                                                            where comment.PostID == post.ID && comment.Status == "Active"
                                                            select new CommentViewModel
                                                            {
                                                                ID = comment.ID,
                                                                UserID = comment.UserID,
                                                                PostID = comment.PostID,
                                                                Content = comment.Content,
                                                                Status = comment.Status,
                                                                DateTime = comment.DateTime,
                                                                UserName = commentUser.Name // Extracting the username from the Users table
                                                            }).OrderBy(c=>c.DateTime).ToList()
                                            }).ToListAsync();




            ViewBag.posts = postsWithUserNames;

            return View();
        }

        /// <summary>
        /// Displays the about us page.
        /// </summary>
        /// <returns>The view containing the about us content.</returns>
        public IActionResult AboutUs()
        {
            return View();
        }

        /// <summary>
        /// Displays the privacy page.
        /// </summary>
        /// <returns>The view containing the privacy policy.</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Displays the error page.
        /// </summary>
        /// <returns>The view containing the error details.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
