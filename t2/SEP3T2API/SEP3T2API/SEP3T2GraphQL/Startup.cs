using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GraphQL.Server.Ui.Playground;
using HotChocolate.Types;
using SEP3T2GraphQL.Graphql;
using SEP3T2GraphQL.Repositories;
using SEP3T2GraphQL.Repositories.Impl;
using SEP3T2GraphQL.Services;
using SEP3T2GraphQL.Services.Impl;
using SEP3T2GraphQL.Services.Validation;
using SEP3T2GraphQL.Services.Validation.GuestValidation;
using SEP3T2GraphQL.Services.Validation.HostValidation;
using SEP3T2GraphQL.Services.Validation.ResidenceValidation;
using SEP3T2GraphQL.Services.Validation.UserValidation;
using SEP3T2GraphQL.SignalR;

namespace SEP3T2GraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddType<ListType>()
                .AddMutationType<Mutation>().ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true);
            services.AddScoped<IResidenceRepository, ResidenceRepository>();
            services.AddScoped<IResidenceService, ResidenceService>();
            services.AddScoped<IResidenceValidation, ResidenceValidation>();
            services.AddScoped<IHostRepository, HostRepository>();
            services.AddScoped<IHostService, HostService>();
            services.AddScoped<IHostReviewService, HostReviewService>();
            services.AddScoped<CreateHostReviewValidation>();
            services.AddScoped<IGuestReviewRepository, GuestReviewRepository>();
            services.AddScoped<CreateGuestReviewValidation>();
            services.AddScoped<IHostReviewRepository, HostReviewRepository>();
            services.AddScoped<IHostValidation, HostValidation>();
            services.AddScoped<IGuestValidation, GuestValidation>();
            services.AddScoped<IGuestService, GuestService>();
            services.AddScoped<IGuestRepository, GuestRepository>();
            services.AddScoped<IRentalService, RentalService>();
            services.AddScoped<IRentRequestRepository, RentRequestRepository>();
            services.AddScoped<CreateRentRequestValidator>();
            services.AddScoped<IFacilityService, FacilityService>();
            services.AddScoped<IFacilityRepository, FacilityRepository>();
            services.AddScoped<IRuleService, RuleService>();
            services.AddScoped<IRuleRepository, RuleRepository>();
            services.AddScoped<IAdministrationService, AdministrationService>();
            services.AddScoped<IAdministrationRepository, AdministrationRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGuestReviewRepository, GuestReviewRepository>();
            services.AddScoped<IGuestReviewService, GuestReviewService>();
            services.AddScoped<CreateGuestValidator>();
            services.AddScoped<IResidenceReviewRepository, ResidenceReviewRepository>();
            services.AddScoped<CreateResidenceReviewValidator>();
            services.AddScoped<IResidenceReviewService, ResidenceReviewService>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<CreateAddressValidator>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<CreateCityValidator>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<UserValidation>();
            services.AddScoped<IMessagingService, MessagingService>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<MessagingHub>("/chat");
                endpoints.MapGraphQL();
            });

            app.UseGraphQLPlayground(new PlaygroundOptions()
            {
                GraphQLEndPoint = "/graphql"
            }, "/graphql-ui");
        }
    }
}