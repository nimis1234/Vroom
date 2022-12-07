using System.ComponentModel.DataAnnotations;

namespace Vroom.Model
{
    public class Features
    {
        //changes
        public int Id { get; set; }

        [Required] // inorder to not allow null
        [MaxLength(255)]
        public string Name { get; set; }

        public Make Make { get; set; }
        public int MakeId { get; set; }

    }
}
