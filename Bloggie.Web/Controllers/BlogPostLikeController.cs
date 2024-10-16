﻿using Bloggie.Web.Models.ViewModels;
using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BlogPostLikeController : Controller
    {
        private readonly IBlogPostLikeRepository _blogPostLikeRepository;

        public BlogPostLikeController(IBlogPostLikeRepository blogPostLikeRepository)
        {
            _blogPostLikeRepository = blogPostLikeRepository;
        }

        [Route("Add")]
        public async Task<IActionResult> AddLike([FromBody] AddBlogPostLikeRequest addBlogPostLikeRequest)
        {
            await _blogPostLikeRepository.AddLikeForBlog(addBlogPostLikeRequest.BlogPostId, addBlogPostLikeRequest.UserId);
            return Ok();
        }

    }
}
