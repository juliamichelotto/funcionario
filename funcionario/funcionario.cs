using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    public class Funcionario
    {
        public string CPF { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public double ValorHora { get; set; }
        public double Hora { get; set; }
        public double Salario { get; private set; }
        public void CalcularSalario()
        {
            Salario = Hora * ValorHora;
        }
    }
}
