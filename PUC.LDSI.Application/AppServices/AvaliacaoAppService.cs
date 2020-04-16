using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Application.AppServices
{
    public class AvaliacaoAppService : IAvaliacaoAppService
    {
        private readonly IAvaliacaoService avaliacaoService;
        public AvaliacaoAppService(IAvaliacaoService avaliacaoService)
        {
            this.avaliacaoService = avaliacaoService;
        }


        public async Task<DataResult<int>> AdicionarAvaliacaoAsync(int professorId, string disciplina, string materia, string descricao)
        {
            try
            {
                var retorno = await avaliacaoService.AdicionarAvaliacaoAsync(professorId, disciplina, materia, descricao);
                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> AdicionarOpcaoAvaliacaoAsync(int questaoId, string descricao, byte verdadeira)
        {
            try
            {
                var retorno = await avaliacaoService.AdicionarOpcaoAvaliacaoAsync(questaoId, descricao, verdadeira);
                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> AdicionarQuestaoAvaliacaoAsync(int avaliacaoId, int tipo, string enunciado)
        {
            try
            {
                var retorno = await avaliacaoService.AdicionarQuestaoAvaliacaoAsync(avaliacaoId, tipo, enunciado);
                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> AlterarAvaliacaoAsync(int id, string disciplina, string materia, string descricao)
        {
            try
            {
                var retorno = await avaliacaoService.AlterarAvaliacaoAsync(id, disciplina, materia, descricao);
                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> AlterarOpcaoAvaliacaoAsync(int id, string descricao, byte verdadeira)
        {
            try
            {
                var retorno = await avaliacaoService.AlterarOpcaoAvaliacaoAsync(id, descricao, verdadeira);
                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> AlterarQuestaoAvaliacaoAsync(int id, int tipo, string enunciado)
        {
            try
            {
                var retorno = await avaliacaoService.AlterarQuestaoAvaliacaoAsync(id, tipo, enunciado);
                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> ExcluirAvaliacaoAsync(int id)
        {
            try
            {
                var retorno = await avaliacaoService.ExcluirAvaliacaoAsync(id);
                return new DataResult<int>(1);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> ExcluirOpcaoAvaliacaoAsync(int id)
        {
            try
            {
                var retorno = await avaliacaoService.ExcluirOpcaoAvaliacaoAsync(id);
                return new DataResult<int>(1);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

        public async Task<DataResult<int>> ExcluirQuestaoAvaliacaoAsync(int id)
        {
            try
            {
                var retorno = await avaliacaoService.ExcluirQuestaoAvaliacaoAsync(id);
                return new DataResult<int>(1);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

        public async Task<List<Avaliacao>> ListarAvaliacoesDoProfessorAsync(int professorId)
        {
            try
            {
                var retorno = await avaliacaoService.ListarAvaliacoesDoProfessorAsync(professorId);
                return new DataResult<int>(retorno);
            }
            catch (Exception ex)
            {
                return new DataResult<int>(ex);
            }
            throw new NotImplementedException();
        }

    }
}
