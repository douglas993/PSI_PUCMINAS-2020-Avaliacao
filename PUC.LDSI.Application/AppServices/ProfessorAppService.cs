using System;
using System.Threading.Tasks;
using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.Domain.Interfaces.Services;

namespace PUC.LDSI.Application.AppServices
{
    public class ProfessorAppService : IProfessorAppService
    {
        private readonly IProfessorService professorService;

        public ProfessorAppService(IProfessorService professorService)
        {
            this.professorService = professorService;
        }

        public async Task<DataResult<int>> IncluirProfessorAsync(string nome)
        {
            try
            {
                var retorno = await professorService.IncluirProfessorAsync(nome);
                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
        }
    }
}
