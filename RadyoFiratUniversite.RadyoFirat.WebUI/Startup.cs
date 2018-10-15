using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.Business.Concrete;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IIletisimDal, EfIletisimDal>();
            services.AddScoped<IKunyeDal, EfKunyeDal>();
            services.AddScoped<IKurumsalDal, EfKurumsalDal>();
            services.AddScoped<IProgramciDal, EfProgramciDal>();
            services.AddScoped<IRolesDal, EfRolesDal>();
            services.AddScoped<IVitrinDal, EfVitrinDal>();
            services.AddScoped<IYayinDal, EfYayinDal>();

            services.AddScoped<IIletisimService, IletisimManager>();
            services.AddScoped<IKunyeService, KunyeManager>();
            services.AddScoped<IKurumsalService, KurumsalManager>();
            services.AddScoped<IProgramciService, ProgramciManager>();
            services.AddScoped<IRolesService, RolesManager>();
            services.AddScoped<IVitrinService, VitrinManager>();
            services.AddScoped<IYayinService, YayinManager>();


           
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
