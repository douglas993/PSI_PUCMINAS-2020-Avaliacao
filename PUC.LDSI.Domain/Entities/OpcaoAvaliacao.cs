using System.Collections.Generic;

namespace PUC.LDSI.Domain.Entities
{
    public class OpcaoAvaliacao : Entity
    {
        public int QuestaoAvaliacaoId { get; set; }
        public string Descricao { get; set; }
        public byte Verdadeira { get; set; }
        public QuestaoAvaliacao QuestaoAvaliacao { get; set; }
        public List<OpcaoProva> OpcoesProvas { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (QuestaoAvaliacaoId == 0)
                erros.Add("A questão da avaliação precisa ser informada!");

            if (string.IsNullOrEmpty(Descricao))
                erros.Add("A descrição da opção avaliação precisa ser informada!");

            return erros.ToArray();
        }
    }
}
