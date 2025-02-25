using System.ComponentModel.DataAnnotations;

namespace OnlineFoodDeliverySystem
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int Phone {  get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }

    }
}
