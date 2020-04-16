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
    public class TurmaRepository : Repository<Turma>, ITurmaRepository
    {
        private readonly AppDbContext context;
        public TurmaRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }
        public override async Task<Turma> ObterAsync(int id)
        {
            var turma = await context.Turma.Include(x => x.Alunos).Where(x => x.Id == id).FirstOrDefaultAsync();

            return turma;
        }
    }
}
