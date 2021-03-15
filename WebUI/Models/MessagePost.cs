using System;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
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
        [StringLength(256), DataType(DataType.MultilineText)]
        public String Message { get; set; }
    }
}
