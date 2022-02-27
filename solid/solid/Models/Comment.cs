using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommenterName { get; set; }
        public string CommenterEmail { get; set; }
        public DateTime CommentDate { get; set; }
        public string Text { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
