using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Interfaces.Services
{
    public interface IAvaliacaoService
    {
        //Retorna o Id da avaliação criada
        Task<int> AdicionarAvaliacaoAsync(int professorId, string disciplina, string materia, string descricao);
        //Retorna o Id da questão criada
        Task<int> AdicionarQuestaoAvaliacaoAsync(int avaliacaoId, int tipo, string enunciado);
        //Retorna o Id da opção criada
        Task<int> AdicionarOpcaoAvaliacaoAsync(int questaoId, string descricao, byte verdadeira);

        //Retorna o Id da avaliação alterada
        Task<int> AlterarAvaliacaoAsync(int id, string disciplina, string materia, string descricao);
        //Retorna o Id da questão alterada
        Task<int> AlterarQuestaoAvaliacaoAsync(int id, int tipo, string enunciado);
        //Retorna o Id da opção alterada
        Task<int> AlterarOpcaoAvaliacaoAsync(int id, string descricao, byte verdadeira);

        Task<int> ExcluirAvaliacaoAsync(int id);
        //Retorna o Id da avaliação cuja questão pertencia
        Task<int> ExcluirQuestaoAvaliacaoAsync(int id);
        //Retorna o Id da questão cuja opção pertencia
        Task<int> ExcluirOpcaoAvaliacaoAsync(int id);

        Task<List<Avaliacao>> ListarAvaliacoesDoProfessorAsync(int professorId);
    }
}
