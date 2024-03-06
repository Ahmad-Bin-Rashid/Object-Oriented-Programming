using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class User
    {
        private string UserName;
        private List<Post> Posts = new List<Post>();
        private List<User> Followers = new List<User>();

        public User() { }

        public User(string userName)
        {
            UserName = userName;
            Posts = new List<Post>();
            Followers = new List<User>();
        }

        public void SetUsername(string username)
        {
            this.UserName = username;
        }

        public string GetUsername()
        {
            return this.UserName;
        }

        public void AddPost()
        {
            Post post = new Post();
            Console.Write("Enter Post Content: ");
            string content = Console.ReadLine();
            Console.WriteLine();
            post.CreatePost(content);
            Posts.Add(post);
        }

        public void AddFollower(User user)
        {
            Followers.Add(user);
        }

        public void ViewUser()
        {
            Console.WriteLine($"UserName: {this.UserName}");
            Console.WriteLine();
            Console.Write("Followers: ");
            foreach (User user in this.Followers)
            {
                Console.Write(user.UserName);
            }
            Console.WriteLine("\n\nPosts: \n");
            foreach (Post post in this.Posts)
            {
                post.ViewPost();
                Console.WriteLine();
            }

        }

        public void AddComment()
        {
            this.Posts[0].AddComment();
        }

        public void AddLike()
        {
            this.Posts[0].AddLike();
        }
    }


    class Post
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


    class Comment
    {
        private string comment;
        private string CommentedBy;

        public Comment(string CommentContent, string CommentBy)
        {
            this.comment = CommentContent;
            this.CommentedBy = CommentBy;
        }

        public Comment() { }

        public void SetComment(string CommentContent)
        {
            this.comment = CommentContent;
        }

        public string GetCommentContent()
        {
            return this.comment;
        }

        public void SetCommentBy(string CommentBy)
        {
            this.CommentedBy = CommentBy;
        }

        public string GetCommentBy()
        {
            return this.CommentedBy;
        }
    }




    class Like
    {
        private string Name;
        public Like() { }
        public Like(string name)
        {
            this.Name = name;
        }

        public void GiveLike(string name)
        {
            this.Name = name;
        }

        public string GetLikeName()
        {
            return this.Name;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Ahmad");

            Console.WriteLine($"Welcome {user1.GetUsername()}\n");

            user1.AddFollower(user2);
            user1.AddPost();
            user1.AddComment();
            user1.AddLike();

            user1.ViewUser();

            Console.ReadKey();
        }
    }
}
