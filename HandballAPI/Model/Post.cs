using System.ComponentModel.DataAnnotations;

namespace HandballAPI.Model
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Author { get; set; }
        public string Team { get; set; }

        public void CloneIt(Post post)
        {
            Title = post.Title;
            Description = post.Description;
            Link = post.Link;
            Author = post.Author;
            Team = post.Team;
        }

        //public int UserId { get; set; }
        //public User User { get; set; }
    }
}
