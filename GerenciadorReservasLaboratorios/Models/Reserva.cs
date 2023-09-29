using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int IdSala { get; set; }
        public int IdResponsavel { get; set; }
        public int IdDisciplina { get; set; }
        public int IdCurso { get; set; }
        public int IdSolicitante { get; set; }
        public DateTime ReservaData { get; set; }
        public TimeSpan ReservaHora { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Status { get; set; }
        public string Observacoes { get; set; }
        public string Turno { get; set; }
        public string NomeResponsavel
        {
            get
            {
                return Responsavel == null ? "" : Responsavel.Nome;
            }
        }
        public string NomeSolicitante
        {
            get
            {
                return Solicitante == null ? "" : Solicitante.Nome;
            }
        }
        public string NomeSala
        {
            get
            {
                return Sala == null ? "" : Sala.Nome;
            }
        }
        public string NomeCurso
        {
            get
            {
                return Curso == null ? "" : Curso.Nome;
            }
        }
        public string NomeDisciplina
        {
            get
            {
                return Disciplina == null ? "" : Disciplina.Nome;
            }
        }
        // Propriedades de navegação para Sala, Disciplina, Curso, Solicitante e Responsável
        public Sala Sala { get; set; }
        public Disciplina Disciplina { get; set; }
        public Curso Curso { get; set; }
        public Usuario Solicitante { get; set; }
        public Usuario Responsavel { get; set; }
    }
}
