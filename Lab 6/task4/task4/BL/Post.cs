using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    internal class Post
    {
        private string PostContent;
        private List<Comment> Comments = new List<Comment>();
        private List<Like> Likes = new List<Like>();

        public Post() { }


        public void CreatePost(string postContent)
        {
            this.PostContent = postContent;
        }

        public void UpdatePost(string postContent)
        {
            this.PostContent = postContent;
        }

        public string GetPost()
        {
            return this.PostContent;
        }

        public void AddComment()
        {
            Comment comment = new Comment();
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();
            comment.SetCommentBy(name);
            Console.Write("Enter Comment: ");
            string c = Console.ReadLine();
            Console.WriteLine();
            comment.SetComment(c);
            this.Comments.Add(comment);
        }

        public void AddLike()
        {
            Like like = new Like();
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine();
            like.GiveLike(name);
            this.Likes.Add(like);
        }

        public void ViewPost()
        {
            Console.WriteLine($"Post: {this.PostContent}");
            Console.WriteLine();
            Console.WriteLine("Comments: \n");
            foreach (Comment comment in this.Comments)
            {
                string Content = comment.GetCommentContent();
                string ContentBy = comment.GetCommentBy();
                Console.WriteLine($"{ContentBy} Commented -{Content}-");
                Console.WriteLine();
            }
            Console.WriteLine("Likes:\n");
            foreach (Like like in this.Likes)
            {
                string LikeBy = like.GetLikeName();
                Console.WriteLine(LikeBy);
            }
        }
    }
}
