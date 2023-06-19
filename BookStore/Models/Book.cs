using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public int Pages { get; set; }
        [DataType(DataType.Text)]
        public string Title { get; set; }
        [DataType(DataType.Text)]
        public string Author { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [DataType(DataType.MultilineText)]
        public string Descritpion { get; set; }
    }
}
