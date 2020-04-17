using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public async Task<List<Avaliacao>> ListarAvaliacoesDoProfessorAsync(int professorId)
        {
            var query = context.Avaliacao
                .Include(x => x.QuestoesAvaliacoes).ThenInclude(y => y.OpcoesAvaliacoes)
                .Include(x => x.Professor)
                .Where(x => x.Professor.Id == professorId);

            return await query.ToListAsync();
        }

        public override async Task<Avaliacao> ObterAsync(int id)
        {
            var avaliacao = await context.Avaliacao
                .Include(x => x.Professor)
                .Include(x => x.QuestoesAvaliacoes).ThenInclude(y => y.OpcoesAvaliacoes)
                .Include(x => x.Publicacoes)
                .FirstOrDefaultAsync(m => m.Id == id);

            return avaliacao;
        }
    }
}