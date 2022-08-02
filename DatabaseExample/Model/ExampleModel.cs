using System.ComponentModel.DataAnnotations;

namespace DatabaseExample.Model
{
    public class ExampleModel
    {
        //Defines columns only. Table name is set in DbContext
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
