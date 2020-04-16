using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Exception;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository turmaRepository;
        private readonly IAlunoRepository alunoRepository;

        public TurmaService(ITurmaRepository turmaRepository, IAlunoRepository alunoRepository)
        {
            this.turmaRepository = turmaRepository;
            this.alunoRepository = alunoRepository;
        }
        public async Task<int> AdicionarTurmaAsync(string descricao)
        {
            var turma = new Turma() { Nome = descricao };

            var erros = turma.Validate();
            if(erros.Length == 0)
            {
                await turmaRepository.AdicionarAsync(turma);
                turmaRepository.SaveChanges();

                return turma.Id;
            }
            //Não precisa de else, se ele entrar no if essa parte não será executada
             throw new DomainException(erros);
        }

        public async Task<int> AlterarTurmaAsync(int id, string descricao)
        {
            var turma = await turmaRepository.ObterAsync(id);
            turma.Nome = descricao;
            var erros = turma.Validate();

            if(erros.Length == 0)
            {
                turmaRepository.Modificar(turma);
                return turmaRepository.SaveChanges();
            }

            throw new DomainException(erros);
        }

        public async Task ExcluirAsync(int id)
        {
            var turma = await turmaRepository.ObterAsync(id);
            if(turma.Alunos?.Count > 0)
            throw new DomainException("Não é possível excluir uma turma que possui alunos matriculados!");

            turmaRepository.Excluir(id);
            turmaRepository.SaveChanges();
        }

        public List<Turma> ListarTurmas()
        {
            var lista = turmaRepository.ObterTodos().Cast<Turma>().ToList();
            return lista;
        }
        public async Task<Turma> ObterAsync(int id)
        {
            var turma = await turmaRepository.ObterAsync(id);
            return turma;
        }
       public async Task<int> IncluirAlunoAsync(int turmaId, string nomeAluno)
        {
            var aluno = new Aluno() { Nome = nomeAluno, TurmaId = turmaId };

            var erros = aluno.Validate();
            if (erros.Length == 0)
            {
                await alunoRepository.AdicionarAsync(aluno);
                alunoRepository.SaveChanges();

                return aluno.Id;
            }

            throw new DomainException(erros);
        }
    }
}
