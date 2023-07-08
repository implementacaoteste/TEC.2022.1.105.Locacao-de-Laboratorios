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
        public int IdUsuario { get; set; }
        public int IdDisciplina { get; set; }
        public int IdCurso { get; set; }
        public string Solicitante { get; set; }
        public DateTime ReservaData { get; set; }
        public DateTime ReservaHora { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Status { get; set; }
        public string Observacoes { get; set; }
        public string Turno { get; set; }
    }
}
