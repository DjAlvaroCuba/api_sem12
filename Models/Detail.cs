using System.ComponentModel.DataAnnotations;

namespace lab12cuba2.Models
{
    public class Detail
    {
        [Key]
        public int DetailID { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float Subtotal { get; set; }

        //llave foranea de products

        public int ProductID { get; set; }
        public Product Product { get; set; }
        //llave foranea de invoice

        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }

    }
}
