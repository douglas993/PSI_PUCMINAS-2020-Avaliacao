using System.Collections.Generic;

namespace PUC.LDSI.Domain.Entities
{
    public class QuestaoProva : Entity
    {
        public int QuestaoAvaliacaoId { get; set; }
        public int ProvaId { get; set; }
        public float Nota { get; set; }
        public QuestaoAvaliacao QuestaoAvaliacao { get; set; }
        public Prova Prova { get; set; }
        public List<OpcaoProva> OpcoesProvas { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (QuestaoAvaliacaoId == 0)
                erros.Add("A questão da avaliação precisa ser informada!");

            if (ProvaId == 0)
                erros.Add("A prova precisa ser informada!");

            return erros.ToArray();
        }
    }
}
