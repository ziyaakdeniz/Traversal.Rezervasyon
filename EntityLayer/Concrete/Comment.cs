using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment:BaseModel

    {
        public string ComentUser { get; set; }

        public DateTime ComentDate { get; set; }

        public string Content { get; set; }

        public  int DestinationId {  get; set; }

        public virtual Destination Destination { get; set; }




    }
}
