using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a text message 
    /// post in a social network, taking common message
    /// properties such as author and time from 
    /// the Post superclass.
    /// </summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// version 0.1
    /// Modified by Jason Huggins (15/03/2021)
    /// </author>
    public class MessagePost : Post
    {
        // an arbitrarily long, multi-line message
        public String Message { get; }

        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        public MessagePost(String author, String text): base(author)
        {
            Message = text;
        }

        /// <summary>
        /// Overrides the method in the base class and
        /// displays a message post with the common
        /// post properties. 
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"\tMessage: {Message}");

            base.Display();
        }
    }
}
