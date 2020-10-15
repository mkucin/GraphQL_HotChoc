using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Subscriptions;
using GeniaxApi.Types;
using GeniaxApi.Types.TestTypes;

namespace GraphQL_HotChoc
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
            services.AddControllers();
            services.AddGraphQL(
                    SchemaBuilder.New()
                    .AddDocumentFromFile("./Schemas/test-schema.graphql")
                    .BindComplexType<Query>()
                    .BindComplexType<Mutation>()
                    .BindComplexType<Subscription>()
                    .BindComplexType<Fahrzeug>()
                    .BindComplexType<Maschine>()
                    .Create()
                )
                .AddInMemorySubscriptions()
                .AddInMemorySubscriptionProvider();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //* Optional -- Ein GraphQL-Playground zum testen der GraphQL API -> Dieser ist erreichbar unter */gql/graphiql
                app.UseGraphiQL();
            }

            app.UseHttpsRedirection();

            /* - .UseWebSockets() needed for Subscription (Subscribions communicates over WebSockets and not over HTTP) */
            app.UseWebSockets();

            app.UseRouting();

            /* HotChocolate wird mit der Anwendung verbunden der GraphQL-Server ist unter /gql erreichbar*/
            app.UseGraphQL();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
