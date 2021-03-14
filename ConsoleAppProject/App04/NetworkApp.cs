using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This class acts as an app for a social network,
    /// where the user is able to make/remove posts, 
    /// display all posts by certain categories, 
    /// add comments and like/unlike posts.
    /// </summary>
    /// <author>
    /// Jason Huggins (14/03/2021)
    /// </author>
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// Displays a menu to the user where they can select
        /// which function they would like to carry out.
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("\tJason's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image",
                "Display All Posts",
                "Display Posts by Date",
                "Display Posts by Author",
                "Remove Post", "Add Comment",
                "Like/Unlike Post", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1:
                        PostMessage();
                        break;
                    case 2:
                        PostImage();
                        break;
                    case 3:
                        DisplayAll();
                        break;
                    case 4:
                        DisplayByDate();
                        break;
                    case 5:
                        DisplayByAuthor();
                        break;
                    case 6:
                        RemovePost();
                        break;
                    case 7:
                        AddComment();
                        break;
                    case 8:
                        LikePost();
                        break;
                    case 9:
                        wantToQuit = true;
                        break;
                }
            } while (!wantToQuit); 
        }

        /// <summary>
        /// Prompts the user to input their name.
        /// </summary>
        private string InputName()
        {
            Console.Write("\tPlease enter your name > ");
            string author = Console.ReadLine();
            return author;
        }

        /// <summary>
        /// Prompts the user to input a text message which
        /// will be posted onto their news feed. 
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Post a Message");
            string author = InputName();

            Console.Write("\tPlease enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("Message Posted");
            post.Display();
        }

        /// <summary>
        /// Prompts the user to input a photo's filename and 
        /// caption which will be posted onto their news 
        /// feed. 
        /// </summary>
        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Post an Image");
            string author = InputName();

            Console.Write("\tPlease enter your image's filename > ");
            string filename = Console.ReadLine();

            Console.Write("\tPlease enter a caption for the image > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("Message Posted");
            post.Display();
        }

        /// <summary>
        /// Displays all posts in the news feed. 
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompts the user to input an author name and
        /// the app will search for posts in the news
        /// feed by that author if it exists.
        /// </summary>
        private void DisplayByAuthor()
        {
            ConsoleHelper.OutputTitle("Display Posts by Author");

            Console.Write("\tPlease enter the author you'd like " +
                "to search for > ");
            string author = Console.ReadLine();

            news.DisplayByAuthor(author);
        }

        /// <summary>
        /// Prompts the user to input the ID of the post
        /// they would like to remove from their news
        /// feed.
        /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle("Removing a Post");

            int id = (int)ConsoleHelper.InputNumber("\tPlease enter "
                + "the post's ID > ", 1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        /// <summary>
        /// Prompts the user to add a comment to a post, first
        /// asking for the post's ID and then a comment.
        /// </summary>
        private void AddComment()
        {
            ConsoleHelper.OutputTitle("Adding a Comment");

            int id = (int)ConsoleHelper.InputNumber("\tPlease enter "
                + "the post's ID > ", 1, Post.GetNumberOfPosts());

            Console.Write("\tPlease enter a comment for this post > ");
            string comment = Console.ReadLine();

            news.AddComment(id, comment);
        }

        /// <summary>
        /// 
        /// </summary>
        private void LikePost()
        {
            throw new NotImplementedException();
        }
    }
}
