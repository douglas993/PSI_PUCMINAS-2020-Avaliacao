using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class OpcaoAvaliacaoRepository : Repository<OpcaoAvaliacao>, IOpcaoAvaliacaoRepository
    {
            private readonly AppDbContext context;
            public OpcaoAvaliacaoRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }
            public override async Task<OpcaoAvaliacao> ObterAsync(int id)
        {
            var opcaoavaliacao = await context.OpcaoAvaliacao.Include(x => x.OpcoesProvas)
                .Where(x => x.QuestaoAvaliacaoId == id).FirstOrDefaultAsync();

            return opcaoavaliacao;
        }
    }
}