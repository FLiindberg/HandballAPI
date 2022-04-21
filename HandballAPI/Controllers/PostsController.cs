using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HandballAPI.Data;
using HandballAPI.Model;
using HandballAPI.DataAccessUI;

namespace HandballAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostsDataAccess dataAccess;

        public PostsController(IPostsDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpGet]
        public async Task<ActionResult<List<Post>>> Get()
        {
            return Ok(dataAccess.GetPosts());
        }

        [HttpGet("{postId}")]
        public async Task<ActionResult<Post>> GetById(int postId)
        {
            var post = dataAccess.GetPostById(postId);

            if (post == null)
                return NotFound("Post not found");

            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult<List<Post>>> AddPost(Post post)
        {
            dataAccess.AddPost(post);

            return Ok(dataAccess.GetPosts());
        }

        [HttpPut]
        public async Task<ActionResult<List<Post>>> UpdatePost(Post p)
        {
            var post = dataAccess.GetPostById(p.PostId);

            if (post == null)
                return NotFound("Post not found");

            dataAccess.UpdatePost(p);

            return Ok(dataAccess.GetPosts());
        }

        [HttpDelete("{postId}")]
        public async Task<ActionResult<List<Post>>> Delete(int postId)
        {
            var post = dataAccess.GetPostById(postId);

            if (post == null)
                return NotFound("Post not found");

            dataAccess.DeletePost(postId);

            return Ok(dataAccess.GetPosts());
        }
    }
}
