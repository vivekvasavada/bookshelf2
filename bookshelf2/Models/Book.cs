using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace bookshelf2.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Decsription { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        //navigation propertyj
    }
}