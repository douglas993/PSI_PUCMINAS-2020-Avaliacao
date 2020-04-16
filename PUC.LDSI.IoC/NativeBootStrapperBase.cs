using Microsoft.Extensions.DependencyInjection;
using PUC.LDSI.Application.AppServices;
using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.DataBase.Repository;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Domain.Interfaces.Services;
using PUC.LDSI.Domain.Services;

namespace PUC.LDSI.IoC
{
    public abstract class NativeBootStrapperBase
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //AppService
            services.AddScoped<ITurmaAppService, TurmaAppService>();
            services.AddScoped<IProfessorAppService, ProfessorAppService>();
            services.AddScoped<IAvaliacaoAppService, AvaliacaoAppService>();

            //Repositorio
            services.AddScoped<ITurmaRepository, TurmaRepository>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IProfessorRepository, ProfessorRepository>();
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddScoped<IOpcaoAvaliacaoRepository, OpcaoAvaliacaoRepository>();
            services.AddScoped<IQuestaoAvaliacaoRepository, QuestaoAvaliacaoRepository>();

            //Service
            services.AddScoped<ITurmaService, TurmaService>();
            services.AddScoped<IProfessorService, ProfessorService>();
            services.AddScoped<IAvaliacaoService, AvaliacaoService>();
        }
    }
}
