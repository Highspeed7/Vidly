using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Genres
    {
        [Required]
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}
