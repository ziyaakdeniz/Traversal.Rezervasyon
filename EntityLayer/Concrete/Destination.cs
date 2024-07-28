using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
		// public int Id { get; set; }

		public int Id { get; set; }

		public bool Status { get; set; } = false;


		public string? City { get; set; }

        public string? DayNigth { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public string? Image { get; set; }

        public int Capacity { get; set; }

        public string? CoverImage { get; set; }

        public string? Details1 { get; set; }

        public string? Details2 { get; set; }

        public string? Image2 {  get; set; }    

        public virtual ICollection<Comment> Comments { get; set; }=new List<Comment>();
    }
}
