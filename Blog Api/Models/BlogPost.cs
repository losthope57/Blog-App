using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Api.Models
{
    public class BlogPost
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }
    }
}
