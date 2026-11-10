using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Senac.ADS.PPFA.SenacEduca.Repositories;

namespace Senac.ADS.PPFA.SenacEduca.WinForms
{

    static class Program
    {
        // Propriedade para expor o ServiceProvider globalmente, se necessário
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();


            var context = ServiceProvider.GetService<SenacEducaContext>();
            context!.Database.Migrate();

            var MainForm = ServiceProvider.GetRequiredService<FrmAluno1>();
            Application.Run(MainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<FrmAluno1>();
            services.AddTransient<SenacEducaContextFactory>();
            services.AddTransient(opt => opt.GetService<SenacEducaContextFactory>()!.CreateDbContext());
        }
    }
}