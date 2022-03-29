using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smart_Strength_Backend.Models;
using Smart_Strength_Backend.Services;
using Smart_Strength_Backend.Services.Interfaces;

namespace Smart_Strength_Backend.Controllers
{
    [Route("api/comments")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        public ICommentsService CommentsSevice { get; }
        public CommentsController(ICommentsService commentsService)
        {
            this.CommentsSevice = commentsService;
        }

        [HttpPost]
        [Route("add")]
        public async Task<Comment> AddComment(string postId, string userId, string content)
        {
            try
            {
                Comment result = await this.CommentsSevice.AddComment(postId, userId, content);
                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpPost]
        [Route("like")]
        public async Task<bool> LikeComment(string userId, string commentId)
        {
            try
            {
                bool result = await this.CommentsSevice.LikeComment(commentId, userId);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        [HttpPost]
        [Route("unlike")]
        public async Task<bool> UnlikeComment(string userId, string commentId)
        {
            try
            {
                bool result = await this.CommentsSevice.UnlikeComment(commentId, userId);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
