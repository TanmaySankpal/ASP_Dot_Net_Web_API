using System.ComponentModel.DataAnnotations;

namespace Calculator_WebApplication.Model
{
    public class NumberSet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number1 { get; set; }
        [Required]
        public int Number2 { get; set; }
        [Required]
        public int Number3 { get; set; }

        public int Sum {  get; set; }
    }
}
