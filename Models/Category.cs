using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngularDemo.Models
{
    public class Category
    {
        [Key]
        public int CategoryID {get;set;}
        public string CategoryName{get;set;}
        public string Desctiption {get;set;}
        public ICollection<Product> Products{get;set;}
    }
}