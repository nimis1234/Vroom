using System.ComponentModel.DataAnnotations;

namespace Vroom.Model
{
    public class Features
    {
        public int Id { get; set; }

        [Required] // inorder to not allow null
        [MaxLength(255)]
        public string Name { get; set; }

        //make
        public Make Make { get; set; }
        public int MakeId { get; set; }

    }
}
