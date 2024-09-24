using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using SosialMedia.Context;
using SosialMedia.DAL.Repositories.Abstract;
using SosialMedia.DAL.Repositories.Concrate;
using System.Data;

public class Program
{
    static void Main(string[] args)
    {
        
        using (var unitOfWork = new UnitOfWork(new SosialMediaDb()))
        {

            var userDetails = new UserDetails
            {
                Name = "John",
                Surname = "Doe",
                Birthday = new DateTime(1990, 1, 1),
                Role = Roles.User
            };

            unitOfWork.UserDetails.Add(userDetails);
            unitOfWork.Complete(); 

            var user = new User
            {
                UserDetails = userDetails,
                Posts = new List<Post>()
            };

            var post1 = new Post
            {
                Text = "First Post",
                LikeCount = 10,
                User = user,
                Comment = string.Empty, 
                Comments = new List<Comment>()
            };

            unitOfWork.Users.Add(user);
            unitOfWork.Posts.Add(post1);
            unitOfWork.Complete();

            var comment1 = new Comment
            {
                Text = "Great post!",
                LikeCount = 15,
                Posts = new List<Post> { post1 },
                comment_in_comments = new List<Comment>()
            };

            post1.Comments.Add(comment1);
            unitOfWork.Comments.Add(comment1);
            unitOfWork.Complete();



        }
    }
}

