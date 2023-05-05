using Microsoft.EntityFrameworkCore;
using Template.Data;
using Template.Models;

namespace Template
{
    public class LookupsLoaderService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger _logger;

        public LookupsLoaderService(IServiceProvider serviceProvider, ILogger<LookupsLoaderService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {

            SeedData();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Stop Server");
            return Task.CompletedTask;
        }
        public async void SeedData()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var _context =
                    scope.ServiceProvider
                        .GetRequiredService<TemplateContext>();
                Console.WriteLine("Start Seeding Data");
                //TODO Add MORE Tables 
                var per = await _context.Personnes.FirstOrDefaultAsync();
                if (per == null)
                    _context.Personnes.AddRange(new List<Personne>{
                    new Personne() { Nom = "Djehinet", Prenom = "Djawed", Age = 1 },
                    new Personne() { Nom = "Djehinet", Prenom = "Nadjib", Age = 32 },
                    new Personne() { Nom = "Djehinet", Prenom = "Fateh", Age = 30 }
                    });
                await _context.SaveChangesAsync();

                Console.WriteLine("Done With Seeding Data");
            }
        }
    }
}