using System;

namespace Models
{
    public class SaidasAntecipadas
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public int IdProfessor { get; set; }
        public int IdCoordenacao { get; set; }
        public string Motivo { get; set; }
        public string Status { get; set; }
        public DateTime DataSaida { get; set; }
        public TimeSpan HoraSaida { get; set; }
        public string NomeAluno
        {
            get
            {
                return Aluno == null ? "" : Aluno.Nome;
            }
        }
        public string NomeProfessor
        {
            get
            {
                return Professor == null ? "" : Professor.Nome;
            }
        }
        public string NomeCoordenacao
        {
            get
            {
                return Coordenacao == null ? "" : Coordenacao.Nome;
            }
        }
        // Propriedades de navegação para Aluno, Professor e Coordenacao
        public Aluno Aluno { get; set; }
        public Usuario Professor { get; set; }
        public Usuario Coordenacao { get; set; }
    }
}

