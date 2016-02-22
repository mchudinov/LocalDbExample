using System.ComponentModel.DataAnnotations.Schema;

namespace LocalDbExample
{
    public class Widget
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Sum { get; set; }
    }
}
