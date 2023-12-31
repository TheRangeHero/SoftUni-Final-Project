﻿using GamesNexus.Data.Common;
using GamesNexus.Data.Models;
using GamesNexus.Services.Data;
using GamesNexus.Services.Data.Interfaces;
using GamesNexus.Web.Infrastructure.MIddlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

using static GamesNexus.Common.GeneralApplicationConstants;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WebApplicationBuilderExtensions
    {

        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IGameService, GameServices>();
            services.AddScoped<IUserService, UserServices>();
            services.AddScoped<INewsService, NewsServices>();
            services.AddScoped<IPublisherService, PublisherServices>();
            services.AddScoped<IGenreService, GenreServices>();
            services.AddScoped<ICategoryService, CategoryServices>();
            services.AddScoped<IDiscussionService, DiscussionServices>();
            services.AddScoped<ICommentService, CommentServices>();
        }

        public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app, string email)
        {
            using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

            IServiceProvider serviceProvider = scopedServices.ServiceProvider;

            UserManager<ApplicationUser> userManager =
                serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole<Guid>> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            Task.Run(async () =>
                    {
                        if (await roleManager.RoleExistsAsync(AdminRoleName))
                        {
                            return;
                        }

                        IdentityRole<Guid> role =
                    new IdentityRole<Guid>(AdminRoleName);

                        await roleManager.CreateAsync(role);

                        ApplicationUser adminUser =
                    await userManager.FindByEmailAsync(email);

                        await userManager.AddToRoleAsync(adminUser, AdminRoleName);
                    })
                    .GetAwaiter()
                    .GetResult();

            return app;
        }

        public static IApplicationBuilder EnableOnlineUsersCheck(this IApplicationBuilder app)
        {
            return app.UseMiddleware<OnlineUsersMiddleware>();
        }
    }
}

