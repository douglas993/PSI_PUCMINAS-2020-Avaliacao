using Microsoft.EntityFrameworkCore.Migrations;

namespace PUC.LDSI.DataBase.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Turma_turmaId",
                table: "Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Professor_professorId",
                table: "Avaliacao");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcaoAvaliacao_QuestaoAvaliacao_questaoAvaliacaoId",
                table: "OpcaoAvaliacao");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcaoProva_OpcaoAvaliacao_opcaoAvaliacaoId",
                table: "OpcaoProva");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcaoProva_QuestaoProva_questaoProvaId",
                table: "OpcaoProva");

            migrationBuilder.DropForeignKey(
                name: "FK_Prova_Aluno_alunoId",
                table: "Prova");

            migrationBuilder.DropForeignKey(
                name: "FK_Prova_Avaliacao_avaliacaoId",
                table: "Prova");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacao_Avaliacao_avalicaoId",
                table: "Publicacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacao_Turma_turmaId",
                table: "Publicacao");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestaoAvaliacao_Avaliacao_avaliacaoId",
                table: "QuestaoAvaliacao");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestaoProva_Prova_provaId",
                table: "QuestaoProva");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestaoProva_QuestaoAvaliacao_questaoAvaliacaoId",
                table: "QuestaoProva");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Turma",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "questaoAvaliacaoId",
                table: "QuestaoProva",
                newName: "QuestaoAvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "provaId",
                table: "QuestaoProva",
                newName: "ProvaId");

            migrationBuilder.RenameColumn(
                name: "nota",
                table: "QuestaoProva",
                newName: "Nota");

            migrationBuilder.RenameIndex(
                name: "IX_QuestaoProva_questaoAvaliacaoId",
                table: "QuestaoProva",
                newName: "IX_QuestaoProva_QuestaoAvaliacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestaoProva_provaId",
                table: "QuestaoProva",
                newName: "IX_QuestaoProva_ProvaId");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "QuestaoAvaliacao",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "enunciado",
                table: "QuestaoAvaliacao",
                newName: "Enunciado");

            migrationBuilder.RenameColumn(
                name: "avaliacaoId",
                table: "QuestaoAvaliacao",
                newName: "AvaliacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestaoAvaliacao_avaliacaoId",
                table: "QuestaoAvaliacao",
                newName: "IX_QuestaoAvaliacao_AvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "valorProva",
                table: "Publicacao",
                newName: "ValorProva");

            migrationBuilder.RenameColumn(
                name: "turmaId",
                table: "Publicacao",
                newName: "TurmaId");

            migrationBuilder.RenameColumn(
                name: "dataInicio",
                table: "Publicacao",
                newName: "DataInicio");

            migrationBuilder.RenameColumn(
                name: "dataFim",
                table: "Publicacao",
                newName: "DataFim");

            migrationBuilder.RenameColumn(
                name: "avalicaoId",
                table: "Publicacao",
                newName: "AvalicaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicacao_turmaId",
                table: "Publicacao",
                newName: "IX_Publicacao_TurmaId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicacao_avalicaoId",
                table: "Publicacao",
                newName: "IX_Publicacao_AvalicaoId");

            migrationBuilder.RenameColumn(
                name: "notaObtida",
                table: "Prova",
                newName: "NotaObtida");

            migrationBuilder.RenameColumn(
                name: "dataProva",
                table: "Prova",
                newName: "DataProva");

            migrationBuilder.RenameColumn(
                name: "avaliacaoId",
                table: "Prova",
                newName: "AvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "alunoId",
                table: "Prova",
                newName: "AlunoId");

            migrationBuilder.RenameIndex(
                name: "IX_Prova_avaliacaoId",
                table: "Prova",
                newName: "IX_Prova_AvaliacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Prova_alunoId",
                table: "Prova",
                newName: "IX_Prova_AlunoId");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Professor",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "resposta",
                table: "OpcaoProva",
                newName: "Resposta");

            migrationBuilder.RenameColumn(
                name: "questaoProvaId",
                table: "OpcaoProva",
                newName: "QuestaoProvaId");

            migrationBuilder.RenameColumn(
                name: "opcaoAvaliacaoId",
                table: "OpcaoProva",
                newName: "OpcaoAvaliacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_OpcaoProva_questaoProvaId",
                table: "OpcaoProva",
                newName: "IX_OpcaoProva_QuestaoProvaId");

            migrationBuilder.RenameIndex(
                name: "IX_OpcaoProva_opcaoAvaliacaoId",
                table: "OpcaoProva",
                newName: "IX_OpcaoProva_OpcaoAvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "verdadeira",
                table: "OpcaoAvaliacao",
                newName: "Verdadeira");

            migrationBuilder.RenameColumn(
                name: "questaoAvaliacaoId",
                table: "OpcaoAvaliacao",
                newName: "QuestaoAvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "OpcaoAvaliacao",
                newName: "Descricao");

            migrationBuilder.RenameIndex(
                name: "IX_OpcaoAvaliacao_questaoAvaliacaoId",
                table: "OpcaoAvaliacao",
                newName: "IX_OpcaoAvaliacao_QuestaoAvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "professorId",
                table: "Avaliacao",
                newName: "ProfessorId");

            migrationBuilder.RenameColumn(
                name: "materia",
                table: "Avaliacao",
                newName: "Materia");

            migrationBuilder.RenameColumn(
                name: "disciplina",
                table: "Avaliacao",
                newName: "Disciplina");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Avaliacao",
                newName: "Descricao");

            migrationBuilder.RenameIndex(
                name: "IX_Avaliacao_professorId",
                table: "Avaliacao",
                newName: "IX_Avaliacao_ProfessorId");

            migrationBuilder.RenameColumn(
                name: "turmaId",
                table: "Aluno",
                newName: "TurmaId");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Aluno",
                newName: "Nome");

            migrationBuilder.RenameIndex(
                name: "IX_Aluno_turmaId",
                table: "Aluno",
                newName: "IX_Aluno_TurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno",
                column: "TurmaId",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Professor_ProfessorId",
                table: "Avaliacao",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcaoAvaliacao_QuestaoAvaliacao_QuestaoAvaliacaoId",
                table: "OpcaoAvaliacao",
                column: "QuestaoAvaliacaoId",
                principalTable: "QuestaoAvaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcaoProva_OpcaoAvaliacao_OpcaoAvaliacaoId",
                table: "OpcaoProva",
                column: "OpcaoAvaliacaoId",
                principalTable: "OpcaoAvaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcaoProva_QuestaoProva_QuestaoProvaId",
                table: "OpcaoProva",
                column: "QuestaoProvaId",
                principalTable: "QuestaoProva",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prova_Aluno_AlunoId",
                table: "Prova",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prova_Avaliacao_AvaliacaoId",
                table: "Prova",
                column: "AvaliacaoId",
                principalTable: "Avaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacao_Avaliacao_AvalicaoId",
                table: "Publicacao",
                column: "AvalicaoId",
                principalTable: "Avaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacao_Turma_TurmaId",
                table: "Publicacao",
                column: "TurmaId",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestaoAvaliacao_Avaliacao_AvaliacaoId",
                table: "QuestaoAvaliacao",
                column: "AvaliacaoId",
                principalTable: "Avaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestaoProva_Prova_ProvaId",
                table: "QuestaoProva",
                column: "ProvaId",
                principalTable: "Prova",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestaoProva_QuestaoAvaliacao_QuestaoAvaliacaoId",
                table: "QuestaoProva",
                column: "QuestaoAvaliacaoId",
                principalTable: "QuestaoAvaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Professor_ProfessorId",
                table: "Avaliacao");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcaoAvaliacao_QuestaoAvaliacao_QuestaoAvaliacaoId",
                table: "OpcaoAvaliacao");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcaoProva_OpcaoAvaliacao_OpcaoAvaliacaoId",
                table: "OpcaoProva");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcaoProva_QuestaoProva_QuestaoProvaId",
                table: "OpcaoProva");

            migrationBuilder.DropForeignKey(
                name: "FK_Prova_Aluno_AlunoId",
                table: "Prova");

            migrationBuilder.DropForeignKey(
                name: "FK_Prova_Avaliacao_AvaliacaoId",
                table: "Prova");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacao_Avaliacao_AvalicaoId",
                table: "Publicacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacao_Turma_TurmaId",
                table: "Publicacao");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestaoAvaliacao_Avaliacao_AvaliacaoId",
                table: "QuestaoAvaliacao");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestaoProva_Prova_ProvaId",
                table: "QuestaoProva");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestaoProva_QuestaoAvaliacao_QuestaoAvaliacaoId",
                table: "QuestaoProva");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Turma",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "QuestaoAvaliacaoId",
                table: "QuestaoProva",
                newName: "questaoAvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "ProvaId",
                table: "QuestaoProva",
                newName: "provaId");

            migrationBuilder.RenameColumn(
                name: "Nota",
                table: "QuestaoProva",
                newName: "nota");

            migrationBuilder.RenameIndex(
                name: "IX_QuestaoProva_QuestaoAvaliacaoId",
                table: "QuestaoProva",
                newName: "IX_QuestaoProva_questaoAvaliacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestaoProva_ProvaId",
                table: "QuestaoProva",
                newName: "IX_QuestaoProva_provaId");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "QuestaoAvaliacao",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "Enunciado",
                table: "QuestaoAvaliacao",
                newName: "enunciado");

            migrationBuilder.RenameColumn(
                name: "AvaliacaoId",
                table: "QuestaoAvaliacao",
                newName: "avaliacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestaoAvaliacao_AvaliacaoId",
                table: "QuestaoAvaliacao",
                newName: "IX_QuestaoAvaliacao_avaliacaoId");

            migrationBuilder.RenameColumn(
                name: "ValorProva",
                table: "Publicacao",
                newName: "valorProva");

            migrationBuilder.RenameColumn(
                name: "TurmaId",
                table: "Publicacao",
                newName: "turmaId");

            migrationBuilder.RenameColumn(
                name: "DataInicio",
                table: "Publicacao",
                newName: "dataInicio");

            migrationBuilder.RenameColumn(
                name: "DataFim",
                table: "Publicacao",
                newName: "dataFim");

            migrationBuilder.RenameColumn(
                name: "AvalicaoId",
                table: "Publicacao",
                newName: "avalicaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicacao_TurmaId",
                table: "Publicacao",
                newName: "IX_Publicacao_turmaId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicacao_AvalicaoId",
                table: "Publicacao",
                newName: "IX_Publicacao_avalicaoId");

            migrationBuilder.RenameColumn(
                name: "NotaObtida",
                table: "Prova",
                newName: "notaObtida");

            migrationBuilder.RenameColumn(
                name: "DataProva",
                table: "Prova",
                newName: "dataProva");

            migrationBuilder.RenameColumn(
                name: "AvaliacaoId",
                table: "Prova",
                newName: "avaliacaoId");

            migrationBuilder.RenameColumn(
                name: "AlunoId",
                table: "Prova",
                newName: "alunoId");

            migrationBuilder.RenameIndex(
                name: "IX_Prova_AvaliacaoId",
                table: "Prova",
                newName: "IX_Prova_avaliacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Prova_AlunoId",
                table: "Prova",
                newName: "IX_Prova_alunoId");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Professor",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Resposta",
                table: "OpcaoProva",
                newName: "resposta");

            migrationBuilder.RenameColumn(
                name: "QuestaoProvaId",
                table: "OpcaoProva",
                newName: "questaoProvaId");

            migrationBuilder.RenameColumn(
                name: "OpcaoAvaliacaoId",
                table: "OpcaoProva",
                newName: "opcaoAvaliacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_OpcaoProva_QuestaoProvaId",
                table: "OpcaoProva",
                newName: "IX_OpcaoProva_questaoProvaId");

            migrationBuilder.RenameIndex(
                name: "IX_OpcaoProva_OpcaoAvaliacaoId",
                table: "OpcaoProva",
                newName: "IX_OpcaoProva_opcaoAvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "Verdadeira",
                table: "OpcaoAvaliacao",
                newName: "verdadeira");

            migrationBuilder.RenameColumn(
                name: "QuestaoAvaliacaoId",
                table: "OpcaoAvaliacao",
                newName: "questaoAvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "OpcaoAvaliacao",
                newName: "descricao");

            migrationBuilder.RenameIndex(
                name: "IX_OpcaoAvaliacao_QuestaoAvaliacaoId",
                table: "OpcaoAvaliacao",
                newName: "IX_OpcaoAvaliacao_questaoAvaliacaoId");

            migrationBuilder.RenameColumn(
                name: "ProfessorId",
                table: "Avaliacao",
                newName: "professorId");

            migrationBuilder.RenameColumn(
                name: "Materia",
                table: "Avaliacao",
                newName: "materia");

            migrationBuilder.RenameColumn(
                name: "Disciplina",
                table: "Avaliacao",
                newName: "disciplina");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Avaliacao",
                newName: "descricao");

            migrationBuilder.RenameIndex(
                name: "IX_Avaliacao_ProfessorId",
                table: "Avaliacao",
                newName: "IX_Avaliacao_professorId");

            migrationBuilder.RenameColumn(
                name: "TurmaId",
                table: "Aluno",
                newName: "turmaId");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Aluno",
                newName: "nome");

            migrationBuilder.RenameIndex(
                name: "IX_Aluno_TurmaId",
                table: "Aluno",
                newName: "IX_Aluno_turmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_turmaId",
                table: "Aluno",
                column: "turmaId",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Professor_professorId",
                table: "Avaliacao",
                column: "professorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcaoAvaliacao_QuestaoAvaliacao_questaoAvaliacaoId",
                table: "OpcaoAvaliacao",
                column: "questaoAvaliacaoId",
                principalTable: "QuestaoAvaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcaoProva_OpcaoAvaliacao_opcaoAvaliacaoId",
                table: "OpcaoProva",
                column: "opcaoAvaliacaoId",
                principalTable: "OpcaoAvaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcaoProva_QuestaoProva_questaoProvaId",
                table: "OpcaoProva",
                column: "questaoProvaId",
                principalTable: "QuestaoProva",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prova_Aluno_alunoId",
                table: "Prova",
                column: "alunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prova_Avaliacao_avaliacaoId",
                table: "Prova",
                column: "avaliacaoId",
                principalTable: "Avaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacao_Avaliacao_avalicaoId",
                table: "Publicacao",
                column: "avalicaoId",
                principalTable: "Avaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacao_Turma_turmaId",
                table: "Publicacao",
                column: "turmaId",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestaoAvaliacao_Avaliacao_avaliacaoId",
                table: "QuestaoAvaliacao",
                column: "avaliacaoId",
                principalTable: "Avaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestaoProva_Prova_provaId",
                table: "QuestaoProva",
                column: "provaId",
                principalTable: "Prova",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestaoProva_QuestaoAvaliacao_questaoAvaliacaoId",
                table: "QuestaoProva",
                column: "questaoAvaliacaoId",
                principalTable: "QuestaoAvaliacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
