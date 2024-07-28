using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
		public int Id { get; set; }

		public bool Status { get; set; } = false;

		public string ComentUser { get; set; }

        public DateTime ComentDate { get; set; }

        public string Content { get; set; }

        public  int DestinationId {  get; set; }

        public virtual Destination Destination { get; set; }

    }
}
