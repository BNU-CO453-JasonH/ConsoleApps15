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
                "Display All Posts (by comments/likes)",
                "Display All Posts (by date/time)",
                "Display All Posts (by author)",
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

        private void PostMessage()
        {
            throw new NotImplementedException();
        }

        private void PostImage()
        {
            throw new NotImplementedException();
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }

        private void RemovePost()
        {
            throw new NotImplementedException();
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        private void LikePost()
        {
            throw new NotImplementedException();
        }
    }
}
