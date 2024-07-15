using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingData.Repository.PendingRepBus;

namespace WorkingData.ServiceCollection
{
    public static class Add
    {
        public static IServiceCollection AddWorkingData(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPendingRepBus, PendingRepBus>();
            return serviceCollection;
        }
    }
}
