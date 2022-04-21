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

        //Get Method
        public IEnumerable<Post> GetPosts()
        {
            return _hDbContext.Posts.ToList();
        }

        //Get By Id
        public Post GetPostById(int postid)
        {
            return _hDbContext.Posts.AsNoTracking().Single(p => p.PostId == postid);
        }

        //Add Method
        public void AddPost(Post post)
        {
            _hDbContext.Posts.Add(post);

            var b = _hDbContext.Posts.SingleOrDefault(p => p.PostId == post.PostId);

            _hDbContext.SaveChanges();
        }

        //Update Method
        public void UpdatePost(Post post)
        {
            var b = _hDbContext.Posts.SingleOrDefault(p => p.PostId == post.PostId);

            b.CloneIt(post);

            _hDbContext.SaveChanges();
        }

        //Delete Method
        public void DeletePost(int postid)
        {
            var b = _hDbContext.Posts.SingleOrDefault(p => p.PostId == postid);

            _hDbContext.Posts.Remove(b);

            _hDbContext.SaveChanges();
        }
    }
}
