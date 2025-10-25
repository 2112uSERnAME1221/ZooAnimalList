using System.ComponentModel.DataAnnotations;

namespace ZooAnimalList.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public DateTime ScheduleDate { get; set; }
    }
}
