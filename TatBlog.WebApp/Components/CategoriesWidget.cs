﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TatBlog.Core.DTO;
using TatBlog.Services.Blogs;

namespace TatBlog.WebApp.Components
{
    public class CategoriesWidget : ViewComponent
    {
        private readonly IBlogRepository _blogRepository;
        public CategoriesWidget(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _blogRepository.GetCategoryItemsAsync();
            return View(categories);
        }
    }
}