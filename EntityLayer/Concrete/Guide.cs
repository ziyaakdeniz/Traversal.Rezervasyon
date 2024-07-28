using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
		//  public int Id { get; set; }
		public int Id { get; set; }


		public bool Status { get; set; }=false;

		public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public string? InstagramURL { get; set; }

        public string? TwitterURL { get; set; }

      //  public bool Status { get; set; }=true;
    }
}
