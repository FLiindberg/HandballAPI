using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HandballAPI.Data;
using HandballAPI.Model;

namespace HandballAPI.DataAccessUI
{
    public class PostsDataAccess : IPostsDataAccess
    {
        private readonly HDbContext _hDbContext;

        public PostsDataAccess(HDbContext hDbContext)
        {
            _hDbContext = hDbContext;
        }

        //Get All Posts
        public IEnumerable<Post> GetPosts()
        {
            return _hDbContext.Posts.ToList();
        }

        //Get Post By Id
        public Post GetPostById(int postid)
        {
            return _hDbContext.Posts.AsNoTracking().Single(p => p.PostId == postid);
        }

        //Add A Post
        public void AddPost(Post post)
        {
            _hDbContext.Posts.Add(post);

            var b = _hDbContext.Posts.SingleOrDefault(p => p.PostId == post.PostId);

            _hDbContext.SaveChanges();
        }

        //Update A Post
        public void UpdatePost(Post post)
        {
            var b = _hDbContext.Posts.SingleOrDefault(p => p.PostId == post.PostId);

            b.CloneIt(post);

            _hDbContext.SaveChanges();
        }

        //Delete A Post
        public void DeletePost(int postid)
        {
            var b = _hDbContext.Posts.SingleOrDefault(p => p.PostId == postid);

            _hDbContext.Posts.Remove(b);

            _hDbContext.SaveChanges();
        }
    }
}
