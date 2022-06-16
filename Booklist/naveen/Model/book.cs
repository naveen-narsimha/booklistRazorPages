using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace naveen.Model
{
    public class book
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string Name { get; set; }
        //[Display(Name ="naveen")]
        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
