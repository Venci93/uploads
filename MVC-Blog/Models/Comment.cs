using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Blog.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Date = DateTime.Now;
        }
  
        [Key]
        public int Id { get; set; }

        public int PostId { get; set; }

        public string Text { get; set; }

        public string Author_Id { get; set; }

        [ForeignKey("Author_Id")]
        public ApplicationUser Author { get; set; }

        public Post Post { get; set; }

        public DateTime Date { get; private set; }
    }
}