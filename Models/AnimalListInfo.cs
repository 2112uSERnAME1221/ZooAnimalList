using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ZooAnimalList.Models
{

    public enum Health
    {
        Surgery,
        Zoochosis,
        Sick,
        Healthy,
        Died
    }

    public class AnimalListInfo
    {
        [Key]
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public double Wieght{ get; set; }
        public Char Gender { get; set; }       
        public Health Status { get; set; }
    }
}
