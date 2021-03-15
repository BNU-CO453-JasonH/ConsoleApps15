using System;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
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
    /// Modified by Jason Huggins (15/03/2021)
    /// </author>
    public class PhotoPost : Post
    {
        // the name of the image file
        [StringLength(128), Required]
        public String Filename { get; set; }
        
        // a one line image caption
        [StringLength(30), Required]
        public String Caption { get; set; }   
    }
}
