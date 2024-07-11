using Journey.Infraestructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey.Infraestructure.Entities
{
    public class Activity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public ActivityStatus Status { get; set; }
        public Guid TripId { get; set; }
    }
}
