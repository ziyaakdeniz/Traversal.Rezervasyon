﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SubAbout
    {
		//   public int Id { get; set; }
		public int Id { get; set; }

		public bool Status { get; set; }=false;

		public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

      //  public bool Status { get; set; }=true;
    }
}
