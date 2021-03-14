using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This class stores information about a post in a social network,
    /// containing the common properties such as a username, timestamp,
    /// likes, comments and more. It acts as a superclass for the
    /// MessagePost and PhotoPost classes.
    /// </summary>
    /// <author>
    /// Jason Huggins (modified 14/03/2021)
    /// </author>
    public class Post
    {
        // Properties
        public int PostID { get; }
        public String Username { get; }
        public DateTime Timestamp { get; }

        // Attributes
        private static int instances = 0;
        private int likes;
        private readonly List<String> comments;

        /// <summary>
        /// Constructor initialising values.
        /// </summary>
        public Post(string author)
        {
            instances++;
            PostID = instances;

            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

        /// <summary>
        /// Returns the number of posts.
        /// </summary>
        public static int GetNumberOfPosts()
        {
            return instances;
        }

        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>        
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// Display the details of this post.
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"\tPost ID: {PostID}");
            Console.WriteLine($"\tAuthor: {Username}");
            Console.WriteLine($"\tTime Elapsed: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"\tLikes:  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("\tNo comments.");
            }
            else
            {
                Console.WriteLine($"\t{comments.Count} comment(s).\n");
                int commentNo = 0;

                foreach (string comment in comments)
                {
                    commentNo++;
                    Console.WriteLine($"\tComment {commentNo}");
                    Console.WriteLine($"\t{comment}\n");
                }
            }
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}
