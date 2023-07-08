using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DateTime DataHoraSaida { get; set; }
    }
}
