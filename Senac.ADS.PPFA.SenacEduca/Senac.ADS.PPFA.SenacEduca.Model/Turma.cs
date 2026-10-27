using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.SenacEduca.Model
{
    public class Turma : BaseModel
    {
        public string? Descricao { get; set; }
        public string? Periodo { get; set; }

        public virtual ICollection<Grade>? Grades { get; set; }
        public virtual ICollection<Aluno>? Alunos { get; set; }
    }
}
