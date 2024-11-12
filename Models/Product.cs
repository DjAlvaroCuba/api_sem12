using System.ComponentModel.DataAnnotations;

namespace lab12cuba2.Models
{
    public class Product
    {

        [Key]//si no funciona el pductiID
        public int ProductID { get; set; }//ID AL FINAL PARA DETECTAR PK con entity
            
        public string Name { get; set; }

        public float Price { get; set; }

    }
}
