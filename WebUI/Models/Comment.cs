using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Comment
    {
        // Primary key
        public int CommentID { get; set; }

        // Foreign key
        public int PostID { get; set; }

        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        public virtual Post Post { get; set; }
    }
}
