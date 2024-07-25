using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        public virtual DbSet<About1> About1s { get; set; }

        public virtual DbSet<About2> About2s { get; set; }

        public virtual DbSet<Destination> Destinations { get; set; }

        public virtual DbSet<Feature> Features { get; set; }

        public virtual DbSet<Feature2> Features2s { get; set; }

        public virtual DbSet<Guide> Guides { get; set; }

        public virtual DbSet<Newslater > Newslaters { get; set; }

        public virtual DbSet<SubAbout> SubAbouts { get; set; }

        public virtual DbSet<Testimonial> Testimonials { get; set; }

        public virtual DbSet<Comment> Comments { get; set; }


    }
}
