using System.ComponentModel.DataAnnotations;

namespace ZooAnimalList.Models
{
    public class Price
    {
        [Key]
        public int CostId { get; set; }
        public double TicketPrice { get; set; }
        
        public int Amount { get; set; }
    }
}
