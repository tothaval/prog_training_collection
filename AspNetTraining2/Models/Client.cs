using System.ComponentModel.DataAnnotations;

namespace AspNetTraining2.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<ItemClient>? ItemClients { get; set; }

    }
}
