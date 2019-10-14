using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pokegraf.Application.Implementation.Configuration;
using Pokegraf.Application.Implementation.Service;
using Pokegraf.Domain.Conversation.Query.FindConversation;
using Pokegraf.Infrastructure.Implementation.Configuration;
using Pokegraf.Persistence.Implementation.Configuration;

namespace Pokegraf.Api.WebApi.Configuration
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDependencies(configuration);
            services.AddInfrastructureDependencies(configuration);
            services.AddPersistenceDependencies(configuration);

            if (!string.IsNullOrWhiteSpace(configuration["POKEGRAF_REDIS_CACHE_URL"]))
            {
                services.AddDistributedCache(configuration);
            }
            
            services.AddMediatR(
                typeof(TelegramService).Assembly, 
                typeof(FindConversationQuery).GetTypeInfo().Assembly);
            
            return services;
        }
        
        public static void InitializeDatabases(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.InitializePersistenceDatabases(configuration);
        }
    }
}