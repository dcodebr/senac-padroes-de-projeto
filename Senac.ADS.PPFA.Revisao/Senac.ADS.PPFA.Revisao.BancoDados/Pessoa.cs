using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.Revisao.BancoDados
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Rg { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}
