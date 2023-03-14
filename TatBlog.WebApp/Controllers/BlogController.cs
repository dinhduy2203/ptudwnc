﻿using Microsoft.AspNetCore.Mvc;
using TatBlog.Services.Blogs;

namespace TatBlog.WebApp.Controllers
{
    public class BlogController : Controller
    {

        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public async Task<IActionResult> Index(
            [FromQuery(Name ="p")] int pageNumber =1,
            [FromQuery(Name ="ps")] int pageSize = 10)
        
        {
            var postQuery = new PostQuery()
            {
                PublisheOnly = true
            };
        }
        
    
        public IActionResult About() => View();
        public IActionResult Contact() => View();
        public IActionResult Rss() => Content("Nội dung sẽ được cập nhật");
    }
}
