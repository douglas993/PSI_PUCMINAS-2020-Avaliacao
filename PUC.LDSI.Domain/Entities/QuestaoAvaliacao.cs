using System.Collections.Generic;

namespace PUC.LDSI.Domain.Entities
{
    public class QuestaoAvaliacao : Entity
    {
        public int AvaliacaoId { get; set; }
        public int Tipo { get; set; }
        public string Enunciado { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public List<QuestaoProva> QuestoesProvas { get; set; }
        public List<OpcaoAvaliacao> OpcoesAvaliacoes { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (AvaliacaoId == 0)
                erros.Add("A avaliação precisa ser informada!");

            if (Tipo == 0)
                erros.Add("O tipo precisa ser informado, são: 1 (Múltipla Escolha) ou 2 (Verdadeiro ou Falso)!");

            if (string.IsNullOrEmpty(Enunciado))
                erros.Add("O enunciado precisa ser informado!");

            return erros.ToArray();
        }
    }
}
