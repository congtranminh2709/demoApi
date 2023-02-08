using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoApi.Data
{
    
    public class Person
    {
        [Key]    
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        [Range(0, 150)]
        public int Age { get; set; }


    }
}
