using System.ComponentModel.DataAnnotations.Schema;

namespace Vroom.Model
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // point to Make 
        public Make Make { get; set; }
        [ForeignKey("Make")]
        public int MakeId { get; set; }

    }
}
