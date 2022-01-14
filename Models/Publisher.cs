using System.Collections.Generic;

namespace Deak_Levente_Ferenc_Lab8.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
