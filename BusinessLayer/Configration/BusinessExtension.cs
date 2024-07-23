using BusinessLayer.Abstact;
using BusinessLayer.Concrete;
using DataAccessLayer.Absract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Shared.Abstract;
using DataAccessLayer.Shared.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Configration
{
    public static class BusinessExtension
    {
        public static void BusinessDI(this IServiceCollection services)
        {
            services.AddScoped<IAbout1Servise,About1Service>();
            services.AddScoped<IAbout2Service,About2Service>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IFeature2Service, Feature2Service>();
            services.AddScoped<IGuideService, GuideService>();
            services.AddScoped<INewslaterService, NewslaterService>();
            services.AddScoped<ISubAboutService, SubAboutService>();
            services.AddScoped<ITestimonialService, TestimonialService>();

        }

        public static void RepositoryDI(this IServiceCollection repos)
        {
            repos.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            repos.AddScoped<IAbout1Repository, About1Repository>();
            repos.AddScoped<IAbout2Repository, About2Repository>();
            repos.AddScoped<IContactRepository, ContactRepository>();
            repos.AddScoped<IDestinationRepository, DestinationRepository>();
            repos.AddScoped<IFeatureRepository, FeatureRepository>();
            repos.AddScoped<IFeature2Repository, Feature2Repository>();
            repos.AddScoped<IGuideRepository, GuideRepository>();
            repos.AddScoped<INewslaterRepository, Newslaterrepository>();
            repos.AddScoped<ITestimonialRepository, TestimonialRepository>();
        }
    }
}
