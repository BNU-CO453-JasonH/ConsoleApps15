using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    /// Michael Kölling and David J. Barnes
    /// version 0.1
    /// Modified by Jason Huggins (14/03/2021)
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Jason";
        private readonly List<Post> posts;

        ///<summary>
        /// Construct a news feed with some
        /// sample posts.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR, 
                "Testing message posts!");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR,
                "Photo1.jpg", "Testing photo posts!");
            AddPhotoPost(photoPost);
        }

        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// Finds a post in the news feed based on a
        /// given ID.
        /// </summary>
        public Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostID == id)
                {
                    return post;
                }
            }

            return null;
        }

        /// <summary>
        /// Removes a post from the news feed based on
        /// the post's ID.
        /// </summary>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\n\tPost with ID {id} doesn't exist.");
            }
            else
            {
                Console.WriteLine($"\n\tPost with ID {id} has " +
                    $"been removed from the news feed.\n");
                posts.Remove(post);
                post.Display();
            }
        }

        /// <summary>
        /// Adds a comment to a post with a given ID and comment
        /// by the user.
        /// </summary>
        public void AddComment(int id, string comment)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\n\tPost with ID {id} doesn't exist.");
            }
            else if (comment == "")
            {
                Console.WriteLine($"\n\tNo comment has been entered.");
            }
            else
            {
                Console.WriteLine("\n\tComment has been added to post with "
                    + $"ID {id}\n");
                post.AddComment(comment);
                post.Display();
            }
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();
            }
        }
    }
}
