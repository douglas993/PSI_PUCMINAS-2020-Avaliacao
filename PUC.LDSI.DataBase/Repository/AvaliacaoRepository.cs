using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class AvaliacaoRepository : Repository<Avaliacao>, IAvaliacaoRepository
    {
        private readonly AppDbContext context;
        public AvaliacaoRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }
        public override async Task<Avaliacao> ObterAsync(int id)
        {
            var avaliacao = await context.Avaliacao.Include(x => x.QuestoesAvaliacoes)
                .Include(x => x.Professor)
                .Where(x => x.ProfessorId == id).FirstOrDefaultAsync();

            return avaliacao;
        }
    }
}