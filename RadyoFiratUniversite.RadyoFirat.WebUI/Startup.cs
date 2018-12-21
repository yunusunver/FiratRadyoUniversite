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
using Microsoft.AspNetCore.Session;

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
            services.AddScoped<ITop30Dal, EfTop30Dal>();
            services.AddScoped<IAdminDal, EfAdminDal>();
            services.AddScoped<IMesajDal, EfMesajDal>();

            services.AddScoped<IIletisimService, IletisimManager>();
            services.AddScoped<IKunyeService, KunyeManager>();
            services.AddScoped<IKurumsalService, KurumsalManager>();
            services.AddScoped<IProgramciService, ProgramciManager>();
            services.AddScoped<IRolesService, RolesManager>();
            services.AddScoped<IVitrinService, VitrinManager>();
            services.AddScoped<IYayinService, YayinManager>();
            services.AddScoped<ITop30Service, Top30Manager>();
            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IMesajService, MesajManager>();

           
            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
