using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Reserva
    {
        public Reserva() {}

        public Reserva(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            this.TipoSuite = tipoSuite;
            this.Capacidade = capacidade;           
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}