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

            var MainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(MainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<Form1>();
            services.AddTransient(opt => opt.GetService<SenacEducaContextFactory>()!.CreateDbContext());
        }
    }
}