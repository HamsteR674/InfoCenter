using InteractionDb.Repository.Divisions;
using InteractionDb.Repository.PendingTasks;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ServiceCollection
{
    public static class AddSer
    {
        public static IServiceCollection AddInteractionDb(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddScoped<IDivisions, Divisions>()
                .AddScoped<IPendingTasks, PendingTasks>();
             
            return serviceCollection;
        }
    }
}
