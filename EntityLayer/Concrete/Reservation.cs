using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        public int Id { get; set; }

        public int AppUserId {  get; set; }
        
        public virtual AppUser AppUser { get; set; }

        public string PersonCount {  get; set; }

        public string Destination { get; set; }

        public DateTime DestinationDate { get; set; }

        public string Description { get; set; } 

        public string status { get; set; }


    }
}
