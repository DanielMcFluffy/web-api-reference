using WebApiDemo.Models.Validations;

namespace WebApiDemo.Models
{
    public class Shirt
    {
        public int ShirtId { get; set; }
        public string? Brand{ get; set; }
        public string? Color { get; set; }
        //mens greater than 8
        //wmns greather than 6
        [Shirt_EnsureCorrectSizing]
        public int Size { get; set; }
        public string? Gender { get; set; }
        public double? Price { get; set; }
    }
}
