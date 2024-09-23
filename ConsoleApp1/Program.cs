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
        //UserDetailsRepository userDetailsRepository = new UserDetailsRepository();
        //UserRepository userRepository = new UserRepository();
        //PostRepository postRepository = new PostRepository();
        //CommentRepository commentRepository = new CommentRepository();

        //UserDetails user_INFO_1 = new UserDetails()
        //{
        //    Name = "",
        //    Surname = "",
        //    Birthday = DateTime.Now,
        //    Role=Roles.Admin
        //};

        //User user1 = new User()
        //{
        //    UserDetailsId = 1
        //};
        //Comment commentClass1 = new Comment()
        //{
        //    Text = "hello",
        //    Comments = new List<Comment>() { new Comment() { Text="hello"} },

        //};
        //Post post1 = new Post()
        //{
        //    Text = "Step It Academy",
        //    Comment= commentClass1,
        //    UserId = 1,
        //};



        //userDetailsRepository.Add(user_INFO_1);
        //userRepository.Add(user1);
        //postRepository.Add(post1);
        //commentRepository.Add(commentClass1);

        //userDetailsRepository.SaveChanges();
        //userRepository.SaveChanges();
        //postRepository.SaveChanges();
        //commentRepository.SaveChanges();


        using (var unitOfWork = new UnitOfWork(new SosialMediaDb()))
        {
            var userDetails = new UserDetails
            {
                Name = "hello",
                Surname = "Nazimli",
                Birthday = DateTime.Now,
                Role = Roles.Admin
            };
            unitOfWork.UserDetails.Add(userDetails);
            unitOfWork.Complete();

            var user1 = new User
            {
                UserDetailsId=22
            };
            unitOfWork.Users.Add(user1);
            unitOfWork.Complete();

            var comment1 = new Comment
            {
                Text = "Main Comment",
                LikeCount = 41,
                comment_in_comments = new List<Comment>
            {
                new Comment { Text = "hello", LikeCount = 85 },
                new Comment { Text = "another nested comment", LikeCount = 93 }
            }

            };
            
            unitOfWork.Comments.Add(comment1);
            unitOfWork.Complete();

            var commentsList = new List<Comment> { comment1 };
            var post = new Post
            {
               
                Text = "Step It Academy",
                Comments= commentsList,
                UserId = 22,
                LikeCount=5,
                User=user1
            
             };
            unitOfWork.Posts.Add(post);
            unitOfWork.Complete();
           
        }
    }
}

