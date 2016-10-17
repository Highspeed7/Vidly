using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        [Column("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public Genres Genre { get; set; }
        public byte GenreId { get; set; }
    }
}