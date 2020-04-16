using System.Threading.Tasks;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Exception;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Domain.Interfaces.Services;

namespace PUC.LDSI.Domain.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository professorRepository;

        public ProfessorService(IProfessorRepository professorRepository)
        {
            this.professorRepository = professorRepository;
        }

        public async Task<int> IncluirProfessorAsync(string nome)
        {
            var professor = new Professor() { Nome = nome };

            var erros = professor.Validate();
            if (erros.Length == 0)
            {
                await professorRepository.AdicionarAsync(professor);
                professorRepository.SaveChanges();

                return professor.Id;
            }
            //Não precisa de else, se ele entrar no if essa parte não será executada
            throw new DomainException(erros);
        }
    }
}
