using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class QuestaoAvaliacaoRepository : Repository<QuestaoAvaliacao>, IQuestaoAvaliacaoRepository
    {
        private readonly AppDbContext context;
        public QuestaoAvaliacaoRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }
        public override async Task<QuestaoAvaliacao> ObterAsync(int id)
        {
            var questaoavaliacao = await context.QuestaoAvaliacao.Include(x => x.Avaliacao)
                .Include(x => x.OpcoesAvaliacoes)
                .Include(x => x.QuestoesProvas)
                .Where(x => x.AvaliacaoId == id).FirstOrDefaultAsync();

            return questaoavaliacao;
        }
    }
}