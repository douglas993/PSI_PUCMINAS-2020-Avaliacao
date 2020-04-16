using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Turma : Entity
    {
        public string Nome { get; set; }
        public List<Publicacao> Publicacoes { get; set; }
        public List<Aluno> Alunos { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O nome precisa ser informado!");

            return erros.ToArray();
        }
    }
}
