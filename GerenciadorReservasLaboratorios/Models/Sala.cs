using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sala
    {
        public int Id { get; set; }
        public int IdPredio { get; set; }
        public string Nome { get; set; }

        public string NomePredio
        {
            get
            {
                return Predio == null ? "" : Predio.Nome;
            }
        }
        // Propriedades de navegação para Sala, Disciplina, Curso, Solicitante e Responsável
        public Predio Predio { get; set; }
    }
}
