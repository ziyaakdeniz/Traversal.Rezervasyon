using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination : BaseModel
    {
       // public int Id { get; set; }

        public string? City { get; set; }

        public string? DayNigth { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public string? Image { get; set; }

        public int Capacity { get; set; }

      //  public bool Status { get; set; }=true;
    }
}
