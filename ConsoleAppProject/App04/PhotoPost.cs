using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a photo (with a 
    /// caption) post in a social network, taking common 
    /// message properties such as author and time from 
    /// the Post superclass.
    ///</summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// @version 0.1
    /// Modified by Jason Huggins (14/03/2021)
    /// </author>
    public class PhotoPost : Post
    {
        // the name of the image file
        public String Filename { get; set; }
        
        // a one line image caption
        public String Caption { get; set; }   

        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(String author, String filename, 
            String caption) : base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }
    }
}
