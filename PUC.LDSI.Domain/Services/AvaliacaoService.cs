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
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoRepository avaliacaoRepository;
        private readonly IOpcaoAvaliacaoRepository opcaoavaliacaoRepository;
        private readonly IQuestaoAvaliacaoRepository questaoavaliacaoRepository;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository, IOpcaoAvaliacaoRepository opcaoavaliacaoRepository, IQuestaoAvaliacaoRepository questaoavaliacaoRepository)
        {
            this.avaliacaoRepository = avaliacaoRepository;
            this.opcaoavaliacaoRepository = opcaoavaliacaoRepository;
            this.questaoavaliacaoRepository = questaoavaliacaoRepository;
        }
        
        public async Task<int> AdicionarAvaliacaoAsync(int professorId, string disciplina, string materia, string descricao)
        {
            var avaliacao = new Avaliacao { ProfessorId = professorId, Disciplina = disciplina, Materia = materia, Descricao = descricao };

            var erros = avaliacao.Validate();
            if (erros.Length == 0)
            {
                await avaliacaoRepository.AdicionarAsync(avaliacao);
                avaliacaoRepository.SaveChanges();

                return avaliacao.Id;
            }
            throw new NotImplementedException();
        }

        public async Task<int> AdicionarOpcaoAvaliacaoAsync(int questaoId, string descricao, byte verdadeira)
        {
            var opcaoAvaliacao = new OpcaoAvaliacao { QuestaoAvaliacaoId = questaoId, Descricao = descricao, Verdadeira = verdadeira };

            var erros = opcaoAvaliacao.Validate();
            if (erros.Length == 0)
            {
                await opcaoavaliacaoRepository.AdicionarAsync(opcaoAvaliacao);
                avaliacaoRepository.SaveChanges();

                return opcaoAvaliacao.Id;
            }
            throw new NotImplementedException();
        }

        public async Task<int> AdicionarQuestaoAvaliacaoAsync(int avaliacaoId, int tipo, string enunciado)
        {
            var questaoAvaliacao = new QuestaoAvaliacao { AvaliacaoId = avaliacaoId, Tipo = tipo, Enunciado = enunciado };

            var erros = questaoAvaliacao.Validate();
            if (erros.Length == 0)
            {
                await questaoavaliacaoRepository.AdicionarAsync(questaoAvaliacao);
                avaliacaoRepository.SaveChanges();

                return questaoAvaliacao.Id;
            }


            throw new NotImplementedException();
        }

        public async Task<int> AlterarAvaliacaoAsync(int id, string disciplina, string materia, string descricao)
        {
            var avaliacao = await avaliacaoRepository.ObterAsync(id);
            avaliacao.Disciplina = disciplina;
            avaliacao.Materia = materia;
            avaliacao.Descricao = descricao;
            var erros = avaliacao.Validate();

            if (erros.Length == 0)
            {
                avaliacaoRepository.Modificar(avaliacao);
                return avaliacaoRepository.SaveChanges();
            }

            throw new DomainException(erros);

            throw new NotImplementedException();
        }

        public async Task<int> AlterarOpcaoAvaliacaoAsync(int id, string descricao, byte verdadeira)
        {
            var opcaoAvaliacao = await opcaoavaliacaoRepository.ObterAsync(id);
            opcaoAvaliacao.Descricao = descricao;
            opcaoAvaliacao.Verdadeira = verdadeira;
            var erros = opcaoAvaliacao.Validate();

            if (erros.Length == 0)
            {
                opcaoavaliacaoRepository.Modificar(opcaoAvaliacao);
                return opcaoavaliacaoRepository.SaveChanges();
            }

            throw new DomainException(erros);
            throw new NotImplementedException();
        }

        public async Task<int> AlterarQuestaoAvaliacaoAsync(int id, int tipo, string enunciado)
        {
            var questaoAvaliacao = await questaoavaliacaoRepository.ObterAsync(id);
            questaoAvaliacao.Tipo = tipo;
            questaoAvaliacao.Enunciado = enunciado;
            var erros = questaoAvaliacao.Validate();

            if (erros.Length == 0)
            {
                questaoavaliacaoRepository.Modificar(questaoAvaliacao);
                return questaoavaliacaoRepository.SaveChanges();
            }

            throw new DomainException(erros);
            throw new NotImplementedException();
        }

        public async Task<int> ExcluirAvaliacaoAsync(int id)
        {
            var avaliacao = await avaliacaoRepository.ObterAsync(id);
            if (avaliacao.Publicacoes?.Count > 0)
                throw new DomainException("Não é possível excluir uma avaliação que já foi publicada ou realizada");

            avaliacaoRepository.Excluir(id);
            avaliacaoRepository.SaveChanges();
            throw new NotImplementedException();
        }

        public async Task<int> ExcluirOpcaoAvaliacaoAsync(int id)
        {
            var opcaoAvaliacao = await opcaoavaliacaoRepository.ObterAsync(id);
            if (opcaoAvaliacao.OpcoesProvas?.Count > 0)
                throw new DomainException("Não é possível excluir a opção de uma avaliação que já foi realizada!");

            opcaoavaliacaoRepository.Excluir(id);
            opcaoavaliacaoRepository.SaveChanges();
            throw new NotImplementedException();
        }

        public async Task<int> ExcluirQuestaoAvaliacaoAsync(int id)
        {
            var questaoAvaliacao = await questaoavaliacaoRepository.ObterAsync(id);
            if (questaoAvaliacao.QuestoesProvas?.Count > 0)
                throw new DomainException("Não é possível excluir a questão de uma avaliação que já foi realizada!");

            questaoavaliacaoRepository.Excluir(id);
            questaoavaliacaoRepository.SaveChanges();
            throw new NotImplementedException();
        }

        public List<Avaliacao> ListarAvaliacao()
        {
            var avaliacao = avaliacaoRepository.ObterTodos().Cast<Avaliacao>().ToList();
            return avaliacao;
            throw new NotImplementedException();
        }


        public async Task<List<Avaliacao>> ListarAvaliacoesDoProfessorAsync(int professorId)
        {
            var avaliacao = await avaliacaoRepository.ListarAvaliacoesDoProfessorAsync(professorId);
            return avaliacao;
            throw new NotImplementedException();
        }

    }
}
