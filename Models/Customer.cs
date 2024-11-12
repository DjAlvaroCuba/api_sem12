using System.ComponentModel.DataAnnotations;

namespace lab12cuba2.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
    }
}
