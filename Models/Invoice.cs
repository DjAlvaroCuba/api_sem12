using System.ComponentModel.DataAnnotations;

namespace lab12cuba2.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }

        //llave foranea

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }


    }
}
