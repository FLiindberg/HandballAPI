using HandballAPI.Model;
using System.Collections.Generic;

namespace HandballAPI.DataAccessUI
{
    public interface IPostsDataAccess
    {
        IEnumerable<Post> GetPosts();
        Post GetPostById(int postid);
        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int postid);
    }
}
